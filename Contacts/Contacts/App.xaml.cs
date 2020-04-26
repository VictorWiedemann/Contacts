using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Contacts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //By changing the line below from: MainPage = new MainPage();
            //this will give us pre-generated back buttons, titles, etc.
            //Users do not "see" navigation page.
            MainPage = new NavigationPage(new ContactsPage());
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
