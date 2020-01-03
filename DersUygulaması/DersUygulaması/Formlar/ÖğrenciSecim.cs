using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersUygulaması
{
    public partial class ÖğrenciSecim : MetroFramework.Forms.MetroForm
    {
        public ÖğrenciSecim()
        {
            InitializeComponent();
           
        }

        private void ÖğrenciSecim_Load(object sender, EventArgs e)
        {
            lblAd.Text = ÖgrenciGiris.Adı + " " + ÖgrenciGiris.Soyad;
        
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ÖğrenciBilgiler b = new ÖğrenciBilgiler();
            b.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            TestEkranı t = new TestEkranı();
            t.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisForm g = new GirisForm();
            g.Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            İstatistik i = new İstatistik();
            i.Show();
            this.Hide();
            
        }
    }
}
