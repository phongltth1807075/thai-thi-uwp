using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using bai_thi_uwp.Entity;
using bai_thi_uwp.Models;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace bai_thi_uwp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListContact : Page
    {
        static ObservableCollection<Contact> ListAllContact;
        private ContactModal contactModal;

        public ListContact()
        {
            this.InitializeComponent();
            this.contactModal = new ContactModal();

            this.Loaded += LoadContact;
        }
        private void LoadContact(object sender, RoutedEventArgs e)

        {

            var list = contactModal.Select();

            ListAllContact = new ObservableCollection<Contact>(list);

            ListViewNote.ItemsSource = ListAllContact;
        }
    }
}
