using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ViewModelLibrary;

namespace UCLibrary
{
    /// <summary>
    /// Logique d'interaction pour UCCreate.xaml
    /// </summary>
    public partial class UCCreate : UserControl
    {
        public ViewContact viewcontact { get; set; }

        public UCCreate()
        {
            viewcontact = new ViewContact();
            InitializeComponent();
        }

        private void LoadImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
            "Portable Network Graphic (*.png)|*.png";

            if (op.ShowDialog() == true)
            {
                viewcontact.ContactImg = new BitmapImage(new Uri(op.FileName));
            }
        }
        private void SaveContact_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
