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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-O1ELLSS;Initial Catalog=ZTArackiralama;Integrated Security=True";

        private void btn_musterieklecikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {

        }

        private void cb_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cb_marka.SelectedIndex == 0)
            {
                cb_seri.Properties.Items.Clear();            
                cb_seri.Properties.Items.Add("449 z");
                cb_seri.Properties.Items.Add("320 i");
                cb_seri.Properties.Items.Add("111 y");
                cb_seri.Properties.Items.Add("888 zt");
            }
            else if(cb_marka.SelectedIndex == 1)
            {
                cb_seri.Properties.Items.Clear();

                cb_seri.Properties.Items.Add("D204");
                cb_seri.Properties.Items.Add("D300");
                cb_seri.Properties.Items.Add("D350");
                cb_seri.Properties.Items.Add("D163");
            }
            else if (cb_marka.SelectedIndex == 2)
            {
                cb_seri.Properties.Items.Clear();

                cb_seri.Properties.Items.Add("911 4S");
                cb_seri.Properties.Items.Add("918 RSR");
                cb_seri.Properties.Items.Add("S918");
                cb_seri.Properties.Items.Add("P959");
                cb_seri.Properties.Items.Add("917 K"); 
            }
            else if (cb_marka.SelectedIndex == 3)
            {
                cb_seri.Properties.Items.Clear();

                cb_seri.Properties.Items.Add("SQ4");
                cb_seri.Properties.Items.Add("MC20"); 
                cb_seri.Properties.Items.Add("MHEV 330");
              
            }
            else if (cb_marka.SelectedIndex == 4)
            {
                cb_seri.Properties.Items.Clear();

                cb_seri.Properties.Items.Add("E");
                cb_seri.Properties.Items.Add("");
                cb_seri.Properties.Items.Add("");
            }
            else if (cb_marka.SelectedIndex == 5)
            {
                cb_seri.Properties.Items.Clear();

                cb_seri.Properties.Items.Add("");
                cb_seri.Properties.Items.Add("");
                cb_seri.Properties.Items.Add("");
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar values (@Plaka, @Marka, @Seri, @Model, @Renk, @Kilometre,@Yakit, @Ucret, @Durum)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@Plaka", txt_plaka.Text);
            komut.Parameters.AddWithValue("@Marka", cb_marka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri", cb_seri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txt_model.Text);
            komut.Parameters.AddWithValue("@Renk", txt_renk.Text);
            komut.Parameters.AddWithValue("@Kilometre", txt_km.Text);
            komut.Parameters.AddWithValue("@Yakit", cb_yakit.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret", txt_kira.Text);
            komut.Parameters.AddWithValue("@Durum", cb_durum.SelectedItem);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Arac kaydı başarıyla oluşturulmuştur.");

        }
    }
}
