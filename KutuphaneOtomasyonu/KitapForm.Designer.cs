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
            this.components = new System.ComponentModel.Container();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.cmbYazarId = new System.Windows.Forms.ComboBox();
            this.txtKitapAdeti = new System.Windows.Forms.TextBox();
            this.lblKitapAdeti = new System.Windows.Forms.Label();
            this.lblYazarId = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.lstKitap = new System.Windows.Forms.ListBox();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(734, 190);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(184, 35);
            this.txtKitapAdi.TabIndex = 13;
            // 
            // cmbYazarId
            // 
            this.cmbYazarId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYazarId.FormattingEnabled = true;
            this.cmbYazarId.Location = new System.Drawing.Point(735, 232);
            this.cmbYazarId.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYazarId.Name = "cmbYazarId";
            this.cmbYazarId.Size = new System.Drawing.Size(183, 37);
            this.cmbYazarId.TabIndex = 12;
            // 
            // txtKitapAdeti
            // 
            this.txtKitapAdeti.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdeti.Location = new System.Drawing.Point(733, 275);
            this.txtKitapAdeti.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdeti.Name = "txtKitapAdeti";
            this.txtKitapAdeti.Size = new System.Drawing.Size(185, 35);
            this.txtKitapAdeti.TabIndex = 11;
            // 
            // lblKitapAdeti
            // 
            this.lblKitapAdeti.AutoSize = true;
            this.lblKitapAdeti.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdeti.Location = new System.Drawing.Point(602, 276);
            this.lblKitapAdeti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitapAdeti.Name = "lblKitapAdeti";
            this.lblKitapAdeti.Size = new System.Drawing.Size(124, 29);
            this.lblKitapAdeti.TabIndex = 10;
            this.lblKitapAdeti.Text = "Kitap Adeti";
            // 
            // lblYazarId
            // 
            this.lblYazarId.AutoSize = true;
            this.lblYazarId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarId.Location = new System.Drawing.Point(602, 235);
            this.lblYazarId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazarId.Name = "lblYazarId";
            this.lblYazarId.Size = new System.Drawing.Size(111, 29);
            this.lblYazarId.TabIndex = 9;
            this.lblYazarId.Text = "Yazar Adı";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.Location = new System.Drawing.Point(602, 196);
            this.lblKitapAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(113, 29);
            this.lblKitapAdi.TabIndex = 8;
            this.lblKitapAdi.Text = "Kitap Adı ";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Location = new System.Drawing.Point(734, 318);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(184, 46);
            this.btnKitapEkle.TabIndex = 7;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // lstKitap
            // 
            this.lstKitap.ContextMenuStrip = this.cmsSil;
            this.lstKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKitap.FormattingEnabled = true;
            this.lstKitap.ItemHeight = 20;
            this.lstKitap.Location = new System.Drawing.Point(25, 100);
            this.lstKitap.Name = "lstKitap";
            this.lstKitap.Size = new System.Drawing.Size(500, 244);
            this.lstKitap.TabIndex = 14;
            this.lstKitap.SelectedIndexChanged += new System.EventHandler(this.lstKitap_SelectedIndexChanged);
            // 
            // cmsSil
            // 
            this.cmsSil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(95, 28);
            this.cmsSil.Click += new System.EventHandler(this.cmsSil_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGuncelle.Location = new System.Drawing.Point(734, 128);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(184, 43);
            this.btnKitapGuncelle.TabIndex = 16;
            this.btnKitapGuncelle.Text = "Kitap Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAra.Location = new System.Drawing.Point(733, 77);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(185, 35);
            this.txtKitapAra.TabIndex = 17;
            this.txtKitapAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKitapAra_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.kitap;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.btnKitapGuncelle);
            this.Controls.Add(this.lstKitap);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.cmbYazarId);
            this.Controls.Add(this.txtKitapAdeti);
            this.Controls.Add(this.lblKitapAdeti);
            this.Controls.Add(this.lblYazarId);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.btnKitapEkle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KitapForm";
            this.Text = "KitapForm";
            this.Load += new System.EventHandler(this.KitapForm_Load);
            this.cmsSil.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.ListBox lstKitap;
        private System.Windows.Forms.ContextMenuStrip cmsSil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}