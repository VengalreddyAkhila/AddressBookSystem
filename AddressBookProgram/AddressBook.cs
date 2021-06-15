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
        public void Contact(string fistName, string lastName, string address, string city, string state, long zipcode, long phoneNumber, string email)
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
        public void Display()
        {
            //using foreach loop  calling the variables
            foreach (Contact contact in contactList)
            {                
                Console.WriteLine($"FirstName: { contact.fistName}\n LastName: { contact.lastName}\n Address: {contact.address}");               
                Console.WriteLine($"City: {contact.city}\n State: {contact.state}\n Zipcode: {contact.zipcode}\n PhoneNumber: {contact.phoneNumber}\n Email id: {contact.email}\n");                
            }
        }

        /// <summary>
        /// editing with parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void Edit(string firstName, string lastName)
        {           
            Contact Editedcontact = null;
            foreach (Contact contact in this.contactList)
            {
                if (contact.fistName == firstName && contact.lastName == lastName)
                    this.editContact(Editedcontact);
            }
        }
        public void editContact(Contact Editedcontact)
        {
            bool status = true;

            while (status == true)
            {

                Console.WriteLine($"Enter 1 to edit FirstName \n Enter 2 to edit LastName \n Enter 3 to edit Address \n Enter 4 to edit City \n");
                Console.WriteLine($"Enter 5 to edit State \n Enter 6 to edit Zip \n Enter 7 to edit PhoneNumber \n Enter 8 to edit Email Id \n Enter 9 if Editing is done \n");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    // Edit FirstName
                    case 1:
                        Console.WriteLine("Enter new FirstName");
                        string firstName = Console.ReadLine();
                        Editedcontact.fistName = firstName;
                        break;
                    // edit Lastlame
                    case 2:
                        Console.WriteLine("Enter new LastName");
                        string lastName = Console.ReadLine();
                        Editedcontact.lastName = lastName;
                        break;
                    // Edit Address
                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        Editedcontact.address = address;
                        break;
                    // Edit City
                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        Editedcontact.city = city;
                        break;
                    // Edit State
                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        Editedcontact.state = state;
                        break;
                    // Edit Zipcode
                    case 6:
                        Console.WriteLine("Enter new Zip");
                        long zipcode = long.Parse(Console.ReadLine());
                        Editedcontact.zipcode = zipcode;
                        break;
                    // Edit Phone NUmber
                    case 7:
                        Console.WriteLine("Enter new PhoneNumber");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        Editedcontact.phoneNumber = phoneNumber;
                        break;
                    // Edit Email ID
                    case 8:
                        Console.WriteLine("Enter new Email Id");
                        string email = Console.ReadLine();
                        Editedcontact.email = email;
                        break;
                    //editing is Done
                    case 9:
                        Console.WriteLine("New Contacts :-");
                        this.printNewContactList(Editedcontact);
                        return;

                }
            }
        }
        //Print list After Edit
        public void printNewContactList(Contact contact)
        {
            Console.WriteLine($"FirstName:  + { contact.fistName}\n LastName: + { contact.lastName}\n Address: + {contact.address}\n");
            Console.WriteLine($"City: + {contact.city}\n State:  + {contact.state}\n Zipcode: + {contact.zipcode}\n PhoneNumber: + {contact.phoneNumber}\n Email id: + {contact.email}\n");            
        }
        /// <summary>
        /// Deleting the contacts in list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void delete(string firstName, string lastName)
        {
            Contact contactDeleted = null;
            foreach (Contact contact in this.contactList)
            {
                if (contact.fistName == firstName && contact.lastName == lastName)
                {                    
                    contactDeleted = contact;
                    this.contactList.Remove(contactDeleted);
                    break;
                }
            }
            if (contactDeleted == null)
                Console.WriteLine("No contact exists");
            else
                Console.WriteLine("Deleted");
        }
      
    }
}



