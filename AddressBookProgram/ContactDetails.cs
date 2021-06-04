using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgram
{
    /// <summary>
    //Addressbookprogram using oops concept
    //by using interface and  constructos
    /// </summary>
    interface IContacts
    {
        void Addressbook();
    }
    class ContactDetails : IContacts
    {      
        //variables
        public string firstname;
         public string lastname;
         public  string address;
         public string city;
         public string state;
         public string email;
         public int zipcode;
         public long phonenumber;
       
        //using constructors
        public ContactDetails(string firstname, string lastname, string address, string city,
                                  string state, string email, int zipcode, long phonenumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.email = email;
            this.zipcode = zipcode;
            this.phonenumber = phonenumber;
        }

        public void Addressbook()
        {            
            Console.WriteLine("Enter the details:");
        }
    }
}









    

