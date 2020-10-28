using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Problem!");
            AddressBook addressBook = new AddressBook();
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Console.Write("Enter State: ");
            string state = Console.ReadLine();
            Console.Write("Enter ZIP: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phNo: ");
            string phoneNumber =Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            addressBook.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            addressBook.ViewContact();
            addressBook.EditContact(firstName);
            addressBook.ViewContact();
            Console.ReadLine();
        }
    }
}
