using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmHastaBilgiGuncelleme : Form
    {
        public FrmHastaBilgiGuncelleme()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnHBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre1.Text);
            komut2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskTcNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellenmiştir.");
        }

        private void BtnSifreKarsilastir_Click(object sender, EventArgs e)
        {
            if (TxtSifre1.Text == TxtSifre2.Text)
            {
                Lblsifredogrulama.BackColor = Color.Green;
                Lblsifredogrulama.Text = "Girilen şifreler aynı.";
                Lblsifredogrulama.Visible = true;
            }
            else
            {
                Lblsifredogrulama.Text = "Girilen şifreler aynı değil.";
            }
        }

        private void FrmHastaBilgiGuncelleme_Load(object sender, EventArgs e)
        {
            MskTcNo.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();   
                MskTelefon.Text = dr[4].ToString();
                TxtSifre1.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti();

        }
    }
}
