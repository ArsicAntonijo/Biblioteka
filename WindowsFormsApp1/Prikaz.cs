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
    public partial class Prikaz : Form
    {
        public Prikaz()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void poljePretageRazduzenja_TextChanged(object sender, EventArgs e)
        {
            string pojamPretrage = poljePretageRazduzenja.Text;

            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziRazduzivanja(pojamPretrage);

           prikazRazuzenja.DataSource = dt;
        }

        private void Prikaz_Load(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziRazduzivanja("");

            prikazRazuzenja.DataSource = dt;

            dt = baza.PretagaPoBaziRezervacija("");

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime date = DateTime.Parse(dt.Rows[i]["Datum"].ToString());
                DateTime now = DateTime.Today;

                if(date.Year != now.Year)
                {
                    if(12 - date.Month + now.Month > 2)
                    {
                        //brisi
                        baza.brisanjeRezervacije(dt.Rows[i]["ID_Knjige"].ToString(), dt.Rows[i]["ID_Studenta"].ToString());
                    }
                }
                else
                {
                    if(now.Month - date.Month > 2)
                    {
                        //brisi
                        baza.brisanjeRezervacije(dt.Rows[i]["ID_Knjige"].ToString(), dt.Rows[i]["ID_Studenta"].ToString());
                    }
                }
            }

            prikazRezervacije.DataSource = dt;
        }

        private void poljePretrageKnjige_TextChanged(object sender, EventArgs e)
        {
            string poljePretrage = poljePretrageRezervacije.Text;
            RadSaBazom baza = new RadSaBazom();

            DataTable dt = new DataTable();
            dt = baza.PretagaPoBaziRezervacija(poljePretrage);

            prikazRezervacije.DataSource = dt;
        }
    }
}
