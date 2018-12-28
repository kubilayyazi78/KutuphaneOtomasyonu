namespace KutuphaneOtomasyonu
{
    partial class KitapForm
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
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.cmbYazarId = new System.Windows.Forms.ComboBox();
            this.txtKitapAdeti = new System.Windows.Forms.TextBox();
            this.lblKitapAdeti = new System.Windows.Forms.Label();
            this.lblYazarId = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstKitap = new System.Windows.Forms.ListView();
            this.KitapAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YazarAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitapAdeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(356, 269);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdi.TabIndex = 13;
            // 
            // cmbYazarId
            // 
            this.cmbYazarId.FormattingEnabled = true;
            this.cmbYazarId.Location = new System.Drawing.Point(356, 305);
            this.cmbYazarId.Name = "cmbYazarId";
            this.cmbYazarId.Size = new System.Drawing.Size(121, 21);
            this.cmbYazarId.TabIndex = 12;
            // 
            // txtKitapAdeti
            // 
            this.txtKitapAdeti.Location = new System.Drawing.Point(356, 334);
            this.txtKitapAdeti.Name = "txtKitapAdeti";
            this.txtKitapAdeti.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdeti.TabIndex = 11;
            // 
            // lblKitapAdeti
            // 
            this.lblKitapAdeti.AutoSize = true;
            this.lblKitapAdeti.Location = new System.Drawing.Point(292, 341);
            this.lblKitapAdeti.Name = "lblKitapAdeti";
            this.lblKitapAdeti.Size = new System.Drawing.Size(58, 13);
            this.lblKitapAdeti.TabIndex = 10;
            this.lblKitapAdeti.Text = "Kitap Adeti";
            // 
            // lblYazarId
            // 
            this.lblYazarId.AutoSize = true;
            this.lblYazarId.Location = new System.Drawing.Point(292, 308);
            this.lblYazarId.Name = "lblYazarId";
            this.lblYazarId.Size = new System.Drawing.Size(52, 13);
            this.lblYazarId.TabIndex = 9;
            this.lblYazarId.Text = "Yazar Adı";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(292, 276);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(52, 13);
            this.lblKitapAdi.TabIndex = 8;
            this.lblKitapAdi.Text = "Kitap Adı ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstKitap
            // 
            this.lstKitap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KitapAdi,
            this.YazarAdi,
            this.KitapAdeti});
            this.lstKitap.Location = new System.Drawing.Point(12, 12);
            this.lstKitap.Name = "lstKitap";
            this.lstKitap.Size = new System.Drawing.Size(776, 236);
            this.lstKitap.TabIndex = 14;
            this.lstKitap.UseCompatibleStateImageBehavior = false;
            this.lstKitap.View = System.Windows.Forms.View.Details;
            // 
            // KitapAdi
            // 
            this.KitapAdi.Text = "Kitap Adı";
            this.KitapAdi.Width = 120;
            // 
            // YazarAdi
            // 
            this.YazarAdi.Text = "Yazar Adı";
            this.YazarAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YazarAdi.Width = 120;
            // 
            // KitapAdeti
            // 
            this.KitapAdeti.Text = "Kitap Adeti";
            this.KitapAdeti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KitapAdeti.Width = 120;
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKitap);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.cmbYazarId);
            this.Controls.Add(this.txtKitapAdeti);
            this.Controls.Add(this.lblKitapAdeti);
            this.Controls.Add(this.lblYazarId);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.button1);
            this.Name = "KitapForm";
            this.Text = "KitapForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.ComboBox cmbYazarId;
        private System.Windows.Forms.TextBox txtKitapAdeti;
        private System.Windows.Forms.Label lblKitapAdeti;
        private System.Windows.Forms.Label lblYazarId;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstKitap;
        private System.Windows.Forms.ColumnHeader KitapAdi;
        private System.Windows.Forms.ColumnHeader YazarAdi;
        private System.Windows.Forms.ColumnHeader KitapAdeti;
    }
}