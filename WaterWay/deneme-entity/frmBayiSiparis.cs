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
    public partial class frmBayiSiparis : Form
    {
        public frmBayiSiparis()
        {
            InitializeComponent();
        }

        private void frmBayiSiparis_Load(object sender, EventArgs e)
        {

            var siparis = Singleton.Context.Siparis
                .Join(Singleton.Context.Müsteri, s => s.MusteriID, m => m.MusteriID, (s, m) =>
                       new {
                           s.SiparisID,
                           s.SiparisZamani,
                           s.TeslimZamani,
                           s.SiparisTutar,
                           AdSoyad = m.MusteriAd + " " + m.MusteriSoyad,
                          Adres= Singleton.Context.Adres.Where(a => a.AdresID == (m.AdresID)).Select(a => a.Il + " " + a.Ilce).FirstOrDefault()
                }
                ).ToList();


            foreach (var item in siparis)
            {
                string[] degerler = new string[6]
                {
                    item.SiparisID.ToString(),
                    item.SiparisZamani.ToString(),
                    item.TeslimZamani==null?"":item.TeslimZamani.ToString(),
                    item.SiparisTutar==null?"":item.SiparisTutar.ToString(),
                    item.AdSoyad.ToString(),
                    item.Adres
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lstSiparis.Items.Add(viewItem);
            }
        }
    }
}
