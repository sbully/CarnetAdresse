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
            get { return ViewContactList; }
            set { ViewContactList = value; }
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
            UcLoad = new UCCreate();
            //InitViewContact();
            initViewBook();
            InitializeComponent();
        }

        //#region INITIALISATION VIEW CONTACT
        //public void InitViewContact()
        //{
        //    viewContact = new ViewContact(new Contact());
        //}
        //#endregion

        #region INITIALISATION VIEWBOOK
        private void initViewBook()
        {
            ObservableCollection<Contact> malist = new ObservableCollection<Contact>
            {
                new Contact(),
                new Contact(),
                new Contact(),
                new Contact()
            };
            ContactBook contactbook = new ContactBook(malist);
            ViewBook = new ViewContactBook(contactbook);

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
            //this.ViewContactList = ViewBook.ViewContactList.Where(x => x.Favorite == true);
        }

        private void ContactList_OnClick(object sender, RoutedEventArgs e)
        {

        }



    }
}
