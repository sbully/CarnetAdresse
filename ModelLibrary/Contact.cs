using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string section;
        private string emailadr;
        private string phoneNumber;
        private string posteNumber;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Section { get => section; set => section = value; }
        public string Emailadr { get => emailadr; set => emailadr = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string PosteNumber { get => posteNumber; set => posteNumber = value; }

        public Contact()
        {

        }


    }
}
