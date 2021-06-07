using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressBookProgram
{
    class AddressBook
    {
        private List<Contacts> contactList;
        /// <summary>
        /// creating the contact details list
        /// </summary>
        public AddressBook()
        {
            contactList = new List<Contacts>();
        }
        /// <summary>
        /// using constructor 
        /// </summary>
        /// <param name="fistName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="email"></param>
        /// <param name="zipcode"></param>
        /// <param name="phoneNumber"></param>
        public void addContacts(string fistName, string lastName, string address, string city, string state, string email, int zipcode, long phoneNumber)
        {            
            Contacts contact = new Contacts();            
            contact.fistName = fistName;
            contact.lastName = lastName;
            contact.address = address;
            contact.city = city;
            contact.state = state;
            contact.email = email;
            contact.zipcode = zipcode;
            contact.phoneNumber = phoneNumber;
            
            //adding contact details in  list 
            contactList.Add(contact);
        }        
        public void print()
        {
            //using foreach loop for calling the variable 
            foreach (Contacts contact in contactList)
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
    }
}

