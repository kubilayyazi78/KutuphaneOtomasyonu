using KutuphaneOtomasyonu.Entities;
using KutuphaneOtomasyonu.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class KitapKiralaForm : Form
    {
        public KitapKiralaForm()
        {
            InitializeComponent();
        }

        private void KitapKiralaForm_Load(object sender, EventArgs e)
        {
            MyContext db = KiraGetir();
            var uyeAdi = db.Uyeler
                 .OrderBy(x => x.UyeAdi)
                 .Select(x => new UyeKiraView()
                 {
                     UyeId = x.UyeId,
                     UyeAdi = x.UyeAdi,
                     UyeSoyadi = x.UyeSoyadi

                 }).ToList();
            cmbUyeAdi.DataSource = uyeAdi.ToList();

            
            var kitapAdi = db.Kitaplar
                 .Select(x => new KitapUyeView()
                 {
                     KitapAdi = x.KitapAdi,
                     KitapId = x.KitapId,
                 }).ToList();
            cmbKitapAdi.DataSource = kitapAdi.ToList();
            cmbKitapAdi.DisplayMember = "KitapAdi";
        }

        private MyContext KiraGetir()
        {
            MyContext db = new MyContext();
            dgvKirala.DataSource =
                db.Kiralar
                .OrderBy(x => x.Uye.UyeAdi)
                .Select(x => new KiralaView()
                {
                    UyeId = x.Uye.UyeAdi,
                    KitapId = x.Kitap.KitapAdi,
                    AlinanTarih = x.AlinanTarih
                }).ToList();
            return db;
        }

        int ktpId;
        int uyId;
        private void btnKirala_Click(object sender, EventArgs e)
        {
            KitapUyeView seciliKitap = (KitapUyeView)cmbKitapAdi.SelectedItem;
            ktpId = seciliKitap.KitapId;
            UyeKiraView seciliUye = (UyeKiraView)cmbUyeAdi.SelectedItem;
            uyId = seciliUye.UyeId;
            MyContext db = new MyContext();
            db.Kiralar.Add(new Kira()
            {
                KitapId = ktpId,
                UyeId = uyId
            });
         
            KiraGetir();

            var stok = db.Kitaplar.Find(ktpId);
            
            if (stok.Adet>0)
            {
                stok.Adet--;
               
                db.SaveChanges();
                KiraGetir();
            }
            else if (stok.Adet ==0)
            {
                MessageBox.Show("Seçilen Kitap Kütüphanemizde Kalmamıştır.");
            }
            
            
        }
    }
}
