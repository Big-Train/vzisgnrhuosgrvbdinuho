using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace vzisgnrhuosgrvbdinuho
{
    public partial class KsiazkaWindow : Window
    {
        public KsiazkaClass ksiazka;
        public KsiazkaWindow()
        {
            InitializeComponent();
            Klasaw.ItemsSource = Enum.GetValues(typeof(Klasa)).Cast<Klasa>();
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Klasaw.ItemsSource = Enum.GetValues(typeof(Klasa)).Cast<Klasa>();
            ksiazka = new KsiazkaClass(Nazwa.Text,Autor.Text, (Klasa)Klasaw.SelectedValue);
            this.DialogResult = true;
        }
    }
}
