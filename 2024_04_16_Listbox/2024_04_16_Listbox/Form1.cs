using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_04_16_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFelvetel_Click(object sender, EventArgs e)
        {
            string nev = txtNev.Text;
            if (nev.Length > 0 && !VaneBenneElem(lbLista, nev))
                lbLista.Items.Add(nev);
                //lbLista.Items[index].ToString();
            else if (nev.Length == 0)
                MessageBox.Show("Nincs kitöltve a Név mező!");
            else
                MessageBox.Show("Már létezik a listában ez a név!");
            txtNev.Text = "";
        }

        private bool VaneBenneElem(ListBox lista, string nev)
        {
            int i = 0;
            while (i < lista.Items.Count && lista.Items[i].ToString() != nev)
                i++;
            return i < lista.Items.Count;
        }

        private void lbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbLista.SelectedIndex!= -1)
                txtNev.Text = lbLista.SelectedItem.ToString();
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            int index = lbLista.SelectedIndex;
            lbLista.Items[index] = txtNev.Text;
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            int index = lbLista.SelectedIndex;
            lbLista.Items.RemoveAt(index);
        }
    }
}
