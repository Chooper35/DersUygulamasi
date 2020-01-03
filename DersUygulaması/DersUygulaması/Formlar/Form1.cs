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
    public partial class GirisForm : MetroFramework.Forms.MetroForm
    {
        public GirisForm()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnÖgrenci_Click(object sender, EventArgs e)
        {
            ÖgrenciGiris ö = new ÖgrenciGiris();
            ö.Show();
            this.Hide();
        }

        private void btnÖgretmen_Click(object sender, EventArgs e)
        {
            ÖğretmenGiriş o = new ÖğretmenGiriş();
            o.Show();
            this.Hide();
        }
    }
}
