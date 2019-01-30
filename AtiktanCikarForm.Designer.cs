namespace YazılımSınamaProje
{
    partial class AtiktanCikarForm
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCikacakBilgisayar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AtiktanCikar = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCikacakUrun = new System.Windows.Forms.TextBox();
            this.UrunAtiktanCikar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(523, 291);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(473, 230);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(523, 55);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(473, 230);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtCikacakBilgisayar
            // 
            this.txtCikacakBilgisayar.Location = new System.Drawing.Point(247, 132);
            this.txtCikacakBilgisayar.Name = "txtCikacakBilgisayar";
            this.txtCikacakBilgisayar.Size = new System.Drawing.Size(140, 21);
            this.txtCikacakBilgisayar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atıktan Çıkacak Bilgisayar ID";
            // 
            // AtiktanCikar
            // 
            this.AtiktanCikar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.AtiktanCikar.Location = new System.Drawing.Point(247, 169);
            this.AtiktanCikar.Name = "AtiktanCikar";
            this.AtiktanCikar.Size = new System.Drawing.Size(140, 58);
            this.AtiktanCikar.TabIndex = 4;
            this.AtiktanCikar.Text = "Bilgisayar Atıktan Çıkar";
            this.AtiktanCikar.Click += new System.EventHandler(this.AtiktanCikar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atıktan Çıkacak Ürün ID";
            // 
            // txtCikacakUrun
            // 
            this.txtCikacakUrun.Location = new System.Drawing.Point(247, 239);
            this.txtCikacakUrun.Name = "txtCikacakUrun";
            this.txtCikacakUrun.Size = new System.Drawing.Size(140, 21);
            this.txtCikacakUrun.TabIndex = 5;
            // 
            // UrunAtiktanCikar
            // 
            this.UrunAtiktanCikar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.UrunAtiktanCikar.Location = new System.Drawing.Point(247, 277);
            this.UrunAtiktanCikar.Name = "UrunAtiktanCikar";
            this.UrunAtiktanCikar.Size = new System.Drawing.Size(140, 58);
            this.UrunAtiktanCikar.TabIndex = 7;
            this.UrunAtiktanCikar.Text = "Ürün Atıktan Çıkar";
            this.UrunAtiktanCikar.Click += new System.EventHandler(this.UrunAtiktanCikar_Click);
            // 
            // AtiktanCikarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 526);
            this.Controls.Add(this.UrunAtiktanCikar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCikacakUrun);
            this.Controls.Add(this.AtiktanCikar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCikacakBilgisayar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.Name = "AtiktanCikarForm";
            this.Text = "AtiktanCikarForm";
            this.Load += new System.EventHandler(this.AtiktanCikarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TextBox txtCikacakBilgisayar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton AtiktanCikar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCikacakUrun;
        private DevExpress.XtraEditors.SimpleButton UrunAtiktanCikar;
    }
}