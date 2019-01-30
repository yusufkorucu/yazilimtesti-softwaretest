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
    public partial class UrunAtikKontrolForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public UrunAtikKontrolForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");
        private void UrunAtikKontrolForm_Load(object sender, EventArgs e)
        {
            Durum = "Pasif";
            AtikGel();
            UrunGel();
        }

        private void Atik_Click(object sender, EventArgs e)
        {
            Durum = "Pasif";
            AtikG();
            AtikGel();
            UrunGel();

        }
        public string Durum { get; set; }
        public void AtikGel()
        {
            baglanti.Open();

            SqlCommand komutatikgetir = new SqlCommand("select *from Urunler where UrunAktif=@a1", baglanti);
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
        public void UrunGel()
        {
            baglanti.Open();
            SqlCommand komutbilgisayargetir = new SqlCommand("Select *from Urunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutbilgisayargetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
            baglanti.Close();
        }
        public void AtikG()
        {
            baglanti.Open();
            SqlCommand komutatik = new SqlCommand("update Urunler set UrunAktif=@a2 where UrunID=@a1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutatik);
            komutatik.Parameters.AddWithValue("@a1", txtuid.Text);

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

    }
}