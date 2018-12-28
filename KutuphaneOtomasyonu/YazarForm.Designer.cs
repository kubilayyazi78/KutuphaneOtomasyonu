namespace KutuphaneOtomasyonu
{
    partial class YazarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.lblYazarSoyadi = new System.Windows.Forms.Label();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.YazarAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YazarSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(418, 395);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYazarEkle.TabIndex = 16;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.Location = new System.Drawing.Point(393, 359);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtYazarSoyadi.TabIndex = 15;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(393, 332);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(100, 20);
            this.txtYazarAdi.TabIndex = 14;
            // 
            // lblYazarSoyadi
            // 
            this.lblYazarSoyadi.AutoSize = true;
            this.lblYazarSoyadi.Location = new System.Drawing.Point(318, 362);
            this.lblYazarSoyadi.Name = "lblYazarSoyadi";
            this.lblYazarSoyadi.Size = new System.Drawing.Size(69, 13);
            this.lblYazarSoyadi.TabIndex = 13;
            this.lblYazarSoyadi.Text = "Yazar Soyadı";
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.AutoSize = true;
            this.lblYazarAdi.Location = new System.Drawing.Point(318, 332);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(52, 13);
            this.lblYazarAdi.TabIndex = 12;
            this.lblYazarAdi.Text = "Yazar Adı";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.YazarAdi,
            this.YazarSoyadi});
            this.listView1.Location = new System.Drawing.Point(-3, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 222);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // YazarAdi
            // 
            this.YazarAdi.Text = "Yazar Adi";
            this.YazarAdi.Width = 120;
            // 
            // YazarSoyadi
            // 
            this.YazarSoyadi.Text = "Yazar Soyadi";
            this.YazarSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YazarSoyadi.Width = 120;
            // 
            // YazarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnYazarEkle);
            this.Controls.Add(this.txtYazarSoyadi);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.lblYazarSoyadi);
            this.Controls.Add(this.lblYazarAdi);
            this.Name = "YazarForm";
            this.Text = "YazarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label lblYazarSoyadi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader YazarAdi;
        private System.Windows.Forms.ColumnHeader YazarSoyadi;
    }
}