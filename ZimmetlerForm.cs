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
    public partial class ZimmetlerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ZimmetlerForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");

        private void ZimmetlerForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            ZimmetGetir();
            baglanti.Close();

        }
        public void ZimmetGetir()
        {
            SqlCommand komutzimmetgetir = new SqlCommand("Select Personeller.PersonelID,Personeller.PersonelAdi,Personeller.PersonelDtarihi,Personeller.DepartmanID,Bilgisayarlar.BilgisayarID,Bilgisayarlar.BilgisayarAdi from Personeller  inner join Bilgisayarlar  on Personeller.PersonelID=Bilgisayarlar.PersonelID where Personeller.BilgisayarID=Bilgisayarlar.BilgisayarID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutzimmetgetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }
    }
}