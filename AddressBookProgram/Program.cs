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
            addressBook.addContacts("Akhila", "Reddy", "Gadwal", "Hyderabad", "Telangana", 1234567, 899000890, "akhila@gmail.com");
            /// <summary>
            /// Adding contacts to addressbook
            /// </summary>
            /// <param name="addressBook"></param>
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
                int zipcode = Convert.ToInt32(Console.ReadLine());               
                Console.WriteLine("Enter PhoneNumber");
                long phoneNumber = long.Parse(Console.ReadLine());
                addressBook.addContacts(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
                Console.ReadLine();
            }
            AddingContactsToList(addressBook);
            addressBook.print();          
            Console.WriteLine(" Press 1 for Edit the details ,\n Press 2 for Delete the details : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                   // editing the contacts in  list
                case 1:
                    Console.WriteLine("Enter FirstName of Contact to be edited");
                    string firstNameOfContactToBeEdited = Console.ReadLine();
                    Console.WriteLine("Enter LastName of Contact to be edited");
                    string lastNameOfContactToBeEdited = Console.ReadLine();
                    break;
                    //deleting the contacts in list
                case 2:                    
                    Console.WriteLine("Enter FirstName of Contact to be deleted");
                    string firstNameOfContactToBeDeleted = Console.ReadLine();
                    Console.WriteLine("Enter LastName of Contact to be deleted");
                    string lastNameOfContactToBeDeleted = Console.ReadLine();
                    addressBook.delete(firstNameOfContactToBeDeleted, lastNameOfContactToBeDeleted);
                    break;
                default:
                    Console.WriteLine("Invalid choice : ");
                    break;
            }
            Console.ReadLine();
        }

    }

       
    
}

