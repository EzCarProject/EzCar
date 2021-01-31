using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RED7Studios.EzCar.Settings
{
    public partial class frmDateAndTime : Form
    {
        public frmDateAndTime()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear, wMonth, wDayOfWeek, wDay, wHour, wMinute, wSecond, wMilliseconds;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime(ref SYSTEMTIME st);

        private void frmDateAndTime_Load(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            SYSTEMTIME st = new SYSTEMTIME();
            st.wYear = Convert.ToInt16(mcbYear.Text); // must be short
            st.wMonth = Convert.ToInt16(mcbMonth.Text);
            st.wDay = Convert.ToInt16(mcbDay.Text);
            st.wHour = Convert.ToInt16(mcbHour);
            st.wMinute = Convert.ToInt16(mcbMinute);

            SetSystemTime(ref st); // invoke this method.
        }
    }
}
