namespace ZTAracKiralama
{
    partial class MusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListele));
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_eposta = new DevExpress.XtraEditors.TextEdit();
            this.txt_ad = new DevExpress.XtraEditors.TextEdit();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.msk_telno = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_guncellemusterilstele = new DevExpress.XtraEditors.SimpleButton();
            this.btn_silmusterilistele = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cikismusterilistele = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.oDataInstantFeedbackSource1 = new DevExpress.Data.ODataLinq.ODataInstantFeedbackSource();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(150, 404);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(334, 106);
            this.txt_adres.TabIndex = 24;
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(150, 333);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(196, 26);
            this.txt_eposta.TabIndex = 23;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(150, 164);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(196, 26);
            this.txt_ad.TabIndex = 22;
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(150, 228);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(196, 26);
            this.msk_tc.TabIndex = 21;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // msk_telno
            // 
            this.msk_telno.Location = new System.Drawing.Point(150, 279);
            this.msk_telno.Mask = "(999) 000-0000";
            this.msk_telno.Name = "msk_telno";
            this.msk_telno.Size = new System.Drawing.Size(196, 26);
            this.msk_telno.TabIndex = 20;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 410);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 20);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "ADRES :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 339);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 20);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "E-POSTA :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 282);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 20);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "TELEFON NO :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 170);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 20);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "AD SOYAD :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 228);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 20);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "T.C. NO :";
            // 
            // btn_guncellemusterilstele
            // 
            this.btn_guncellemusterilstele.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncellemusterilstele.Appearance.Options.UseFont = true;
            this.btn_guncellemusterilstele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncellemusterilstele.ImageOptions.Image")));
            this.btn_guncellemusterilstele.Location = new System.Drawing.Point(7, 557);
            this.btn_guncellemusterilstele.Name = "btn_guncellemusterilstele";
            this.btn_guncellemusterilstele.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_guncellemusterilstele.Size = new System.Drawing.Size(142, 75);
            this.btn_guncellemusterilstele.TabIndex = 25;
            this.btn_guncellemusterilstele.Text = "Güncelle";
            this.btn_guncellemusterilstele.Click += new System.EventHandler(this.btn_guncellemusterilstele_Click);
            // 
            // btn_silmusterilistele
            // 
            this.btn_silmusterilistele.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_silmusterilistele.Appearance.Options.UseFont = true;
            this.btn_silmusterilistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_silmusterilistele.ImageOptions.Image")));
            this.btn_silmusterilistele.Location = new System.Drawing.Point(177, 557);
            this.btn_silmusterilistele.Name = "btn_silmusterilistele";
            this.btn_silmusterilistele.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_silmusterilistele.Size = new System.Drawing.Size(132, 75);
            this.btn_silmusterilistele.TabIndex = 26;
            this.btn_silmusterilistele.Text = "Sil";
            this.btn_silmusterilistele.Click += new System.EventHandler(this.btn_silmusterilistele_Click);
            // 
            // btn_cikismusterilistele
            // 
            this.btn_cikismusterilistele.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikismusterilistele.Appearance.Options.UseFont = true;
            this.btn_cikismusterilistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikismusterilistele.ImageOptions.Image")));
            this.btn_cikismusterilistele.Location = new System.Drawing.Point(333, 557);
            this.btn_cikismusterilistele.Name = "btn_cikismusterilistele";
            this.btn_cikismusterilistele.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_cikismusterilistele.Size = new System.Drawing.Size(141, 75);
            this.btn_cikismusterilistele.TabIndex = 27;
            this.btn_cikismusterilistele.Text = "Çıkış";
            this.btn_cikismusterilistele.Click += new System.EventHandler(this.btn_cikismusterilistele_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(496, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(956, 636);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(138, 96);
            this.pictureEdit1.TabIndex = 29;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(342, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(132, 96);
            this.pictureEdit2.TabIndex = 30;
            // 
            // MusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1478, 644);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_cikismusterilistele);
            this.Controls.Add(this.btn_silmusterilistele);
            this.Controls.Add(this.btn_guncellemusterilstele);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.msk_telno);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "MusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriListele";
            this.Load += new System.EventHandler(this.MusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_eposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_adres;
        private DevExpress.XtraEditors.TextEdit txt_eposta;
        private DevExpress.XtraEditors.TextEdit txt_ad;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.MaskedTextBox msk_telno;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_guncellemusterilstele;
        private DevExpress.XtraEditors.SimpleButton btn_silmusterilistele;
        private DevExpress.XtraEditors.SimpleButton btn_cikismusterilistele;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.ODataLinq.ODataInstantFeedbackSource oDataInstantFeedbackSource1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}