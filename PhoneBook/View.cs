using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class View
    {
        public void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("-------- Start Menu ---------");
            Console.WriteLine();
            Console.WriteLine("1. Display contacts");
            Console.WriteLine("2. Add a contact");
            Console.WriteLine("3. Delete a contact");
            Console.WriteLine("4. Edit a contact");
            Console.WriteLine();
            Console.Write("Select an option or press Q to quit: ");
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void PrintContact(Contact contact)
        {
            Console.WriteLine(contact.FirstName + " " + contact.LastName);
            Console.WriteLine("Phonenumber: " + contact.PhoneNumber);
        }

        public string GetInputFor(string question)
        {
            Console.WriteLine();
            Console.Write(question + ": ");
            return Console.ReadLine();
        }

        public void PrintContacts(List<Contact> contacts)
        {
            Console.Clear();
            Console.WriteLine("------ Contact List ------");
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine();
                Console.Write("{0} - ", i+1);
                PrintContact(contacts[i]);
            }
        }

        public void PauseForUser()
        {
            Console.WriteLine();
            Console.Write("Press any continue to return to the menu. ");
            Console.ReadKey();
        }

        public string GetContactNoFor(string question)
        {
            Console.WriteLine();
            Console.Write(question + ": ");
            return Console.ReadLine();
        }

        public void ContactUpdated(int editnumber)
        {
            Console.WriteLine();
            Console.WriteLine("Contact#{0} has been updated.", editnumber);
        }

        public void NoContacts()
        {
            Console.Clear();
            Console.WriteLine("You do not currently have any contacts.");
        }

        public void ContactAdded()
        {
            Console.WriteLine();
            Console.WriteLine("Contact added.");
        }

        public void ContactDeleted()
        {
            Console.WriteLine();
            Console.WriteLine("Contact deleted.");
        }

        public void ContactInvalid()
        {
            Console.WriteLine();
            Console.WriteLine("That contact number doesn't exist.");
        }
    }
}
