using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Klase;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void poljePretrageRadnika_TextChanged(object sender, EventArgs e)
        {
            string pojamPretrage = poljePretrageRadnika.Text;

            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziRadnika(pojamPretrage);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeks = e.RowIndex;
            textID.Text = dataGridView1.Rows[indeks].Cells[0].Value.ToString();
            textIme.Text = dataGridView1.Rows[indeks].Cells[1].Value.ToString();
            textPrezime.Text = dataGridView1.Rows[indeks].Cells[2].Value.ToString();
            textSifra.Text = dataGridView1.Rows[indeks].Cells[3].Value.ToString();
        }

        private void buttonNoviRadnik_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            bool ispravnost = baza.UbaciNovogRadnika(textIme.Text, textPrezime.Text, textSifra.Text);
            if (ispravnost)
            {
                MessageBox.Show("Uspesno dadat novi radnik u bazi.");

                Clear();

                DataTable dt = new DataTable();
                dt = baza.PretagaPoBaziRadnika("");

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Doslo je do greske");
            }
        }

        private void buttonUcitajPromene_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            bool ispravnost = baza.UcitavanjePromeneKodRadnika(textID.Text, textIme.Text, textPrezime.Text, textSifra.Text);
            if (ispravnost)
            {
                MessageBox.Show("Uspesno izvršena izmena.");

                DataTable dt = new DataTable();
                dt = baza.PretagaPoBaziRadnika("");

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Doslo je do greske");
            }
        }

        private void buttonIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrebaci_Click(object sender, EventArgs e)
        {
            Hide();
            form1 f = new form1();
            f.ShowDialog();
            f = null;
            Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void poljePretageStudenta_TextChanged(object sender, EventArgs e)
        {
            string pojamPretrage = poljePretageStudenta.Text;

            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziStudenata(pojamPretrage);

            dataGridView3.DataSource = dt;
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeks = e.RowIndex;

            studentIndeks.Text = dataGridView3.Rows[indeks].Cells[0].Value.ToString();
            studentIme.Text = dataGridView3.Rows[indeks].Cells[1].Value.ToString();
            studentPrezime.Text = dataGridView3.Rows[indeks].Cells[2].Value.ToString();
            studentFakultet.Text = dataGridView3.Rows[indeks].Cells[3].Value.ToString();
        }

        private void buttonNoviSudent_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            bool uspesnost = baza.UbaciNovogStudenta(studentIndeks.Text, studentIme.Text, studentPrezime.Text, studentFakultet.Text,
                "", "", "", "");
            if (uspesnost)
            {
                MessageBox.Show("Student je uspesno dodat");
                Clear2();
                DataTable dt = new DataTable();
                dt = baza.PretagaPoBaziStudenata("");

                dataGridView3.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Doslo je do neke greske");
            }
        }

        private void Clear2()
        {
            studentIndeks.Text = "";
            studentIme.Text = "";
            studentPrezime.Text = "";
            studentFakultet.Text = "";
        }
        private void Clear()
        {
            textID.Text = "";
            textIme.Text = "";
            textPrezime.Text = "";
            textSifra.Text = "";
        }

        private void buttonStudentIzmena_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            bool ispravnost = baza.UcitavanjePromeneKodStudenta(studentIndeks.Text, studentIme.Text, studentPrezime.Text, studentFakultet.Text, "", "", "", "");
            if (ispravnost)
            {
                MessageBox.Show("Uspesno izvršena izmena.");
                DataTable dt = new DataTable();
                dt = baza.PretagaPoBaziStudenata("");

                dataGridView3.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Doslo je do greske");
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziStudenata("");

            dataGridView3.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = baza.PretagaPoBaziRadnika("");

            dataGridView1.DataSource = dt2;
        }

        private void buttonBrisanjeRadnika_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();
            bool uspesnost = baza.brisanjeRadnika(textID.Text);

            if (uspesnost)
            {
                MessageBox.Show("Uspesno obrisano!");
                Clear();

                DataTable dt2 = new DataTable();
                dt2 = baza.PretagaPoBaziRadnika("");

                dataGridView1.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("Nastala je greska");
            }
        }

        private void buttonBrisanjeStudenta_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();
            bool uspesnost = baza.brisanjeStudenta(studentIndeks.Text);

            if (uspesnost)
            {
                MessageBox.Show("Uspesno obrisano!");
                Clear2();
                DataTable dt = new DataTable();
                dt = baza.PretagaPoBaziStudenata("");

                dataGridView3.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nastala je greska");
            }
        }
    }
}
