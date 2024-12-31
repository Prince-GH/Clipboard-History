using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using System.Data.SQLite;



namespace popup
{
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents _globalHook;
        private List<string> clipboardHistory = new List<string>();
        private Timer clipboardTimer;
        private string connectionString = "Data Source=clipboardData.db;Version=3;";


        public Form1()
        {
            this.TopMost = true;
            InitializeComponent();
            // Call methods on form load
            //CreateTable();
            //InsertData("Alice", 25);
            //ShowData();
            // Pass the ListBox and the parent Form to the customizer
            new ClipHistoryCustomizer(ClipHistory, this);






            // Start the global hook
            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyDown += OnGlobalKeyDown;

            // Fetch data form keyboard
            clipboardTimer = new Timer();
            clipboardTimer.Interval = 500; // Check every 0.5 sec or 500ms
            clipboardTimer.Tick += ClipboardTimer_Tick;
            clipboardTimer.Start();

        }

        //-----------database/////////.................

        // CreateTable: Creates the table if it doesn't exist
        private void CreateTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS ClipDataTable (clipData TEXT)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        // InsertData: Inserts a record into the Users table
        private void InsertData(string clipData)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO ClipDataTable (clipData) VALUES (@clipData)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@clipData", clipData);
                cmd.ExecuteNonQuery();
            }
        }

        // ShowData: Retrieves all records and displays them in MessageBoxes
        private void ShowData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM ClipDataTable";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show($"ID: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");

                }
            }
        }


        //------database end--------------------------

        // Event handler for global key down || press win + O
        private void OnGlobalKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.O && e.Modifiers == Keys.LWin)
            {
                ShowPopUp();
            }
        }

        // Add items to the ClipboardHistory list
        private void ClipboardTimer_Tick(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();
            if(!string.IsNullOrEmpty(clipboardText) && (clipboardHistory.Count == 0 || !clipboardHistory.Contains(clipboardText)))
            {
                clipboardHistory.Add(clipboardText);

                UpdateClipboardHistoryUI();
            }
        }

        // Update the lsitBox (ClipHistory)
        private void UpdateClipboardHistoryUI()
        {
            ClipHistory.Items.Clear();
            foreach (var text in clipboardHistory)
            {
                ClipHistory.Items.Add(text);
            }
        }


        // Show the popUp on the screen when press : win + O
        private void ShowPopUp()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.TopMost = true;
            this.Show();
        }

        // Copy to the clipboard
        private async void ClipHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ClipHistory.SelectedIndex;
            if(selectedIndex >= 0)
                
            {
                Clipboard.SetText(clipboardHistory[selectedIndex]);

                // Show the "Copied!" status
                Status.Text = "Copied!";
                Status.ForeColor = Color.Green;
                Status.Visible = true;

                // Start the timer to hide the status after 3 seconds
                await (Task.Delay(3000));
                Status.Visible = false;

            }
        }

        // -----------------------------------------------------------

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Clean up the global hook
            if (_globalHook != null)
            {
                _globalHook.KeyDown -= OnGlobalKeyDown;
                _globalHook.Dispose();
            }
            base.OnFormClosed(e);
        }

        // -----------------------------------------------------------

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClipHistory_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
