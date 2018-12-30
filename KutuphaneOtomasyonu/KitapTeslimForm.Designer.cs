namespace KutuphaneOtomasyonu
{
    partial class KitapTeslimForm
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
            this.lstTeslim = new System.Windows.Forms.ListBox();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTeslim
            // 
            this.lstTeslim.FormattingEnabled = true;
            this.lstTeslim.ItemHeight = 16;
            this.lstTeslim.Location = new System.Drawing.Point(12, 12);
            this.lstTeslim.Name = "lstTeslim";
            this.lstTeslim.Size = new System.Drawing.Size(776, 212);
            this.lstTeslim.TabIndex = 0;
            // 
            // btnTeslim
            // 
            this.btnTeslim.Location = new System.Drawing.Point(295, 275);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(119, 40);
            this.btnTeslim.TabIndex = 1;
            this.btnTeslim.Text = "Kitap Teslim Et";
            this.btnTeslim.UseVisualStyleBackColor = true;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // KitapTeslimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTeslim);
            this.Controls.Add(this.lstTeslim);
            this.Name = "KitapTeslimForm";
            this.Text = "KitapTeslimForm";
            this.Load += new System.EventHandler(this.KitapTeslimForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeslim;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Label label1;
    }
}