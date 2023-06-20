using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EditEmployeeWindow : Form
    {
        Pracownik pracownik;
        public EditEmployeeWindow()
        {
            InitializeComponent();
        }
        public EditEmployeeWindow(Pracownik pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
        }
        public void Edytuj(Pracownik pracownik)
        {
            this.pracownik = pracownik;
            textBox_Imie.Text = pracownik.imie;
            textBox_Miasto.Text = pracownik.miasto;
            textBox_Nazwisko.Text = pracownik.nazwisko;
            textBox_Pensja.Text = pracownik.pensja.ToString();
            textBox_Pesel.Text = pracownik.pesel.ToString();
            textBox_Stanowisko.Text = pracownik.stanowisko;
            textBox_Ulica.Text = pracownik.ulica;
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            pracownik.imie = textBox_Imie.Text;
            pracownik.nazwisko = textBox_Nazwisko.Text;
            pracownik.pesel = Convert.ToInt64(textBox_Pesel.Text);
            pracownik.ulica = textBox_Ulica.Text;
            pracownik.miasto = textBox_Miasto.Text;
            pracownik.stanowisko = textBox_Stanowisko.Text;
            pracownik.pensja = Convert.ToInt32(textBox_Pensja.Text);
            this.Close();
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {          
            this.Close();
        }
    }
}
