namespace Proje_Hastane
{
    partial class FrmDoktorGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGirisPaneli));
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.TxtDGirisSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDGirisYap = new System.Windows.Forms.Button();
            this.MskTCNO = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(127, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 58);
            this.label3.TabIndex = 15;
            this.label3.Text = "Doktor Giriş Paneli";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(401, 218);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(158, 22);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Şifremi Unuttum";
            // 
            // TxtDGirisSifre
            // 
            this.TxtDGirisSifre.Location = new System.Drawing.Point(196, 215);
            this.TxtDGirisSifre.Name = "TxtDGirisSifre";
            this.TxtDGirisSifre.Size = new System.Drawing.Size(173, 29);
            this.TxtDGirisSifre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta TC No:";
            // 
            // btnDGirisYap
            // 
            this.btnDGirisYap.Location = new System.Drawing.Point(218, 259);
            this.btnDGirisYap.Name = "btnDGirisYap";
            this.btnDGirisYap.Size = new System.Drawing.Size(136, 41);
            this.btnDGirisYap.TabIndex = 8;
            this.btnDGirisYap.Text = "Giriş Yap";
            this.btnDGirisYap.UseVisualStyleBackColor = true;
            this.btnDGirisYap.Click += new System.EventHandler(this.btnDGirisYap_Click);
            // 
            // MskTCNO
            // 
            this.MskTCNO.Location = new System.Drawing.Point(196, 164);
            this.MskTCNO.Mask = "00000000000";
            this.MskTCNO.Name = "MskTCNO";
            this.MskTCNO.Size = new System.Drawing.Size(173, 29);
            this.MskTCNO.TabIndex = 1;
            this.MskTCNO.ValidatingType = typeof(int);
            // 
            // FrmDoktorGirisPaneli
            // 
            this.AcceptButton = this.btnDGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(621, 370);
            this.Controls.Add(this.MskTCNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.TxtDGirisSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDGirisYap);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGirisPaneli";
            this.Text = "FrmDoktorGirisPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox TxtDGirisSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDGirisYap;
        private System.Windows.Forms.MaskedTextBox MskTCNO;
    }
}