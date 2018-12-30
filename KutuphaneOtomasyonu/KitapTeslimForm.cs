using KutuphaneOtomasyonu.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class KitapTeslimForm : Form
    {
        public KitapTeslimForm()
        {
            InitializeComponent();
        }
        private void btnTeslim_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            if (lstTeslim.SelectedItem == null) return;

            var kitapId = (lstTeslim.SelectedItem as TeslimView).KitapId;
            var uyeId = (lstTeslim.SelectedItem as TeslimView).UyeId;
            var stok = db.Kitaplar.Find(kitapId);
            var ceza = db.Uyeler.Find(uyeId);
            var satir = db.Kiralar.Find(uyeId, kitapId);
            DateTime alinan = satir.AlinanTarih;
            DateTime simdikiZaman = DateTime.Now;
            TimeSpan fark = simdikiZaman - alinan;
            int sonuc = fark.Minutes;
            if (sonuc > 5)
            {
                ceza.Ceza = sonuc * 2;
                db.SaveChanges();
                MessageBox.Show("Kitabı Geç Getirdiğiniz İçin Ceza Verildi");
            }




            stok.Adet++;
            var rawQuery = db.Database.SqlQuery<RawQuery>(
           "delete from Kiralar where UyeId =" + uyeId + " and KitapId =" + kitapId);
            db.SaveChanges();
            lstTeslim.DataSource = rawQuery.ToList();
            MessageBox.Show("Seçili Kitap Teslim Edildi");
            KiraTeslimGetir();


        }

        private void KitapTeslimForm_Load(object sender, EventArgs e)
        {
            KiraTeslimGetir();
        }

        private void KiraTeslimGetir()
        {
            MyContext db = new MyContext();
            lstTeslim.DataSource =
                db.Kiralar
                .OrderBy(x => x.Uye.UyeAdi)
                .Select(x => new TeslimView()
                {
                    UyeId = x.UyeId,
                    KitapId = x.KitapId,
                    KitapAdi = x.Kitap.KitapAdi,
                    UyeAdi = x.Uye.UyeAdi,
                    UyeSoyadi = x.Uye.UyeSoyadi,
                    AlinanTarih = x.AlinanTarih
                }).ToList();
        }

        public class RawQuery
        {
            public int UyeId { get; set; }
            public int KitapId { get; set; }
        }
    }
}
