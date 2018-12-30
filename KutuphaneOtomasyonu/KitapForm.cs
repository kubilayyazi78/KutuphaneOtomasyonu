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
    public partial class KitapForm : Form
    {
        public KitapForm()
        {
            InitializeComponent();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {

            MyContext db = new MyContext();
            var yazarlariGetir = db.Yazarlar
                .OrderBy(x => x.YazarAdi)
                .Select(x => new KitapYazarView()
                {
                    YazarAdi = x.YazarAdi,
                    YazarSoyadi = x.YazarSoyadi,
                    YazarId = x.YazarId

                }).ToList();
            cmbYazarId.DataSource = yazarlariGetir.ToList();
            KitaplariGetir();


        }


        private void KitaplariGetir()
        {
            MyContext db = new MyContext();

            lstKitap.DataSource = db.Kitaplar
                .OrderBy(x => x.KitapAdi)
                .Select(x => new KitapView()
                {
                    KitapAdi = x.KitapAdi,
                    Adet = x.Adet,
                    YazarId = x.Yazar.YazarAdi,
                    KitapId = x.KitapId


                }).ToList();

        }
        int yzrId;
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KitapYazarView seciliYazar = (KitapYazarView)cmbYazarId.SelectedItem;
                yzrId = seciliYazar.YazarId;
                MyContext db = new MyContext();
                db.Kitaplar.Add(new Kitap()
                {
                    KitapAdi = txtKitapAdi.Text,
                    Adet = Convert.ToInt32(txtKitapAdeti.Text),
                    YazarId = yzrId
                });
                db.SaveChanges();
                KitaplariGetir();
            }
            catch
            {

                MessageBox.Show("Hatalı Kitap Ekleme İşlemi Yaptınız");
            }


        }

        private void cmsSil_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                if (lstKitap.SelectedItem == null) return;

                var kitapId = (lstKitap.SelectedItem as KitapView).KitapId;
                var kitap = db.Kitaplar.Find(kitapId);
                db.Kitaplar.Remove(kitap);
                MessageBox.Show("Seçili Kitap Silindi");
                db.SaveChanges();
                KitaplariGetir();
            }
            catch
            {

                MessageBox.Show("Hatalı Bir Silme İşlemi Gerçekleştirdiniz");
            }
        }
        int ktpId;
        private void lstKitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitap.SelectedItem == null)
            {
                return;
            }

            MyContext db = new MyContext();
            KitapView seciliKitap = (KitapView)lstKitap.SelectedItem;
            ktpId = seciliKitap.KitapId;
            var kitap = db.Kitaplar.Find(ktpId);
            txtKitapAdi.Text = kitap.KitapAdi;
            txtKitapAdeti.Text = kitap.Adet.ToString();

            var kitapList = cmbYazarId.DataSource as List<KitapYazarView>;
            foreach (var item in kitapList)
            {
                if (item.YazarId == kitap.YazarId)
                {
                    cmbYazarId.SelectedItem = item;
                    break;
                }
            }


        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                KitapView seciliKitap = (KitapView)lstKitap.SelectedItem;
                ktpId = seciliKitap.KitapId;

                var kitap = db.Kitaplar.Find(ktpId);
                kitap.KitapAdi = txtKitapAdi.Text;
                kitap.Adet = Convert.ToInt32(txtKitapAdeti.Text);
                kitap.YazarId = (cmbYazarId.SelectedItem as KitapYazarView).YazarId;
                db.SaveChanges();
                KitaplariGetir();
                MessageBox.Show("Kitap Bilgileri Güncellenmiştir");
            }
            catch
            {
                MessageBox.Show("Kitap Bilgileri Güncellenirken Hata Oluştu");

            }

        }

        private void txtKitapAra_KeyUp(object sender, KeyEventArgs e)
        {
            string arama = txtKitapAra.Text.ToLower();

            MyContext db = new MyContext();
            List<KitapView> bulunanKitaplar = new List<KitapView>();
            db.Kitaplar
                .Where(x => x.KitapAdi.ToLower().Contains(arama) || x.Yazar.YazarAdi.ToLower().Contains(arama))
                .ToList()
                .ForEach(x => bulunanKitaplar.Add(new KitapView()
                {
                    Adet = x.Adet,
                    KitapAdi = x.KitapAdi,
                    YazarId = x.Yazar.YazarAdi,
                    KitapId = x.KitapId
                }));
            lstKitap.DataSource = bulunanKitaplar;
        }
    }
}
