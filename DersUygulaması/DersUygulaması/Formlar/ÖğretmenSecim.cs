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
    public partial class ÖğretmenSecim : MetroFramework.Forms.MetroForm
    {
        public ÖğretmenSecim()
        {
            InitializeComponent();
        }

        private void ÖğretmenSecim_Load(object sender, EventArgs e)
        {
            lblKullanıcı.Text = ÖğretmenGiriş.Adı + " " + ÖğretmenGiriş.Soyad;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ÖğretmenBilgiler f = new ÖğretmenBilgiler();
            f.Show();
            this.Hide();

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ÖgretmenSoruEkleme o = new ÖgretmenSoruEkleme();
            o.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisForm f = new GirisForm();
            f.Show();
            this.Hide();
        }
    }
}
