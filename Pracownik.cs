using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab2
{
    public class Pracownik
    {
        private string Imie;
        private string Nazwisko;
        private long Pesel;
        private string Ulica;
        private string Miasto;
        private string Stanowisko;
        private int Pensja;

        public string imie   
        {
            get { return Imie; }   
            set { Imie = value; }  
        }
        public string nazwisko
        {
            get { return Nazwisko; }
            set { Nazwisko = value; }
        }
        public long pesel
        {
            get { return Pesel; }
            set {
                if (value.ToString().Length == 11)
                {
                    Pesel = value;
                }               
            }
        }
        public string ulica
        {
            get { return Ulica; }
            set { Ulica = value; }
        }
        public string miasto
        {
            get { return Miasto; }
            set { Miasto = value; }
        }
        public string stanowisko
        {
            get { return Stanowisko; }
            set { Stanowisko = value; }
        }
        public int pensja
        {
            get { return Pensja; }
            set { Pensja = value; }
        }
        public void Zapisz()
        {
            if (pesel != 0)
            {
                List<string> zapisz = new List<string>
                {
                    Imie,
                    Nazwisko,
                    Pesel.ToString(),
                    Ulica,
                    Miasto,
                    Stanowisko,
                    Pensja.ToString()
                };
                File.WriteAllLines($"{pesel}.txt",zapisz);
            }
        }
        public Pracownik Otworz(string plik)
        {
            Pracownik pracownik = new Pracownik();
            string[] lines = File.ReadAllLines(plik);
            pracownik.imie = lines[0];
            pracownik.nazwisko = lines[1];
            pracownik.pesel = Convert.ToInt64(lines[2]);
            pracownik.ulica = lines[3];
            pracownik.miasto = lines[4];
            pracownik.stanowisko = lines[5];
            pracownik.pensja = Convert.ToInt32(lines[6]);
            return pracownik;
        }
        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
