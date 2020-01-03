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
    public partial class ÖğretmenBilgiler : MetroFramework.Forms.MetroForm
    {
        public ÖğretmenBilgiler()
        {
            InitializeComponent();
        }

        private void ÖğretmenBilgiler_Load(object sender, EventArgs e)
        {
            LoadTeacher();
            btnGüncelle.Enabled = false;
        }
        ÖgretmenDal o = new ÖgretmenDal();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            o.Update(new Öğretmen
            {
                ögretmenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                ögretmenAd = txtAd.Text,
                ögretmenSoyad = txtSoyad.Text,
                ögretmenSifre = txtSifre.Text,
                ögretmenTelefon=txtTelefon.Text,
            });
            LoadTeacher();
            MessageBox.Show("Güncelleme Başarılı.");
        }
        public void LoadTeacher()
        {
            dataGridView1.DataSource = o.ListOneTeacher(ÖğretmenGiriş.Id);
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            btnGüncelle.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÖğretmenSecim o = new ÖğretmenSecim();
            o.Show();
            this.Hide();
        }
    }
}
