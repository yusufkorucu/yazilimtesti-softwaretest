using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Sql;
using System.Data.SqlClient;


namespace YazılımSınamaProje
{
    public partial class PersonelGuncelleForm : DevExpress.XtraEditors.XtraForm
    {
        public PersonelGuncelleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");
        private void PersonelGuncelleForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            Getir();

            baglanti.Close();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Personeller set PersonelAdi=@a1,PersonelSoyadi=@a2,PersonelDtarihi=@a3,PersonelNumara=@a4,DepartmanID=@a5,KullaniciID=@a6 where PersonelID=@a7 ", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", Convert.ToDateTime(txtdt.Text));
            komutguncelle.Parameters.AddWithValue("@a4", Convert.ToInt32( txtno.Text));
            if (cmbdep.Text == "SatinAlma")
            {
                cmbdep.Text = "1";
            }
            if (cmbdep.Text == "TeknikHizmetler")
            {
                cmbdep.Text = "1";
            }
            if (cmbdep.Text == "Bilgi İşlem")
            {
                cmbdep.Text = "3";
            }

            komutguncelle.Parameters.AddWithValue("@a5", cmbdep.Text);
            if (cmbptip.Text == "Admin")
            {
                cmbptip.Text = "1";

            }
            if (cmbptip.Text == "Birim Şefi")
            {
                cmbptip.Text = "2";

            }
            if (cmbptip.Text == "Memur")
            {
                cmbptip.Text = "3";

            }
            komutguncelle.Parameters.AddWithValue("@a6", cmbptip.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtpid.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Başarılı Şekilde Güncellendi");
            Getir();

        }
        public void Getir()
        {
            SqlCommand komut = new SqlCommand("Select *from Personeller", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
    }
}