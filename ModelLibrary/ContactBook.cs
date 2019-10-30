using System.Collections.ObjectModel;
using System.Linq;

namespace ModelLibrary
{
    public class ContactBook
    {
        private ObservableCollection<Contact> myContactList;
        public ObservableCollection<Contact> MyContactList
        {
            get { return myContactList; }
            set { myContactList = value; }
        }

        public ContactBook()
        {
            myContactList = new ObservableCollection<Contact>();
        }

        public ContactBook(ObservableCollection<Contact> _listcontact)
        {
            myContactList = _listcontact;
        }

        public bool AddContact(Contact _contact)
        {
            if(_contact!=null && myContactList.FirstOrDefault(c=> c.Emailadr == _contact.Emailadr)!=null)
            {
                myContactList.Add(_contact);
                return true;
            }
            return false;
        }

        public void RemoveContact(Contact _contact)
        {
            myContactList.Remove(_contact);
        }
       

    }
}
