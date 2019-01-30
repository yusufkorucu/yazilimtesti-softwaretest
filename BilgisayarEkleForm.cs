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
    public partial class BilgisayarEkleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BilgisayarEkleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");

        private void BilgisayarEkleForm_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            Personel();
            Bigisayarlar();
            baglanti.Close();

        }
        public void Personel()
        {
            SqlCommand komutpergetir = new SqlCommand("Select *from Personeller", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutpergetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        public void Bigisayarlar()
        {
            SqlCommand komutbilggetir = new SqlCommand("Select * from Bilgisayarlar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutbilggetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public string Durum { get; set; }
        private void BtnBilgisayarEkle_Click(object sender, EventArgs e)
        {
            Durum = "Aktif";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Bilgisayarlar (UrunID,PersonelID,BilgisayarAdi,BilgisayarDurum) values (@a1,@a2,@a3,@a4)", baglanti);
            komut.Parameters.AddWithValue("@a1", txtuid.Text);
            komut.Parameters.AddWithValue("@a2", txtpid.Text);
            komut.Parameters.AddWithValue("@a3", txtbadi.Text);
            komut.Parameters.AddWithValue("@a4", Durum);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgisayar Başarıyla Eklenmiştir");
            Bigisayarlar();
            Personel();
            baglanti.Close();

        }
    }
}