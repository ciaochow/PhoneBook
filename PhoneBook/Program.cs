using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            View view = new View();
            ContactList contactList = new ContactList();
            while (true)
            {
                view.StartMenu();
                string v = view.GetInput();
                if (v.ToUpper() == "Q")
                {
                    System.Environment.Exit(0);
                }
                // Display all contacts.
                else if (v == "1")
                {
                    List<Contact> contacts = contactList.GetAllContacts();
                    if (contacts.Count == 0)
                        view.NoContacts();
                    else
                    {
                        view.PrintContacts(contacts);
                    }
                    view.PauseForUser();
                }
                // Add a contact.
                else if (v == "2")
                {
                    Contact contact = new Contact();
                    contact.FirstName = view.GetInputFor("Please enter your first name");
                    contact.LastName = view.GetInputFor("Please enter your last name");
                    contact.PhoneNumber = view.GetInputFor("Please enter your phone number");
                    contactList.AddContact(contact);
                    Console.Clear();
                    view.PrintContact(contact);
                    view.ContactAdded();
                    view.PauseForUser();
                }
                // Delete a contact.
                else if (v == "3")
                {
                    List<Contact> contacts = contactList.GetAllContacts();
                    if (contacts.Count == 0)
                    {
                        view.NoContacts();
                    }
                    else
                    {
                        view.PrintContacts(contacts);
                        int deletenumber =
							int.Parse(view.GetInputFor("Enter number of contact to delete"));

						bool deleteSuccess = contactList.DeleteContact(deletenumber - 1);
						if (deleteSuccess) { 
							view.ContactDeleted (); 
						} else {
							view.ContactInvalid ();
						}
                    }
                    view.PauseForUser();
                }
                // Edit a contact.
                else if (v == "4")
                {
                    List<Contact> contacts = contactList.GetAllContacts();
                    if (contacts.Count == 0)
                    {
                        view.NoContacts();
                    }
                    else
                    {
                        view.PrintContacts(contacts);
                        int editnumber =
							int.Parse(view.GetInputFor("Please enter the number of the contact to edit"));
						
                        if (editnumber > contacts.Count || editnumber < 1)
                        {
                            view.ContactInvalid();
//                            view.PauseForUser();
//                            continue;
                        }
                        else
                        {
                            view.PrintContact(contacts[editnumber - 1]);
                            string firstName = view.GetInputFor("Enter the updated first name");
                            string lastName = view.GetInputFor("Enter the updated last name");
                            string phoneNumber = view.GetInputFor("Enter the updated phone number");
							contactList.EditContact (editnumber - 1, firstName, lastName, phoneNumber);
							Console.WriteLine ();
                            view.PrintContact(contacts[editnumber - 1]);
                            view.ContactUpdated(editnumber);
                        }
                    }
                    view.PauseForUser();
                }
            }
        }
    }
}
