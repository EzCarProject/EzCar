using RED7Studios.UI.Forms;
using System;
using System.Runtime.InteropServices;

namespace RED7Studios.EzCar.Settings
{
    public partial class frmDateAndTime : ModernForm
    {
        public frmDateAndTime()
        {
            // Create the form.
            InitializeComponent();

            // Initalize the languages.
            this.Text = Languages.Resources.frmDateAndTime_Name;
            this.btnSave.Text = Languages.Resources.frmDateAndTime_Save;
            this.mlbNotice.Text = Languages.Resources.frmDateAndTime_AdminNote;
        }

        // Set the struct layout to 'sequential'.
        [StructLayout(LayoutKind.Sequential)]
        // Create a new struct called 'SYSTEMTIME'.
        public struct SYSTEMTIME
        {
            // Create public shorts called 'wYear', 'wMonth', 'wDayOfWeek', 'wDay', 'wHour', 'wMinute', 'wSecond' and 'wMilliseconds'.
            public short wYear, wMonth, wDayOfWeek, wDay, wHour, wMinute, wSecond, wMilliseconds;
        }

        // Import the 'kernal32' dll (and set the last error to true).
        [DllImport("kernel32.dll", SetLastError = true)]

        // Create a new public static bool called 'SetSystemTime' and ref the 'SYSTEMTIME' as 'st'.
        public static extern bool SetSystemTime(ref SYSTEMTIME st);

        // PS: The converting to int 16 makes it compatible for 'short'.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new 'SYSTEMTIME' called 'st'.
            SYSTEMTIME st = new SYSTEMTIME();

            // Set the year to the selected year.
            st.wYear = Convert.ToInt16(mcbYear.Text);
            // Set the month to the selected month.
            st.wMonth = Convert.ToInt16(mcbMonth.Text);
            // Set the day to the selected day.
            st.wDay = Convert.ToInt16(mcbDay.Text);
            // Set the hour to the selected hour.
            st.wHour = Convert.ToInt16(mcbHour);
            // Set the minute to the selected minute.
            st.wMinute = Convert.ToInt16(mcbMinute);

            // Run the set system time function and ref the 'st' above.
            SetSystemTime(ref st);
        }

        private void frmDateAndTime_Load(object sender, EventArgs e)
        {

        }
    }
}
