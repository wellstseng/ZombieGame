using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ZombieGame
{
	public partial class Time : UserControl
	{
		//設定遊戲時間
        int mSecond { get; set; }//毫秒
		
		public Time()
		{
            mSecond = 300;
			// 必須將變數初始化
			InitializeComponent();
			this.Loaded+=new System.Windows.RoutedEventHandler(Time_Loaded);
		}
        public Time(int time)
        {
            mSecond = time;
            InitializeComponent();
            this.Loaded += new System.Windows.RoutedEventHandler(Time_Loaded);
        }

		private void Time_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: 在此新增事件處理常式執行項目。
			CountTime.Duration = new Duration(TimeSpan.FromMilliseconds(100));
			CountTime.Completed +=new System.EventHandler(CountTime_Completed);
			TimeBlock.Text = mSecond.ToString() + "." + "0";
			CountTime.Begin();
		}

		private void CountTime_Completed(object sender, System.EventArgs e)
		{
			if (mSecond > 0)
            {
                mSecond--;
                int pointSecond = mSecond % 10;
                int second = (int)(mSecond / 10);
                if(mSecond >=100)
                    TimeBlock.Text = second.ToString() + "." + pointSecond.ToString();
                else
                    TimeBlock.Text ="0" + second.ToString() + "." + pointSecond.ToString();
				CountTime.Begin();
            }
            else
            {
                CountTime.Stop();
                //時間到
                TimeBlock.Text = "0";
                Canvas LayoutRoot = this.Parent as Canvas;
                TimeOut timeOut = new TimeOut();
                timeOut.Name = "timeOut";
                LayoutRoot.Children.Add(timeOut);
               
            }
			
			// TODO: 在此新增事件處理常式執行項目。
		}
	}
}