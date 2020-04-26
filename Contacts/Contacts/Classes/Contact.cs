using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Contacts.Classes
{
    class Contact
    {
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        
        [Column("Surname")]
        public string Lastname { get; set; }
        public string Email { get; set; }
        
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}
