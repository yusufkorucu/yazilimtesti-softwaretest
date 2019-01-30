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
    public partial class PersonelEkleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PersonelEkleForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");

   
        public void Listele()
        {
            
            SqlCommand komut = new SqlCommand("Select *from Personeller", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
           
        }
        public void doldur()
        {
            SqlCommand komut = new SqlCommand("Select *from Departmanlar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbdep.ValueMember = "DepartmanID";
            cmbdep.DisplayMember = "DepartmanAdi";
            cmbdep.DataSource = dt;

        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personeller (PersonelAdi,PersonelSoyadi,PersonelDtarihi,PersonelNumara,DepartmanID,KullaniciID) values (@a1,@a2,@a3,@a4,@a5,@a6)", baglanti);
            komut.Parameters.AddWithValue("@a1", txtad.Text);
            komut.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@a3", Convert.ToDateTime( txtdt.Text));
            komut.Parameters.AddWithValue("@a4",  Convert.ToInt32 (txtno.Text));
            if (cmbdep.Text== "SatinAlma")
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

            komut.Parameters.AddWithValue("@a5", cmbdep.Text);
            if (cmbptip.Text=="Admin")
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
            komut.Parameters.AddWithValue("@a6", cmbptip.Text);


            komut.ExecuteNonQuery();
         
            Listele();
            baglanti.Close();

        }

        private void PersonelEkleForm_Load(object sender, EventArgs e)
        {
            doldur();
        }
    }
}