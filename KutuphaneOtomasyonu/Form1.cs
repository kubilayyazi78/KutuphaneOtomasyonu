using KutuphaneOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyContext db = new MyContext();

            
        }
        public virtual DbSet<Kitap> Kitaplar { get; set; }

        private void uyeIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeForm uyeForm = new UyeForm();
            uyeForm.MdiParent = this;
            uyeForm.Show();
        }

        private void yazarİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazarForm yazarForm = new YazarForm();
            yazarForm.MdiParent = this;
            yazarForm.Show();
        }

        private void kitapİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapForm kitapForm = new KitapForm();
            kitapForm.MdiParent = this;
            kitapForm.Show();
        }

        private void kitapKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapKiralaForm kitapKiralaForm = new KitapKiralaForm();
            kitapKiralaForm.MdiParent = this;
            kitapKiralaForm.Show();
        }

        private void kitapTeslimEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapTeslimForm kitapTeslimForm = new KitapTeslimForm();
            kitapTeslimForm.MdiParent = this;
            kitapTeslimForm.Show();
        }
    }
}
