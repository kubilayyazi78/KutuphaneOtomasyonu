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
    public partial class YazarForm : Form
    {
        public YazarForm()
        {
            InitializeComponent();
        }

        private void YazarForm_Load(object sender, EventArgs e)
        {
            YazarGetir();

        }

        private void YazarGetir()
        {
            MyContext db = new MyContext();

            lstYazarlar.DataSource = db.Yazarlar
                .OrderBy(x => x.YazarAdi)
                .Select(x => new YazarView()
                {
                    YazarAdi = x.YazarAdi,
                    YazarSoyadi = x.YazarSoyadi,
                    YazarId =x.YazarId
                     
                }).ToList();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {

            try
            {
                MyContext db = new MyContext();
                db.Yazarlar.Add(new Yazar()
                {
                    YazarAdi = txtYazarAdi.Text,
                    YazarSoyadi = txtYazarSoyadi.Text
                });

                db.SaveChanges();
                YazarGetir();
            }
            catch 
            {
               MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }
        
        private void cmsSil_Click(object sender, EventArgs e)
        {

            try
            {
                MyContext db = new MyContext();
                if (lstYazarlar.SelectedItem == null) return;

                var yazarId = (lstYazarlar.SelectedItem as YazarView).YazarId;
                var yazar = db.Yazarlar.Find(yazarId);
                db.Yazarlar.Remove(yazar);
                MessageBox.Show("Seçili Yazar Silindi");
                db.SaveChanges();
                YazarGetir();
            }
            catch 
            {

                MessageBox.Show("Hatalı Bir Silme İşlemi Gerçekleştirdiniz");
            }
        }
    }
}
