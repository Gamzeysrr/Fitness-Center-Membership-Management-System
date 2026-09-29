using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gym
{
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\OneDrive\Belgeler\gymdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from UyeTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDG.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            anasayfa log = new anasayfa();
            log.Show();
            this.Hide();
        }

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        int key = 0;

        private void UyeDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = UyeDG.Rows[e.RowIndex];
                    if (selectedRow.Cells.Count >= 6)
                    {
                        key = Convert.ToInt32(selectedRow.Cells[0].Value);
                        AdSoyadTB.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                        TelefonTB.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                        CinsiyetCB.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                        YasTB.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                        OdemeTB.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Seçilen satır beklenen hücreleri içermiyor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from UyeTable where UyeId=" + key;
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Silinmiştir.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            if (key == 0 || string.IsNullOrWhiteSpace(AdSoyadTB.Text) || string.IsNullOrWhiteSpace(TelefonTB.Text) || string.IsNullOrWhiteSpace(CinsiyetCB.Text) || string.IsNullOrWhiteSpace(YasTB.Text) || string.IsNullOrWhiteSpace(OdemeTB.Text))
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update UyeTable set UAdSoyad=@AdSoyad, UTelefon=@Telefon, UCinsiyet=@Cinsiyet, UYas=@Yas, UOdeme=@Odeme where UyeId=@UyeId";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@AdSoyad", AdSoyadTB.Text);
                    komut.Parameters.AddWithValue("@Telefon", TelefonTB.Text);
                    komut.Parameters.AddWithValue("@Cinsiyet", CinsiyetCB.Text);
                    komut.Parameters.AddWithValue("@Yas", YasTB.Text);
                    komut.Parameters.AddWithValue("@Odeme", OdemeTB.Text);
                    komut.Parameters.AddWithValue("@UyeId", key);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Güncellenmiştir.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
