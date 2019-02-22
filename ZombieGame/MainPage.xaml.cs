using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
//
       
namespace ZombieGame
{
	public partial class MainPage : UserControl
	{
      
		public MainPage()
		{
			// 必須將變數初始化
			InitializeComponent();
			this.Loaded += new System.Windows.RoutedEventHandler(MainPage_Loaded);
            
            
		}
		private void MainPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: 在此新增事件處理常式執行項目。
            WelcomePage WP = new WelcomePage();
            LayoutRoot.Children.Add(WP);
            WP.Transition.Completed += new EventHandler(Transition_Completed);
           
		}
        private void Transition_Completed(object sender, EventArgs e)
        {
            SelectStage SS = new SelectStage();
            SS.Name = "SelectStage1";
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(SS);
         }

       
	}
}