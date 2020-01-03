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
    public partial class TestEkranı : MetroFramework.Forms.MetroForm
    {
        public int ögrenmeDurumuDeger;
        public int soruID;
      
        

        public TestEkranı()
        {
            InitializeComponent();
        }

        private void TestEkranı_Load(object sender, EventArgs e)
        {
            Sorugetir();

            timer1.Interval = 100;
        }



        public void Sorugetir()
        {

            if (rbtnTest1.Checked == true)
            {

                btnD.Visible = true;
                btnA.Visible = true;
                metroPanel3.Visible = false;

                using (ClassProjectDBContext c = new ClassProjectDBContext())
                {
                    var random = c.SoruTbl.OrderBy(x => Guid.NewGuid()).Where(x => x.Test == 1 && x.soruÖgrenmeDurumu == 2).FirstOrDefault();
                    if (random == null)
                    {
                        timer1.Stop();
                        MessageBox.Show("Test Bitti");
                        ÖğrenciSecim o = new ÖğrenciSecim();
                        o.Show();
                        this.Close();
                    }
                    else
                    {
                        timer1.Start();
                        lblÖgrenmeDurumu.Text = random.soruÖgrenmeDurumu.ToString();
                        ögrenmeDurumuDeger = Convert.ToInt32(lblÖgrenmeDurumu.Text);
                        lblKonuıd.Text = random.soruKonu.ToString();
                        lblId.Text = random.soruId.ToString();
                        soruID = Convert.ToInt32(lblId.Text);
                        lblTest.Text = random.Test.ToString();
                        if (Convert.ToInt32(lblTest.Text) == 1)
                        {
                            lblSoru.Text = random.soruText;
                            btnA.Text = random.soruA;
                            btnB.Text = random.soruB;
                            btnC.Text = random.soruC;
                            btnD.Text = random.soruD;
                            lblCevap.Text = random.soruCevap;
                        }
                        else
                        {
                            MessageBox.Show("Test bitti");
                        }

                    }

                }
            }
            else if (rbtntest2.Checked == true)
            {

                btnD.Visible = true;
                btnA.Visible = true;
                metroPanel3.Visible = false;

                using (ClassProjectDBContext c = new ClassProjectDBContext())
                {
                    var random = c.SoruTbl.OrderBy(x => Guid.NewGuid()).Where(x => x.Test == 2 && x.soruÖgrenmeDurumu == 2).FirstOrDefault();
                    if (random == null)
                    {
                        timer1.Stop();
                        MessageBox.Show("Test Bitti");
                        ÖğrenciSecim o = new ÖğrenciSecim();
                        o.Show();
                        this.Close();
                    }
                    else
                    {
                        timer1.Start();
                        lblÖgrenmeDurumu.Text = random.soruÖgrenmeDurumu.ToString();
                        ögrenmeDurumuDeger = Convert.ToInt32(lblÖgrenmeDurumu.Text);
                        lblKonuıd.Text = random.soruKonu.ToString();
                        lblId.Text = random.soruId.ToString();
                        soruID = Convert.ToInt32(lblId.Text);
                        lblTest.Text = random.Test.ToString();
                        if (Convert.ToInt32(lblTest.Text) == 2)
                        {
                            lblSoru.Text = random.soruText;
                            btnA.Text = random.soruA;
                            btnB.Text = random.soruB;
                            btnC.Text = random.soruC;
                            btnD.Text = random.soruD;
                            lblCevap.Text = random.soruCevap;
                        }
                        else
                        {
                            MessageBox.Show("Test bitti");
                        }
                    }
                }


            }
            else if (rbtn3.Checked == true)
            {
                metroPanel3.Visible = false;

                btnD.Visible = true;
                btnA.Visible = true;

                using (ClassProjectDBContext c = new ClassProjectDBContext())
                {
                    var random = c.SoruTbl.OrderBy(x => Guid.NewGuid()).Where(x => x.Test == 3 && x.soruÖgrenmeDurumu == 2).FirstOrDefault();
                    if (random == null)
                    {
                        timer1.Stop();
                        MessageBox.Show("Test Bitti");
                        ÖğrenciSecim o = new ÖğrenciSecim();
                        o.Show();
                        this.Close();
                    }
                    else
                    {
                        timer1.Start();
                        lblÖgrenmeDurumu.Text = random.soruÖgrenmeDurumu.ToString();
                        ögrenmeDurumuDeger = Convert.ToInt32(lblÖgrenmeDurumu.Text);
                        lblKonuıd.Text = random.soruKonu.ToString();
                        lblId.Text = random.soruId.ToString();
                        soruID = Convert.ToInt32(lblId.Text);
                        lblTest.Text = random.Test.ToString();
                        if (Convert.ToInt32(lblTest.Text) == 3)
                        {
                            lblSoru.Text = random.soruText;
                            btnA.Text = random.soruA;
                            btnB.Text = random.soruB;
                            btnC.Text = random.soruC;
                            btnD.Text = random.soruD;
                            lblCevap.Text = random.soruCevap;
                        }
                        else
                        {
                            MessageBox.Show("Test bitti");
                        }
                    }
                }

            }
            else if (rbtn4.Checked == true)
            {

                btnD.Visible = true;
                btnA.Visible = true;
                metroPanel3.Visible = false;
                timer1.Start();
                using (ClassProjectDBContext c = new ClassProjectDBContext())
                {
                    var random = c.SoruTbl.OrderBy(x => Guid.NewGuid()).Where(x => x.Test == 4 && x.soruÖgrenmeDurumu == 2).FirstOrDefault();
                    //var deneme = from s in c.SoruTbl.OrderBy(x => Guid.NewGuid()).Where(x => x.Test == 4 && x.soruÖgrenmeDurumu == 2)
                    //             join k in c.KonuTbl.OrderBy(x=>x.konuId==)
                                 
                    if (random == null)
                    {
                        timer1.Stop();
                        MessageBox.Show("Test Bitti");
                        ÖğrenciSecim o = new ÖğrenciSecim();
                        o.Show();
                        this.Close();
                    }
                    else
                    {
                        lblÖgrenmeDurumu.Text = random.soruÖgrenmeDurumu.ToString();
                        ögrenmeDurumuDeger = Convert.ToInt32(lblÖgrenmeDurumu.Text);
                        lblId.Text = random.soruId.ToString();
                        lblKonuıd.Text = random.soruKonu.ToString();
                        soruID = Convert.ToInt32(lblId.Text);
                        lblTest.Text = random.Test.ToString();
                        if (Convert.ToInt32(lblTest.Text) == 4)
                        {
                            lblSoru.Text = random.soruText;
                            btnA.Text = random.soruA;
                            btnB.Text = random.soruB;
                            btnC.Text = random.soruC;
                            btnD.Text = random.soruD;
                            lblCevap.Text = random.soruCevap;
                        }
                        else
                        {
                            MessageBox.Show("Test bitti");
                        }
                    }
                }
            }
            else if (rbtn5.Checked == true)
            {

                btnD.Visible = true;
                btnA.Visible = true;
                metroPanel3.Visible = false;
                timer1.Start();
                using (ClassProjectDBContext c = new ClassProjectDBContext())
                {
                    var random = c.SoruTbl.OrderBy(x => Guid.NewGuid()).Where(x => x.Test == 4 && x.soruÖgrenmeDurumu == 2).FirstOrDefault();
                    //var deneme = from s in c.SoruTbl.OrderBy(x => Guid.NewGuid()).Where(x => x.Test == 4 && x.soruÖgrenmeDurumu == 2)
                    //             join k in c.KonuTbl.OrderBy(x=>x.konuId==)

                    if (random == null)
                    {
                        timer1.Stop();
                        MessageBox.Show("Test Bitti");
                        ÖğrenciSecim o = new ÖğrenciSecim();
                        o.Show();
                        this.Close();
                    }
                    else
                    {
                        lblÖgrenmeDurumu.Text = random.soruÖgrenmeDurumu.ToString();
                        ögrenmeDurumuDeger = Convert.ToInt32(lblÖgrenmeDurumu.Text);
                        lblId.Text = random.soruId.ToString();
                        lblKonuıd.Text = random.soruKonu.ToString();
                        soruID = Convert.ToInt32(lblId.Text);
                        lblTest.Text = random.Test.ToString();
                        if (Convert.ToInt32(lblTest.Text) == 4)
                        {
                            lblSoru.Text = random.soruText;
                            btnA.Text = random.soruA;
                            btnB.Text = random.soruB;
                            btnC.Text = random.soruC;
                            btnD.Text = random.soruD;
                            lblCevap.Text = random.soruCevap;
                        }
                        else
                        {
                            MessageBox.Show("Test bitti");
                        }
                    }
                }
            }
        }


        private void btnA_Click(object sender, EventArgs e)
        {
            var soruID = Convert.ToInt32(lblId.Text);
            var konuID = Convert.ToInt32(lblKonuıd.Text);
            var testID = Convert.ToInt32(lblTest.Text);

            using (ClassProjectDBContext czn = new ClassProjectDBContext())
            {
                if (btnA.Text == lblCevap.Text)
                {
                    var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    var konu = czn.KonuTbl.Where(x => x.konuId == konuID).FirstOrDefault();
                    var test = czn.testClasses.Where(x => x.TestNo == testID).FirstOrDefault();
                    //var query = from s in czn.SoruTbl
                    //            join k in czn.KonuTbl
                    //on s.soruKonu equals k.konuId
                    //            select new
                    //            {

                    //            };
                    ogrdurumuguncelle.soruÖgrenmeDurumu += 1;
                    konu.konuBasarisi += 1;
                    test.TestBasarisi += 1;
                    czn.SaveChanges();                   
                    MessageBox.Show("Doğru Cevap");
                    Sorugetir();
                    pBar.Value = 0;
                }
                //else if(pBar.Value==100)
                //{
                //    //var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                //    ogrdurumuguncelle.soruÖgrenmeDurumu -= 1;
                //    czn.SaveChanges();
                //    MessageBox.Show("Yanlış Cevap");
                //    pBar.Value = 0;
                //    Sorugetir();
                //}
                else
                {
                    var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    ogrdurumuguncelle.soruÖgrenmeDurumu -= 1;
                    czn.SaveChanges();
                    MessageBox.Show("Yanlış Cevap");
                    Sorugetir();
                    pBar.Value = 0;
                }


            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            var soruID = Convert.ToInt32(lblId.Text);
            var konuID = Convert.ToInt32(lblKonuıd.Text);
            var testID = Convert.ToInt32(lblTest.Text);
            using (ClassProjectDBContext czn = new ClassProjectDBContext())
            {
                if (btnB.Text == lblCevap.Text)
                {
                    var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    var konu = czn.KonuTbl.Where(x => x.konuId == konuID).FirstOrDefault();
                    var test = czn.testClasses.Where(x => x.TestNo == testID).FirstOrDefault();
                    ogrdurumuguncelle.soruÖgrenmeDurumu += 1;
                    konu.konuBasarisi += 1;
                    test.TestBasarisi += 1;
                    czn.SaveChanges();
                    MessageBox.Show("Doğru Cevap");
                    Sorugetir();
                    pBar.Value = 0;
                }

                else
                {
                    var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    ogrdurumuguncelle.soruÖgrenmeDurumu -= 1;
                    czn.SaveChanges();
                    MessageBox.Show("Yanlış Cevap");
                    Sorugetir();
                    pBar.Value = 0;
                }

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            var soruID = Convert.ToInt32(lblId.Text);
            var konuID = Convert.ToInt32(lblKonuıd.Text);
            var testID = Convert.ToInt32(lblTest.Text);
            using (ClassProjectDBContext czn = new ClassProjectDBContext())
            {
                if (btnC.Text == lblCevap.Text)
                {
                    var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    var konu = czn.KonuTbl.Where(x => x.konuId == konuID).FirstOrDefault();
                    var test = czn.testClasses.Where(x => x.TestNo == testID).FirstOrDefault();
                    ogrdurumuguncelle.soruÖgrenmeDurumu += 1;
                    konu.konuBasarisi += 1;
                    test.TestBasarisi += 1;
                    czn.SaveChanges();
                    MessageBox.Show("Doğru Cevap");
                    Sorugetir();
                    pBar.Value = 0;
                }
                else
                {
                    var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    ogrdurumuguncelle.soruÖgrenmeDurumu -= 1;
                    czn.SaveChanges();
                    MessageBox.Show("Yanlış Cevap");
                    Sorugetir();
                    pBar.Value = 0;
                }

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            var soruID = Convert.ToInt32(lblId.Text);
            var konuID = Convert.ToInt32(lblKonuıd.Text);
            var testID = Convert.ToInt32(lblTest.Text);
            using (ClassProjectDBContext czn = new ClassProjectDBContext())
            {
                if (btnD.Text == lblCevap.Text)
                {
                    var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    var konu = czn.KonuTbl.Where(x => x.konuId == konuID).FirstOrDefault();
                    var test = czn.testClasses.Where(x => x.TestNo == testID).FirstOrDefault();
                    ogrdurumuguncelle.soruÖgrenmeDurumu += 1;
                    konu.konuBasarisi += 1;
                    test.TestBasarisi += 1;
                    czn.SaveChanges();
                    MessageBox.Show("Doğru Cevap");
                    Sorugetir();
                    pBar.Value = 0;
                }
                else
                {
                    var ogrdurumuguncelle = czn.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    ogrdurumuguncelle.soruÖgrenmeDurumu -= 1;
                    czn.SaveChanges();
                    MessageBox.Show("Yanlış Cevap");
                    Sorugetir();
                    pBar.Value = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÖğrenciSecim o = new ÖğrenciSecim();
            o.Show();
            this.Hide();
        }

        private void rbtnTest1_Click(object sender, EventArgs e)
        {
            Sorugetir();
        }

        private void rbtntest2_Click(object sender, EventArgs e)
        {
            Sorugetir();
        }

        private void metroRadioButton1_Click(object sender, EventArgs e)
        {
            Sorugetir();
        }

        private void metroRadioButton2_Click(object sender, EventArgs e)
        {
            Sorugetir();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBar.Value++;
            using (ClassProjectDBContext c = new ClassProjectDBContext())
            {
                if (pBar.Value == 100)
                {
                    var ogrdurumuguncelle = c.SoruTbl.Where(x => x.soruId == soruID).FirstOrDefault();
                    ogrdurumuguncelle.soruÖgrenmeDurumu -= 1;
                    c.SaveChanges();
                    Sorugetir();
                    pBar.Value = 0;
                }
            }
        }

        private void rbtn5_Click(object sender, EventArgs e)
        {
            Sorugetir();
        }
    }
}
            
        
    


