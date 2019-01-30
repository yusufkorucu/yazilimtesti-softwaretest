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
    public partial class DepartmanEkleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DepartmanEkleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");

        private void DepartmanEkleForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            DepGetir();
            baglanti.Close();
            
        }
        public void DepGetir()
        {
            SqlCommand komutdepgetir = new SqlCommand("select *from Departmanlar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutdepgetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void BtnDeparmanEkleme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komudepekle = new SqlCommand("insert into Departmanlar (DepartmanAdi) values (@a1)", baglanti);
            komudepekle.Parameters.AddWithValue("@a1", txtdadi.Text);
            komudepekle.ExecuteNonQuery();
            MessageBox.Show("Departman Başarı ile eklenmiştir.");
            DepGetir();
            baglanti.Close();
        }
    }
}