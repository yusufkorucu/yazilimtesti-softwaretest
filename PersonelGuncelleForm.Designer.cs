namespace YazılımSınamaProje
{
    partial class PersonelGuncelleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGuncelleForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbptip = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbdep = new System.Windows.Forms.ComboBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(656, 359);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(784, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONEL ID";
            // 
            // cmbptip
            // 
            this.cmbptip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbptip.FormattingEnabled = true;
            this.cmbptip.Items.AddRange(new object[] {
            "Admin",
            "Birim Şefi",
            "Memur"});
            this.cmbptip.Location = new System.Drawing.Point(885, 68);
            this.cmbptip.Name = "cmbptip";
            this.cmbptip.Size = new System.Drawing.Size(111, 21);
            this.cmbptip.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(787, 76);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 13);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Personel Tipi:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(747, 274);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(103, 13);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Personel Departmanı:";
            // 
            // cmbdep
            // 
            this.cmbdep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdep.FormattingEnabled = true;
            this.cmbdep.Items.AddRange(new object[] {
            "SatinAlma",
            "TeknikHizmetler",
            "Bilgi İşlem"});
            this.cmbdep.Location = new System.Drawing.Point(884, 271);
            this.cmbdep.Name = "cmbdep";
            this.cmbdep.Size = new System.Drawing.Size(111, 21);
            this.cmbdep.TabIndex = 7;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(884, 229);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(111, 21);
            this.txtno.TabIndex = 6;
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(884, 188);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(111, 21);
            this.txtdt.TabIndex = 5;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(884, 151);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(111, 21);
            this.txtsoyad.TabIndex = 4;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(884, 111);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(111, 21);
            this.txtad.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(740, 232);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(131, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Personel Telefon Numarası:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(740, 191);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Personel Doğum Tarihi:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(770, 154);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Personel Soyadı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(787, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Personel Adı:";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(884, 24);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(111, 21);
            this.txtpid.TabIndex = 1;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(884, 315);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(112, 37);
            this.BtnGuncelle.TabIndex = 8;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // PersonelGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 359);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.cmbptip);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cmbdep);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "PersonelGuncelleForm";
            this.Text = "PersonelGuncelleForm";
            this.Load += new System.EventHandler(this.PersonelGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbptip;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cmbdep;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtpid;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
    }
}