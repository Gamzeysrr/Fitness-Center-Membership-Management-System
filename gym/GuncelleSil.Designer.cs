using System;
using System.Windows.Forms;

namespace gym
{
    partial class GuncelleSil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuncelleSil));
            this.button2 = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.CinsiyetCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OdemeTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdSoyadTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UyeDG = new System.Windows.Forms.DataGridView();
            this.YasTB = new System.Windows.Forms.TextBox();
            this.Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UyeDG)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 60;
            // 
            // Guncelle
            // 
            this.Guncelle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Guncelle.ForeColor = System.Drawing.Color.DarkRed;
            this.Guncelle.Location = new System.Drawing.Point(317, 326);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(96, 45);
            this.Guncelle.TabIndex = 47;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // CinsiyetCB
            // 
            this.CinsiyetCB.FormattingEnabled = true;
            this.CinsiyetCB.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CinsiyetCB.Location = new System.Drawing.Point(336, 258);
            this.CinsiyetCB.Name = "CinsiyetCB";
            this.CinsiyetCB.Size = new System.Drawing.Size(172, 24);
            this.CinsiyetCB.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(331, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(331, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ödenecek Tutar";
            // 
            // OdemeTB
            // 
            this.OdemeTB.Location = new System.Drawing.Point(336, 175);
            this.OdemeTB.Multiline = true;
            this.OdemeTB.Name = "OdemeTB";
            this.OdemeTB.Size = new System.Drawing.Size(172, 27);
            this.OdemeTB.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(33, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Yaş";
            // 
            // TelefonTB
            // 
            this.TelefonTB.Location = new System.Drawing.Point(38, 255);
            this.TelefonTB.Multiline = true;
            this.TelefonTB.Name = "TelefonTB";
            this.TelefonTB.Size = new System.Drawing.Size(172, 27);
            this.TelefonTB.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(33, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Üye Adı Soyadı";
            // 
            // AdSoyadTB
            // 
            this.AdSoyadTB.Location = new System.Drawing.Point(38, 175);
            this.AdSoyadTB.Multiline = true;
            this.AdSoyadTB.Name = "AdSoyadTB";
            this.AdSoyadTB.Size = new System.Drawing.Size(172, 27);
            this.AdSoyadTB.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(209, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Güncelle/Sil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(125, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 42);
            this.label1.TabIndex = 35;
            this.label1.Text = "FITNESS CENTER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(1100, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 25);
            this.label9.TabIndex = 53;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(779, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 36);
            this.label10.TabIndex = 56;
            this.label10.Text = "Üye Listesi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(1066, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "🡸";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // UyeDG
            // 
            this.UyeDG.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.UyeDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UyeDG.Location = new System.Drawing.Point(587, 93);
            this.UyeDG.Name = "UyeDG";
            this.UyeDG.RowHeadersWidth = 51;
            this.UyeDG.RowTemplate.Height = 25;
            this.UyeDG.Size = new System.Drawing.Size(539, 278);
            this.UyeDG.TabIndex = 58;
            this.UyeDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UyeDG_CellContentClick);
            // 
            // YasTB
            // 
            this.YasTB.Location = new System.Drawing.Point(38, 326);
            this.YasTB.Multiline = true;
            this.YasTB.Name = "YasTB";
            this.YasTB.Size = new System.Drawing.Size(172, 27);
            this.YasTB.TabIndex = 59;
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sil.ForeColor = System.Drawing.Color.DarkRed;
            this.Sil.Location = new System.Drawing.Point(436, 326);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(96, 45);
            this.Sil.TabIndex = 61;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // GuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1138, 415);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.YasTB);
            this.Controls.Add(this.UyeDG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.CinsiyetCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OdemeTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelefonTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdSoyadTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuncelleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuncelleSil";
            this.Load += new System.EventHandler(this.GuncelleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UyeDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.ComboBox CinsiyetCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OdemeTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelefonTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdSoyadTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView UyeDG;
        private System.Windows.Forms.TextBox YasTB;
        private System.Windows.Forms.Button Sil;
    }
}