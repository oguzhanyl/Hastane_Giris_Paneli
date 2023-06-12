using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmHastaGirisPaneli : Form
    {
        public FrmHastaGirisPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeKayit fruye = new FrmUyeKayit();
            fruye.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtGirisSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = MskTc.Text;
                fr.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC Numarası veya şifre.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
        }

        private void FrmHastaGirisPaneli_Load(object sender, EventArgs e)
        {
            MskTc.Focus();
        }
    }
}
