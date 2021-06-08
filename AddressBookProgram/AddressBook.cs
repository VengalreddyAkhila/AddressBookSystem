using System;
using System.Collections.Generic;
using System.Text;



namespace AddressBookProgram
{
    class AddressBook
    {
        /// <summary>
        /// creating contactlist for address book
        /// using generics
        /// </summary>
        private List<Contact> contactList;        
        public AddressBook()
        {           
            contactList = new List<Contact>();
        }
        /// <summary>
        /// using Constructors creating a list
        /// </summary>
        /// <param name="fistName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipcode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public void addContacts(string fistName, string lastName, string address, string city, string state, int zipcode, long phoneNumber, string email)
        {           
            Contact contact = new Contact();            
            contact.fistName = fistName;
            contact.lastName = lastName;
            contact.address = address;
            contact.city = city;
            contact.state = state;
            contact.zipcode = zipcode;
            contact.phoneNumber = phoneNumber;
            contact.email = email;
          
            contactList.Add(contact);
        }       
        public void print()
        {
            //using foreach loop  calling the variables
            foreach (Contact contact in contactList)
            {                
                Console.WriteLine("FirstName: " + contact.fistName);
                Console.WriteLine("LastName: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("Zipcode: " + contact.zipcode);
                Console.WriteLine("PhoneNumber: " + contact.phoneNumber);
                Console.WriteLine("Email id: " + contact.email);
            }
        }

        /// <summary>
        /// editing with parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void edit(string firstName, string lastName)
        {           
            Contact contactToBeEdited = null;           
            foreach (Contact contact in this.contactList)
            {
                if (contact.fistName == firstName && contact.lastName == lastName)
                    contactToBeEdited = contact;
            }
            // if First Name And last name is not match with entered data gives error
            if (contactToBeEdited == null)
            {                
                Console.WriteLine("No such contact exists");
                return;
            }           
            this.editThisContact(contactToBeEdited);
        }
        public void editThisContact(Contact contactToBeEdited)
        {            
            while (true)
            {                
                Console.WriteLine("Enter 1 to edit FirstName");
                Console.WriteLine("Enter 2 to edit LastName");
                Console.WriteLine("Enter 3 to edit Address");
                Console.WriteLine("Enter 4 to edit City");
                Console.WriteLine("Enter 5 to edit State");
                Console.WriteLine("Enter 6 to edit Zip");
                Console.WriteLine("Enter 7 to edit PhoneNumber");
                Console.WriteLine("Enter 8 to edit Email Id");
                Console.WriteLine("Enter 9 if Editing is done");
               
                int choice = Convert.ToInt32(Console.ReadLine());                
                switch (choice)
                {
                    // Edit FirstName
                    case 1:
                        Console.WriteLine("Enter new FirstName");
                        string fName = Console.ReadLine();
                        contactToBeEdited.fistName = fName;
                        break;
                    // edit Lastlame
                    case 2:
                        Console.WriteLine("Enter new LastName");
                        string lName = Console.ReadLine();
                        contactToBeEdited.lastName = lName;
                        break;
                    // Edit Address
                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        contactToBeEdited.address = address;
                        break;
                    // Edit City
                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        contactToBeEdited.city = city;
                        break;
                    // Edit State
                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        contactToBeEdited.state = state;
                        break;
                    // Edit Zipcode
                    case 6:
                        Console.WriteLine("Enter new Zip");
                        int zipcode = Convert.ToInt32(Console.ReadLine());
                        contactToBeEdited.zipcode = zipcode;
                        break;
                    // Edit Phone NUmber
                    case 7:
                        Console.WriteLine("Enter new PhoneNumber");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        contactToBeEdited.phoneNumber = phoneNumber;
                        break;
                    // Edit Email ID
                    case 8:
                        Console.WriteLine("Enter new Email Id");
                        string email = Console.ReadLine();
                        contactToBeEdited.email = email;
                        break;
                    //if Done
                    case 9:
                        Console.WriteLine("Editing done.New Contacts :-");
                        this.printSpecificContact(contactToBeEdited);
                        return;
                }
            }
        }
        //Print list After Edit
        public void printSpecificContact(Contact contact)
        {
            Console.WriteLine("FirstName: " + contact.fistName);
            Console.WriteLine("LastName: " + contact.lastName);
            Console.WriteLine("Address: " + contact.address);
            Console.WriteLine("City: " + contact.city);
            Console.WriteLine("State: " + contact.state);
            Console.WriteLine("Zip: " + contact.zipcode);
            Console.WriteLine("PhoneNumber: " + contact.phoneNumber);
            Console.WriteLine("Email id: " + contact.email);
        }
    }
}



