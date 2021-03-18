using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Klase;

namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        private bool prikazStudenta = false;

        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PrikaziSveKnjige();

            dataGridView1.DataSource = dt;
        }

        private void buttonUbacivanje_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            //provera dali knjiga vec postoji u bazi
            DataTable dt = baza.PretagaPoBaziKjniga(textNaziv.Text);
            bool provera = false;
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Autor"].Equals(textAutor.Text))
                    {
                        provera = true;
                        MessageBox.Show("Odabrana knjiga se vec nalazi u bazi, podesite kolicinu.");
                    }
                }               
            }

            //ubacivanje kjige u bazu
            if (!provera)
            {
                bool uspesnost = baza.UbaciNovuKnjigu(textNaziv.Text, textAutor.Text, textRaspolozivo.Text);

                if (uspesnost)
                {
                    MessageBox.Show("uspesno ucitano!");
                    Clear();

                    DataTable dt2 = new DataTable();
                    dt2 = baza.PrikaziSveKnjige();

                    dataGridView1.DataSource = dt2;
                }
                else
                {
                    MessageBox.Show("Nastala je greska");
                }
            }
        }

        private void buttonUcitajPromene_Click(object sender, EventArgs e)
        {
            //ucitavanje promene oko knjige u bazu
            RadSaBazom baza = new RadSaBazom();
            bool uspesnost = baza.UcitavanjePromene(textID.Text, textNaziv.Text, textAutor.Text, textRaspolozivo.Text);

            if (uspesnost)
            {
                MessageBox.Show("uspesno ucitano!");
                Clear();

                DataTable dt = new DataTable();
                dt = baza.PrikaziSveKnjige();

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nastala je greska");
            }
        }

        private void buttonBrisanje_Click(object sender, EventArgs e)
        {
            // brisanje knjige
            RadSaBazom baza = new RadSaBazom();
            bool uspesnost = baza.BrisanjeKnjige(textID.Text);

            if (uspesnost)
            {
                MessageBox.Show("uspesno ucitano!");
                Clear();

                DataTable dt = new DataTable();
                dt = baza.PrikaziSveKnjige();

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nastala je greska");
            }
        }

        private void Clear()
        {
            textAutor.Text = "";
            textNaziv.Text = "";
            textRaspolozivo.Text = "";
            textID.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeks = e.RowIndex;
            textID.Text = dataGridView1.Rows[indeks].Cells[0].Value.ToString();
            textNaziv.Text = dataGridView1.Rows[indeks].Cells[1].Value.ToString();
            textAutor.Text = dataGridView1.Rows[indeks].Cells[2].Value.ToString();
            textRaspolozivo.Text = dataGridView1.Rows[indeks].Cells[3].Value.ToString();  
        }

        private void poljePretrage_TextChanged(object sender, EventArgs e)
        {
            string pojamPretrage = poljePretrage.Text;

            RadSaBazom baza = new RadSaBazom();
            
            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziKjniga(pojamPretrage);

            dataGridView1.DataSource = dt;
        }

        private void buttonPrebacivanje_Click(object sender, EventArgs e)
        {
            Hide();
            Student s = new Student();
            s.ShowDialog();
            s = null;
            Show();
        }

        private void poljePretageStudenta_TextChanged(object sender, EventArgs e)
        {
            string pojamPretrage = poljePretageStudenta.Text;

            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            if (!prikazStudenta)
            {
                dt = baza.PretagaPoBaziPozajmljivanja(pojamPretrage);
            }
            else
            {
                dt = baza.PretagaPoBaziStudenata(pojamPretrage);
            }

            dataGridView3.DataSource = dt;
        }

        private void poljePretrageKnjige_TextChanged(object sender, EventArgs e)
        {
            string pojamPretrage = poljePretrageKnjige.Text;

            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziKjniga(pojamPretrage);

            dataGridView2.DataSource = dt;
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeks = e.RowIndex;

            if (!prikazStudenta)
            {
                StudentID.Text = dataGridView3.Rows[indeks].Cells[1].Value.ToString();
                textKnjiga1.Text = dataGridView3.Rows[indeks].Cells[0].Value.ToString();
                textDatum1.Text = dataGridView3.Rows[indeks].Cells[2].Value.ToString();
            }
            else
            {
                StudentID.Text = dataGridView3.Rows[indeks].Cells[0].Value.ToString();
            }
            

           // if (!textKnjiga1.Text.Equals("")) textKnjiga1.ReadOnly = true;
            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeks = e.RowIndex;
           
            textKnjiga1.Text = dataGridView2.Rows[indeks].Cells[0].Value.ToString();
            textDatum1.Text = DateTime.Today.ToString();
            
        }

        private void buttonNoviSudent_Click(object sender, EventArgs e)
        {
        
        }

        private void Clear2()
        {
            StudentID.Text = "";
            textKnjiga1.Text = "";
            textDatum1.Text = "";
            
        }


        private void buttonUzimanje1_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();
            /*
                         bool  provera = baza.UcitavanjePromeneKodStudenta(textIndeks.Text, textIme.Text, textPrezime.Text, textFakultet.Text,
                            textKnjiga1.Text, textDatum1.Text, textKnjiga2.Text, textDatum2.Text);                          */

            if (StudentID.Text.Equals(""))
                MessageBox.Show("Morate uneti id studenta!");
            else
            {
                if (!textKnjiga1.Text.Equals(""))
                {
                    // ako koci da se ubaci SQL query "SELECT COUNT(ID_knjige) FROM dbt_knjige WHERE ID_knjige="id""
                    DataTable dt = baza.PretagaPoBaziKjniga(textKnjiga1.Text);

                    if (dt.Rows.Count == 0 || dt.Rows[0]["Kolicina"].ToString().Equals("0"))
                    {
                        MessageBox.Show("Trazene knjige nema na raspolaganju");
                    }
                    else
                    {
                        bool provera;

                        provera = baza.UbaciNovogPozajmljivanje(textKnjiga1.Text, StudentID.Text, textDatum1.Text);

                        if (!provera) MessageBox.Show("Doslo je do greske");

                        int n = (int)dt.Rows[0]["Kolicina"];
                        string N = Convert.ToString(--n);
                        baza.UcitavanjePromene(dt.Rows[0]["ID_knjige"].ToString(), dt.Rows[0]["NazivKnjige"].ToString(), dt.Rows[0]["Autor"].ToString(), N);

                        DataTable dt2 = new DataTable();
                        if (!prikazStudenta)
                        {
                            dt2 = baza.PretagaPoBaziPozajmljivanja("");
                        }
                        else
                        {
                            dt2 = baza.PretagaPoBaziStudenata("");
                        }

                        dataGridView3.DataSource = dt2;

                        dt2 = baza.PretagaPoBaziKjniga("");

                        dataGridView2.DataSource = dt2;
                    }
                }
                else
                {
                    MessageBox.Show("Morate uneti id knjige!");
                }
            }
           
        }

        private void buttonPrebacivanje_Click_1(object sender, EventArgs e)
        {
            /* Hide();
            Admin a = new Admin();
            a.ShowDialog();
            a = null;
            Show(); */
            this.Close();
        }

        private void buttonPovratak1_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            if (StudentID.Text.Equals(""))
                MessageBox.Show("Morate uneti id studenta!");
            else
            {
                if (!textKnjiga1.Text.Equals(""))
                {
                    DataTable dt = baza.PretagaPoBaziKjniga(textKnjiga1.Text);

                    if (dt.Rows.Count == 0 || dt.Rows[0]["Kolicina"].ToString().Equals("0"))
                    {
                        MessageBox.Show("Trazene knjige nema na raspolaganju");
                    }
                    else
                    {
                        bool provera;                        

                        provera = baza.brisanjePozajmljivanja(textKnjiga1.Text, StudentID.Text);

                        if (!provera) 
                        {
                            MessageBox.Show("Doslo je do greske"); 
                        }
                        else
                        {

                            int n = (int)dt.Rows[0]["Kolicina"];
                            string N = Convert.ToString(++n);
                            // ucitavanje promene u kolicini knjige
                            baza.UcitavanjePromene(dt.Rows[0]["ID_knjige"].ToString(), dt.Rows[0]["NazivKnjige"].ToString(), dt.Rows[0]["Autor"].ToString(), N);
                            //upis novog razduzivanja
                            baza.UbaciNovorazduzivanje(textKnjiga1.Text, StudentID.Text, textDatum1.Text);

                            Clear2();
                            DataTable dt2 = new DataTable();
                            if (!prikazStudenta)
                            {
                                dt2 = baza.PretagaPoBaziPozajmljivanja("");
                            }
                            else
                            {
                                dt2 = baza.PretagaPoBaziStudenata("");
                            }

                            dataGridView3.DataSource = dt2;

                            dt2 = baza.PretagaPoBaziKjniga("");

                            dataGridView2.DataSource = dt2;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Morate uneti id knjige!");
                }
            }                  
        }

        private void buttonPovratak2_Click(object sender, EventArgs e)
        {
        }

        private void textRaspolozivo_TextChanged(object sender, EventArgs e)
        {
            /*
            if(!textRaspolozivo.Text.Equals("[0-9]*"))
            {
                MessageBox.Show("Mora se unose broj");
            }*/
        }

        private void form1_Load(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();
            DataTable dt = new DataTable();
            if (!prikazStudenta)
            {
                dt = baza.PretagaPoBaziPozajmljivanja("");
            } 
            else
            {
                dt = baza.PretagaPoBaziStudenata("");
            }
            dataGridView3.DataSource = dt;


            dt = baza.PretagaPoBaziKjniga("");

            dataGridView2.DataSource = dt;

            dt = baza.PrikaziSveKnjige();

            dataGridView1.DataSource = dt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            prikazStudenta = !prikazStudenta;
        }

        private void buttonPogeldajReyervacije_Click(object sender, EventArgs e)
        {
            Hide();
            Prikaz p = new Prikaz();
            p.ShowDialog();
            p = null;
            Show();

        }
    }
}
