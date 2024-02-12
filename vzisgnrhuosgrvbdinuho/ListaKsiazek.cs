using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vzisgnrhuosgrvbdinuho
{
    internal class ListaKsiazek
    {
        public ObservableCollection<KsiazkaClass> ksiazki = new ObservableCollection<KsiazkaClass>();
        public ListaKsiazek()
        {
            //LoadKsiazki("plik.txt");
        }
        public void AddKsiazka(KsiazkaClass ksiazka)
        {
            ksiazki.Add(ksiazka);
        }
        public void RemoveKsiazka(KsiazkaClass ksiazka)
        {
            ksiazki.Remove(ksiazka);
        }
        public void EditKsiazka(int index, KsiazkaClass ksiazka)
        {
            ksiazki[index] = ksiazka;
        }
        public void RemoveKsiazkaAt(int index)
        {
            if (index >= 0 && index < ksiazki.Count)
                ksiazki.RemoveAt(index);
        }
        public void LoadKsiazki(string file)
        {
            ksiazki.Clear();
            try
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {

                    string[] parts = line.Split("<<,uwu,>>");

                    string tytu = parts[0].Trim();
                    string autor = parts[1].Trim();
                    Klasa klasa = (Klasa)Enum.Parse(typeof(Klasa), parts[2].Trim(), true);
                    KsiazkaClass ksiazkaxd = new KsiazkaClass(tytu, autor, klasa);
                    ksiazki.Add(ksiazkaxd);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("blad: " + ex.Message);
            }
        }
        public void AddKsiazki(string file)
        {
            try
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {

                    string[] parts = line.Split("<<,uwu,>>");

                    string tytu = parts[0].Trim();
                    string autor = parts[1].Trim();
                    Klasa klasa = (Klasa)Enum.Parse(typeof(Klasa), parts[2].Trim(), true);
                    KsiazkaClass ksiazkaxd = new KsiazkaClass(tytu, autor, klasa);
                    ksiazki.Add(ksiazkaxd);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("blad: " + ex.Message);
            }
        }
        public void SaveKsiazki(string file)
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (KsiazkaClass ksiazka in ksiazki)
                {
                    lines.Add(ksiazka.ToString());
                }

                File.WriteAllLines(file, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine("bladxd: " + ex.Message);
            }
        }
        
    }
}
