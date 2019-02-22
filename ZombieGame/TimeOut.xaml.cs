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
	public partial class TimeOut : UserControl
	{
        bool alreadyClick =false;
        
		public TimeOut()
		{
			// 必須將變數初始化
			InitializeComponent();
            this.Loaded+=new RoutedEventHandler(TimeOut_Loaded);
            BackToSelect.Click +=new RoutedEventHandler(BackToSelect_Click);
            
         
		}
        private void TimeOut_Loaded(object sender, EventArgs e)
        {
            alreadyClick = false;//返回主畫面防呆
            Canvas LayoutRoot = this.Parent as Canvas;
            SelectStage saveStage = (SelectStage)LayoutRoot.FindName("SelectStage1") as SelectStage;
            //int x = LayoutRoot.Children.IndexOf(this.);
            Time time = (Time)LayoutRoot.FindName("Timer") as Time;
            string str= time.TimeBlock.Text.ToString();
            double endTime = Convert.ToDouble(str);
            switch (saveStage.isSelectStage)
            {
                case 11:
					
                    if (endTime <= 0)
                    {
                        TestBlock.Text = "Success1-1";
                    }

                    break;
                case 12:
                   
                    if (endTime <= 0)
                    {
                        TestBlock.Text = "Success1-2";
                    }

                    break;

            }
            
        }
        private void BackToSelect_Click(object sender, EventArgs e)
        {
            if(alreadyClick == false)
            {
                Canvas LayoutRoot = this.Parent as Canvas;
			    SelectStage saveStage = (SelectStage)LayoutRoot.FindName("SelectStage1") as SelectStage;
			    saveStage.stageSave.Content = saveStage.isSelectStage;
                LayoutRoot.Children.RemoveAt(3);
                LayoutRoot.Children.RemoveAt(2);
                LayoutRoot.Children.RemoveAt(1);
           	    saveStage.ToShow.Begin();
                alreadyClick=true;
            }
       
        }
	}
}