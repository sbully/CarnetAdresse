using HandlerLibrary;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ViewModelLibrary
{
    public class ViewContact : ObservableObject
    {
        private Contact contact;
        //private static string pathImg = "pack://application/,,,WpfApp1;Component/Resources/";
        private string directory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);


        public ViewContact(Contact _contact)
        {
            contact = _contact;
            this.LastName = _contact.LastName;
            this.FirstName = _contact.FirstName;
            this.Section = _contact.Section;
            this.Emailadr = _contact.Emailadr;
            this.PhoneNumber = _contact.PhoneNumber;
            this.PosteNumber = _contact.PosteNumber;
            this.Favorite = _contact.Favorite;
            //string path = Path.Combine(directory, "ImageProfil", contact.Id.ToString());
            //string pathimg = Path.Combine(directory, "ImageProfil", (contact.Id + ".png"));
            //string pathSansExt = Path.GetFileNameWithoutExtension(path);

            string pathdir = Path.Combine(directory, "ImageProfil");
            var files = Directory.GetFiles(pathdir, contact.Id.ToString() + ".*").ToList();
            string filename = files[0];

            //if (File.Exists(path))
            if (File.Exists(filename))
            {
                ContactImg = new BitmapImage();
                ContactImg.BeginInit();
                ContactImg.UriSource = new Uri((filename), UriKind.RelativeOrAbsolute);
                ContactImg.EndInit();
            }
            
        }

        public ViewContact()
        {
            //contact = new Contact();
        }

        private BitmapImage contactImg;
        public BitmapImage ContactImg
        {
            get { return contactImg; }
            set { contactImg = value;
                OnProperty_Change(nameof(ContactImg));
            }
        }

        private string lastName;
        public string LastName {
            get { return lastName; }
            set {
                lastName = value;
                OnProperty_Change(nameof(LastName));
            }
        }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set {
                firstName = value;
                OnProperty_Change(nameof(FirstName));
            }
        }

        private string section;
        public string Section
        {
            get { return section; }
            set
            {
                section = value;
                OnProperty_Change(nameof(Section));
            }
        }

        private string emailadr;
        public string Emailadr
        {
            get { return emailadr;
; }
            set
            {
                emailadr = value;
                OnProperty_Change(nameof(Emailadr));
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnProperty_Change(nameof(PhoneNumber));
            }
        }

        private string posteNumber;
        public string PosteNumber
        {
            get { return posteNumber; }
            set
            {
                posteNumber = value;
                OnProperty_Change(nameof(PosteNumber));
            }
        }

        private bool favorite;
        public bool Favorite
        {
            get { return favorite; }
            set
            {
                favorite = value;
                OnProperty_Change(nameof(Favorite));
            }
        }

        public static implicit operator Contact(ViewContact viewContact )
        {
            return new Contact
            {
                Emailadr = viewContact.Emailadr,
                FirstName = viewContact.FirstName,
                LastName = viewContact.LastName,
                PhoneNumber = viewContact.PhoneNumber,
                PosteNumber = viewContact.PosteNumber,
                Section = viewContact.Section,
               Favorite = viewContact.Favorite
            };
        }

    }
}
