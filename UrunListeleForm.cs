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
    public partial class UrunListeleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public UrunListeleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");

        private void UrunListeleForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            Listele();
            baglanti.Close();
        }
        public void Listele()
        {
            SqlCommand komutlistele = new SqlCommand("Select *From Urunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutlistele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

          



        }
    }
}