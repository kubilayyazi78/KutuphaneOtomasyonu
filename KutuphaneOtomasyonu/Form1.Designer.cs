﻿namespace KutuphaneOtomasyonu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uyeIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTeslimEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uyeIslemleriToolStripMenuItem,
            this.yazarİslemleriToolStripMenuItem,
            this.kitapİslemleriToolStripMenuItem,
            this.kiralamaIslemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1216, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uyeIslemleriToolStripMenuItem
            // 
            this.uyeIslemleriToolStripMenuItem.Name = "uyeIslemleriToolStripMenuItem";
            this.uyeIslemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.uyeIslemleriToolStripMenuItem.Text = "Uye Islemleri";
            this.uyeIslemleriToolStripMenuItem.Click += new System.EventHandler(this.uyeIslemleriToolStripMenuItem_Click);
            // 
            // yazarİslemleriToolStripMenuItem
            // 
            this.yazarİslemleriToolStripMenuItem.Name = "yazarİslemleriToolStripMenuItem";
            this.yazarİslemleriToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.yazarİslemleriToolStripMenuItem.Text = "Yazar Islemleri";
            this.yazarİslemleriToolStripMenuItem.Click += new System.EventHandler(this.yazarİslemleriToolStripMenuItem_Click);
            // 
            // kitapİslemleriToolStripMenuItem
            // 
            this.kitapİslemleriToolStripMenuItem.Name = "kitapİslemleriToolStripMenuItem";
            this.kitapİslemleriToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.kitapİslemleriToolStripMenuItem.Text = "Kitap Islemleri";
            this.kitapİslemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapİslemleriToolStripMenuItem_Click);
            // 
            // kiralamaIslemleriToolStripMenuItem
            // 
            this.kiralamaIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapKiralaToolStripMenuItem,
            this.kitapTeslimEtToolStripMenuItem});
            this.kiralamaIslemleriToolStripMenuItem.Name = "kiralamaIslemleriToolStripMenuItem";
            this.kiralamaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.kiralamaIslemleriToolStripMenuItem.Text = "Kiralama Islemleri";
            // 
            // kitapKiralaToolStripMenuItem
            // 
            this.kitapKiralaToolStripMenuItem.Name = "kitapKiralaToolStripMenuItem";
            this.kitapKiralaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.kitapKiralaToolStripMenuItem.Text = "Kitap Kirala";
            this.kitapKiralaToolStripMenuItem.Click += new System.EventHandler(this.kitapKiralaToolStripMenuItem_Click);
            // 
            // kitapTeslimEtToolStripMenuItem
            // 
            this.kitapTeslimEtToolStripMenuItem.Name = "kitapTeslimEtToolStripMenuItem";
            this.kitapTeslimEtToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.kitapTeslimEtToolStripMenuItem.Text = "Kitap Teslim Et";
            this.kitapTeslimEtToolStripMenuItem.Click += new System.EventHandler(this.kitapTeslimEtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.anasayfa;
            this.ClientSize = new System.Drawing.Size(1216, 646);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uyeIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTeslimEtToolStripMenuItem;
    }
}

