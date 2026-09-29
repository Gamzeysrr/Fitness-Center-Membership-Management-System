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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\OneDrive\Belgeler\gymdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillName()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand ("select UAdSoyad from UyeTable", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UAdSoyad", typeof(string));
            dt.Load(rdr);
            AdSoyadCB.ValueMember = "UAdSoyad";
            AdSoyadCB.DataSource = dt;
            baglanti.Close();

        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from OdemeTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OdemeDG.DataSource = dt;
            baglanti.Close();
        }

        private void Adfiltrele()
        {
            baglanti.Open();
            string query = "select * from OdemeTable where OUye = @OUye";
            SqlCommand komut = new SqlCommand(query, baglanti);
            komut.Parameters.AddWithValue("@OUye", AramaTB.Text);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OdemeDG.DataSource = dt;
            baglanti.Close();
        }

       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void label2_Click(object sender, EventArgs e)
        {
            anasayfa log = new anasayfa();
            log.Show();
            this.Hide();
        }

        private void UyeDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Odeme_Load_1(object sender, EventArgs e)
        {
            FillName();
            uyeler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdSoyadCB.Text == "" || OdenecekTutarTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                DateTime periyot = Periyot.Value;
                baglanti.Open();
                  string checkQuery = "select count(*) from OdemeTable where OUye = @OUye";
                SqlCommand checkCommand = new SqlCommand(checkQuery, baglanti);
                checkCommand.Parameters.AddWithValue("@OUye", AdSoyadCB.SelectedValue.ToString());
                int count = (int)checkCommand.ExecuteScalar();

                {
                    
                    try
                    {
                        
                        count = 1;

                        MessageBox.Show("Ödeme Başarıyla Alındı");
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show(ex.Message);
                    }
                }
                {
                    
                    string insertQuery = "insert into OdemeTable (OAy, OUye, OTutar) values (@OAy, @OUye, @OTutar)";
                    SqlCommand komut = new SqlCommand(insertQuery, baglanti);
                    komut.Parameters.AddWithValue("@OAy", periyot);
                    komut.Parameters.AddWithValue("@OUye", AdSoyadCB.SelectedValue.ToString());
                    komut.Parameters.AddWithValue("@OTutar", OdenecekTutarTB.Text);
                    komut.ExecuteNonQuery();
                    
                }

                baglanti.Close();
                uyeler();
                
            }
        }

        private void AraButon_Click(object sender, EventArgs e)
        {
            Adfiltrele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
