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
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(527, 511);
            this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(100, 28);
            this.btnUyeEkle.TabIndex = 29;
            this.btnUyeEkle.Text = "Uye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // txtUyeTc
            // 
            this.txtUyeTc.Location = new System.Drawing.Point(493, 458);
            this.txtUyeTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtUyeTc.Name = "txtUyeTc";
            this.txtUyeTc.Size = new System.Drawing.Size(132, 22);
            this.txtUyeTc.TabIndex = 27;
            // 
            // txtUyeSoyadi
            // 
            this.txtUyeSoyadi.Location = new System.Drawing.Point(493, 421);
            this.txtUyeSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUyeSoyadi.Name = "txtUyeSoyadi";
            this.txtUyeSoyadi.Size = new System.Drawing.Size(132, 22);
            this.txtUyeSoyadi.TabIndex = 26;
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Location = new System.Drawing.Point(493, 382);
            this.txtUyeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(132, 22);
            this.txtUyeAdi.TabIndex = 25;
            // 
            // lblUyeTc
            // 
            this.lblUyeTc.AutoSize = true;
            this.lblUyeTc.Location = new System.Drawing.Point(389, 466);
            this.lblUyeTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeTc.Name = "lblUyeTc";
            this.lblUyeTc.Size = new System.Drawing.Size(93, 17);
            this.lblUyeTc.TabIndex = 24;
            this.lblUyeTc.Text = "Uye Tc Kimlik";
            // 
            // lblUyeAdi
            // 
            this.lblUyeAdi.AutoSize = true;
            this.lblUyeAdi.Location = new System.Drawing.Point(389, 385);
            this.lblUyeAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeAdi.Name = "lblUyeAdi";
            this.lblUyeAdi.Size = new System.Drawing.Size(57, 17);
            this.lblUyeAdi.TabIndex = 23;
            this.lblUyeAdi.Text = "Uye Adı";
            // 
            // lblUyeSoyadi
            // 
            this.lblUyeSoyadi.AutoSize = true;
            this.lblUyeSoyadi.Location = new System.Drawing.Point(389, 430);
            this.lblUyeSoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeSoyadi.Name = "lblUyeSoyadi";
            this.lblUyeSoyadi.Size = new System.Drawing.Size(80, 17);
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
            this.lstUye.FormattingEnabled = true;
            this.lstUye.ItemHeight = 16;
            this.lstUye.Location = new System.Drawing.Point(1, 12);
            this.lstUye.Name = "lstUye";
            this.lstUye.Size = new System.Drawing.Size(1030, 292);
            this.lstUye.TabIndex = 32;
            // 
            // UyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
    }
}