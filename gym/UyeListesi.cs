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
    public partial class UyeListesi : Form
    {
        public UyeListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\OneDrive\Belgeler\gymdb.mdf;Integrated Security=True;Connect Timeout=30");
      
        private void uyeler()
        { baglanti.Open();
            string query = "select *from UyeTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDG.DataSource = ds.Tables[0];
            baglanti.Close();

                }
        private void Adfiltrele()
        {
            try
            {
                baglanti.Open();
                string query = "SELECT * FROM UyeTable WHERE UAdSoyad LIKE @Arama OR UTelefon LIKE @Arama OR UCinsiyet LIKE @Arama";
                SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
                sda.SelectCommand.Parameters.AddWithValue("@Arama", "%" + AramaTB.Text + "%");
                var ds = new DataSet();
                sda.Fill(ds);
                UyeDG.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
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

        private void UyeListesi_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Adfiltrele();
            AramaTB.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeler();
        }
        private void Telfiltrele()
        {
            baglanti.Open();
            string query = "select *from UyeTable where UTelefon='" + AramaTB.Text + "'";
        SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
        SqlCommandBuilder builder = new SqlCommandBuilder();
        var ds = new DataSet();
        sda.Fill(ds);
            UyeDG.DataSource = ds.Tables[0];
            baglanti.Close();

        }
}
}
