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
    public partial class MemurGirişi : DevExpress.XtraEditors.XtraForm
    {
        public MemurGirişi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-31SPU2M\\SQLEXPRESS;Initial Catalog=YazılimSinamaProje;Integrated Security=True");

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kullanici where KullaniciAdi=@p1 and KullaniciSifre=@p2 and KullaniciTipID=3", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ProgramForm pf = new ProgramForm();
                pf.ribbonPage6.Visible = false;
                pf.ribbonPage10.Visible = false;
                pf.ribbonPageGroup8.Visible = false;
                pf.ribbonPageGroup13.Visible = false;
                pf.ribbonPageGroup17.Visible = false;
                pf.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatali Gİris");
            }
            baglanti.Close();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}