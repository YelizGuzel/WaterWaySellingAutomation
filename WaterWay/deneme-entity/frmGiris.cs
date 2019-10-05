using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_entity
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void BayiGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBayiGiris frm = new frmBayiGiris();
            frm.Show();
        }

        private void MüsteriGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriGiris frm = new frmMüsteriGiris();
            frm.Show();
        }

        private void AdminGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminGiris frm = new frmAdminGiris();
            frm.Show();

        }
    }
}
