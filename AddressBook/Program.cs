using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Problem!");
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter ZIP: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phNo: ");
            string phoneNumber =Console.ReadLine();
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();
            addressBook.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            addressBook.ViewContact();
            Console.ReadLine();
        }
    }
}
