using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.Sql;
using System.Data.SqlClient;


namespace YazılımSınamaProje
{
    public partial class UrunSatinAlForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public UrunSatinAlForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");
        private void UrunSatinAlForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            Urunler();
            Personeller();
            baglanti.Close();

        }
        public void Personeller()
        {
            SqlCommand komutpersonelgetir = new SqlCommand(" Select Personeller.PersonelID,Personeller.PersonelAdi,Personeller.PersonelSoyadi from Personeller ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutpersonelgetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        public void Urunler()
        { 
            SqlCommand komuturungetir = new SqlCommand("Select *from Urunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komuturungetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }
        public string Durum { get; set; }
        private void BtnSatinAl_Click(object sender, EventArgs e)
        {
            Durum = "Aktif";
            baglanti.Open();
            SqlCommand komutsatinal = new SqlCommand("insert into Urunler (UrunAdi,UrunMarkası,UrunParca,UrunFiyat,PersonelID,UrunAktif) values (@a1,@a2,@a3,@a4,@a5,@a6)", baglanti);
            komutsatinal.Parameters.AddWithValue("@a1", txtuad.Text);
            komutsatinal.Parameters.AddWithValue("@a2", txtumar.Text);
            komutsatinal.Parameters.AddWithValue("@a3", txtupa.Text);
            komutsatinal.Parameters.AddWithValue("@a4", txtuf.Text);
            komutsatinal.Parameters.AddWithValue("@a5", txtpid.Text);
            komutsatinal.Parameters.AddWithValue("@a6", Durum);
            komutsatinal.ExecuteNonQuery();
            MessageBox.Show("Urun Başarıyla Alınmıştır.");
            Urunler();
            baglanti.Close();
        }
    }
}