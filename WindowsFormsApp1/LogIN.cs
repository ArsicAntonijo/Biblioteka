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
    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
        }

        private void buttonLogovanje_Click(object sender, EventArgs e)
        {
            RadSaBazom baza = new RadSaBazom();


            if (textID.Text.Equals("admin"))
            {
                if (textSifra.Text.Equals("admin"))
                {
                    textID.Text = "";
                    textSifra.Text = "";
                    Hide();
                    Admin a = new Admin();
                    a.ShowDialog();
                    // ukoliko hocu da posle gasenja ostane ukljucen log in treba se odkomentira dole
                   // a = null;
                   // Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pogresna sifra");
                }
            }
            else
            {
                DataTable dt = baza.PretagaPoBaziRadnika(textID.Text);
                if (dt.Rows.Count != 0)
                {
                    if (textSifra.Text.Equals((string)dt.Rows[0]["Sifra"]))
                    {
                        textID.Text = "";
                        textSifra.Text = "";
                        Hide();
                        form1 f = new form1();
                        f.ShowDialog();
                        f = null;
                        Show();
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("Sifru koju ste uneli je pogresna, molim vas pokusajte opet.");
                    }
                } 
                else
                {
                    MessageBox.Show("Proverite ID koji ste uneli, uneti ID nije validan.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textSifra.Text = "";
            Hide();
            Student s = new Student();
            s.ShowDialog();
            // s = null;
            // Show();
            Close();
        }
    }
}
