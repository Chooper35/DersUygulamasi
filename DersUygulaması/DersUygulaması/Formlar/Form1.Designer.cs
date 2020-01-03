namespace DersUygulaması
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnÖgrenci = new MetroFramework.Controls.MetroTile();
            this.btnÖgretmen = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnÖgrenci
            // 
            this.btnÖgrenci.Location = new System.Drawing.Point(133, 130);
            this.btnÖgrenci.Name = "btnÖgrenci";
            this.btnÖgrenci.Size = new System.Drawing.Size(195, 194);
            this.btnÖgrenci.TabIndex = 0;
            this.btnÖgrenci.Text = "Öğrenci";
            this.btnÖgrenci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnÖgrenci.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnÖgrenci.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnÖgrenci.Click += new System.EventHandler(this.btnÖgrenci_Click);
            // 
            // btnÖgretmen
            // 
            this.btnÖgretmen.Location = new System.Drawing.Point(462, 130);
            this.btnÖgretmen.Name = "btnÖgretmen";
            this.btnÖgretmen.Size = new System.Drawing.Size(195, 194);
            this.btnÖgretmen.TabIndex = 1;
            this.btnÖgretmen.Text = "Öğretmen";
            this.btnÖgretmen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnÖgretmen.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnÖgretmen.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnÖgretmen.Click += new System.EventHandler(this.btnÖgretmen_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.btnÖgretmen);
            this.Controls.Add(this.btnÖgrenci);
            this.Name = "GirisForm";
            this.Text = "Hoşgeldiniz";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnÖgrenci;
        private MetroFramework.Controls.MetroTile btnÖgretmen;
    }
}

