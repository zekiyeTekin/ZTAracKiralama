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
    public partial class Sozlesme : Form
    {
        public Sozlesme()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-O1ELLSS;Initial Catalog=ZTArackiralama;Integrated Security=True";
        
        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar where Durumu ='Bos'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cb_arac.Properties.Items.Add(read["Plaka"]);
            }
        }

        public void Sozlesme_Listele()
        {
            SqlConnection baglanti =new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Sozlesme";
            SqlCommand komut =new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new  DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sozlesme_Load(object sender, EventArgs e)
        {
            Arac_Listele();
            Sozlesme_Listele();
        }

        private void cb_arac_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi =" Select * from Araclar where Plaka like '"+ cb_arac.SelectedItem +"'";
            SqlCommand komut= new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read =komut.ExecuteReader();
            while (read.Read())
            {
                txt_marka.Text = read["Marka"].ToString();
                txt_seri.Text = read["Seri"].ToString();
                txt_model.Text = read["Model"].ToString();
                txt_renk.Text = read["Renk"].ToString();
                
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarki = DateTime.Parse(dateofset_donus.Text) - DateTime.Parse(date_cıkıs.Text);
            int gunhesap = gunfarki.Days;
            txt_gun.Text = gunhesap.ToString();
            txt_tutar.Text = (gunhesap * float.Parse(txt_kiraucreti.Text)).ToString();

        }

        private void cb_kirasekil_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = " Select Kira_Ucreti from Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if(cb_kirasekil.SelectedIndex == 0)
                {
                    txt_kiraucreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) *1).ToString();
                }
                else if (cb_kirasekil.SelectedIndex == 1)
                {
                    txt_kiraucreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.90).ToString();
                }

                else if (cb_kirasekil.SelectedIndex == 2)
                {
                    txt_kiraucreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.70).ToString();
                }
                else if (cb_kirasekil.SelectedIndex == 3)
                {
                    txt_kiraucreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.50).ToString();
                }

            }
         }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = " Insert Into Sozlesme Values (@tcno, @adsoyad, @Telefon, @ehliyetno, @ehliyettarih,@Plaka, @Marka, @Seri, @Model, @renk, @kirasekli, @kiraucret, @kiralanangun, @tutar, @cıkıstarihi, @donustarihi)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@tcno",txt_tc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txt_adsoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txt_tel.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txt_ehliyetno.Text);
            komut.Parameters.AddWithValue("@ehliyettarih", txt_ehliyettarihi.Text);
            komut.Parameters.AddWithValue("@Plaka", cb_arac.Text);
            komut.Parameters.AddWithValue("@Marka", txt_marka.Text);
            komut.Parameters.AddWithValue("@Seri", txt_seri.Text);
            komut.Parameters.AddWithValue("@Model", txt_model.Text);
            komut.Parameters.AddWithValue("@renk", txt_renk.Text);
            komut.Parameters.AddWithValue("@kirasekli", cb_kirasekil.SelectedItem);
            komut.Parameters.AddWithValue("@kiraucret", txt_kiraucreti.Text); ;
            komut.Parameters.AddWithValue("@kiralanangun", txt_gun.Text);
            komut.Parameters.AddWithValue("@tutar", txt_tutar.Text);
            komut.Parameters.AddWithValue("@cıkıstarihi", date_cıkıs.Text);
            komut.Parameters.AddWithValue("@donustarihi", dateofset_donus.Text);

            string komutCumlesiUp = "Update Araclar set Durumu ='Dolu' where Plaka ='"+ cb_arac.SelectedItem +"'";
            SqlCommand komutUp =new SqlCommand(komutCumlesiUp, baglanti);

            komut.ExecuteNonQuery();
            komutUp.ExecuteNonQuery();
            baglanti.Close();
            Sozlesme_Listele();
            Arac_Listele();

            MessageBox.Show("Kayıt Başarılıdır.");


        }

        private void txt_tutar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_tcileara_EditValueChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = " Select * from Musteriler where Tc_No like '" +txt_tcileara.Text +"'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_tc.Text = read["Tc_No"].ToString();
                txt_adsoyad.Text = read["Ad_Soyad"].ToString();
                txt_tel.Text = read["Tel_No"].ToString();
            }
        }

        private void btn_aracteslim_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            DateTime Bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            int ucret = int.Parse(satir.Cells["Kira_Ucreti"].Value.ToString());
            var tutar = int.Parse(satir.Cells["Tutar"].Value.ToString());
            DateTime cikis = DateTime.Parse(satir.Cells["Cikis_Tarih"].Value.ToString());
            TimeSpan gun =Bugun - cikis;
            int gunu = gun.Days;
            int ToplamTutar = gunu - ucret;

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = " Delete from Sozlesme where Plaka ='" +satir.Cells["Plaka"].Value.ToString() +"'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();


            string komutCumlesiUpd = " Update Araclar set Durumu ='Bos' where Plaka ='" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komutUpd = new SqlCommand(komutCumlesiUpd, baglanti);
            komutUpd.ExecuteNonQuery();

            string komutCumlesiSatis = " Insert Into Satis Values (@tcno, @adsoyad, @Plaka, @gun, @kirasekli, @kiraucret, @tutar, @Cikis_Tarih, @Donus_Tarih)'" +satir.Cells["Plaka"].Value;
            SqlCommand komutSatis = new SqlCommand(komutCumlesiSatis, baglanti);

            komutSatis.Parameters.AddWithValue("@tcno",satir.Cells["Tc_No"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@adsoyad", satir.Cells["Ad_Soyad"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@gun", gunu);
            komutSatis.Parameters.AddWithValue("@kirasekli", satir.Cells["Kira_Sekli"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@kiraucret", ucret);
            komutSatis.Parameters.AddWithValue("@tutar", ToplamTutar);
            komutSatis.Parameters.AddWithValue("@Cikis_Tarih", satir.Cells["Cikis_Tarih"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Donus_Tarih", satir.Cells["Donus_Tarih"].Value.ToString());

            try
            {
                komutSatis.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show("Arac Teslim Edildi.");
            }
            
                
             
            
            //baglanti.Close();
            
            
         
           

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
