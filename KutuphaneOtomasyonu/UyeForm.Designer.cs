namespace KutuphaneOtomasyonu
{
    partial class UyeForm
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
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.txtUyeTc = new System.Windows.Forms.TextBox();
            this.txtUyeSoyadi = new System.Windows.Forms.TextBox();
            this.txtUyeAdi = new System.Windows.Forms.TextBox();
            this.lblUyeTc = new System.Windows.Forms.Label();
            this.lblUyeAdi = new System.Windows.Forms.Label();
            this.lblUyeSoyadi = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.UyeAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyeSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyeTcKimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyeCeza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(395, 415);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUyeEkle.TabIndex = 29;
            this.btnUyeEkle.Text = "Uye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            // 
            // txtUyeTc
            // 
            this.txtUyeTc.Location = new System.Drawing.Point(370, 372);
            this.txtUyeTc.Name = "txtUyeTc";
            this.txtUyeTc.Size = new System.Drawing.Size(100, 20);
            this.txtUyeTc.TabIndex = 27;
            // 
            // txtUyeSoyadi
            // 
            this.txtUyeSoyadi.Location = new System.Drawing.Point(370, 342);
            this.txtUyeSoyadi.Name = "txtUyeSoyadi";
            this.txtUyeSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtUyeSoyadi.TabIndex = 26;
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Location = new System.Drawing.Point(370, 310);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUyeAdi.TabIndex = 25;
            // 
            // lblUyeTc
            // 
            this.lblUyeTc.AutoSize = true;
            this.lblUyeTc.Location = new System.Drawing.Point(292, 379);
            this.lblUyeTc.Name = "lblUyeTc";
            this.lblUyeTc.Size = new System.Drawing.Size(72, 13);
            this.lblUyeTc.TabIndex = 24;
            this.lblUyeTc.Text = "Uye Tc Kimlik";
            // 
            // lblUyeAdi
            // 
            this.lblUyeAdi.AutoSize = true;
            this.lblUyeAdi.Location = new System.Drawing.Point(292, 313);
            this.lblUyeAdi.Name = "lblUyeAdi";
            this.lblUyeAdi.Size = new System.Drawing.Size(44, 13);
            this.lblUyeAdi.TabIndex = 23;
            this.lblUyeAdi.Text = "Uye Adı";
            // 
            // lblUyeSoyadi
            // 
            this.lblUyeSoyadi.AutoSize = true;
            this.lblUyeSoyadi.Location = new System.Drawing.Point(292, 349);
            this.lblUyeSoyadi.Name = "lblUyeSoyadi";
            this.lblUyeSoyadi.Size = new System.Drawing.Size(61, 13);
            this.lblUyeSoyadi.TabIndex = 22;
            this.lblUyeSoyadi.Text = "Uye Soyadı";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UyeAdi,
            this.UyeSoyadi,
            this.UyeTcKimlik,
            this.UyeCeza});
            this.listView1.Location = new System.Drawing.Point(3, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 257);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // UyeAdi
            // 
            this.UyeAdi.Text = "Uye Adi";
            this.UyeAdi.Width = 120;
            // 
            // UyeSoyadi
            // 
            this.UyeSoyadi.Text = "Uye Soyadi";
            this.UyeSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UyeSoyadi.Width = 120;
            // 
            // UyeTcKimlik
            // 
            this.UyeTcKimlik.Text = "Tc Kimlik No";
            this.UyeTcKimlik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UyeTcKimlik.Width = 120;
            // 
            // UyeCeza
            // 
            this.UyeCeza.Text = "Ceza";
            this.UyeCeza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UyeCeza.Width = 120;
            // 
            // UyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.txtUyeTc);
            this.Controls.Add(this.txtUyeSoyadi);
            this.Controls.Add(this.txtUyeAdi);
            this.Controls.Add(this.lblUyeTc);
            this.Controls.Add(this.lblUyeAdi);
            this.Controls.Add(this.lblUyeSoyadi);
            this.Name = "UyeForm";
            this.Text = "UyeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.TextBox txtUyeTc;
        private System.Windows.Forms.TextBox txtUyeSoyadi;
        private System.Windows.Forms.TextBox txtUyeAdi;
        private System.Windows.Forms.Label lblUyeTc;
        private System.Windows.Forms.Label lblUyeAdi;
        private System.Windows.Forms.Label lblUyeSoyadi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader UyeAdi;
        private System.Windows.Forms.ColumnHeader UyeSoyadi;
        private System.Windows.Forms.ColumnHeader UyeTcKimlik;
        private System.Windows.Forms.ColumnHeader UyeCeza;
    }
}