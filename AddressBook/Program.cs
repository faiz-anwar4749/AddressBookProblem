using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Problem!");
            AddressBook addressBook = new AddressBook();
            int choice;
            do
            {
                Console.WriteLine("Choose An Option \n1.Add New Contact \n2.Edit Existing Contact \n3.Delete A Contact \n4.View A Contact \n5.View All Contacts \n6.Exit Application\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
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
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();
                        addressBook.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To Edit :");
                        string nameToEdit = Console.ReadLine();
                        addressBook.EditContact(nameToEdit);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To Delete :");
                        string nameToDelete = Console.ReadLine();
                        addressBook.DeleteContact(nameToDelete);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name Of Contact To View :");
                        string nameToView = Console.ReadLine();
                        addressBook.ViewContact(nameToView);
                        break;
                    case 5:
                        addressBook.ViewContact();
                        break;
                    case 6:
                        Console.WriteLine("Thank You For Using Address Book System.");
                        break;

                }
            } while (choice != 6);
        }
    }
}
