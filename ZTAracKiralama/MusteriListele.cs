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
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-O1ELLSS;Initial Catalog=ZTArackiralama;Integrated Security=True";

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            Musteri_Listele();
        }
        public void Musteri_Listele()
        {
            SqlConnection baglanti = new  SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Musteriler";
            SqlCommand komut =new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da =new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglanti.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                msk_tc.Text = dr["Tc_No"].ToString();
                txt_ad.Text = dr["Ad_Soyad"].ToString();
                msk_telno.Text = dr["Tel_No"].ToString();
                txt_eposta.Text = dr["Mail"].ToString();
                txt_adres.Text = dr["Adres"].ToString();
            }
        }

        private void btn_guncellemusterilstele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Musteriler set Ad_Soyad = @adsoyad, Tel_No = @TelefonNo, Mail = @Mail, Adres= @Adres Where Tc_No=@Tcno";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Tcno", msk_tc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txt_ad.Text);
            komut.Parameters.AddWithValue("@TelefonNo", msk_telno.Text);
            komut.Parameters.AddWithValue("@Mail", txt_eposta.Text);
            komut.Parameters.AddWithValue("@Adres", txt_adres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();


        }

        private void btn_cikismusterilistele_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_silmusterilistele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete from Musteriler where Tc_No=@Tcno", baglanti);
            komut.Parameters.AddWithValue("@Tcno", msk_tc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Musteri_Listele();

        }
    }
}
