using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class İstatistik : MetroFramework.Forms.MetroForm
    {
        public İstatistik()
        {
            InitializeComponent();
           
        }

        private void İstatistik_Load(object sender, EventArgs e)
        {
            TesteGöre();
            pieChart1.Visible = false;
            cartesianChart1.Visible = false;
        }

        private void radioKonu_Click(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
            pieChart1.Visible = true;
            cartesianChart1.Visible = false;
            KonuyaGöre();
        }
        public void KonuyaGöre()
        {
            using (ClassProjectDBContext c = new ClassProjectDBContext())
            {
                Func<ChartPoint, string> fu = x => string.Format("{0}{1:P}", x.Y, x.Participation);
                SeriesCollection series = new SeriesCollection();
                foreach (var veri in c.KonuTbl.ToList())
                {
                    PieSeries pie = new PieSeries();
                    pie.Title = veri.konuAd;
                    pie.Values = new ChartValues<int> { veri.konuBasarisi };
                    pie.DataLabels = true;
                    pie.LabelPoint = fu;
                    series.Add(pie);
                    pieChart1.Series = series;
                }
            }
        }

        public void TesteGöre()
        {
            using (ClassProjectDBContext c = new ClassProjectDBContext())
            {
                Func<ChartPoint, string> fu = x => string.Format("{0}{1:P}", x.Y, x.Participation);
                SeriesCollection series = new SeriesCollection();
                foreach (var veri in c.testClasses.ToList())
                {
                    PieSeries pie = new PieSeries();                  
                    pie.Title = veri.TestNo.ToString() +".Test";
                    pie.Values = new ChartValues<int> { veri.TestBasarisi };
                    pie.DataLabels = true;
                    pie.LabelPoint = fu;
                    series.Add(pie);
                    pieChart1.Series = series;
                   
                }
            }
        }

        private void rbtnTest_Click(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
            TesteGöre();
            pieChart1.Visible = true;
            cartesianChart1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÖğrenciSecim o = new ÖğrenciSecim();
            o.Show();
            this.Hide();
        }
        public void KartezyenChartTest()
        {
            using (ClassProjectDBContext czn = new ClassProjectDBContext())
            {                     
                    ColumnSeries series = new ColumnSeries()
                    {
                        DataLabels=true,Values=new ChartValues<int>(),
                        LabelPoint=point=>point.Y.ToString()
                    };
                    Axis axisX = new Axis()
                    {
                        Separator=new Separator() { Step=1,IsEnabled=false},
                        Labels=new List<string>()
                    };
                    Axis axisY = new Axis()
                    {
                        LabelFormatter = y => y.ToString(),
                        Separator=new Separator()
                    };
                    cartesianChart1.Series.Add(series);
                    cartesianChart1.AxisX.Add(axisX);
                    cartesianChart1.AxisY.Add(axisY);
                foreach(var item in czn.testClasses.ToList())
                {
                    series.Values.Add(item.TestBasarisi);
                    axisX.Labels.Add(item.TestNo.ToString());
                    axisY.Title = "TEST BAŞARISI";
                    axisX.Title = "TEST NUMARASI";
                }
            }
        }
        public void KartezyenChartKonu()
        {
            using (ClassProjectDBContext czn = new ClassProjectDBContext())
            {
                ColumnSeries series = new ColumnSeries()
                {
                    DataLabels = true,
                    Values = new ChartValues<int>(),
                    LabelPoint = point => point.Y.ToString()
                };
                Axis axisX = new Axis()
                {
                    Separator = new Separator() { Step = 1, IsEnabled = false },
                    Labels = new List<string>()
                };
                Axis axisY = new Axis()
                {
                    LabelFormatter = y => y.ToString(),
                    Separator = new Separator()
                   
                };
                cartesianChart1.Series.Add(series);
                cartesianChart1.AxisX.Add(axisX);
                cartesianChart1.AxisY.Add(axisY);
                foreach (var item in czn.KonuTbl.ToList())
                {
                    series.Values.Add(item.konuBasarisi);
                    axisX.Labels.Add(item.konuAd);
                    axisY.Title = "KONU BAŞARISI";
                    axisX.Title = "KONU ADI";
                }
            }
        }
        private void rbtnKartezyenTEst_Click(object sender, EventArgs e)
        {
            
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            KartezyenChartTest();
            cartesianChart1.Visible = true;
            pieChart1.Visible = false;
        }

        private void metroRadioButton1_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            KartezyenChartKonu();
            cartesianChart1.Visible = true;
            pieChart1.Visible = false;
        }
    }
}
