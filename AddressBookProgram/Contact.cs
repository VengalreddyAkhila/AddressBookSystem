namespace AddressBookProgram
{
    class Contact
    {
        /// <summary>
        /// creating the list  using properties 
        /// </summary>       
        
        public string fistName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public long zipcode { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }
    }
}