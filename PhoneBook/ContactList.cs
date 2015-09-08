using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class ContactList
    {
        public List<Contact> Contacts { get; set; }

        public ContactList()
        {
            this.Contacts = new List<Contact>();
        }
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return Contacts;
        }

    }
}
