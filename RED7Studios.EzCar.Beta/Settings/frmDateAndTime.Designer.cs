namespace RED7Studios.EzCar.Settings
{
    partial class frmDateAndTime
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
            this.mcbHour = new MetroFramework.Controls.MetroComboBox();
            this.mcbMinute = new MetroFramework.Controls.MetroComboBox();
            this.mcbDay = new MetroFramework.Controls.MetroComboBox();
            this.mcbMonth = new MetroFramework.Controls.MetroComboBox();
            this.mcbYear = new MetroFramework.Controls.MetroComboBox();
            this.mlbNotice = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new RED7Studios.UI.Controls.ModernButton();
            this.SuspendLayout();
            // 
            // mcbHour
            // 
            this.mcbHour.FormattingEnabled = true;
            this.mcbHour.ItemHeight = 23;
            this.mcbHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.mcbHour.Location = new System.Drawing.Point(13, 45);
            this.mcbHour.Name = "mcbHour";
            this.mcbHour.Size = new System.Drawing.Size(121, 29);
            this.mcbHour.TabIndex = 0;
            // 
            // mcbMinute
            // 
            this.mcbMinute.FormattingEnabled = true;
            this.mcbMinute.ItemHeight = 23;
            this.mcbMinute.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.mcbMinute.Location = new System.Drawing.Point(140, 45);
            this.mcbMinute.Name = "mcbMinute";
            this.mcbMinute.Size = new System.Drawing.Size(121, 29);
            this.mcbMinute.TabIndex = 29;
            // 
            // mcbDay
            // 
            this.mcbDay.FormattingEnabled = true;
            this.mcbDay.ItemHeight = 23;
            this.mcbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.mcbDay.Location = new System.Drawing.Point(13, 80);
            this.mcbDay.Name = "mcbDay";
            this.mcbDay.Size = new System.Drawing.Size(121, 29);
            this.mcbDay.TabIndex = 30;
            // 
            // mcbMonth
            // 
            this.mcbMonth.FormattingEnabled = true;
            this.mcbMonth.ItemHeight = 23;
            this.mcbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.mcbMonth.Location = new System.Drawing.Point(140, 80);
            this.mcbMonth.Name = "mcbMonth";
            this.mcbMonth.Size = new System.Drawing.Size(121, 29);
            this.mcbMonth.TabIndex = 31;
            // 
            // mcbYear
            // 
            this.mcbYear.FormattingEnabled = true;
            this.mcbYear.ItemHeight = 23;
            this.mcbYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.mcbYear.Location = new System.Drawing.Point(267, 80);
            this.mcbYear.Name = "mcbYear";
            this.mcbYear.Size = new System.Drawing.Size(121, 29);
            this.mcbYear.TabIndex = 32;
            // 
            // mlbNotice
            // 
            this.mlbNotice.AutoSize = true;
            this.mlbNotice.Location = new System.Drawing.Point(13, 496);
            this.mlbNotice.Name = "mlbNotice";
            this.mlbNotice.Size = new System.Drawing.Size(288, 19);
            this.mlbNotice.TabIndex = 33;
            this.mlbNotice.Text = "*Make sure the program is ran as administrator.";
            // 
            // btnSave
            // 
            this.btnSave.CustomColorScheme = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnSave.Location = new System.Drawing.Point(13, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 47);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDateAndTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 525);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mlbNotice);
            this.Controls.Add(this.mcbYear);
            this.Controls.Add(this.mcbMonth);
            this.Controls.Add(this.mcbDay);
            this.Controls.Add(this.mcbMinute);
            this.Controls.Add(this.mcbHour);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDateAndTime";
            this.Text = "Date and Time";
            this.Load += new System.EventHandler(this.frmDateAndTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mcbHour;
        private MetroFramework.Controls.MetroComboBox mcbMinute;
        private MetroFramework.Controls.MetroComboBox mcbDay;
        private MetroFramework.Controls.MetroComboBox mcbMonth;
        private MetroFramework.Controls.MetroComboBox mcbYear;
        private MetroFramework.Controls.MetroLabel mlbNotice;
        private RED7Studios.UI.Controls.ModernButton btnSave;
    }
}