using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp1
{

    public partial class MyCalendar : UserControl
    {
        // [變數] 主色
        public System.Drawing.Color mainColor = Color.FromArgb(87, 191, 212);
        public System.Drawing.Color dateColor = Color.FromArgb(67, 67, 67);
        
        // [當前日期]
        DateTime now = DateTime.Now;


        public MyCalendar()
        {
            InitializeComponent();

            // [旋轉背景]
            this.rightBtn.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);

        }

        private void MyCalendar_Load(object sender, EventArgs e)
        {

            displayDays();
            displayMonths();
        }

        #region [顯示日期] displayDays()
        private void displayDays ()
        {

            // [當月1號]
            DateTime startMonth = new DateTime(now.Year, now.Month, 1);

            // [當月天數] 
            int days =DateTime.DaysInMonth(now.Year, now.Month);

            // [當月1號星期]
            int dayOfTheWeek =Convert.ToInt32(now.DayOfWeek.ToString("d"));

            // [上月日期]
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                if (dayOfTheWeek != 1)
                {
                    BlankDate unblank = new BlankDate();
                    daysPanel.Controls.Add(unblank);
                }
            }

            // [當月日期]
            for (int i = 1; i <= days; i++)
            {
                SingleDate ucdays=new SingleDate();
                ucdays.days(i);
                daysPanel.Controls.Add(ucdays);

            }

            // [Debug]    
            Debug.WriteLine("now: " + now);
            Debug.WriteLine("startMonth: " + startMonth);
            Debug.WriteLine("days: " + days);
            Debug.WriteLine("dayOfTheWeek: " + dayOfTheWeek);

        }
        #endregion


        #region [顯示月份] displayDays()
        private void displayMonths()
        {

        }
        #endregion

        // [點擊按鈕] 下個月
        private void rightBtn_Click(object sender, EventArgs e)
        {
            // [清除] daysPanel
            daysPanel.Controls.Clear();

            
        }
    }
}
