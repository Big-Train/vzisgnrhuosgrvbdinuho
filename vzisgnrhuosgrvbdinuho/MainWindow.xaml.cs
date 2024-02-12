using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vzisgnrhuosgrvbdinuho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaKsiazek lista = new ListaKsiazek();

        public MainWindow()
        {
            InitializeComponent();
            pListBox.ItemsSource = lista.ksiazki;
        }
        private void AddKsiazka_Click(object sender, RoutedEventArgs e)
        {
            KsiazkaWindow ksiazkaWindow = new KsiazkaWindow();
            ksiazkaWindow.DataContext = ksiazkaWindow.ksiazka;
            var result = ksiazkaWindow.ShowDialog();
            if (result == true)
            {
                lista.AddKsiazka(ksiazkaWindow.ksiazka);
            }
        }
        private void EditKsiazka_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(pListBox.SelectedIndex);
            if (pListBox.SelectedIndex >=0) 
            { 
                KsiazkaWindow ksiazkaWindow = new KsiazkaWindow();
                KsiazkaClass per = lista.ksiazki[pListBox.SelectedIndex];
                ksiazkaWindow.ksiazka = new KsiazkaClass(per.Nazwa, per.Autor, per.Klasa);
                ksiazkaWindow.DataContext = ksiazkaWindow.ksiazka;
                var result = ksiazkaWindow.ShowDialog();
                if (result == true)
                {
                    lista.EditKsiazka(pListBox.SelectedIndex, ksiazkaWindow.ksiazka);
                }
            }
        }
        private void DeleteKsiazka_Click(object sender, RoutedEventArgs e)
        {
            lista.RemoveKsiazkaAt(pListBox.SelectedIndex);
        }

        private void LoadKsiazkaFromFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            lista.LoadKsiazki(openFileDialog.FileName);
        }
        private void SaveKsiazkaToFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            lista.SaveKsiazki(saveFileDialog.FileName);
        }
        private void AddFromFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            lista.AddKsiazki(openFileDialog.FileName);
        }
        private void CloseApp_Click(object sender, RoutedEventArgs e) 
        {
            Application.Current.Shutdown();
        }
    }
}