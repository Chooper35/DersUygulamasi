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
    public partial class ÖğretmenGiriş : MetroFramework.Forms.MetroForm
    {
        public ÖğretmenGiriş()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*';
        }

        private void ÖğretmenGiriş_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            KullanıcıKontrol();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            ÖğretmenKayit f = new ÖğretmenKayit();
            f.ShowDialog();
        }
        public static string Adı;
        public static string Sifre;
        public static string Soyad;
        public static int Id;
        public static string Telefon;

        private void KullanıcıKontrol()
        {
            var Ad = txtAd.Text;
            var password = txtSifre.Text;
            using (ClassProjectDBContext context = new ClassProjectDBContext())
            {
                var user = context.ÖğretmenTbl.FirstOrDefault(s => s.ögretmenAd == Ad);
                if (user != null)
                {
                    Adı = user.ögretmenAd;
                    Soyad = user.ögretmenSoyad;
                    Sifre = user.ögretmenSifre;
                    Id = user.ögretmenId;
                    Telefon = user.ögretmenTelefon;
                    if (user.ögretmenSifre == password)
                    {
                        ÖğretmenSecim ö = new ÖğretmenSecim();
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
