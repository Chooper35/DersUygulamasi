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
    public partial class ÖgretmenSoruEkleme : MetroFramework.Forms.MetroForm
    {
        public ÖgretmenSoruEkleme()
        {
            InitializeComponent();
        }
        SoruDal _soruDal = new SoruDal();
        private void ÖgretmenSoruEkleme_Load(object sender, EventArgs e)
        {
            LoadQ();
            btnGünc.Enabled = false;
            btnSil.Enabled = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGüncMetin.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAG.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBG.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCG.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDG.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCevapgünc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtGüncKonu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtGüncTest.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            btnGünc.Enabled = true;
            btnSil.Enabled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _soruDal.Add(new Soru
            {
                soruText = txtMetin.Text,
                soruA=txtA.Text,
                soruB=txtB.Text,
                soruC=txtC.Text,
                soruD=txtD.Text,
                soruCevap=txtCevap.Text,
                soruÖgrenmeDurumu=2,
                soruKonu=Convert.ToInt32(txtKonu.Text),
                Test=Convert.ToInt32(txtGüncTest.Text),
            });
            LoadQ();
            MessageBox.Show("Soru ekleme başarılı.!.");
        }
        public void LoadQ()
        {
            dataGridView1.DataSource = _soruDal.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void lnkKonu_Click(object sender, EventArgs e)
        {
            KonuEkranı k = new KonuEkranı();
            k.ShowDialog();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            _soruDal.Update(new Soru
            {
                soruId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                soruText = txtGüncMetin.Text,
                soruA = txtAG.Text,
                soruB = txtBG.Text,
                soruC = txtCG.Text,
                soruD = txtDG.Text,
                soruCevap = txtCevapgünc.Text,
                soruÖgrenmeDurumu = 1,
                soruKonu = Convert.ToInt32(txtGüncKonu.Text),
                Test=Convert.ToInt32(txtGüncTest.Text),
            });
            LoadQ();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _soruDal.Delete(new Soru
            {
                soruId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            LoadQ();
            MessageBox.Show("Başarıyla silindi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÖğretmenSecim o = new ÖğretmenSecim();
            o.Show();
            this.Hide();
        }
        TestDal _testDal = new TestDal();

        private void metroLink1_Click(object sender, EventArgs e)
        {
            TestLiset t = new TestLiset();
            t.ShowDialog();         
        }
    }
}
