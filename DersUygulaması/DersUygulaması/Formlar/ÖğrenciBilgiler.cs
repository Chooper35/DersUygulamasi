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
    public partial class ÖğrenciBilgiler : MetroFramework.Forms.MetroForm
    {
        public ÖğrenciBilgiler()
        {
            InitializeComponent();
            btnGüncelle.Enabled = false;
        }
        ÖğrenciDal _ögrenciDal = new ÖğrenciDal();
        private void ÖğrenciBilgiler_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        public void LoadStudents()
        {
            dataGridView1.DataSource = _ögrenciDal.ListOneÖgrenci(ÖgrenciGiris.Id);
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            _ögrenciDal.Update(new Öğrenci
            {
                ögrenciId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                ögrenciAd = txtAd.Text,
                ögrenciSoyad =txtSoyad.Text,
                ögrenciSifre = txtSifre.Text,
            });
            LoadStudents();
            MessageBox.Show("Bilgiler Güncellendi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            btnGüncelle.Enabled = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ÖğrenciSecim o = new ÖğrenciSecim();
            o.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÖğrenciSecim o = new ÖğrenciSecim();
            o.Show();
            this.Hide();
        }
    }

}
