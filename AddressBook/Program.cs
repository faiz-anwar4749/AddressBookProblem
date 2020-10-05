using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Problem!");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Faiz", "Anwar", "Hospital Chowk", "Daltonganj", "Palamau", 822101, 9876543210, "faiz.anwar@gmail.com");
            addressBook.ViewContact();
            Console.ReadLine();
        }
    }
}
