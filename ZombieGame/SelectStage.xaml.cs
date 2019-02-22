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
	public partial class SelectStage : UserControl
	{

        public int isSelectStage { get; set; }		
        public Button[]  buttonArray = new Button[2];
        public int witchButtom;
        
		public SelectStage()
		{
			// 必須將變數初始化
			InitializeComponent();
			ToShow.Completed+=new System.EventHandler(ToShow_Completed);
            this.Loaded+=new RoutedEventHandler(SelectStage_Loaded);
            //將Button存入陣列
            for (int i = 0; i < 2; i++)
            {
                int stageNum = 11;
                stageNum+=i;
                string buttonName = "S" + stageNum.ToString();
                buttonArray[i] = this.FindName(buttonName) as Button;
                buttonArray[i].Click += new RoutedEventHandler(Which_Stage_Click);
            }
        }
        //物件載入執行
        private void SelectStage_Loaded(object sender, RoutedEventArgs e)
        {
            this.ButtonClick.Completed += new EventHandler(ButtonClick_Completed);
        }
        

        //偵測哪個按鈕被按下
        private void Which_Stage_Click(object sender, RoutedEventArgs e)
        {

            Button buttonSelect= sender as Button;
            switch (buttonSelect.Name.ToString())
            {
                case "S11" :
                    this.isSelectStage = 11;
                break;

                case "S12":
                    this.isSelectStage = 12;
                break;
            }
            ButtonClick.Stop();
            ButtonClick.Begin();
               
        }
        //選擇動畫結束後執行關卡
        private void ButtonClick_Completed(object sender, EventArgs e)
        {
            //MainPage
            Canvas LayoutRoot = this.Parent as Canvas;
            Time time = new Time(50);//這裡設定關卡時間 預設30
            time.Name = "Timer";
            time.SetValue(Canvas.LeftProperty, (double)520);
            
            switch (isSelectStage)
            {
                case 11:
                    
                    Balltest.stage11 stage11 = new Balltest.stage11();
                    stage11.Name = "s11";
                    stage11.Width = 640;
                    stage11.Height = 480;                    
                    LayoutRoot.Children.Add(stage11);
                    break;
                case 12:
                    Stage1_2 stage12=new Stage1_2();
                    stage12.Name = "s12";
                    //LayoutRoot.Children.Clear();
                    LayoutRoot.Children.Add(stage12);
                   
                    break;
                default:
                    
                    break;
            }
            LayoutRoot.Children.Add(time);
          
        }

        private void ToShow_Completed(object sender, System.EventArgs e)
        {
            // TODO: 在此新增事件處理常式執行項目。
            int Pass = Convert.ToInt32(stageSave.Content.ToString());
            Pass++;
            string openStageStr = "S" + Pass;
            Button showButton = this.FindName(openStageStr) as Button;
            showButton.Visibility = Visibility.Visible;
        }
    }
}