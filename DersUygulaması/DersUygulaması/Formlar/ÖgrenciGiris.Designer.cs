namespace DersUygulaması
{
    partial class ÖgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖgrenciGiris));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.linkKayıt = new MetroFramework.Controls.MetroLink();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(125, 260);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ad:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(116, 311);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Şifre:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(175, 256);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(130, 23);
            this.txtAd.TabIndex = 2;
            this.txtAd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(175, 307);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(130, 23);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(203, 353);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // linkKayıt
            // 
            this.linkKayıt.Location = new System.Drawing.Point(267, 382);
            this.linkKayıt.Name = "linkKayıt";
            this.linkKayıt.Size = new System.Drawing.Size(75, 23);
            this.linkKayıt.TabIndex = 5;
            this.linkKayıt.Text = "Kayıt ol";
            this.linkKayıt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkKayıt.Click += new System.EventHandler(this.linkKayıt_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(134, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 161);
            this.panel1.TabIndex = 6;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(368, 265);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(35, 13);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "label1";
            this.lblSoyad.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(368, 317);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(23, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 35);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ÖgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkKayıt);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ÖgrenciGiris";
            this.Text = "Ögrenci Giriş";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ÖgrenciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroButton btnGiris;
        private MetroFramework.Controls.MetroLink linkKayıt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button button1;
    }
}