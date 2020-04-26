using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Contacts.Classes;
using Xamarin.Essentials;
using SQLite;
using System.IO;

namespace Contacts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage //This "MainPage" is the reference that ties the XAML file under X:Class
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = nameEntry.Text,
                Lastname = lastnameEntry.Text,
                Email = emailEntry.Text,
                PhoneNumber = phoneNumberEntry.Text,
                Address = addressEntry.Text
            };

            //completly different form of "using"
            //the database path is the one brought down from the Android or iOS main fucntion call.
            if (string.IsNullOrEmpty(App.FilePath))
            { 
                throw new DirectoryNotFoundException(); 
            }
            
            //as soon as this block of code is complete, this SQLite connection will be closed.
            //This is equiv to the dispose function.
            using (SQLite.SQLiteConnection Conn = new SQLiteConnection(App.FilePath)) 
            {
                //Line below will call the table that is the same as what we have saved in the Contact class
                //All of the public var <name> that we have will each be a column.
                Conn.CreateTable<Contact>();

                //return variable will be the number of rows that is added to the table at this time:
                int rowsAdded = Conn.Insert(contact);
            }
        
        }
    }
}
