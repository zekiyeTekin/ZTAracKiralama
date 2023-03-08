using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTAracKiralama
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musterieklefrm =new MusteriEkle();
            musterieklefrm.Show();

        }

        private void btn_musteriList_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListelefrm =new MusteriListele();
            musteriListelefrm.Show();
        }

        private void btn_aracEkle_Click(object sender, EventArgs e)
        {
            AracEkle araceklefrm =new AracEkle();
            araceklefrm.Show();
        }

        private void btn_aracListe_Click(object sender, EventArgs e)
        {
            AracListele aracListelefrm =new AracListele();
            aracListelefrm.Show();
        }

        private void btn_sozlesme_Click(object sender, EventArgs e)
        {
            Sozlesme sozlesmefrm =new Sozlesme();
            sozlesmefrm.Show();
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            Satis satisfrm = new Satis();
            satisfrm.Show();
        }

        private void btn_anasayfacikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
