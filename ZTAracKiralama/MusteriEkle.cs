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


namespace ZTAracKiralama
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-O1ELLSS;Initial Catalog=ZTArackiralama;Integrated Security=True";

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = " Insert Into Musteriler Values (@Tcno,@AdSoyad,@TelefonNo,@Mail,@Adres)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@Tcno",msk_tc.Text);
            komut.Parameters.AddWithValue("@AdSoyad",txt_ad.Text);
            komut.Parameters.AddWithValue("@TelefonNo",msk_telno.Text);
            komut.Parameters.AddWithValue("@Mail",txt_eposta.Text);
            komut.Parameters.AddWithValue("@Adres",txt_adres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız başarıyla gerçekleşmiştir.");


        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void txt_adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
