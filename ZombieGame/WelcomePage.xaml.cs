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
	public partial class WelcomePage : UserControl
	{
        
		public WelcomePage()
		{
			// 必須將變數初始化
			InitializeComponent();
			Enter.Click +=new RoutedEventHandler(Enter_Click);
                      
		}
        private void Enter_Click(object sender, RoutedEventArgs s)
        {
          
           this.Transition.Begin();
		          
        }

       
        
	}
}