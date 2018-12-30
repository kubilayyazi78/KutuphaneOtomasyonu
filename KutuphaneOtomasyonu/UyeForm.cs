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
    public partial class UyeForm : Form
    {
        public UyeForm()
        {
            InitializeComponent();
        }

        private void UyeForm_Load(object sender, EventArgs e)
        {
            UyeleriGetir();

        }

        private void UyeleriGetir()
        {
            MyContext db = new MyContext();
            lstUye.DataSource = db.Uyeler
                .OrderBy(x => x.UyeAdi)
                .Select(x => new UyeView()
                {
                    UyeId = x.UyeId,
                    UyeAdi = x.UyeAdi,
                    UyeSoyadi = x.UyeSoyadi,
                    Ceza = x.Ceza,
                    TcKimlik = x.TcKimlik
                }).ToList();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {

            try
            {
                MyContext db = new MyContext();
                db.Uyeler.Add(new Uye()
                {
                    UyeAdi = txtUyeAdi.Text,
                    UyeSoyadi = txtUyeSoyadi.Text,
                    TcKimlik = txtUyeTc.Text,
                });
                db.SaveChanges();
                UyeleriGetir();
            }
            catch
            {

                MessageBox.Show("Üye Ekleme İşleminizde Hata Oluştu");
            }
        }

        private void cmsSil_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                if (lstUye.SelectedItem == null) return;

                var uyeId = (lstUye.SelectedItem as UyeView).UyeId;
                var uye = db.Uyeler.Find(uyeId);
                db.Uyeler.Remove(uye);
                MessageBox.Show("Seçili Yazar Silindi");
                db.SaveChanges();
                UyeleriGetir();
            }
            catch
            {

                MessageBox.Show("Hatalı Bir Silme İşlemi Gerçekleştirdiniz");
            }
        }
        int uyId;
        private void lstUye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUye.SelectedItem == null)
            {
                return;
            }

            MyContext db = new MyContext();
            UyeView seciliUye = (UyeView)lstUye.SelectedItem;
            uyId = seciliUye.UyeId;
            var uye = db.Uyeler.Find(uyId);
            txtUyeAdi.Text = uye.UyeAdi;
            txtUyeSoyadi.Text = uye.UyeSoyadi;
            txtUyeTc.Text = uye.TcKimlik;

        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                UyeView seciliUye = (UyeView)lstUye.SelectedItem;
                uyId = seciliUye.UyeId;

                var uye = db.Uyeler.Find(uyId);
                uye.UyeAdi = txtUyeAdi.Text;
                uye.UyeSoyadi = txtUyeSoyadi.Text;
                uye.TcKimlik = txtUyeTc.Text;
                db.SaveChanges();
                UyeleriGetir();
                MessageBox.Show("Üye Bilgileri Güncellenmiştir");
            }
            catch
            {
                MessageBox.Show("Üye Bilgileri Güncellenirken Hata Oluştu");

            }
        }

        private void txtUyeArama_KeyUp(object sender, KeyEventArgs e)
        {
            string arama = txtUyeArama.Text.ToLower();

            MyContext db = new MyContext();
            List<UyeView> bulunanUyeler = new List<UyeView>();
            db.Uyeler
                .Where(x => x.UyeAdi.ToLower().Contains(arama) || x.UyeSoyadi.ToLower().Contains(arama))
                .ToList()
                .ForEach(x => bulunanUyeler.Add(new UyeView()
                {
                    UyeSoyadi = x.UyeSoyadi,
                    UyeAdi = x.UyeAdi,
                    UyeId = x.UyeId,
                    Ceza = x.Ceza,
                    TcKimlik = x.TcKimlik

                }));
            lstUye.DataSource = bulunanUyeler;
        }
    }
}
