namespace DersUygulaması
{
    partial class İstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İstatistik));
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.radioKonu = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnTest = new MetroFramework.Controls.MetroRadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.rbtnKartezyenTEst = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(618, 89);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(754, 443);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // radioKonu
            // 
            this.radioKonu.AutoSize = true;
            this.radioKonu.Location = new System.Drawing.Point(90, 175);
            this.radioKonu.Name = "radioKonu";
            this.radioKonu.Size = new System.Drawing.Size(167, 15);
            this.radioKonu.TabIndex = 1;
            this.radioKonu.TabStop = true;
            this.radioKonu.Text = "Konuya göre başarı oranları";
            this.radioKonu.UseVisualStyleBackColor = true;
            this.radioKonu.Click += new System.EventHandler(this.radioKonu_Click);
            // 
            // rbtnTest
            // 
            this.rbtnTest.AutoSize = true;
            this.rbtnTest.Location = new System.Drawing.Point(90, 236);
            this.rbtnTest.Name = "rbtnTest";
            this.rbtnTest.Size = new System.Drawing.Size(153, 15);
            this.rbtnTest.TabIndex = 2;
            this.rbtnTest.TabStop = true;
            this.rbtnTest.Text = "Teste göre başarı oranları";
            this.rbtnTest.UseVisualStyleBackColor = true;
            this.rbtnTest.Click += new System.EventHandler(this.rbtnTest_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(58, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 35);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(328, 119);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1363, 322);
            this.cartesianChart1.TabIndex = 20;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // rbtnKartezyenTEst
            // 
            this.rbtnKartezyenTEst.AutoSize = true;
            this.rbtnKartezyenTEst.Location = new System.Drawing.Point(90, 295);
            this.rbtnKartezyenTEst.Name = "rbtnKartezyenTEst";
            this.rbtnKartezyenTEst.Size = new System.Drawing.Size(164, 15);
            this.rbtnKartezyenTEst.TabIndex = 21;
            this.rbtnKartezyenTEst.TabStop = true;
            this.rbtnKartezyenTEst.Text = "Kartezyen Grafik Teste göre";
            this.rbtnKartezyenTEst.UseVisualStyleBackColor = true;
            this.rbtnKartezyenTEst.Click += new System.EventHandler(this.rbtnKartezyenTEst_Click);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(90, 359);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(178, 15);
            this.metroRadioButton1.TabIndex = 22;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Kartezyen Grafik Konuya göre";
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            this.metroRadioButton1.Click += new System.EventHandler(this.metroRadioButton1_Click);
            // 
            // İstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 624);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.rbtnKartezyenTEst);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtnTest);
            this.Controls.Add(this.radioKonu);
            this.Controls.Add(this.pieChart1);
            this.Name = "İstatistik";
            this.Text = "İstatistik";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.İstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private MetroFramework.Controls.MetroRadioButton radioKonu;
        private MetroFramework.Controls.MetroRadioButton rbtnTest;
        private System.Windows.Forms.Button button1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private MetroFramework.Controls.MetroRadioButton rbtnKartezyenTEst;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
    }
}