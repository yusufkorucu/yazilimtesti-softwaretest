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
    public partial class PersonelListeleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PersonelListeleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");
        public void Listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Personeller", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglanti.Close();
        }

        private void PersonelListeleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}