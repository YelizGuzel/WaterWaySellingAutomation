namespace deneme_entity
{
    partial class frmBayiSiparis
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
            this.lstSiparis = new System.Windows.Forms.ListView();
            this.SiparisID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SiparisZamani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeslimZamani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SiparisTutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstSiparis
            // 
            this.lstSiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SiparisID,
            this.SiparisZamani,
            this.TeslimZamani,
            this.SiparisTutar,
            this.MusteriID,
            this.Adres});
            this.lstSiparis.FullRowSelect = true;
            this.lstSiparis.GridLines = true;
            this.lstSiparis.HideSelection = false;
            this.lstSiparis.Location = new System.Drawing.Point(12, 13);
            this.lstSiparis.Margin = new System.Windows.Forms.Padding(4);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(775, 221);
            this.lstSiparis.TabIndex = 5;
            this.lstSiparis.UseCompatibleStateImageBehavior = false;
            this.lstSiparis.View = System.Windows.Forms.View.Details;
            // 
            // SiparisID
            // 
            this.SiparisID.Text = "ID";
            this.SiparisID.Width = 48;
            // 
            // SiparisZamani
            // 
            this.SiparisZamani.Text = "Sipariş Zamanı";
            this.SiparisZamani.Width = 154;
            // 
            // TeslimZamani
            // 
            this.TeslimZamani.Text = "İstenilen Zaman";
            this.TeslimZamani.Width = 146;
            // 
            // SiparisTutar
            // 
            this.SiparisTutar.Text = "Tutar";
            this.SiparisTutar.Width = 58;
            // 
            // MusteriID
            // 
            this.MusteriID.Text = "Müşteri";
            this.MusteriID.Width = 100;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 68;
            // 
            // frmBayiSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.lstSiparis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBayiSiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.frmBayiSiparis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSiparis;
        private System.Windows.Forms.ColumnHeader SiparisID;
        private System.Windows.Forms.ColumnHeader SiparisZamani;
        private System.Windows.Forms.ColumnHeader TeslimZamani;
        private System.Windows.Forms.ColumnHeader SiparisTutar;
        private System.Windows.Forms.ColumnHeader MusteriID;
        private System.Windows.Forms.ColumnHeader Adres;
    }
}