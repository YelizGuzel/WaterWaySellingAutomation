﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace deneme_entity
{
    public partial class frmBayiGiris : Form
    {


        public frmBayiGiris()
        {
            InitializeComponent();

        }



        private void BtnGiris_Click(object sender, EventArgs e)
        {


            var sirket = Singleton.Context.Sirket.Where(m => m.SirketAdi == txtKullaniciAdi.Text && m.Parola == txtParola.Text).FirstOrDefault();
           
            try
            {


                if (sirket == null)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    return;
                }
                else
                {
                    
                    frmBayii frm = new frmBayii(sirket);
                    frm.Show();
                    this.Close();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("HATA");
            }


            

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            frmKayit frm = new frmKayit();
            frm.Show();
        }

      
    }
}
