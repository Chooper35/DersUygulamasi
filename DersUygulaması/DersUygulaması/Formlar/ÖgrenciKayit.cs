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
    public partial class ÖgrenciKayit : MetroFramework.Forms.MetroForm
    {
        public ÖgrenciKayit()
        {
            InitializeComponent();
        }

        private void ÖgrenciKayit_Load(object sender, EventArgs e)
        {

        }
        ÖğrenciDal _ögrenciDal = new ÖğrenciDal();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            _ögrenciDal.Add(new Öğrenci
            {
                ögrenciAd = txtAd.Text,
                ögrenciSoyad = txtSoyad.Text,
                ögrenciSifre = txtSifre.Text,
            });
            MessageBox.Show("Kayıt Başarılı.");
        }
    }
}
