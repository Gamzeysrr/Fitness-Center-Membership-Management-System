using System;

namespace gym
{
    partial class Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme));
            this.label8 = new System.Windows.Forms.Label();
            this.Periyot = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.OdenecekTutarTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OdemeDG = new System.Windows.Forms.DataGridView();
            this.AdSoyadCB = new System.Windows.Forms.ComboBox();
            this.AramaTB = new System.Windows.Forms.TextBox();
            this.AraButon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(768, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 36);
            this.label8.TabIndex = 56;
            this.label8.Text = "Ödemeler";
            // 
            // Periyot
            // 
            this.Periyot.Location = new System.Drawing.Point(339, 299);
            this.Periyot.Name = "Periyot";
            this.Periyot.Size = new System.Drawing.Size(172, 22);
            this.Periyot.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(334, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Ödeme Tarihi";
            // 
            // OdenecekTutarTB
            // 
            this.OdenecekTutarTB.Location = new System.Drawing.Point(339, 210);
            this.OdenecekTutarTB.Multiline = true;
            this.OdenecekTutarTB.Name = "OdenecekTutarTB";
            this.OdenecekTutarTB.Size = new System.Drawing.Size(172, 27);
            this.OdenecekTutarTB.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(334, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Ödenecek Turar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(334, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Üye Adı Soyadı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(375, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 64;
            this.button1.Text = "Öde";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(1100, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-46, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(1066, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "🡸";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OdemeDG
            // 
            this.OdemeDG.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.OdemeDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdemeDG.Location = new System.Drawing.Point(529, 100);
            this.OdemeDG.Name = "OdemeDG";
            this.OdemeDG.RowHeadersWidth = 51;
            this.OdemeDG.RowTemplate.Height = 25;
            this.OdemeDG.Size = new System.Drawing.Size(597, 263);
            this.OdemeDG.TabIndex = 70;
            this.OdemeDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UyeDG_CellContentClick);
            // 
            // AdSoyadCB
            // 
            this.AdSoyadCB.FormattingEnabled = true;
            this.AdSoyadCB.Location = new System.Drawing.Point(339, 143);
            this.AdSoyadCB.Name = "AdSoyadCB";
            this.AdSoyadCB.Size = new System.Drawing.Size(172, 24);
            this.AdSoyadCB.TabIndex = 71;
            // 
            // AramaTB
            // 
            this.AramaTB.Location = new System.Drawing.Point(552, 395);
            this.AramaTB.Name = "AramaTB";
            this.AramaTB.Size = new System.Drawing.Size(106, 22);
            this.AramaTB.TabIndex = 72;
            // 
            // AraButon
            // 
            this.AraButon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AraButon.ForeColor = System.Drawing.Color.DarkRed;
            this.AraButon.Location = new System.Drawing.Point(673, 388);
            this.AraButon.Name = "AraButon";
            this.AraButon.Size = new System.Drawing.Size(88, 36);
            this.AraButon.TabIndex = 73;
            this.AraButon.Text = "Ara";
            this.AraButon.UseVisualStyleBackColor = false;
            this.AraButon.Click += new System.EventHandler(this.AraButon_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(774, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 74;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1138, 477);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AraButon);
            this.Controls.Add(this.AramaTB);
            this.Controls.Add(this.AdSoyadCB);
            this.Controls.Add(this.OdemeDG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Periyot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OdenecekTutarTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Periyot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OdenecekTutarTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView OdemeDG;
        private System.Windows.Forms.ComboBox AdSoyadCB;
        private System.Windows.Forms.TextBox AramaTB;
        private System.Windows.Forms.Button AraButon;
        private System.Windows.Forms.Button button2;
    }
}