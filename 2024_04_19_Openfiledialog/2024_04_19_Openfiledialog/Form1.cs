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

namespace _2024_04_19_Openfiledialog
{
    public partial class Form1 : Form
    {
        private List<Kepviselo> kepviselok = new List<Kepviselo>();
        public Form1()
        {
            InitializeComponent();
            //Fajlbeolvasas("szavazatok.txt");
            //ListaKiiratasa();

            //HF Pizzak.txt -> legördülő menübe
            //Rendelés eredményét kiíratni egy indexszel ellátott fájlba!
        }

        private void ListaKiiratasa()
        {
            lblFajl.Items.Clear();
            for (int i = 0; i < kepviselok.Count; i++)
            {
                lblFajl.Items.Add(kepviselok[i].ToString());
            }
        }

        private void Fajlbeolvasas(string utvonal)
        {
            kepviselok.Clear();
            try
            {
                StreamReader f = new StreamReader(utvonal);
                while (!f.EndOfStream)
                {
                    kepviselok.Add(new Kepviselo(f.ReadLine()));
                }
                f.Close();
            }
            catch
            {
                MessageBox.Show("HIBA! pl.: Nem jól adta meg az útvonalat vagy nem létezik a fájl, rossz a kiterjesztés. STB.");
            }
        }

        private void btnFajlbe_Click(object sender, EventArgs e)
        {
            //Fajlbeolvasas(txtUtvonal.Text);
            //ListaKiiratasa();
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "cs files (*.cs)|*.cs|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Fajlbeolvasas(openFileDialog1.FileName);
                ListaKiiratasa();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //A listából válasszon ki egy elemet és írassa ki eredeti szerkezettel az ön által választott helyre és névvel.
                FajlbaIratas(saveFileDialog1.FileName);
            }
        }

        private void FajlbaIratas(string utvonal)
        {
            StreamWriter f = new StreamWriter(utvonal);
            f.Write(lblFajl.SelectedItem.ToString());
            f.Close();
        }
    }

    class Kepviselo
    {
        public int kerulet, szavazatokSzama;
        public string vnev, knev, part;

        public Kepviselo(string sor)
        {
            string[] st = sor.Split(' ');
            kerulet = Convert.ToInt32(st[0]);
            szavazatokSzama = Convert.ToInt32(st[1]);
            vnev = st[2];
            knev = st[3];
            part = st[4];
        }

        public override string ToString()
        {
            return kerulet + " " + szavazatokSzama + " " + vnev + " " + knev + " " + part;
        }
    }
}
