using ModelLibrary;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using UCLibrary;
using ViewModelLibrary;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<ViewContact> viewContactList;
        public ObservableCollection<ViewContact> ViewContactList
        {
            get { return viewContactList; }
            set
            {
                viewContactList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ViewContactList)));
            }
        }

        private ViewContact isSelectedContact;
        public ViewContact IsSelectedContact
        {
            get { return isSelectedContact; }
            set { isSelectedContact = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsSelectedContact)));
            }
        }

        private ViewContact viewContact;
        public ViewContact ViewContact
        {
            get { return viewContact; }
            set
            {
                viewContact = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ViewContact)));
            }
        }



        private ViewContactBook viewBook;
        public ViewContactBook ViewBook
        {
            get { return viewBook; }
            set
            {
                viewBook = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ViewBook)));
            }
        }

        private FrameworkElement ucLoad;
        public FrameworkElement UcLoad
        {
            get { return ucLoad; }
            set
            {
                ucLoad = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(UcLoad)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };


        public MainWindow()
        {
            UcLoad = new UCDetails();
            initViewBook();
            InitializeComponent();
        }

        #region INITIALISATION VIEWBOOK
        private void initViewBook()
        {
            ObservableCollection<Contact> malist = new ObservableCollection<Contact>
            {
                new Contact{
            LastName = "Doe",
            FirstName = "Jeanne",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = true
                },
                new Contact{
            LastName = "Doe",
            FirstName = "John",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = false
                },
                new Contact{
            LastName = "Doe",
            FirstName = "Jack",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = false
                },
                new Contact{
            LastName = "Doe",
            FirstName = "Johnny",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = true
                },
                new Contact{
            LastName = "Doe",
            FirstName = "Jennifer",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = false
                },
                 new Contact{
            LastName = "Doe",
            FirstName = "John",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = false
                },
                new Contact{
            LastName = "Doe",
            FirstName = "Jack",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = false
                },
                new Contact{
            LastName = "Doe",
            FirstName = "Johnny",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = true
                },
                new Contact{
            LastName = "Doe",
            FirstName = "Jennifer",
            Section = "CRM",
            Emailadr = "jdoe@gmail.com",
            PhoneNumber = "0102030405",
            PosteNumber = "1234",
            Favorite = false
                }
            };
            ContactBook contactbook = new ContactBook(malist);
            ViewBook = new ViewContactBook(contactbook);
            this.ViewContactList = ViewBook.ViewContactList;

        }
        #endregion

        private void AddContact(object sender, RoutedEventArgs e)
        {
            UcLoad = new UCCreate();
        }
        private void RemoveContact(object sender, RoutedEventArgs e)
        {

        }
        private void EditContact(object sender, RoutedEventArgs e)
        {
            UcLoad = new UCDetails();
        }
        public void AddContactToBook(ViewContact _viewcontact)
        {

        }

        private void FavoriteList_Onclick(object sender, RoutedEventArgs e)
        {
            this.ViewContactList = new ObservableCollection<ViewContact>(ViewBook.ViewContactList.Where(x => x.Favorite == true).ToList());
        }

        private void ContactList_OnClick(object sender, RoutedEventArgs e)
        {
            this.ViewContactList = ViewBook.ViewContactList;
        }



    }
}
