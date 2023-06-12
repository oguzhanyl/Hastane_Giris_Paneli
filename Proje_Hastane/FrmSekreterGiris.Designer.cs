namespace Proje_Hastane
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.TxtDGirisSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDGirisYap = new System.Windows.Forms.Button();
            this.MskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(99, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 58);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sekreter Giriş Paneli";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(373, 193);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(158, 22);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Şifremi Unuttum";
            // 
            // TxtDGirisSifre
            // 
            this.TxtDGirisSifre.Location = new System.Drawing.Point(168, 190);
            this.TxtDGirisSifre.Name = "TxtDGirisSifre";
            this.TxtDGirisSifre.Size = new System.Drawing.Size(173, 29);
            this.TxtDGirisSifre.TabIndex = 2;
            this.TxtDGirisSifre.Text = "0707";
            this.TxtDGirisSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sekreter TC No:";
            // 
            // btnDGirisYap
            // 
            this.btnDGirisYap.Location = new System.Drawing.Point(190, 234);
            this.btnDGirisYap.Name = "btnDGirisYap";
            this.btnDGirisYap.Size = new System.Drawing.Size(136, 41);
            this.btnDGirisYap.TabIndex = 3;
            this.btnDGirisYap.Text = "Giriş Yap";
            this.btnDGirisYap.UseVisualStyleBackColor = true;
            this.btnDGirisYap.Click += new System.EventHandler(this.btnDGirisYap_Click);
            // 
            // MskTcNo
            // 
            this.MskTcNo.Location = new System.Drawing.Point(168, 139);
            this.MskTcNo.Mask = "00000000000";
            this.MskTcNo.Name = "MskTcNo";
            this.MskTcNo.Size = new System.Drawing.Size(173, 29);
            this.MskTcNo.TabIndex = 1;
            this.MskTcNo.Text = "77777777777";
            this.MskTcNo.ValidatingType = typeof(int);
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.btnDGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(542, 351);
            this.Controls.Add(this.MskTcNo);
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
            this.Name = "FrmSekreterGiris";
            this.Text = "FrmSekreterGiris";
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
        private System.Windows.Forms.MaskedTextBox MskTcNo;
    }
}