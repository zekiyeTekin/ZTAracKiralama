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
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-O1ELLSS;Initial Catalog=ZTArackiralama;Integrated Security=True";



        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglanti.Close();
        }



        private void AracListele_Load(object sender, EventArgs e)
        {
            Arac_Listele();
        }

        private void cb_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_marka.SelectedIndex == 0)
            {
                cb_seri.Properties.Items.Clear();

                cb_seri.Properties.Items.Add("476 k");
                cb_seri.Properties.Items.Add("320 i");
                cb_seri.Properties.Items.Add("4029 A");
                cb_seri.Properties.Items.Add("ZT 86");
            }
            else if (cb_marka.SelectedIndex == 1)
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

                cb_seri.Properties.Items.Add("E 1450");
                cb_seri.Properties.Items.Add("E 429");
                cb_seri.Properties.Items.Add("999 Sf");
            }
            else if (cb_marka.SelectedIndex == 5)
            {
                cb_seri.Properties.Items.Clear();

                cb_seri.Properties.Items.Add("AA543");
                cb_seri.Properties.Items.Add("BA 39");
                cb_seri.Properties.Items.Add("EEE 47");
            }
        
    }

        private void btn_guncellearaclistele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Araclar set Marka = @marka, Seri = @seri, Model = @Model, Renk= @Renk, Kilometre =@Km, Yakit=@yakit , Kira_Ucreti=@Ucret, Durumu=@Durum  Where Plaka=@Plaka";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Plaka", txt_plaka.Text);
            komut.Parameters.AddWithValue("@marka", cb_marka.SelectedItem);
            komut.Parameters.AddWithValue("@seri", cb_seri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txt_model.Text);
            komut.Parameters.AddWithValue("@Renk", txt_renk.Text);
            komut.Parameters.AddWithValue("@Km", txt_km.Text);
            komut.Parameters.AddWithValue("@yakit", cb_yakit.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret", txt_kira.Text);
            komut.Parameters.AddWithValue("@Durum", cb_durum.SelectedItem);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

        private void btn_silaraclistele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete from Araclar where Plaka=@Plaka", baglanti);
            komut.Parameters.AddWithValue("@Plaka", txt_plaka.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Arac_Listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txt_plaka.Text = dr["Plaka"].ToString();
                cb_marka.Text = dr["Marka"].ToString();
                cb_seri.Text = dr["Seri"].ToString();
                txt_model.Text = dr["Model"].ToString();
                txt_renk.Text = dr["Renk"].ToString();
                txt_km.Text = dr["Kilometre"].ToString();
                cb_yakit.Text = dr["Yakit"].ToString();
                txt_kira.Text = dr["Kira_Ucreti"].ToString();
                cb_durum.Text = dr["Durumu"].ToString();
            }
        }

        private void btn_cikisaraclistele_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
