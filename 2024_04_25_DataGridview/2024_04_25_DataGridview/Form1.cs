using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_04_25_DataGridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TablaBeallitasok();
            FejlecBeallitasok();
            TablaFeltoltese();
        }

        private void FejlecBeallitasok()
        {
            for (int i = 0; i < dgvTabla.ColumnCount; i++)
                dgvTabla.Columns[i].HeaderText = ""+(i+1);

            dgvTabla.RowHeadersWidth = 60;
            for (int i = 0; i < dgvTabla.RowCount; i++)
            {
                dgvTabla.Rows[i].HeaderCell.Value = "" + (i + 1);
            }
        }

        private void TablaFeltoltese()
        {
            for (int i = 0; i < dgvTabla.RowCount; i++)
            {
                for (int j = 0; j < dgvTabla.ColumnCount; j++)
                {
                    dgvTabla.Rows[i].Cells[j].Value = (i + 1)*(j + 1);
                }
            }
        }

        private void TablaBeallitasok()
        {
            dgvTabla.RowCount = 10;
            dgvTabla.ColumnCount = 5;
            //dgvTabla.ColumnHeadersVisible = false;
            //dgvTabla.RowHeadersVisible = false;
            int x = 50;
            //OszlopSzelessegBeallitasa(x);
            SorMagassagBeallitasa(x);
            dgvTabla.Width = dgvTabla.ColumnCount * x+(int)(x*0.25);
            //dgvTabla.Height = dgvTabla.RowCount * x + (int)(x * 0.25);
            //dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTabla.Height = (x + 1) * dgvTabla.RowCount-1;
        }

        private void SorMagassagBeallitasa(int x)
        {
            for (int i = 0; i < dgvTabla.RowCount; i++)
                dgvTabla.Rows[i].Height = x;
        }

        private void OszlopSzelessegBeallitasa(int x)
        {
            for (int i = 0; i < dgvTabla.ColumnCount; i++)
                dgvTabla.Columns[i].Width = x;
        }


    }
}
