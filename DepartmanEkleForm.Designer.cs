namespace YazılımSınamaProje
{
    partial class DepartmanEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmanEkleForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtdadi = new System.Windows.Forms.TextBox();
            this.BtnDeparmanEkleme = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(285, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(285, 43);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Departman Ekleme";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(153, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Yeni Departman Adı:";
            // 
            // txtdadi
            // 
            this.txtdadi.Location = new System.Drawing.Point(224, 96);
            this.txtdadi.Name = "txtdadi";
            this.txtdadi.Size = new System.Drawing.Size(128, 21);
            this.txtdadi.TabIndex = 1;
            // 
            // BtnDeparmanEkleme
            // 
            this.BtnDeparmanEkleme.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BtnDeparmanEkleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeparmanEkleme.ImageOptions.Image")));
            this.BtnDeparmanEkleme.Location = new System.Drawing.Point(420, 82);
            this.BtnDeparmanEkleme.Name = "BtnDeparmanEkleme";
            this.BtnDeparmanEkleme.Size = new System.Drawing.Size(75, 35);
            this.BtnDeparmanEkleme.TabIndex = 2;
            this.BtnDeparmanEkleme.Text = "Ekle";
            this.BtnDeparmanEkleme.Click += new System.EventHandler(this.BtnDeparmanEkleme_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 207);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(847, 226);
            this.gridControl1.TabIndex = 5;
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
            // DepartmanEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 445);
            this.Controls.Add(this.txtdadi);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnDeparmanEkleme);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "DepartmanEkleForm";
            this.Text = "DepartmanEkleForm";
            this.Load += new System.EventHandler(this.DepartmanEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtdadi;
        private DevExpress.XtraEditors.SimpleButton BtnDeparmanEkleme;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}