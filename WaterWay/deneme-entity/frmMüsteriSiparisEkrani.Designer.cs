namespace deneme_entity
{
    partial class frmMusteriSE
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
            this.grbSiparisEkrani = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lstUrun = new System.Windows.Forms.ListView();
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunUcreti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunBoyut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpSiparisEkrani = new System.Windows.Forms.GroupBox();
            this.gtpSiparis = new System.Windows.Forms.DateTimePicker();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.txtTutarHesapla = new System.Windows.Forms.TextBox();
            this.btnTutarHesapla = new System.Windows.Forms.Button();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.cmbIl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbSiparisEkrani.SuspendLayout();
            this.grpSiparisEkrani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSiparisEkrani
            // 
            this.grbSiparisEkrani.Controls.Add(this.txtAra);
            this.grbSiparisEkrani.Controls.Add(this.btnAra);
            this.grbSiparisEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbSiparisEkrani.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbSiparisEkrani.Location = new System.Drawing.Point(166, 229);
            this.grbSiparisEkrani.Margin = new System.Windows.Forms.Padding(4);
            this.grbSiparisEkrani.Name = "grbSiparisEkrani";
            this.grbSiparisEkrani.Padding = new System.Windows.Forms.Padding(4);
            this.grbSiparisEkrani.Size = new System.Drawing.Size(906, 62);
            this.grbSiparisEkrani.TabIndex = 5;
            this.grbSiparisEkrani.TabStop = false;
            this.grbSiparisEkrani.Text = "Ürün Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(176, 23);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(304, 26);
            this.txtAra.TabIndex = 5;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAra.Location = new System.Drawing.Point(21, 23);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 28);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // lstUrun
            // 
            this.lstUrun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunAdi,
            this.UrunUcreti,
            this.UrunBoyut});
            this.lstUrun.FullRowSelect = true;
            this.lstUrun.HideSelection = false;
            this.lstUrun.Location = new System.Drawing.Point(166, 13);
            this.lstUrun.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(906, 203);
            this.lstUrun.TabIndex = 6;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            this.lstUrun.View = System.Windows.Forms.View.Details;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 123;
            // 
            // UrunUcreti
            // 
            this.UrunUcreti.Text = "Ücret";
            this.UrunUcreti.Width = 118;
            // 
            // UrunBoyut
            // 
            this.UrunBoyut.Text = "Boyut";
            // 
            // grpSiparisEkrani
            // 
            this.grpSiparisEkrani.Controls.Add(this.gtpSiparis);
            this.grpSiparisEkrani.Controls.Add(this.nudAdet);
            this.grpSiparisEkrani.Controls.Add(this.txtTutarHesapla);
            this.grpSiparisEkrani.Controls.Add(this.btnTutarHesapla);
            this.grpSiparisEkrani.Controls.Add(this.lblUrunAdet);
            this.grpSiparisEkrani.Controls.Add(this.btnSiparisVer);
            this.grpSiparisEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSiparisEkrani.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpSiparisEkrani.Location = new System.Drawing.Point(166, 334);
            this.grpSiparisEkrani.Margin = new System.Windows.Forms.Padding(4);
            this.grpSiparisEkrani.Name = "grpSiparisEkrani";
            this.grpSiparisEkrani.Padding = new System.Windows.Forms.Padding(4);
            this.grpSiparisEkrani.Size = new System.Drawing.Size(906, 234);
            this.grpSiparisEkrani.TabIndex = 6;
            this.grpSiparisEkrani.TabStop = false;
            this.grpSiparisEkrani.Text = "Sipariş Ekranı";
            // 
            // gtpSiparis
            // 
            this.gtpSiparis.Location = new System.Drawing.Point(497, 46);
            this.gtpSiparis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gtpSiparis.Name = "gtpSiparis";
            this.gtpSiparis.Size = new System.Drawing.Size(200, 26);
            this.gtpSiparis.TabIndex = 14;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(119, 46);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(100, 26);
            this.nudAdet.TabIndex = 13;
            // 
            // txtTutarHesapla
            // 
            this.txtTutarHesapla.Location = new System.Drawing.Point(15, 158);
            this.txtTutarHesapla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutarHesapla.Multiline = true;
            this.txtTutarHesapla.Name = "txtTutarHesapla";
            this.txtTutarHesapla.Size = new System.Drawing.Size(204, 33);
            this.txtTutarHesapla.TabIndex = 11;
            // 
            // btnTutarHesapla
            // 
            this.btnTutarHesapla.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTutarHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTutarHesapla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTutarHesapla.Location = new System.Drawing.Point(15, 107);
            this.btnTutarHesapla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTutarHesapla.Name = "btnTutarHesapla";
            this.btnTutarHesapla.Size = new System.Drawing.Size(206, 33);
            this.btnTutarHesapla.TabIndex = 10;
            this.btnTutarHesapla.Text = "Tutar Hesapla";
            this.btnTutarHesapla.UseVisualStyleBackColor = false;
            this.btnTutarHesapla.Click += new System.EventHandler(this.btnTutarHesapla_Click);
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUrunAdet.Location = new System.Drawing.Point(13, 43);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(100, 25);
            this.lblUrunAdet.TabIndex = 8;
            this.lblUrunAdet.Text = "Ürün Adet";
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiparisVer.Location = new System.Drawing.Point(497, 72);
            this.btnSiparisVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(200, 33);
            this.btnSiparisVer.TabIndex = 7;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            this.btnSiparisVer.Click += new System.EventHandler(this.BtnSiparisVer_Click_1);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(35, 4);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 31);
            this.lblKullanici.TabIndex = 7;
            // 
            // cmbIl
            // 
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(12, 110);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(121, 24);
            this.cmbIl.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şehir Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 7;
            // 
            // frmMusteriSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1183, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIl);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.grpSiparisEkrani);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbSiparisEkrani);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMusteriSE";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.FrmMusteriSE_Load);
            this.grbSiparisEkrani.ResumeLayout(false);
            this.grbSiparisEkrani.PerformLayout();
            this.grpSiparisEkrani.ResumeLayout(false);
            this.grpSiparisEkrani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbSiparisEkrani;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunUcreti;
        private System.Windows.Forms.ColumnHeader UrunBoyut;
        private System.Windows.Forms.GroupBox grpSiparisEkrani;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.TextBox txtTutarHesapla;
        private System.Windows.Forms.Button btnTutarHesapla;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.DateTimePicker gtpSiparis;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.ComboBox cmbIl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}