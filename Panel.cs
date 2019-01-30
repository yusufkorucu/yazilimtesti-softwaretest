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

namespace YazılımSınamaProje
{
    public partial class Panel : DevExpress.XtraEditors.XtraForm
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AdminForm ad = new AdminForm();
            ad.Show();
            this.Hide();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BirimYetkilisi b = new BirimYetkilisi();
            
            b.Show();
            this.Hide();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MemurGirişi m = new MemurGirişi();
            
       
            m.Show();
            this.Hide();
        }
    }
}