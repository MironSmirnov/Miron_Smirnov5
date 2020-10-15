using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Miron_Smirnov
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new Tunniplaan();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
