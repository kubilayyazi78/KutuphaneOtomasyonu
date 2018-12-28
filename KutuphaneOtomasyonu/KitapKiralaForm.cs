using KutuphaneOtomasyonu.Entities;
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
            MyContext db = new MyContext();

            var sorguKira = from kira in db.Kiralar
                            join u in db.Uyeler on kira.UyeId equals u.UyeId
                            join k in db.Kitaplar on kira.KitapId equals k.KitapId
                            select new
                            {
                                kira.KitapId,
                                kira.UyeId,
                                kira.AlinanTarih

                            };

            ListViewItem lvItem = new ListViewItem();

            var kiralar = db.Kiralar.ToList();
            foreach (var item in kiralar)
            {
                lvItem.SubItems.Add(item.KitapId.ToString());
                lvItem.SubItems.Add(item.UyeId.ToString());
                lvItem.SubItems.Add(item.AlinanTarih.ToString());

            }
            

            cmbUyeAdi.DataSource = db.Uyeler.OrderBy(x => x.UyeAdi).ToList();
            cmbUyeAdi.DisplayMember = "UyeAdi";

            cmbKitapAdi.DataSource = db.Kitaplar.OrderBy(x => x.KitapAdi).ThenBy(x => x.Yazar.YazarAdi).ToList();
          


        }
    }
}
