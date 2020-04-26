using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Contacts.Classes;

namespace Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
        }

        private void NewContactToolbarItem_Clicked(object sender, EventArgs e)
        {
            //all of the heavy-lifting here is done by the Navigation page.
            Navigation.PushAsync(new MainPage());
        }

        //a way to see if we are going to the contacts page:
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath)) 
            {
                //if already created, the program handles this well.
                conn.CreateTable<Contact>();
                var contacts = conn.Table<Contact>().ToList();
            }
        }
    }
}

