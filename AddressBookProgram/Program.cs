using System;

namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook system");
            AddressBook addressBook = new AddressBook();

            Console.WriteLine("Enter how many contacts you want to aadd");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                AddingContactsToList(addressBook);
            }
            addressBook.Display();
            // Adding contacts to addressbook
            static void AddingContactsToList(AddressBook addressBook)
            {
                Console.WriteLine("Enter FirstName");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Email id");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Zipcode");
                long zipcode = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter PhoneNumber");
                long phoneNumber = long.Parse(Console.ReadLine());
                addressBook.Contact(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
                Console.ReadLine();
            }
            addressBook.Search();
            //editing the contact detail
            addressBook.EditContact();
            addressBook.Display();
            //deleting the contact details              
            addressBook.Delete();
           
        }
    }
}
                   
                    
            

           
        

    






