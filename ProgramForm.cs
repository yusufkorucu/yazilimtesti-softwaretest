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

namespace YazılımSınamaProje
{
    public partial class ProgramForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ProgramForm()
        {
            InitializeComponent();
        }
        PersonelListeleForm plf=new PersonelListeleForm ();
        PersonelEkleForm pe;
        PersonelGuncelleForm pg;
        PersonelSilForm ps;
        UrunListeleForm ulf;
        UrunSatinAlForm usf;
        ZimmetlerForm zf;
        DepartmanListeleForm dlf;
        DepartmanEkleForm def;
        BilgisyarListeForm blf;
        BilgisayarEkleForm bef;
        AtikKontrolForm atk;
        UrunAtikKontrolForm uat;
        AtiktanCikarForm atc;
      

        private void BtnPersonelEkle_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            pe = new YazılımSınamaProje.PersonelEkleForm();
            pe.MdiParent = this;
            pe.Show();
            pe.Listele();


        }

        private void BtnPersonelListele_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            plf = new YazılımSınamaProje.PersonelListeleForm();
            plf.MdiParent = this;
            plf.Show();
            plf.Listele();

        }

        private void BtnPersonelGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            pg = new YazılımSınamaProje.PersonelGuncelleForm();
            pg.MdiParent = this;
            pg.Show();

        }

        private void BtnPersonelSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            ps = new YazılımSınamaProje.PersonelSilForm();
            ps.MdiParent = this;
            ps.Show();
            ps.Listele();


        }

        private void BtnKisiZimmetRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnUrunListele_ItemClick(object sender, ItemClickEventArgs e)
        {
            ulf = new YazılımSınamaProje.UrunListeleForm();
            ulf.MdiParent = this;
            ulf.Show();
            ulf.Listele();

        }

        private void BtnUrunSatinAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            usf = new YazılımSınamaProje.UrunSatinAlForm();
            usf.MdiParent = this;
            usf.Show();
            usf.Urunler();
            

        }

        private void BtnZimmetler_ItemClick(object sender, ItemClickEventArgs e)
        {
            zf = new YazılımSınamaProje.ZimmetlerForm();
            zf.MdiParent = this;
            zf.Show();


        }

        private void DepartmanListele_ItemClick(object sender, ItemClickEventArgs e)
        {
            dlf = new YazılımSınamaProje.DepartmanListeleForm();
            dlf.MdiParent = this;
            dlf.Show();
        }

        private void DepartmanEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            def = new YazılımSınamaProje.DepartmanEkleForm();
            def.MdiParent = this;
            def.Show();
        }

        private void BtnBilgisayarListele_ItemClick(object sender, ItemClickEventArgs e)
        {
            blf = new YazılımSınamaProje.BilgisyarListeForm();
            blf.MdiParent = this;
            blf.Show();
        }

        private void BilgisayarEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            bef = new YazılımSınamaProje.BilgisayarEkleForm();
            bef.MdiParent = this;
            bef.Show();
        }

        private void UrunAtik_ItemClick(object sender, ItemClickEventArgs e)
        {
            uat = new YazılımSınamaProje.UrunAtikKontrolForm();
            uat.MdiParent = this;
            uat.Show();

        }

        private void BilgisayarAtikCikar_ItemClick(object sender, ItemClickEventArgs e)
        {
            atk = new YazılımSınamaProje.AtikKontrolForm();
            atk.MdiParent = this;
            atk.Show();

        }

        private void AtikCikar_ItemClick(object sender, ItemClickEventArgs e)
        {
            atc = new YazılımSınamaProje.AtiktanCikarForm();
            atc.MdiParent = this;
            atc.Show();
        }
    }
}