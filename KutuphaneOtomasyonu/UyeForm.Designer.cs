﻿namespace KutuphaneOtomasyonu
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
            this.components = new System.ComponentModel.Container();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.txtUyeTc = new System.Windows.Forms.TextBox();
            this.txtUyeSoyadi = new System.Windows.Forms.TextBox();
            this.txtUyeAdi = new System.Windows.Forms.TextBox();
            this.lblUyeTc = new System.Windows.Forms.Label();
            this.lblUyeAdi = new System.Windows.Forms.Label();
            this.lblUyeSoyadi = new System.Windows.Forms.Label();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstUye = new System.Windows.Forms.ListBox();
            this.btnUyeGuncelle = new System.Windows.Forms.Button();
            this.txtUyeArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCeza = new System.Windows.Forms.Label();
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkle.Location = new System.Drawing.Point(722, 348);
            this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(170, 35);
            this.btnUyeEkle.TabIndex = 29;
            this.btnUyeEkle.Text = "Uye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // txtUyeTc
            // 
            this.txtUyeTc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeTc.Location = new System.Drawing.Point(722, 301);
            this.txtUyeTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtUyeTc.Name = "txtUyeTc";
            this.txtUyeTc.Size = new System.Drawing.Size(170, 35);
            this.txtUyeTc.TabIndex = 27;
            // 
            // txtUyeSoyadi
            // 
            this.txtUyeSoyadi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeSoyadi.Location = new System.Drawing.Point(722, 251);
            this.txtUyeSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUyeSoyadi.Name = "txtUyeSoyadi";
            this.txtUyeSoyadi.Size = new System.Drawing.Size(170, 35);
            this.txtUyeSoyadi.TabIndex = 26;
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeAdi.Location = new System.Drawing.Point(722, 200);
            this.txtUyeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(170, 35);
            this.txtUyeAdi.TabIndex = 25;
            // 
            // lblUyeTc
            // 
            this.lblUyeTc.AutoSize = true;
            this.lblUyeTc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeTc.Location = new System.Drawing.Point(568, 304);
            this.lblUyeTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeTc.Name = "lblUyeTc";
            this.lblUyeTc.Size = new System.Drawing.Size(148, 29);
            this.lblUyeTc.TabIndex = 24;
            this.lblUyeTc.Text = "Uye Tc Kimlik";
            // 
            // lblUyeAdi
            // 
            this.lblUyeAdi.AutoSize = true;
            this.lblUyeAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeAdi.Location = new System.Drawing.Point(577, 206);
            this.lblUyeAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeAdi.Name = "lblUyeAdi";
            this.lblUyeAdi.Size = new System.Drawing.Size(92, 29);
            this.lblUyeAdi.TabIndex = 23;
            this.lblUyeAdi.Text = "Uye Adı";
            // 
            // lblUyeSoyadi
            // 
            this.lblUyeSoyadi.AutoSize = true;
            this.lblUyeSoyadi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeSoyadi.Location = new System.Drawing.Point(577, 254);
            this.lblUyeSoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeSoyadi.Name = "lblUyeSoyadi";
            this.lblUyeSoyadi.Size = new System.Drawing.Size(124, 29);
            this.lblUyeSoyadi.TabIndex = 22;
            this.lblUyeSoyadi.Text = "Uye Soyadı";
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
            // lstUye
            // 
            this.lstUye.ContextMenuStrip = this.cmsSil;
            this.lstUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUye.FormattingEnabled = true;
            this.lstUye.ItemHeight = 20;
            this.lstUye.Location = new System.Drawing.Point(25, 100);
            this.lstUye.Name = "lstUye";
            this.lstUye.Size = new System.Drawing.Size(500, 244);
            this.lstUye.TabIndex = 32;
            this.lstUye.SelectedIndexChanged += new System.EventHandler(this.lstUye_SelectedIndexChanged);
            // 
            // btnUyeGuncelle
            // 
            this.btnUyeGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeGuncelle.Location = new System.Drawing.Point(722, 75);
            this.btnUyeGuncelle.Name = "btnUyeGuncelle";
            this.btnUyeGuncelle.Size = new System.Drawing.Size(170, 42);
            this.btnUyeGuncelle.TabIndex = 33;
            this.btnUyeGuncelle.Text = "Uye Güncelle";
            this.btnUyeGuncelle.UseVisualStyleBackColor = true;
            this.btnUyeGuncelle.Click += new System.EventHandler(this.btnUyeGuncelle_Click);
            // 
            // txtUyeArama
            // 
            this.txtUyeArama.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeArama.Location = new System.Drawing.Point(722, 34);
            this.txtUyeArama.Name = "txtUyeArama";
            this.txtUyeArama.Size = new System.Drawing.Size(170, 35);
            this.txtUyeArama.TabIndex = 34;
            this.txtUyeArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUyeArama_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(717, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Üyenin Ceza Puanı";
            // 
            // lblCeza
            // 
            this.lblCeza.AutoSize = true;
            this.lblCeza.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCeza.Location = new System.Drawing.Point(806, 159);
            this.lblCeza.Name = "lblCeza";
            this.lblCeza.Size = new System.Drawing.Size(0, 29);
            this.lblCeza.TabIndex = 36;
            // 
            // UyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.uye;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.lblCeza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUyeArama);
            this.Controls.Add(this.btnUyeGuncelle);
            this.Controls.Add(this.lstUye);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.txtUyeTc);
            this.Controls.Add(this.txtUyeSoyadi);
            this.Controls.Add(this.txtUyeAdi);
            this.Controls.Add(this.lblUyeTc);
            this.Controls.Add(this.lblUyeAdi);
            this.Controls.Add(this.lblUyeSoyadi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UyeForm";
            this.Text = "UyeForm";
            this.Load += new System.EventHandler(this.UyeForm_Load);
            this.cmsSil.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmsSil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ListBox lstUye;
        private System.Windows.Forms.Button btnUyeGuncelle;
        private System.Windows.Forms.TextBox txtUyeArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCeza;
    }
}