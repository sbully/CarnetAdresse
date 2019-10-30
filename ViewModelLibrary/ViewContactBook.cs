using HandlerLibrary;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ViewModelLibrary
{
    public class ViewContactBook : ObservableObject
    {
        private ContactBook contactBook;
        private ObservableCollection<ViewContact> viewContactList;
        public ObservableCollection<ViewContact> ViewContactList
        {
            get { return viewContactList; }
            set { viewContactList = value; }
        }

        public ViewContactBook(ContactBook _contactBook)
        {
            contactBook = _contactBook;
            ViewContactList = new ObservableCollection<ViewContact>();
            foreach (Contact contact in contactBook.MyContactList)
            {
                ViewContactList.Add(new ViewContact(contact));
            }
            contactBook.MyContactList.CollectionChanged += ListChange; 
        }
        
        public void ListChange(object sender, EventArgs e)
        {

        }

        public bool AddContact(ViewContact _viewcontact)
        {
            ViewContactList.Add(_viewcontact);
           return contactBook.AddContact(_viewcontact);
        }

        public void RemoveContact(ViewContact _viewContact)
        {
            contactBook.RemoveContact(_viewContact);
        }

        public void LoadContact(IEnumerable<ModelLibrary.Contact> _contactList)
        {
            contactBook.MyContactList = new ObservableCollection<ModelLibrary.Contact>(_contactList);
            OnProperty_Change(nameof(contactBook.MyContactList));
        }


    }
}
