using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Klase
{
    class RadSaBazom
    {
        string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable PrikaziSveKnjige()
        {           
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM dbt_knjige";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool UbaciNovuKnjigu(string nazivKnjige, string autor, string kolicina)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "INSERT INTO dbt_knjige (NazivKnjige, Autor, Kolicina) VALUES (@NazivKnjige, @Autor, @Kolicina)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NazivKnjige", nazivKnjige);
                cmd.Parameters.AddWithValue("@Autor", autor);
                cmd.Parameters.AddWithValue("@Kolicina", Convert.ToInt32(kolicina));

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return uspesnost;
        }

        public bool UcitavanjePromene(string id, string naziv, string autor, string kolicina)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "UPDATE dbt_knjige SET NazivKnjige=@NazivKnjige, Autor= @Autor, Kolicina= @Kolicina WHERE ID_knjige=@ID_knjige";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID_knjige", Convert.ToInt32(id));
                cmd.Parameters.AddWithValue("@NazivKnjige", naziv);
                cmd.Parameters.AddWithValue("@Autor", autor);
                cmd.Parameters.AddWithValue("@Kolicina", Convert.ToInt32(kolicina));

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return uspesnost;
        }

        public bool BrisanjeKnjige(string id)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "DELETE FROM dbt_knjige WHERE ID_knjige=@ID_knjige";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID_knjige", id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return uspesnost;
        }

        public DataTable PretagaPoBaziKjniga(string pojamPretrage)
        {
           
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT * FROM dbt_knjige WHERE NazivKnjige LIKE '%" + pojamPretrage + "%' OR Autor LIKE '%" + pojamPretrage + "%' OR ID_knjige LIKE '%" + pojamPretrage + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        // rad sa tabelom studenata

        public DataTable PretagaPoBaziStudenata(string pojamPretrage)
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT indeks, Ime, Prezime, Fakultet FROM dbt_studenti2 WHERE Ime LIKE '%" + pojamPretrage + "%' OR Prezime LIKE '%" + pojamPretrage + "%' OR indeks LIKE '%" + pojamPretrage + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool postojiStudent(string indeks)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT indeks, Ime, Prezime, Fakultet FROM dbt_studenti2 WHERE  indeks LIKE '%" + indeks + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            if(dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        
        public bool UbaciNovogStudenta(string indeks, string ime, string prezime, string faks, string knjiga1, string datum1, string knjiga2, string datum2)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            if (postojiStudent(indeks))
            {
                return false;
            }
            else
            {
                try
                {

                    string sql = "INSERT INTO dbt_studenti2 (indeks, Ime, Prezime, Fakultet, Knjiga1, Datum1, Knjiga2, Datum2) VALUES (@indeks, @Ime, @Prezime, @Fakultet, @Knjiga1, @Datum1, @Knjiga2, @Datum2)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@indeks", indeks);
                    cmd.Parameters.AddWithValue("@Ime", ime);
                    cmd.Parameters.AddWithValue("@Prezime", prezime);
                    cmd.Parameters.AddWithValue("@Fakultet", faks);
                    cmd.Parameters.AddWithValue("@Knjiga1", knjiga1);
                    cmd.Parameters.AddWithValue("@Datum1", datum1);
                    cmd.Parameters.AddWithValue("@Knjiga2", knjiga2);
                    cmd.Parameters.AddWithValue("@Datum2", datum2);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        uspesnost = true;
                    }
                    else
                    {
                        uspesnost = false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }

                return uspesnost;
            }
        }

        public bool UcitavanjePromeneKodStudenta(string id, string ime, string prezime, string faks, string knjiga1, string datum1, string knjiga2, string datum2)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "UPDATE dbt_studenti2 SET Ime=@Ime, Prezime= @Prezime, Fakultet= @Fakultet, Knjiga1=@knjiga1, Datum1=@Datum1, Knjiga2=@Knjiga2, Datum2=@Datum2 WHERE indeks=@indeks";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@indeks", id);
                cmd.Parameters.AddWithValue("@Ime", ime);
                cmd.Parameters.AddWithValue("@Prezime", prezime);
                cmd.Parameters.AddWithValue("@Fakultet", faks);
                cmd.Parameters.AddWithValue("@Knjiga1", knjiga1);
                cmd.Parameters.AddWithValue("@Datum1", datum1);
                cmd.Parameters.AddWithValue("@Knjiga2", knjiga2);
                cmd.Parameters.AddWithValue("@Datum2", datum2);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return uspesnost;
        }

        public bool brisanjeStudenta(string id)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "DELETE FROM dbt_studenti2 WHERE indeks=@indeks";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@indeks", id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return uspesnost;
        }


        // rad sa tabelom radnka

        public bool UbaciNovogRadnika(string ime, string prezime, string sifra)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
           
            try
            {

                string sql = "INSERT INTO dbt_radnici (Ime, Prezime, Sifra) VALUES (@Ime, @Prezime, @Sifra)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Ime", ime);
                cmd.Parameters.AddWithValue("@Prezime", prezime);
                cmd.Parameters.AddWithValue("@Sifra", sifra);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return uspesnost;
        }

        public bool UcitavanjePromeneKodRadnika(string id, string ime, string prezime, string sifra)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
           
            try
            {

                string sql = "UPDATE dbt_radnici SET Ime=@Ime, Prezime= @Prezime, Sifra= @Sifra WHERE ID_radnika=@ID_radnika";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID_radnika", Convert.ToInt32(id));
                cmd.Parameters.AddWithValue("@Ime", ime);
                cmd.Parameters.AddWithValue("@Prezime", prezime);
                cmd.Parameters.AddWithValue("@Sifra", sifra);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return uspesnost;
        }

        public DataTable PretagaPoBaziRadnika(string pojamPretrage)
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT * FROM dbt_radnici WHERE Ime LIKE '%" + pojamPretrage + "%' OR Prezime LIKE '%" + pojamPretrage + "%' OR ID_radnika LIKE '%" + pojamPretrage + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool brisanjeRadnika(string id)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "DELETE FROM dbt_radnici WHERE ID_radnika=@ID_radnika";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID_radnika", id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return uspesnost;
        }

        // Pretraga po bazi pozajmljivanja 
        public bool UbaciNovogPozajmljivanje(string id1, string id2, string datum)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {

                string sql = "INSERT INTO dbt_pozajmljivanja (id_knjige, id_studenta, datum, rok) VALUES (@id_knjige, @id_studenta, @datum, @rok)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_knjige", Convert.ToInt32(id1));
                cmd.Parameters.AddWithValue("@id_studenta", id2);
                cmd.Parameters.AddWithValue("@datum", datum);
                cmd.Parameters.AddWithValue("@rok", 30);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return uspesnost;
        }

        

        public DataTable PretagaPoBaziPozajmljivanja(string pojamPretrage)
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT * FROM dbt_pozajmljivanja WHERE id_knjige LIKE '%" + pojamPretrage + "%' OR id_studenta LIKE '%" + pojamPretrage + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool brisanjePozajmljivanja(string id1, string id2)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "DELETE FROM dbt_pozajmljivanja WHERE id_knjige=@id_knjige AND id_studenta=@id_studenta";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_knjige", Convert.ToInt32(id1));
                cmd.Parameters.AddWithValue("@id_studenta", id2);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return uspesnost;
        }

        //rad sa bazom razduzivanja
        public bool UbaciNovorazduzivanje(string id1, string id2, string datum)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string datum2 = DateTime.Today.ToString();

                string sql = "INSERT INTO Razduzivanje (ID_knjige, indeks, datumzad, datumraz) VALUES (@id_knjige, @id_studenta, @datum, @datum2)";
                SqlCommand cmd = new SqlCommand(sql, conn);               

                cmd.Parameters.AddWithValue("@id_knjige", Convert.ToInt32(id1));
                cmd.Parameters.AddWithValue("@id_studenta", id2);
                cmd.Parameters.AddWithValue("@datum", datum);
                cmd.Parameters.AddWithValue("@datum2", datum2);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return uspesnost;
        }
        public DataTable PretagaPoBaziRazduzivanja(string pojamPretrage)
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT * FROM Razduzivanje WHERE ID_knjige LIKE '%" + pojamPretrage + "%' OR indeks LIKE '%" + pojamPretrage + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //rad sa bazom rezervacija
        public bool UbaciNovaRezervacija(string id1, string id2)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string datum = DateTime.Today.ToString();

                string sql = "INSERT INTO dbt_rezerviranje (ID_Knjige, ID_Studenta, datum) VALUES (@id_knjige, @id_studenta, @datum)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_knjige", Convert.ToInt32(id1));
                cmd.Parameters.AddWithValue("@id_studenta", id2);
                cmd.Parameters.AddWithValue("@datum", datum);           

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return uspesnost;
        }
        public DataTable PretagaPoBaziRezervacija(string pojamPretrage)
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT * FROM dbt_rezerviranje WHERE ID_Knjige LIKE '%" + pojamPretrage + "%' OR ID_Studenta LIKE '%" + pojamPretrage + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool brisanjeRezervacije(string id1, string id2)
        {
            bool uspesnost = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                string sql = "DELETE FROM dbt_rezerviranje WHERE ID_Knjige=@id_knjige AND ID_Studenta=@id_studenta";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_knjige", Convert.ToInt32(id1));
                cmd.Parameters.AddWithValue("@id_studenta", id2);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    uspesnost = true;
                }
                else
                {
                    uspesnost = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return uspesnost;
        }
    }
}
