namespace deneme_entity
{
    partial class frmBayii
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblUrunStok = new System.Windows.Forms.Label();
            this.lblUrunBoyutu = new System.Windows.Forms.Label();
            this.lblUrunUcreti = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.txtUrunBoyut = new System.Windows.Forms.TextBox();
            this.txtUrunUcreti = new System.Windows.Forms.TextBox();
            this.lstUrun = new System.Windows.Forms.ListView();
            this.UrunID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunUcreti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunBoyutu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(507, 37);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(203, 46);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.Location = new System.Drawing.Point(507, 107);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(203, 46);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(228, 39);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(132, 26);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.lblUrunStok);
            this.groupBox1.Controls.Add(this.lblUrunBoyutu);
            this.groupBox1.Controls.Add(this.lblUrunUcreti);
            this.groupBox1.Controls.Add(this.lblUrunAdi);
            this.groupBox1.Controls.Add(this.btnUrunEkle);
            this.groupBox1.Controls.Add(this.txtUrunStok);
            this.groupBox1.Controls.Add(this.txtUrunBoyut);
            this.groupBox1.Controls.Add(this.txtUrunUcreti);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 349);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1008, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün işlemleri";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(507, 173);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(203, 46);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // lblUrunStok
            // 
            this.lblUrunStok.AutoSize = true;
            this.lblUrunStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunStok.ForeColor = System.Drawing.Color.White;
            this.lblUrunStok.Location = new System.Drawing.Point(52, 202);
            this.lblUrunStok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunStok.Name = "lblUrunStok";
            this.lblUrunStok.Size = new System.Drawing.Size(92, 20);
            this.lblUrunStok.TabIndex = 3;
            this.lblUrunStok.Text = "Ürün Stok";
            // 
            // lblUrunBoyutu
            // 
            this.lblUrunBoyutu.AutoSize = true;
            this.lblUrunBoyutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunBoyutu.ForeColor = System.Drawing.Color.White;
            this.lblUrunBoyutu.Location = new System.Drawing.Point(52, 151);
            this.lblUrunBoyutu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunBoyutu.Name = "lblUrunBoyutu";
            this.lblUrunBoyutu.Size = new System.Drawing.Size(113, 20);
            this.lblUrunBoyutu.TabIndex = 3;
            this.lblUrunBoyutu.Text = "Ürün Boyutu";
            // 
            // lblUrunUcreti
            // 
            this.lblUrunUcreti.AutoSize = true;
            this.lblUrunUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunUcreti.ForeColor = System.Drawing.Color.White;
            this.lblUrunUcreti.Location = new System.Drawing.Point(52, 98);
            this.lblUrunUcreti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunUcreti.Name = "lblUrunUcreti";
            this.lblUrunUcreti.Size = new System.Drawing.Size(106, 20);
            this.lblUrunUcreti.TabIndex = 3;
            this.lblUrunUcreti.Text = "Ürün Ücreti";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.ForeColor = System.Drawing.Color.White;
            this.lblUrunAdi.Location = new System.Drawing.Point(52, 39);
            this.lblUrunAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(82, 20);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunStok.Location = new System.Drawing.Point(228, 193);
            this.txtUrunStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(132, 26);
            this.txtUrunStok.TabIndex = 2;
            // 
            // txtUrunBoyut
            // 
            this.txtUrunBoyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunBoyut.Location = new System.Drawing.Point(228, 143);
            this.txtUrunBoyut.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunBoyut.Name = "txtUrunBoyut";
            this.txtUrunBoyut.Size = new System.Drawing.Size(132, 26);
            this.txtUrunBoyut.TabIndex = 2;
            // 
            // txtUrunUcreti
            // 
            this.txtUrunUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunUcreti.Location = new System.Drawing.Point(228, 90);
            this.txtUrunUcreti.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunUcreti.Name = "txtUrunUcreti";
            this.txtUrunUcreti.Size = new System.Drawing.Size(132, 26);
            this.txtUrunUcreti.TabIndex = 2;
            // 
            // lstUrun
            // 
            this.lstUrun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunID,
            this.UrunAdi,
            this.UrunUcreti,
            this.UrunBoyutu,
            this.UrunStok});
            this.lstUrun.FullRowSelect = true;
            this.lstUrun.GridLines = true;
            this.lstUrun.HideSelection = false;
            this.lstUrun.Location = new System.Drawing.Point(1, 120);
            this.lstUrun.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(1007, 221);
            this.lstUrun.TabIndex = 4;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            this.lstUrun.View = System.Windows.Forms.View.Details;
            // 
            // UrunID
            // 
            this.UrunID.Text = "ID";
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ad";
            this.UrunAdi.Width = 187;
            // 
            // UrunUcreti
            // 
            this.UrunUcreti.Text = "Ücret";
            this.UrunUcreti.Width = 85;
            // 
            // UrunBoyutu
            // 
            this.UrunBoyutu.Text = "Boyut";
            this.UrunBoyutu.Width = 134;
            // 
            // UrunStok
            // 
            this.UrunStok.Text = "Stok";
            this.UrunStok.Width = 246;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 36);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            this.siparişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişleriGösterToolStripMenuItem});
            this.siparişİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.siparişİşlemleriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            this.siparişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // siparişleriGösterToolStripMenuItem
            // 
            this.siparişleriGösterToolStripMenuItem.Name = "siparişleriGösterToolStripMenuItem";
            this.siparişleriGösterToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.siparişleriGösterToolStripMenuItem.Text = "Siparişleri Göster";
            this.siparişleriGösterToolStripMenuItem.Click += new System.EventHandler(this.SiparişleriGösterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hosgeldin";
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.AutoSize = true;
            this.lblSirketAdi.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketAdi.ForeColor = System.Drawing.Color.White;
            this.lblSirketAdi.Location = new System.Drawing.Point(439, 57);
            this.lblSirketAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(148, 41);
            this.lblSirketAdi.TabIndex = 3;
            this.lblSirketAdi.Text = "Hosgeldin";
            // 
            // frmBayii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 692);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblSirketAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBayii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmBayii_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUrunUcreti;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunBoyut;
        private System.Windows.Forms.TextBox txtUrunUcreti;
        private System.Windows.Forms.Label lblUrunStok;
        private System.Windows.Forms.Label lblUrunBoyutu;
        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.ColumnHeader UrunID;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunUcreti;
        private System.Windows.Forms.ColumnHeader UrunBoyutu;
        private System.Windows.Forms.ColumnHeader UrunStok;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişleriGösterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSirketAdi;
    }
}