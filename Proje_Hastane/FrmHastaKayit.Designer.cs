namespace Proje_Hastane
{
    partial class FrmUyeKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUyeKayit));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSifre2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.Lblsifredogrulama = new System.Windows.Forms.Label();
            this.BtnSifreKarsilastir = new System.Windows.Forms.Button();
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cinsiyet:";
            // 
            // TxtSifre1
            // 
            this.TxtSifre1.Location = new System.Drawing.Point(224, 266);
            this.TxtSifre1.Name = "TxtSifre1";
            this.TxtSifre1.Size = new System.Drawing.Size(173, 29);
            this.TxtSifre1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(224, 119);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(173, 29);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(224, 70);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(173, 29);
            this.TxtAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ad:";
            // 
            // TxtSifre2
            // 
            this.TxtSifre2.Location = new System.Drawing.Point(224, 316);
            this.TxtSifre2.Name = "TxtSifre2";
            this.TxtSifre2.Size = new System.Drawing.Size(173, 29);
            this.TxtSifre2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Şifre Doğrulama:";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(224, 388);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(173, 30);
            this.CmbCinsiyet.TabIndex = 7;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(224, 218);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(173, 29);
            this.MskTelefon.TabIndex = 4;
            // 
            // MskTcNo
            // 
            this.MskTcNo.Location = new System.Drawing.Point(224, 167);
            this.MskTcNo.Mask = "00000000000";
            this.MskTcNo.Name = "MskTcNo";
            this.MskTcNo.Size = new System.Drawing.Size(173, 29);
            this.MskTcNo.TabIndex = 3;
            this.MskTcNo.ValidatingType = typeof(int);
            // 
            // Lblsifredogrulama
            // 
            this.Lblsifredogrulama.AutoSize = true;
            this.Lblsifredogrulama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblsifredogrulama.Location = new System.Drawing.Point(238, 357);
            this.Lblsifredogrulama.Name = "Lblsifredogrulama";
            this.Lblsifredogrulama.Size = new System.Drawing.Size(41, 15);
            this.Lblsifredogrulama.TabIndex = 22;
            this.Lblsifredogrulama.Text = "label8";
            this.Lblsifredogrulama.Visible = false;
            // 
            // BtnSifreKarsilastir
            // 
            this.BtnSifreKarsilastir.Location = new System.Drawing.Point(424, 289);
            this.BtnSifreKarsilastir.Name = "BtnSifreKarsilastir";
            this.BtnSifreKarsilastir.Size = new System.Drawing.Size(117, 33);
            this.BtnSifreKarsilastir.TabIndex = 23;
            this.BtnSifreKarsilastir.Text = "Karşılaştır";
            this.BtnSifreKarsilastir.UseVisualStyleBackColor = true;
            this.BtnSifreKarsilastir.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.Location = new System.Drawing.Point(241, 424);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(138, 37);
            this.BtnKayitYap.TabIndex = 8;
            this.BtnKayitYap.Text = "Kayıt Yap";
            this.BtnKayitYap.UseVisualStyleBackColor = true;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // FrmUyeKayit
            // 
            this.AcceptButton = this.BtnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(617, 564);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.BtnSifreKarsilastir);
            this.Controls.Add(this.Lblsifredogrulama);
            this.Controls.Add(this.MskTcNo);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.TxtSifre2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmUyeKayit";
            this.Text = "FrmHastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSifre2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.MaskedTextBox MskTcNo;
        private System.Windows.Forms.Label Lblsifredogrulama;
        private System.Windows.Forms.Button BtnSifreKarsilastir;
        private System.Windows.Forms.Button BtnKayitYap;
    }
}