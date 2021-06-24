using System;
using System.Collections.Generic;
using System.Linq;
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
        //display the contact list
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
        /// editing the contact details
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void EditContact()
        {
            if (contactList.Count > 0)
            {
                Console.WriteLine("Enter First Name to edit : ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name to edit:");
                string lastName = Console.ReadLine();

                foreach (Contact contact in contactList)
                {
                    if (contact.fistName == firstName && contact.lastName == lastName)
                    {
                        Console.WriteLine("Press 1. to edit First Name");
                        Console.WriteLine("Press 2. to edit Last Name");
                        Console.WriteLine("Press 3. to edit Address");
                        Console.WriteLine("Press 4. to edit City");
                        Console.WriteLine("Press 5. to edit State");
                        Console.WriteLine("Press 6. to edit zip");
                        Console.WriteLine("Press 7. to edit Phone Number");
                        Console.WriteLine("Press 8. to edit Email");
                        Console.WriteLine("Press 9. To Exit" + "\n");
                        int ContactToBeEdited = Convert.ToInt32(Console.ReadLine());
                        switch (ContactToBeEdited)
                        {
                            //edit firstname
                            case 1:
                                Console.WriteLine("Edit First Name : ");
                                string FirstName = Console.ReadLine();
                                contact.fistName = FirstName;
                                break;
                            // edit Lastlame
                            case 2:
                                Console.WriteLine("Enter new LastName");
                                string LastName = Console.ReadLine();
                                contact.lastName = LastName;
                                break;
                            // Edit Address
                            case 3:
                                Console.WriteLine("Enter new Address");
                                string address = Console.ReadLine();
                                contact.address = address;
                                break;
                            // Edit City
                            case 4:
                                Console.WriteLine("Enter new City");
                                string city = Console.ReadLine();
                                contact.city = city;
                                break;
                            // Edit State
                            case 5:
                                Console.WriteLine("Enter new State");
                                string state = Console.ReadLine();
                                contact.state = state;
                                break;
                            // Edit Zipcode
                            case 6:
                                Console.WriteLine("Enter new Zip");
                                long zipcode = long.Parse(Console.ReadLine());
                                contact.zipcode = zipcode;
                                break;
                            // Edit Phone NUmber
                            case 7:
                                Console.WriteLine("Enter new PhoneNumber");
                                long phoneNumber = long.Parse(Console.ReadLine());
                                contact.phoneNumber = phoneNumber;
                                break;
                            // Edit Email ID
                            case 8:
                                Console.WriteLine("Enter new Email Id");
                                string email = Console.ReadLine();
                                contact.email = email;
                                break;

                        }
                    }
                }

            }
            else
                Console.WriteLine("enter valid name");
        }
        public void Delete()
        {

                Contact contactDeleted = null;
                Console.WriteLine("Enter first name to delete");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter lastname to delete");
                string lastName = Console.ReadLine();
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
                    Console.WriteLine("enter valid contact");
                else
                    Console.WriteLine("Deleted");
            
        }
        /// <summary>
        /// searching city and state in multiple addressbooks 
        /// </summary>
        public void Search()
        {
            //searching for city in addressbook
            Console.WriteLine(" searching city in addressbook");
            String City = Console.ReadLine();
            foreach (Contact contactdetails in this.contactList.FindAll(x => x.city == City ))
            {
                Console.WriteLine("" + contactdetails.fistName + contactdetails.lastName + " from  : " + contactdetails.city+"city");
            }
            //searching for state in addressbook
            Console.WriteLine(" searching state in addressbook");
            String State = Console.ReadLine();
            foreach (Contact contactdetails in this.contactList.FindAll(x => x.state == State))
            {
                Console.WriteLine("" + contactdetails.fistName + contactdetails.lastName + " from  : " + contactdetails.state + "state");
            }
        }
    }

}



