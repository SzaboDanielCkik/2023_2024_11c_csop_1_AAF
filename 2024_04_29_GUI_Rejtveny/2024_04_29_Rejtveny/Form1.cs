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

namespace _2024_04_29_Rejtveny
{
    public partial class Form1 : Form
    {
        List<Versenyzo> versenyzok = new List<Versenyzo>();
        int[,] feladvany = new int[10, 10];
        int akti = 9;

        public Form1()
        {
            InitializeComponent();
            TablaBeallitasok();
            Fajlbeolvasas();
            FeladvanyBeolvasasa();
            GombVizsgalat();
            TablaFeltoltese(akti);
            Ellenorzes(akti);
            //dgvTabla.Rows[0].Cells[0].Style.BackColor = Color.Red;
        }

        private void FeladvanyBeolvasasa()
        {
            StreamReader f = new StreamReader("feladvany.txt");
            int j = 0;
            while (!f.EndOfStream)
            {
                int[] st = Array.ConvertAll(f.ReadLine().Split(' '), Convert.ToInt32);
                for (int i = 0; i < st.Length; i++)
                    feladvany[j, i] = st[i];
                j++;
            }
            f.Close();
        }

        private void Ellenorzes(int akti)
        {
            if (!versenyzok[akti].Osszehasonlit(feladvany) || versenyzok[akti].HajokSzama() != 12 || versenyzok[akti].VaneErintkezes())
                label1.BackColor = Color.Red;
            else
                label1.BackColor = Color.Green;
        }

        private void TablaFeltoltese(int k)
        {
            for (int i = 0; i < dgvTabla.RowCount; i++)
            {
                for (int j = 0; j < dgvTabla.ColumnCount; j++)
                {
                    dgvTabla.Rows[i].Cells[j].Value = versenyzok[k].tabla[i, j];
                }
            }
        }

        private void TablaBeallitasok()
        {
            dgvTabla.RowCount = 10;
            dgvTabla.ColumnCount = 10;
            dgvTabla.ColumnHeadersVisible = false;
            dgvTabla.RowHeadersVisible = false;
            int x = 50;
            SorMagassagBeallitasa(x);
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTabla.Height = x  * dgvTabla.RowCount + 3;
        }

        private void SorMagassagBeallitasa(int x)
        {
            for (int i = 0; i < dgvTabla.RowCount; i++)
                dgvTabla.Rows[i].Height = x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = versenyzok[akti].nev;
            dgvTabla.CurrentCell.Selected = false;
        }

        private void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("megoldas.txt");
            //int n = Convert.ToInt32(f.ReadLine());
            f.ReadLine();
            while (!f.EndOfStream)
            {
                Versenyzo sv = new Versenyzo(f.ReadLine(), TablaKiolvas(f));
                /*sv.nev = f.ReadLine();
                sv.tabla = TablaKiolvas(f);*/
                versenyzok.Add(sv);
            }
            f.Close();
        }

        int[,] TablaKiolvas(StreamReader f)
        {
            int[,] sm = new int[10, 10];
            for (int i = 0; i < sm.GetLength(0); i++)
            {
                string[] st = f.ReadLine().Split(' ');
                //int[] st1 = Array.ConvertAll(f.ReadLine().Split(' '), Convert.ToInt32);
                for (int j = 0; j < sm.GetLength(1); j++)
                    sm[i, j] = Convert.ToInt32(st[j]);
            }
            return sm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            akti++;
            GombVizsgalat();
            TablaFeltoltese(akti);
            label1.Text = versenyzok[akti].nev;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            akti--;
            GombVizsgalat();
            TablaFeltoltese(akti);
            label1.Text = versenyzok[akti].nev;
        }
        private void GombVizsgalat()
        {
            button2.Enabled = akti != versenyzok.Count - 1;
            button1.Enabled = akti != 0;
            Ellenorzes(akti);
        }
    }
}
