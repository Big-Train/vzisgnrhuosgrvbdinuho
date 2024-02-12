using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vzisgnrhuosgrvbdinuho
{
    public class KsiazkaClass
    {
        public string Nazwa { get; set; }
        public string Autor { get; set; }
        public Klasa Klasa { get; set; }
        
        public KsiazkaClass(string Nazwa, string Autor, Klasa Klasa) 
        {
            this.Nazwa = Nazwa;
            this.Autor = Autor;
            this.Klasa = Klasa;
        }

        public override string ToString()
        {
            return Nazwa+ "<<,uwu,>>" + Autor+ "<<,uwu,>>"+ Klasa.ToString();
        }

    }
    public enum Klasa
    {
        Klasa1,
        Klasa2,
        Klasa3
    }
}
