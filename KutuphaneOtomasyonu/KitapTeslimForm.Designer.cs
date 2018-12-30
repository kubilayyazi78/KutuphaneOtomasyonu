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
            this.SuspendLayout();
            // 
            // lstTeslim
            // 
            this.lstTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTeslim.FormattingEnabled = true;
            this.lstTeslim.ItemHeight = 20;
            this.lstTeslim.Location = new System.Drawing.Point(25, 100);
            this.lstTeslim.Name = "lstTeslim";
            this.lstTeslim.Size = new System.Drawing.Size(620, 244);
            this.lstTeslim.TabIndex = 0;
            // 
            // btnTeslim
            // 
            this.btnTeslim.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslim.Location = new System.Drawing.Point(665, 203);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(185, 48);
            this.btnTeslim.TabIndex = 1;
            this.btnTeslim.Text = "Kitap Teslim Et";
            this.btnTeslim.UseVisualStyleBackColor = true;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // KitapTeslimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.kira;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btnTeslim);
            this.Controls.Add(this.lstTeslim);
            this.Name = "KitapTeslimForm";
            this.Text = "KitapTeslimForm";
            this.Load += new System.EventHandler(this.KitapTeslimForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeslim;
        private System.Windows.Forms.Button btnTeslim;
    }
}