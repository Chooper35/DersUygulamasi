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
    public partial class TestLiset : MetroFramework.Forms.MetroForm
    {
        public TestLiset()
        {
            InitializeComponent();
        }

        private void TestLiset_Load(object sender, EventArgs e)
        {
            TestListesi();
        }
        TestDal _testDal = new TestDal();
        public void TestListesi()
        {
            dataGridView1.DataSource = _testDal.GetAll();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _testDal.Add(new TestClass
            {
                TestBasarisi = 1,
            });
            MessageBox.Show("Yeni test numarası eklendi.");
            TestListesi();
        }
    }
}
