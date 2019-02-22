using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ZombieGame
{
	public partial class App : Application
	{
		public App()
		{
			this.Startup += this.Application_Startup;
			this.Exit += this.Application_Exit;
			this.UnhandledException += this.Application_UnhandledException;

			InitializeComponent();
		}

		private void Application_Startup(object sender, StartupEventArgs e)
		{
			this.RootVisual = new MainPage();
		}

		private void Application_Exit(object sender, EventArgs e)
		{
		}

		private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
		{
			// 如果應用程式在偵錯工具外部執行，請使用
			// 瀏覽器的例外機制報告此例外。IE 會在狀態列上以黃色的警告
			// 圖示顯示，Firefox 則會顯示指令碼錯誤。
			if (!System.Diagnostics.Debugger.IsAttached)
			{

				// 注意: 如果傳回例外但尚未處理，則應用程式會
				// 繼續執行。
				// 在實際執行應用程式中，應將這個錯誤處理取代為
				// 可向網站報告錯誤並停止應用程式的其他項目。
				e.Handled = true;
				Deployment.Current.Dispatcher.BeginInvoke(delegate { ReportErrorToDOM(e); });
			}
		}

		private void ReportErrorToDOM(ApplicationUnhandledExceptionEventArgs e)
		{
			try
			{
				string errorMsg = e.ExceptionObject.Message + e.ExceptionObject.StackTrace;
				errorMsg = errorMsg.Replace('"', '\'').Replace("\r\n", @"\n");

				System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(\"Unhandled Error in Silverlight Application " + errorMsg + "\");");
			}
			catch (Exception)
			{
			}
		}
	}
}