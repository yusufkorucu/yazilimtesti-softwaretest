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
    public partial class BilgisyarListeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BilgisyarListeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");
        private void BilgisyarListeForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            BilgisayarListele();
            baglanti.Close();

        }
        public void BilgisayarListele()
        {
            SqlCommand komutbilgisayargetir = new SqlCommand("Select *from Bilgisayarlar",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutbilgisayargetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;





        }
    }
}