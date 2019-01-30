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
    public partial class PersonelSilForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PersonelSilForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");
        private void PersonelSilForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            Listele();
            baglanti.Close();

        }
        public void Listele()
        {
            SqlCommand komutgetir = new SqlCommand("Select *from Personeller", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutgetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void BtnPersonelSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Personeller where PersonelID=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtpid.Text);
            komutsil.ExecuteNonQuery();
            MessageBox.Show("Personel Başarıyla Silinmiştir.");
            Listele();
            baglanti.Close();
        }
    }
}