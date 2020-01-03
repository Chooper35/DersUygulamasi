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
    public partial class ÖğretmenKayit : MetroFramework.Forms.MetroForm
    {
        public ÖğretmenKayit()
        {
            InitializeComponent();
        }

        private void ÖğretmenKayit_Load(object sender, EventArgs e)
        {
            
        }
        ÖgretmenDal _öğretmenDal = new ÖgretmenDal();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            _öğretmenDal.Add(new Öğretmen
            {
                ögretmenAd = txtAd.Text,
                ögretmenSoyad = txtSoyad.Text,
                ögretmenSifre=txtSifre.Text,
                ögretmenTelefon=maskedTextBox1.Text,
            });
            MessageBox.Show("Kayıt olundu.");
        }
    }
}
