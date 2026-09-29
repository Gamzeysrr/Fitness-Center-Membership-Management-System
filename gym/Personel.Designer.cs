namespace gym
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PersonelDG = new System.Windows.Forms.DataGridView();
            this.AdSoyadTB = new System.Windows.Forms.TextBox();
            this.PerTelTB = new System.Windows.Forms.TextBox();
            this.GörevTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDG)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PersonelDG
            // 
            this.PersonelDG.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.PersonelDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelDG.Location = new System.Drawing.Point(607, 52);
            this.PersonelDG.Name = "PersonelDG";
            this.PersonelDG.RowHeadersWidth = 51;
            this.PersonelDG.RowTemplate.Height = 24;
            this.PersonelDG.Size = new System.Drawing.Size(503, 190);
            this.PersonelDG.TabIndex = 4;
            this.PersonelDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonelDG_CellContentClick_1);
            // 
            // AdSoyadTB
            // 
            this.AdSoyadTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdSoyadTB.Location = new System.Drawing.Point(607, 270);
            this.AdSoyadTB.Multiline = true;
            this.AdSoyadTB.Name = "AdSoyadTB";
            this.AdSoyadTB.Size = new System.Drawing.Size(163, 36);
            this.AdSoyadTB.TabIndex = 54;
            // 
            // PerTelTB
            // 
            this.PerTelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PerTelTB.Location = new System.Drawing.Point(808, 270);
            this.PerTelTB.Multiline = true;
            this.PerTelTB.Name = "PerTelTB";
            this.PerTelTB.Size = new System.Drawing.Size(163, 36);
            this.PerTelTB.TabIndex = 55;
            // 
            // GörevTB
            // 
            this.GörevTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GörevTB.Location = new System.Drawing.Point(607, 337);
            this.GörevTB.Multiline = true;
            this.GörevTB.Name = "GörevTB";
            this.GörevTB.Size = new System.Drawing.Size(163, 36);
            this.GörevTB.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(603, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = " Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(804, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(603, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "Görevi";
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ekle.ForeColor = System.Drawing.Color.DarkRed;
            this.Ekle.Location = new System.Drawing.Point(808, 337);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(88, 36);
            this.Ekle.TabIndex = 60;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Güncelle.ForeColor = System.Drawing.Color.DarkRed;
            this.Güncelle.Location = new System.Drawing.Point(996, 295);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(88, 36);
            this.Güncelle.TabIndex = 61;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = false;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sil.ForeColor = System.Drawing.Color.DarkRed;
            this.Sil.Location = new System.Drawing.Point(996, 337);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(88, 36);
            this.Sil.TabIndex = 62;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(1066, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 25);
            this.label9.TabIndex = 74;
            this.label9.Text = "🡸";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(1100, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Yenile
            // 
            this.Yenile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Yenile.ForeColor = System.Drawing.Color.DarkRed;
            this.Yenile.Location = new System.Drawing.Point(902, 340);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(88, 36);
            this.Yenile.TabIndex = 75;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = false;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1138, 415);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GörevTB);
            this.Controls.Add(this.PerTelTB);
            this.Controls.Add(this.AdSoyadTB);
            this.Controls.Add(this.PersonelDG);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView PersonelDG;
        private System.Windows.Forms.TextBox AdSoyadTB;
        private System.Windows.Forms.TextBox PerTelTB;
        private System.Windows.Forms.TextBox GörevTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Yenile;
    }
}