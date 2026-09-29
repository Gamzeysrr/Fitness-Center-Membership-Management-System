using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gym
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\OneDrive\Belgeler\gymdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdSoyadTB.Text) || string.IsNullOrEmpty(PerTelTB.Text) || string.IsNullOrEmpty(GörevTB.Text))
            {
                MessageBox.Show("Eksik Bilgi!");
                return;
            }

            try
            {
                baglanti.Open();
                string query = "INSERT INTO Personel (Personeladi, Telno, Gorev) VALUES (@Personeladi, @Telno, @Gorev)";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@Personeladi", AdSoyadTB.Text);
                komut.Parameters.AddWithValue("@Telno", PerTelTB.Text);
                komut.Parameters.AddWithValue("@Gorev", GörevTB.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Personel Başarıyla Eklenmiştir.");

                
                AdSoyadTB.Text = "";
                PerTelTB.Text = "";
                GörevTB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            anasayfa log = new anasayfa();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void personel()
        {
            baglanti.Open();
            string query = "select *from Personel";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PersonelDG.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void Personel_Load(object sender, EventArgs e)
        {
            personel();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            personel();
        }
        int key = 0;
        private void Güncelle_Click(object sender, EventArgs e)
        {
            {
                if (key == 0 || string.IsNullOrWhiteSpace(AdSoyadTB.Text) || string.IsNullOrWhiteSpace(PerTelTB.Text) || string.IsNullOrWhiteSpace(GörevTB.Text))
                {
                    MessageBox.Show("Eksik Bilgi");
                }
                else
                {
                    try
                    {
                        baglanti.Open();
                        string query = "update Personel set Personeladi=@Personeladi,Telno=@Telno, Gorev=@Gorev";
                        SqlCommand komut = new SqlCommand(query, baglanti);
                        komut.Parameters.AddWithValue("@Personeladi", AdSoyadTB.Text);
                        komut.Parameters.AddWithValue("@Telno", PerTelTB.Text);
                        komut.Parameters.AddWithValue("@Gorev", GörevTB.Text);
                        komut.Parameters.AddWithValue("@Persıd", key);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Üye Başarıyla Güncellenmiştir.");
                        baglanti.Close();
                        personel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }



        private void PersonelDG_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PersonelDG.Rows[e.RowIndex];
                AdSoyadTB.Text = row.Cells["Personeladi"].Value.ToString();
                PerTelTB.Text = row.Cells["Telno"].Value.ToString();
                GörevTB.Text = row.Cells["Gorev"].Value.ToString();
            }
        }



        private void Sil_Click_1(object sender, EventArgs e)
        {
            if (PersonelDG.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = PersonelDG.SelectedRows[0];
                    string personeladi = selectedRow.Cells["Personeladi"].Value.ToString();
                    string telno = selectedRow.Cells["Telno"].Value.ToString();
                    string gorev = selectedRow.Cells["Gorev"].Value.ToString();

                    
                    baglanti.Open();
                    string query = "DELETE FROM Personel WHERE Personeladi = @Personeladi AND Telno = @Telno AND Gorev = @Gorev";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@Personeladi", personeladi);
                    komut.Parameters.AddWithValue("@Telno", telno);
                    komut.Parameters.AddWithValue("@Gorev", gorev);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel başarıyla silinmiştir.");

                    
                    personel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Silinecek personeli seçiniz.");
            }
        }
    }
}