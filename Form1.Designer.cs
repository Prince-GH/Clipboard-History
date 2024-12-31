namespace popup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClipHistory = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClipHistory
            // 
            this.ClipHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClipHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClipHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClipHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClipHistory.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClipHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClipHistory.FormattingEnabled = true;
            this.ClipHistory.ItemHeight = 21;
            this.ClipHistory.Location = new System.Drawing.Point(0, 0);
            this.ClipHistory.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.ClipHistory.MinimumSize = new System.Drawing.Size(0, 5);
            this.ClipHistory.Name = "ClipHistory";
            this.ClipHistory.Size = new System.Drawing.Size(334, 160);
            this.ClipHistory.TabIndex = 0;
            this.ClipHistory.SelectedIndexChanged += new System.EventHandler(this.ClipHistory_SelectedIndexChanged);
            this.ClipHistory.MouseHover += new System.EventHandler(this.ClipHistory_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.ClipHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 160);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Status.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(238, 135);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 19);
            this.Status.TabIndex = 1;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(344, 170);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.ShowInTaskbar = false;
            this.Text = "Clipboard history";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ClipHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Status;
    }
}

