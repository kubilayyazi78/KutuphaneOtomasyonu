﻿namespace KutuphaneOtomasyonu
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
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(475, 331);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(160, 22);
            this.txtKitapAdi.TabIndex = 13;
            // 
            // cmbYazarId
            // 
            this.cmbYazarId.FormattingEnabled = true;
            this.cmbYazarId.Location = new System.Drawing.Point(475, 375);
            this.cmbYazarId.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYazarId.Name = "cmbYazarId";
            this.cmbYazarId.Size = new System.Drawing.Size(160, 24);
            this.cmbYazarId.TabIndex = 12;
            // 
            // txtKitapAdeti
            // 
            this.txtKitapAdeti.Location = new System.Drawing.Point(475, 411);
            this.txtKitapAdeti.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdeti.Name = "txtKitapAdeti";
            this.txtKitapAdeti.Size = new System.Drawing.Size(160, 22);
            this.txtKitapAdeti.TabIndex = 11;
            // 
            // lblKitapAdeti
            // 
            this.lblKitapAdeti.AutoSize = true;
            this.lblKitapAdeti.Location = new System.Drawing.Point(389, 420);
            this.lblKitapAdeti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitapAdeti.Name = "lblKitapAdeti";
            this.lblKitapAdeti.Size = new System.Drawing.Size(76, 17);
            this.lblKitapAdeti.TabIndex = 10;
            this.lblKitapAdeti.Text = "Kitap Adeti";
            // 
            // lblYazarId
            // 
            this.lblYazarId.AutoSize = true;
            this.lblYazarId.Location = new System.Drawing.Point(389, 379);
            this.lblYazarId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazarId.Name = "lblYazarId";
            this.lblYazarId.Size = new System.Drawing.Size(69, 17);
            this.lblYazarId.TabIndex = 9;
            this.lblYazarId.Text = "Yazar Adı";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(389, 340);
            this.lblKitapAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(68, 17);
            this.lblKitapAdi.TabIndex = 8;
            this.lblKitapAdi.Text = "Kitap Adı ";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(536, 459);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(100, 28);
            this.btnKitapEkle.TabIndex = 7;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // lstKitap
            // 
            this.lstKitap.ContextMenuStrip = this.cmsSil;
            this.lstKitap.FormattingEnabled = true;
            this.lstKitap.ItemHeight = 16;
            this.lstKitap.Location = new System.Drawing.Point(12, 24);
            this.lstKitap.Name = "lstKitap";
            this.lstKitap.Size = new System.Drawing.Size(1043, 212);
            this.lstKitap.TabIndex = 14;
            // 
            // cmsSil
            // 
            this.cmsSil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(211, 56);
            this.cmsSil.Click += new System.EventHandler(this.cmsSil_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
    }
}