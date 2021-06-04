using System;

namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to AddressBookSystem");
            ContactDetails contact = new ContactDetails
              ( "Sree","Ramu", "NehruColony","Hyderabad","Telangana",
                       "akhila@gmail.com",509132,67834215678);
            contact.Addressbook();
            
            Console.WriteLine(contact.firstname+ "" + contact.lastname);
            Console.WriteLine (contact.address +"" +contact.state );
            Console.WriteLine(contact.city + "");
            Console.WriteLine(contact.email + "");
            Console.WriteLine(contact.zipcode + "");
            Console.WriteLine (""+contact.phonenumber);
        }
    }
}
