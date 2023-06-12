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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiGuncelleme frhguncel = new FrmHastaBilgiGuncelleme();
            frhguncel.TCno = LblTcNo.Text;
            frhguncel.Show();
        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTcNo.Text = tc;
            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad from Tbl_Hastalar where HastaTC=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTc ="+ tc , bgl.baglanti() );
            da.Fill( dt );
            dataGridView1.DataSource= dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) 
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + CmbBrans.Text +"'" + "and RandevuDoktor='" + CmbDoktor.Text + "'and RandevuDurum=0", bgl.baglanti() );
            da.Fill( dt );
            dataGridView2.DataSource= dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("update tbl_randevular set RandevuDurum=1, HastaSikayet=@n2, HastaTc=@n1 where Randevuid=@n3",bgl.baglanti());
            komutekle.Parameters.AddWithValue("@n1", LblTcNo.Text);
            komutekle.Parameters.AddWithValue("@n2", RchSikayet.Text);
            komutekle.Parameters.AddWithValue("@n3", Txtid.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz Oluşturuldu","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
