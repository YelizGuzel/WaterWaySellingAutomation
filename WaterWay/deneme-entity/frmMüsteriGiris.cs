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
    
    public partial class frmMüsteriGiris : Form
    {
        public static string _kullaniciAdi;
        public frmMüsteriGiris()
        {
            InitializeComponent();
            _kullaniciAdi = "";
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            frmKayit frm = new frmKayit();
            frm.Show();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var müsteri = Singleton.Context.Müsteri.Where(m => m.MusteriAd == txtKullaniciAdi.Text && m.Parola == txtParola.Text).FirstOrDefault();
            
            try
            {
                if (müsteri == null)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    return;
                }
                else
                {
                    //_kullaniciAdi = müsteri.MusteriAd;

                    ////müsteri.Roller.where(r=> r.Ad=="Admin").FirstOrDefault();
                    //MessageBox.Show(müsteri.MusteriID.ToString());
                    frmMusteriSE frm = new frmMusteriSE(müsteri);
                    frm.Show();
                    this.Close();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("HATA");
            }
        }

        private void FrmMüsteriGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
