namespace deneme_entity
{
    partial class frmGiris
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminGirisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayiGirisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriGirisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminGirisToolStripMenuItem,
            this.bayiGirisToolStripMenuItem,
            this.müsteriGirisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1496, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminGirisToolStripMenuItem
            // 
            this.adminGirisToolStripMenuItem.Name = "adminGirisToolStripMenuItem";
            this.adminGirisToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.adminGirisToolStripMenuItem.Text = "Admin Giriş";
            this.adminGirisToolStripMenuItem.Click += new System.EventHandler(this.AdminGirisToolStripMenuItem_Click);
            // 
            // bayiGirisToolStripMenuItem
            // 
            this.bayiGirisToolStripMenuItem.Name = "bayiGirisToolStripMenuItem";
            this.bayiGirisToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.bayiGirisToolStripMenuItem.Text = "Bayi Giriş";
            this.bayiGirisToolStripMenuItem.Click += new System.EventHandler(this.BayiGirisToolStripMenuItem_Click);
            // 
            // müsteriGirisToolStripMenuItem
            // 
            this.müsteriGirisToolStripMenuItem.Name = "müsteriGirisToolStripMenuItem";
            this.müsteriGirisToolStripMenuItem.Size = new System.Drawing.Size(126, 27);
            this.müsteriGirisToolStripMenuItem.Text = "Müsteri Giriş";
            this.müsteriGirisToolStripMenuItem.Click += new System.EventHandler(this.MüsteriGirisToolStripMenuItem_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deneme_entity.Properties.Resources.the_tide_inside_infographic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1496, 817);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bayiGirisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriGirisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminGirisToolStripMenuItem;
    }
}