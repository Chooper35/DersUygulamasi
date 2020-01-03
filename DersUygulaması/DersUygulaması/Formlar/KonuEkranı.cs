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
    public partial class KonuEkranı : MetroFramework.Forms.MetroForm
    {
        public KonuEkranı()
        {
            InitializeComponent();
        }
        
        private void KonuEkranı_Load(object sender, EventArgs e)
        {
            ListKonu();
        }
        KonuDal _konuDal = new KonuDal();
        public void ListKonu()
        {
            dataGridView1.DataSource = _konuDal.GetAll();
            dataGridView1.Columns[2].Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _konuDal.Add(new Konu
            {
                konuAd = txtKonuad.Text,
                konuBasarisi=1,
                
            });
            ListKonu();
            MessageBox.Show("Konu Başarıyla Eklendi");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            _konuDal.Update(new Konu
            {             
                konuAd =txtGüncAd.Text,
                konuBasarisi=1,
                konuId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
            });
            ListKonu();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGüncAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
