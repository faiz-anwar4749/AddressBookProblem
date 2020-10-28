using System;
using System.Collections.Generic;
using System.Text;
namespace AddressBook
{
    interface IContacts
    {
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zip, string phoneNumber, string email);
    }
}
