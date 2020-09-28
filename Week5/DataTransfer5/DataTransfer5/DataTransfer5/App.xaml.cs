using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DataTransfer5
{
	public partial class App : Application
	{
		public App()
		{
			Xamarin.FormsBook.Toolkit.Toolkit.Init();

			if (Properties.ContainsKey("appData"))
			{
				AppData = AppData.Deserialize((string)Properties["appData"]);
			}
			else
			{
				AppData = new AppData();
			}
			Page homePage = new DataTransfer5HomePage();

			// Go to the home page.
			MainPage = new NavigationPage(homePage);
			if (Properties.ContainsKey("isInfoPageActive") &&
				(bool)Properties["isInfoPageActive"])
			{
				homePage.Navigation.PushAsync(new DataTransfer5InfoPage(), false);
			}
		}

		public AppData AppData { private set; get; }

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
			Properties["appData"] = AppData.Serialize();

			Properties["isInfoPageActive"] =
				MainPage.Navigation.NavigationStack.Last() is DataTransfer5InfoPage;
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
