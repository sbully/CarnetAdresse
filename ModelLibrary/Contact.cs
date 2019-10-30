namespace ModelLibrary
{

    public class Contact 
    {
        private static int idnumber = 1;
        private int id;
        private string firstName;
        private string lastName;
        private string section;
        private string emailadr;
        private string phoneNumber;
        private string posteNumber;
        private bool favorite;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Section { get => section; set => section = value; }
        public string Emailadr { get => emailadr; set => emailadr = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string PosteNumber { get => posteNumber; set => posteNumber = value; }
        public bool Favorite { get => favorite; set => favorite = value; }
        
        public Contact()
        {
            Id = idnumber;
            LastName = "Doe";
            FirstName = "John";
            Section = "CRM";
            Emailadr = "jdoe@gmail.com";
            PhoneNumber = "0102030405";
            PosteNumber = "1234";
            idnumber++;

        }

        public Contact(string firstName, string lastName, string section, string emailadr, string phoneNumber, string posteNumber)
        {
            Id = idnumber;
            FirstName = firstName;
            LastName = lastName;
            Section = section;
            Emailadr = emailadr;
            PhoneNumber = phoneNumber;
            PosteNumber = posteNumber;
            idnumber++;
        }

        public void FavoriteHandler()
        {
            favorite = !favorite;
        }


    }
}
