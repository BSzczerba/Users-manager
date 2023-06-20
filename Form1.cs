using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        List<Pracownik> pracownicy;
        public MainForm()
        {
            InitializeComponent();
            pracownicy = new List<Pracownik> { };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] poz = File.ReadAllLines("miejsce_zapisu.txt");
            Pracownik nowy = new Pracownik();
            foreach (string item in poz)
            {
                nowy = nowy.Otworz(item+".txt");
                pracownicy.Add(nowy);
            }
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
           if (lista.SelectedIndex != -1)
           {            
            EditEmployeeWindow edycja = new EditEmployeeWindow();
            edycja.Edytuj(lista.SelectedItem as Pracownik);
            edycja.ShowDialog();
           }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            lista.Items.Clear();
            foreach (Pracownik item in pracownicy)
            {
                lista.Items.Add(item);
            }
            GC.Collect();
        }

        private void Nowy_Click(object sender, EventArgs e)
        {
            Pracownik nowy = new Pracownik();
            pracownicy.Add(nowy);
            EditEmployeeWindow edycja = new EditEmployeeWindow(nowy);
            edycja.ShowDialog();
        }

        private void Zapisz_zmiany_Click(object sender, EventArgs e)
        {
            List<string> miejsce = new List<string> { };
            foreach (Pracownik item in pracownicy)
            {
                item.Zapisz();
                miejsce.Add(item.pesel.ToString());
            }
            File.WriteAllLines("miejsce_zapisu.txt", miejsce);
        }
    }
}
