using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\OneDrive\Belgeler\gymdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AdSoyadTB.Text == "" || TelefonTB.Text == "" || OdemeTB.Text == "" )
            {
                MessageBox.Show("Eksik Bilgi!");
            }
            else 
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into UyeTable values('" + AdSoyadTB.Text + "','" + TelefonTB.Text + "','" + CinsiyetCB.SelectedItem.ToString() + "','" + YasTB.Text + "','" + OdemeTB.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Eklenmiştir.");
                    baglanti.Close();
                    AdSoyadTB.Text = "";
                    TelefonTB.Text = "";
                    CinsiyetCB.Text = "";
                    OdemeTB.Text = "";
                    YasTB.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            anasayfa log = new anasayfa();
            log.Show();
            this.Hide();
        }

      
    }
}
