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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }


        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = Singleton.Context.Admin.Where(m => m.KullaniciAdi == txtKullaniciAdi.Text && m.Parola == txtParola.Text).FirstOrDefault();

            try
            {


                if (sorgu == null)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    return;
                }
                else
                {
                    frmAdminSayfasi frm = new frmAdminSayfasi();
                    frm.Show();
                    this.Close();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("HATA");
            }
        }
    }
}
