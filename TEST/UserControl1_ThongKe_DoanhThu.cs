using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace TEST
{
    public partial class UserControl1_ThongKe_DoanhThu : UserControl
    {
        public UserControl1_ThongKe_DoanhThu()
        {
            InitializeComponent();
        }

        public void ClearChart()
        {
            // xóa biểu đồ.
            cartesianChart_DoanhThu.Controls.Clear();
            cartesianChart_DoanhThu.Series.Clear();
            cartesianChart_DoanhThu.AxisX.Clear();
        }
        private void btn_CacThang_Click(object sender, EventArgs e)
        {
            lbl_Nam.Visible = false;
            cmb_Nam.Visible = false;

            ClearChart();

            var list = from p in Cons.dataContext.Receipts
                       group p by p.receiptdate.Value.Year into g
                       select new
                       {
                           Nam = g.FirstOrDefault().receiptdate.Value.Year,
                           toTal = g.Sum(x => x.total)
                       };
            dataGridView1.DataSource = list;
            //lấy ra năm và số lượng bệnh nhân điều trị.

            Axis axis = new Axis()
            {
                Title = "BIỂU ĐỒ BIẾN ĐỘNG NĂM",

                FontSize = 15,
                IsMerged = true,
                Separator = new Separator
                {

                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };
            //dataGridView1.Visible = false;
            List<string> temp = new List<string>();
            foreach (var item in list.ToList())
            {
                temp.Add(item.Nam.ToString());
            }

            axis.Labels = temp;
            cartesianChart_DoanhThu.AxisX.Add(axis);

            // vẽ biểu đồ.
            LineSeries lineSeries = new LineSeries()
            {
                Title = "Tổng doanh thu: ",
                //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                LineSmoothness = 0,
                PointGeometry = null

            };

            ChartValues<double> ts = new ChartValues<double>();

            foreach (var item in list.ToList())
            {
                ts.Add(double.Parse( item.toTal.ToString()));
            }
            lineSeries.Values = ts;
            cartesianChart_DoanhThu.Series.Add(lineSeries);
        }

        private void btn_CacNam_Click(object sender, EventArgs e)
        {
            //hiển thị năm 
            lbl_Nam.Visible = true;
            cmb_Nam.Visible = true;

            //Clear
            ClearChart();

            //lấy ra năm và số lượng bệnh nhân điều trị.

            Axis axis = new Axis()
            {
                Title = "BIỂU ĐỒ BIẾN ĐỘNG DOANH THU THÁNG",

                FontSize = 15,
                IsMerged = true,
                Separator = new Separator
                {

                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };



            List<string> temp = new List<string>();
            for (int i = 1; i <= 12; i++)
            {
                temp.Add("Tháng " + i.ToString());
            }

            axis.Labels = temp;
            cartesianChart_DoanhThu.AxisX.Add(axis);

            List<double> l = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                l.Add(0);
            }
            var list = from p in Cons.dataContext.Receipts
                       where p.receiptdate.Value.Year == 2018
                       select new
                       {
                           p.receiptdate,
                           p.total
                       };

            dataGridView1.DataSource = list;

            foreach (var item in list.ToList())
            {
                l[item.receiptdate.Value.Month - 1] += double.Parse(item.total.ToString());
            }


            LineSeries lineSeries = new LineSeries()
            {
                Title = "Tổng doanh thu: ",
                //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                LineSmoothness = 0,
                PointGeometry = null

            };

            ChartValues<double> ts = new ChartValues<double>();

            for (int i = 0; i < 12; i++)
            {
                ts.Add(l[i]);
            }
            lineSeries.Values = ts;
            cartesianChart_DoanhThu.Series.Add(lineSeries);
        }

        private void cmb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear
            ClearChart();

            //lấy ra năm và số lượng bệnh nhân điều trị.

            Axis axis = new Axis()
            {
                Title = "BIỂU ĐỒ BIẾN ĐỘNG DOANH THU THÁNG",

                FontSize = 15,
                IsMerged = true,
                Separator = new Separator
                {

                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };



            List<string> temp = new List<string>();
            for (int i = 1; i <= 12; i++)
            {
                temp.Add("Tháng " + i.ToString());
            }

            axis.Labels = temp;
            cartesianChart_DoanhThu.AxisX.Add(axis);

            List<double> l = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                l.Add(0);
            }
            var list = from p in Cons.dataContext.Receipts
                       where p.receiptdate.Value.Year == int.Parse(cmb_Nam.Text)
                       select new
                       {
                           p.receiptdate,
                           p.total
                       };

            dataGridView1.DataSource = list;

            foreach (var item in list.ToList())
            {
                l[item.receiptdate.Value.Month - 1] += double.Parse(item.total.ToString());
            }


            LineSeries lineSeries = new LineSeries()
            {
                Title = "Tổng doanh thu: ",
                //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                LineSmoothness = 0,
                PointGeometry = null

            };

            ChartValues<double> ts = new ChartValues<double>();

            for (int i = 0; i < 12; i++)
            {
                ts.Add(l[i]);
            }
            lineSeries.Values = ts;
            cartesianChart_DoanhThu.Series.Add(lineSeries);
        }

        private void UserControl1_ThongKe_DoanhThu_Load(object sender, EventArgs e)
        {
            for (int i = 2016; i <= DateTime.Now.Year; i++)
            {
                cmb_Nam.Items.Add(i.ToString());
            }

        }
    }
}
