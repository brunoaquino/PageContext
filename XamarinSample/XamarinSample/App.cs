
using Xamarin.Forms;
using XamarinSample.Autofac;
using XamarinSample.Pages.Interfaces;

namespace XamarinSample
{
    public class App : Application
    {

        #region Constructor

        public App()
        {
            AutofacConfig.ConfigureContainer();

            MainPage = new NavigationPage(AutofacConfig.GetPage<IFirstPage, Page>());
        }

        #endregion

        #region Methods

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
