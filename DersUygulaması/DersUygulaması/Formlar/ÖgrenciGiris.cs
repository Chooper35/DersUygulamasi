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
    public partial class ÖgrenciGiris : MetroFramework.Forms.MetroForm
    {
        public ÖgrenciGiris()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*';
        }

        private void ÖgrenciGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullanıcıKontrol();
        }
        public static string Adı;
        public static string Soyad;
        public static string Sifre;
        public static int Id;
        private void linkKayıt_Click(object sender, EventArgs e)
        {
            ÖgrenciKayit o = new ÖgrenciKayit();
            o.ShowDialog();
        }
        private void KullanıcıKontrol()
        {
            var Ad = txtAd.Text;
            var password = txtSifre.Text;
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                var user = context.ÖgrenciTbl.FirstOrDefault(s => s.ögrenciAd == Ad);
                if (user != null)
                {
                    Adı = user.ögrenciAd;
                    Soyad = user.ögrenciSoyad;
                    Sifre = user.ögrenciSifre;
                    Id = user.ögrenciId;
                    if (user.ögrenciSifre == password)
                    {
                        ÖğrenciSecim ö = new ÖğrenciSecim();
                        ö.Show();
                        this.Hide();
                        MessageBox.Show("Hoşgeldiniz " + Ad);

                    }
                    else
                    {
                        MessageBox.Show("Şifre Yanlış.");
                    }
                }
                else
                {
                    MessageBox.Show("Kişi kayıtlı değil");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisForm f = new GirisForm();
            f.Show();
            this.Hide();
        }
    }
}
