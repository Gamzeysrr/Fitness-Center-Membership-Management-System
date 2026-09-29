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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odeme ode = new Odeme();
            ode.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuncelleSil guncelle = new GuncelleSil();
            guncelle.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UyeListesi uye = new UyeListesi();
            uye.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle = new UyeEkle();
            uyeekle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Show();
            this.Hide();
        }
    }
}
