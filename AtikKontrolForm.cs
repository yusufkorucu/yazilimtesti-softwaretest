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
    public partial class AtikKontrolForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AtikKontrolForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");

        private void AtikKontrolForm_Load(object sender, EventArgs e)
        {
            Durum = "Pasif";
            
            BilgisayarGetir();
            AtikGetir();
            

        }
        public string Durum { get; set; }
        public void AtikGetir()
        {
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
        public void BilgisayarGetir()
        {
            baglanti.Open();
            SqlCommand komutbilgisayargetir = new SqlCommand("Select *from Bilgisayarlar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutbilgisayargetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
            baglanti.Close();
            

        }

        private void Atik_Click(object sender, EventArgs e)
        {
            
            Durum = "Pasif";
         

            BAtik();
            BilgisayarGetir();
            AtikGetir();
      
        }

        public void BAtik()
        {
            baglanti.Open();
            SqlCommand komutatik = new SqlCommand("update Bilgisayarlar set BilgisayarDurum=@a2 where BilgisayarID=@a1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutatik);
            komutatik.Parameters.AddWithValue("@a1", txtuid.Text);
          
            komutatik.Parameters.AddWithValue("@a2", Durum);
            komutatik.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr =komutatik.ExecuteReader();
            while (dr.Read())
            {
                gridControl1.DataSource = dt;
                
            }

            baglanti.Close();
        }
    }
}