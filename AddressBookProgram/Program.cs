using System;

namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to AddressBook system");
            //getting contact details
            AddressBook addressBook = new AddressBook();           
            addressBook.addContacts("Akhila", "Reddy", "Gadwal", "Hyderabad", "Telangana","akhila@gmail.com", 509134, 1234567890);            
            addressBook.print();
            Console.ReadLine();
        }
    }
}
