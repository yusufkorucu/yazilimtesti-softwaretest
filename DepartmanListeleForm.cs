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
    public partial class DepartmanListeleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DepartmanListeleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");

        private void DepartmanListeleForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            Departmanlar();
            baglanti.Close();
        }
        public void Departmanlar()
        {
            SqlCommand komutdepgetir = new SqlCommand("select * from Departmanlar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutdepgetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;



        }
    }
}