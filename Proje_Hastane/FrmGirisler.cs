using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGirisPaneli frmgiris = new FrmHastaGirisPaneli();
            frmgiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorGirisPaneli frmDokGiris = new FrmDoktorGirisPaneli();
            frmDokGiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frmSekreter = new FrmSekreterGiris();
            frmSekreter.Show();
            this.Hide();
        }
    }
}
