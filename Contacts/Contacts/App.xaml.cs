using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Contacts
{
    public partial class App : Application
    {
        //static because we don't need to use the class to access this variable.
        public static string FilePath;

        public App()
        {
            InitializeComponent();

            //By changing the line below from: MainPage = new MainPage();
            //this will give us pre-generated back buttons, titles, etc.
            //Users do not "see" navigation page.
            MainPage = new NavigationPage(new ContactsPage());
        }
        public App(string filePath)
        {
            InitializeComponent();

            //By changing the line below from: MainPage = new MainPage();
            //this will give us pre-generated back buttons, titles, etc.
            //Users do not "see" navigation page.
            MainPage = new NavigationPage(new ContactsPage());

            FilePath = filePath;
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
