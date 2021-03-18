using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Klase;

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void poljePretrageKnjige_TextChanged(object sender, EventArgs e)
        {
            string pojamPretrage = poljePretrageKnjige.Text;

            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziKjniga(pojamPretrage);

            dataGridView2.DataSource = dt;
        }

        private void poljePretageStudenta_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeks = e.RowIndex;
            // ne zaboravi ovo da resis da vrakja datum  u label3 i label4
           /*
            textIndeks.Text = dataGridView1.Rows[indeks].Cells[0].Value.ToString();
            textIme.Text = dataGridView1.Rows[indeks].Cells[1].Value.ToString();
            textPrezime.Text = dataGridView1.Rows[indeks].Cells[2].Value.ToString();
            textFakultet.Text = dataGridView1.Rows[indeks].Cells[3].Value.ToString();
            textKnjiga1.Text = dataGridView1.Rows[indeks].Cells[4].Value.ToString();
            textDatum1.Text = dataGridView1.Rows[indeks].Cells[5].Value.ToString();
            textKnjiga2.Text = dataGridView1.Rows[indeks].Cells[6].Value.ToString();
            textDatum2.Text = dataGridView1.Rows[indeks].Cells[7].Value.ToString(); */

            /*
            string id1 = dataGridView1.Rows[indeks].Cells[4].Value.ToString();
            string id2 = dataGridView1.Rows[indeks].Cells[6].Value.ToString();
            DateTime dt = DateTime.Now;

            DateTime dt1 = (DateTime)dataGridView1.Rows[indeks].Cells[5].Value;
            int izlaz1;
            if (dt.Year - dt1.Year == 0)
            {
                izlaz1 = (dt.Month - dt1.Month) * 30 + Math.Abs(dt.Day - dt1.Day);
            }
            else
            {
                izlaz1 = (12 - dt1.Month + dt.Month) * 30 + Math.Abs(dt.Day - dt1.Day);
            }
            label3.Text = "Student kod sebe drzi knigu sa id " + id1 + ", vec " + izlaz1;

            DateTime dt2 = (DateTime)dataGridView1.Rows[indeks].Cells[7].Value;
            int izlaz2;
            if (dt.Year - dt2.Year == 0)
            {
                izlaz2 = (dt.Month - dt2.Month) * 30 + Math.Abs(dt.Day - dt2.Day);
            }
            else
            {
                izlaz2 = (12 - dt2.Month + dt.Month) * 30 + Math.Abs(dt.Day - dt2.Day);
            }
            label4.Text = "Student kod sebe drzi knigu sa id " + id2 + ", vec " + izlaz2; */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziKjniga("");

            dataGridView2.DataSource = dt;
        }

        private void buttonReyervisi_Click(object sender, EventArgs e)
        {
            if(textReyervisi2.Text.Equals("") || textReyervisi1.Text.Equals("")) {
                MessageBox.Show("Polja moraju biti popunjena!");
            }
            else
            {
                RadSaBazom baza = new RadSaBazom();
                bool oo =  baza.UbaciNovaRezervacija(textReyervisi1.Text, textReyervisi2.Text);
                if(oo)
                {
                    MessageBox.Show("Uspesno upisano.");
                }
                else
                {
                    MessageBox.Show("Doslo je do greske.");
                }
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeks = e.RowIndex;
            textReyervisi2.Text = dataGridView2.Rows[indeks].Cells[0].Value.ToString();
        }
    }
}
