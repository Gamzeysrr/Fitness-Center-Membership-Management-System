using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KullaniciTB.Text == "" || SifreTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if (KullaniciTB.Text == "Gamzeysr" && SifreTB.Text == "1234")
            {
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girişi");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
