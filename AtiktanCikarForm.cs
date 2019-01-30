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
    public partial class AtiktanCikarForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AtiktanCikarForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");
        public string Durum { get; set; }
        private void AtiktanCikarForm_Load(object sender, EventArgs e)
        {
            UrunAtikGel();
            AtikGetir();
        }

        public void UrunAtikGel()
        {
            Durum = "Pasif";
            baglanti.Open();

            SqlCommand komutatikgetir = new SqlCommand("select *from Urunler where UrunAktif=@a1", baglanti);
            komutatikgetir.Parameters.AddWithValue("@a1", Durum);
            SqlDataAdapter da = new SqlDataAdapter(komutatikgetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = komutatikgetir.ExecuteReader();
            while (dr.Read())
            {
                gridControl2.DataSource = dt;


            }
            baglanti.Close();
        }

        public void AtikGetir()
        {
            Durum = "Pasif";
            baglanti.Open();

            SqlCommand komutatikgetir = new SqlCommand("select *from Bilgisayarlar where BilgisayarDurum=@a1", baglanti);
            komutatikgetir.Parameters.AddWithValue("@a1", Durum);
            SqlDataAdapter da = new SqlDataAdapter(komutatikgetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = komutatikgetir.ExecuteReader();
            while (dr.Read())
            {
                gridControl1.DataSource = dt;


            }
            baglanti.Close();


        }

        public void BAtik()
        {
            Durum = "Aktif";
            baglanti.Open();
            SqlCommand komutatik = new SqlCommand("update Bilgisayarlar set BilgisayarDurum=@a2 where BilgisayarID=@a1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutatik);
            komutatik.Parameters.AddWithValue("@a1", txtCikacakBilgisayar.Text);

            komutatik.Parameters.AddWithValue("@a2", Durum);
            komutatik.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = komutatik.ExecuteReader();
            while (dr.Read())
            {
                gridControl1.DataSource = dt;

            }

            baglanti.Close();
        }

        public void AtikG()
        {
            Durum = "Aktif";
            baglanti.Open();
            SqlCommand komutatik = new SqlCommand("update Urunler set UrunAktif=@a2 where UrunID=@a1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutatik);
            komutatik.Parameters.AddWithValue("@a1", txtCikacakUrun.Text);
            komutatik.Parameters.AddWithValue("@a2", Durum);
            komutatik.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = komutatik.ExecuteReader();
            while (dr.Read())
            {
                gridControl1.DataSource = dt;

            }

            baglanti.Close();
        }

        private void AtiktanCikar_Click(object sender, EventArgs e)
        {
            BAtik();
            AtikGetir();
        }

        private void UrunAtiktanCikar_Click(object sender, EventArgs e)
        {
            AtikG();
            UrunAtikGel();
        }
    }
}