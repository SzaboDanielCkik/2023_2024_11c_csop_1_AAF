using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_04_09_FormAlapok
{
    public partial class Form1 : Form
    {

        int osszeg = 0;

        public Form1()
        {
            InitializeComponent();
            //this.BackColor = Color.Red;
            txtTelszam.Enabled = false;
            nudSzulev.Enabled = false;
            BtnCsinald.Enabled = false;
        }

        private void BtnCsinald_Click(object sender, EventArgs e)
        {
            string nev = txtNev.Text;
            string telefonszam = txtTelszam.Text;
            int szulev = (int)  nudSzulev.Value;

            //label1.Text += nev + " " + telefonszam + " " + szulev;
            //MessageBox.Show(string.Format("{0} {1} {2}",nev,telefonszam, szulev));
            //MessageBox.Show(string.Format($"{nev} {telefonszam} {szulev}"));
            int kor = 2024 - szulev;
            
            MessageBox.Show(""+kor);


        }

        private void txtNev_TextChanged(object sender, EventArgs e)
        {
            if (txtNev.Text.Length > 0)
            {
                txtTelszam.Enabled = true;
                nudSzulev.Enabled = true;
                BtnCsinald.Enabled = true;
            }
            else
            {
                txtTelszam.Enabled = false;
                nudSzulev.Enabled = false;
                BtnCsinald.Enabled = false;
            }
        }

        private void rdbPiros_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void rdbZold_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void rdbKek_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void rdbEredeti_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.Yellow;
            radioButton2.BackColor = SystemColors.Control;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.BackColor = SystemColors.Control;
            radioButton2.BackColor = Color.Orange;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtNev.Text = comboBox1.Text;
            //txtNev.Text = comboBox1.SelectedItem.ToString();
            int index = comboBox1.SelectedIndex;
            txtNev.Text = comboBox1.Items[index].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int osszeg = 0;
            if (checkBox1.Checked) osszeg += Convert.ToInt32(checkBox1.Text);
            if (checkBox2.Checked) osszeg += Convert.ToInt32(checkBox2.Text);
            if (checkBox3.Checked) osszeg += Convert.ToInt32(checkBox3.Text);*/
            MessageBox.Show("" + osszeg);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                osszeg += Convert.ToInt32(checkBox1.Text);
            else
                osszeg -= Convert.ToInt32(checkBox1.Text);
        }
    }
}
