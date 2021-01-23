using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
namespace TEST
{
    public partial class UserControl_ThongKe_BenhNhan : UserControl
    {


        #region Properties
        public bool isMale = true;
        public bool isYear = true;
        public int year = 2020;
        public int month = 1;

        #endregion
        public UserControl_ThongKe_BenhNhan()
        {
            InitializeComponent();
            LoadChart(isMale, isYear);
        }

        private void UserControl_ThongKe_BenhNhan_Load(object sender, EventArgs e)
        {
            //load cmb
            cmb_GioiTinh.Items.Add("Nam");
            cmb_GioiTinh.Items.Add("Nữ");

            cmb_GioiTinh.Items.Add("Nam/Nữ");
            cmb_GioiTinh.Text = "Nam/Nữ";
            cmb_GioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;


            for (int i = 2020; i <= DateTime.Now.Year; i++)
            {
                cmb_Nam.Items.Add(i.ToString());
            }

        }



        public void LoadChart(bool isMale, bool isYear)
        {


            var genderList = Cons.dataContext.Treatments.GroupBy(x => x.dayOfTreatment.Year).Select(n => new
            {
                Nam = n.Key,
                SoLuong = n.Count()
            }).OrderBy(n => n.Nam);

            LineSeries lineSeries = new LineSeries()
            {
                Title = "Số bệnh nhân",
                //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93 ,12,  123)),
                LineSmoothness = 0,
                PointGeometry = null

            };

            ChartValues<double> ts = new ChartValues<double>();

            foreach (var item in genderList.ToList())
            {
                ts.Add(item.SoLuong);
            }
            lineSeries.Values = ts;
            cartesianChart_ThongKe.Series.Add(lineSeries);


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
            // chèn tháng hoặc năm 

       

            
            //dataGridView1.DataSource = genderList;

            cartesianChart_ThongKe.AxisX.Add(axis);

            //dataGridView1.Visible = false;
        }
  




        private void btn_ThongKeTheoNam_Click(object sender, EventArgs e)
        {
            lbl_Nam.Visible = false;
            cmb_Nam.Visible = false;
            //Clear
            ClearChart();

            //lấy ra năm và số lượng bệnh nhân điều trị.
            var genderList = Cons.dataContext.Treatments.GroupBy(x => x.dayOfTreatment.Year).Select(n => new
            {
                Nam = n.Key,
                SoLuong = n.Count()
            }).OrderBy(n => n.Nam);

            // Add năm.
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

            List<string> temp = new List<string>();
            foreach (var item in genderList.ToList())
            {
                temp.Add(item.Nam.ToString());
            }

            axis.Labels = temp;
            cartesianChart_ThongKe.AxisX.Add(axis);


            
            #region Theo năm - số lượng bệnh nhân

            if (cmb_GioiTinh.Text == "Nam/Nữ")
            {

                // vẽ biểu đồ.
                LineSeries lineSeries = new LineSeries()
                {
                    Title = "Số bệnh nhân",
                    //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                    StrokeThickness = 4,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                    LineSmoothness = 0,
                    PointGeometry = null

                };

                ChartValues<double> ts = new ChartValues<double>();

                foreach (var item in genderList.ToList())
                {
                    ts.Add(item.SoLuong);
                }
                lineSeries.Values = ts;
                cartesianChart_ThongKe.Series.Add(lineSeries);
               

            }

            if (cmb_GioiTinh.Text == "Nam")
            {
                ChartValues<double> ts = new ChartValues<double>();
                //lấy ra năm và số lượng bệnh nhân là nam điều trị.

                var list = from t in Cons.dataContext.Treatments
                                 join p in Cons.dataContext.Patients on t.PatientId equals p.PatientId
                                 where p.gender == true
                                 select new
                                 {
                                     
                                     Nam = t.dayOfTreatment.Year,
                                     MaBenhNhan = p.PatientId,
                                     GioiTinh = p.gender
                                 };

                // Proessing.
                int countMale = 0;
                string oldCode = "";
                foreach (var i in genderList.ToList())
                {
                    countMale = 0;
                    oldCode = "";
                    foreach (var item in list.ToList())
                    {
                        if (item.GioiTinh == true && oldCode != item.MaBenhNhan && item.Nam == i.Nam)
                        {
                            countMale++;
                            oldCode = item.MaBenhNhan;
                        }
                    }
                    ts.Add(countMale);
                }
                

                //dataGridView1.Visible = true;
                //dataGridView1.DataSource = list;
                // vẽ biểu đồ.
                LineSeries lineSeries = new LineSeries()
                {
                    Title = "Số bệnh nhân nam",
                    StrokeThickness = 4,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(1, 135, 134)),
                    LineSmoothness = 0,
                    PointGeometry = null

                };

                

                
                lineSeries.Values = ts;
                cartesianChart_ThongKe.Series.Add(lineSeries);
            }

            if (cmb_GioiTinh.Text == "Nữ")
            {
                ChartValues<double> ts = new ChartValues<double>();
                //lấy ra năm và số lượng bệnh nhân là nam điều trị.

                var list = from t in Cons.dataContext.Treatments
                           join p in Cons.dataContext.Patients on t.PatientId equals p.PatientId
                           where p.gender == false
                           select new
                           {

                               Nam = t.dayOfTreatment.Year,
                               MaBenhNhan = p.PatientId,
                               GioiTinh = p.gender
                           };

                // Proessing.
                int countFemale = 0;
                string oldCode = "";
                foreach (var i in genderList.ToList())
                {
                    countFemale = 0;
                    oldCode = "";
                    foreach (var item in list.ToList())
                    {
                        if (item.GioiTinh == false && oldCode != item.MaBenhNhan && item.Nam == i.Nam)
                        {
                            countFemale++;
                            oldCode = item.MaBenhNhan;
                        }
                    }
                    ts.Add(countFemale);
                }
                //dataGridView1.Visible = true;
                //dataGridView1.DataSource = list;
                // vẽ biểu đồ.
                LineSeries lineSeries = new LineSeries()
                {
                    Title = "Số bệnh nhân nữ",
                    //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                    StrokeThickness = 4,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(205, 16, 118)),
                    LineSmoothness = 0,
                    PointGeometry = null

                };


                lineSeries.Values = ts;
                cartesianChart_ThongKe.Series.Add(lineSeries);
            }

            //dataGridView1.Visible = false;
            #endregion
        }


        public void ClearChart()
        {
            // xóa biểu đồ.
            cartesianChart_ThongKe.Controls.Clear();
            cartesianChart_ThongKe.Series.Clear();
            cartesianChart_ThongKe.AxisX.Clear();
        }

        private void btn_ThongKeThang_Click(object sender, EventArgs e)
        {
            //hiển thị năm 
            lbl_Nam.Visible = true;
            cmb_Nam.Visible = true;

            //Clear
            ClearChart();

            //lấy ra năm và số lượng bệnh nhân điều trị.

            Axis axis = new Axis()
            {
                Title = "BIỂU ĐỒ BIẾN ĐỘNG THÁNG",

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
            cartesianChart_ThongKe.AxisX.Add(axis);



            if (cmb_GioiTinh.Text == "Nam/Nữ")
            {
                LineSeries lineSeries = new LineSeries()
                {
                    Title = "Số bệnh nhân",
                    //Values = new ChartValues<double> { 14, 16, 13, 12, 16 },
                    StrokeThickness = 4,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                    LineSmoothness = 0,
                    PointGeometry = null

                };

                ChartValues<double> ts = new ChartValues<double>();

                var grouped = (from p in Cons.dataContext.Treatments
                               where p.dayOfTreatment.Year == year
                               group p by new { month = p.dayOfTreatment.Month } into d
                               select new { d.Key.month, count = d.Count() }).OrderByDescending(g => g.month);

                for (int i = 1; i <= 12; i++)
                {
                    int x = 0;
                    foreach (var item in grouped.ToList())
                    {
                        if (item.month == i)
                        {
                            x = item.count;
                            break;
                        }
                    }
                    ts.Add(x);
                }

                lineSeries.Values = ts;
                cartesianChart_ThongKe.Series.Add(lineSeries);

            }

            if (cmb_GioiTinh.Text == "Nam")
            {
                LineSeries lineSeries = new LineSeries()
                {
                    Title = "Số bệnh nhân",
                    StrokeThickness = 4,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                    LineSmoothness = 0,
                    PointGeometry = null

                };

                ChartValues<double> ts = new ChartValues<double>();

                var grouped = (from p in Cons.dataContext.Treatments
                               join pp in Cons.dataContext.Patients on p.PatientId equals pp.PatientId
                               where p.dayOfTreatment.Year == year && pp.gender == true
                               group p by new { month = p.dayOfTreatment.Month } into d
                               select new { d.Key.month, count = d.Count() }).OrderByDescending(g => g.month);

                for (int i = 1; i <= 12; i++)
                {
                    int x = 0;
                    foreach (var item in grouped.ToList())
                    {
                        if (item.month == i)
                        {
                            x = item.count;
                            break;
                        }
                    }
                    ts.Add(x);
                }

                lineSeries.Values = ts;
                cartesianChart_ThongKe.Series.Add(lineSeries);

            }

            if (cmb_GioiTinh.Text == "Nữ")
            {
                LineSeries lineSeries = new LineSeries()
                {
                    Title = "Số bệnh nhân",
                    StrokeThickness = 4,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(93, 12, 123)),
                    LineSmoothness = 0,
                    PointGeometry = null

                };

                ChartValues<double> ts = new ChartValues<double>();

                var grouped = (from p in Cons.dataContext.Treatments
                               join pp in Cons.dataContext.Patients on p.PatientId equals pp.PatientId
                               where p.dayOfTreatment.Year == year && pp.gender == false
                               group p by new { month = p.dayOfTreatment.Month } into d
                               select new { d.Key.month, count = d.Count() }).OrderByDescending(g => g.month);

                for (int i = 1; i <= 12; i++)
                {
                    int x = 0;
                    foreach (var item in grouped.ToList())
                    {
                        if (item.month == i)
                        {
                            x = item.count;
                            break;
                        }
                    }
                    ts.Add(x);
                }

                lineSeries.Values = ts;
                cartesianChart_ThongKe.Series.Add(lineSeries);

            }
            //dataGridView1.DataSource = grouped;
        }

        

        private void cmb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = int.Parse(cmb_Nam.Text);
            btn_ThongKeThang_Click(sender, e);
        }

        private void cartesianChart_ThongKe_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
