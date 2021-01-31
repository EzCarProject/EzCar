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
            this.btnDebug = new System.Windows.Forms.Button();
            this.mcbMinute = new MetroFramework.Controls.MetroComboBox();
            this.mcbDay = new MetroFramework.Controls.MetroComboBox();
            this.mcbMonth = new MetroFramework.Controls.MetroComboBox();
            this.mcbYear = new MetroFramework.Controls.MetroComboBox();
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
            this.mcbHour.Location = new System.Drawing.Point(12, 12);
            this.mcbHour.Name = "mcbHour";
            this.mcbHour.Size = new System.Drawing.Size(121, 29);
            this.mcbHour.TabIndex = 0;
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDebug.FlatAppearance.BorderSize = 0;
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebug.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebug.ForeColor = System.Drawing.Color.White;
            this.btnDebug.Location = new System.Drawing.Point(12, 82);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(121, 47);
            this.btnDebug.TabIndex = 28;
            this.btnDebug.Text = "Save";
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
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
            this.mcbMinute.Location = new System.Drawing.Point(139, 12);
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
            this.mcbDay.Location = new System.Drawing.Point(12, 47);
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
            this.mcbMonth.Location = new System.Drawing.Point(139, 47);
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
            this.mcbYear.Location = new System.Drawing.Point(266, 47);
            this.mcbYear.Name = "mcbYear";
            this.mcbYear.Size = new System.Drawing.Size(121, 29);
            this.mcbYear.TabIndex = 32;
            // 
            // frmDateAndTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mcbYear);
            this.Controls.Add(this.mcbMonth);
            this.Controls.Add(this.mcbDay);
            this.Controls.Add(this.mcbMinute);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.mcbHour);
            this.Name = "frmDateAndTime";
            this.Text = "Date & Time";
            this.Load += new System.EventHandler(this.frmDateAndTime_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mcbHour;
        private System.Windows.Forms.Button btnDebug;
        private MetroFramework.Controls.MetroComboBox mcbMinute;
        private MetroFramework.Controls.MetroComboBox mcbDay;
        private MetroFramework.Controls.MetroComboBox mcbMonth;
        private MetroFramework.Controls.MetroComboBox mcbYear;
    }
}