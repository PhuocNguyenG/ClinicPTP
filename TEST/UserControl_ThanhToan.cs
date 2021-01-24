using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace TEST
{
    public partial class UserControl_ThanhToan : UserControl
    {
        public UserControl_ThanhToan()
        {
            InitializeComponent();
        }

        private void UserControl_ThanhToan_Load(object sender, EventArgs e)
        {
            dateTime_ThanhToan.Value = DateTime.Now;
            dateTime_ThanhToan_onValueChanged(sender, e);
            var query = from s in Cons.dataContext.Patients
                        join tr in Cons.dataContext.Treatments on s.PatientId equals tr.PatientId
                        where DateTime.Now == tr.dayOfTreatment     
                        select new
                        {
                            MaBenhNhan = s.PatientId,
                            HoTen = s.fullName,
                            NgaySinh = s.dateOfBirth,
                            GioiTinh = s.gender == true ? "Nam" : "Nữ",
                            SDT = s.phone,
                            DiaChi = s.address,
                            Email = s.email,
                            GhiChu = s.note

                        };
            dgv_BenhNhan.DataSource = query.Distinct();
            


            Cons.date = dateTime_ThanhToan.Value;

        }

        private void btn_LapPhieuThu_Click(object sender, EventArgs e)
        {
            Form_ThanhToan form_ThanhToan = new Form_ThanhToan();
            form_ThanhToan.closeForm += Form_ThanhToan_closeForm;
            form_ThanhToan.ShowDialog();
        }

        private void Form_ThanhToan_closeForm(object sender, EventArgs e)
        {
            UserControl_ThanhToan_Load(sender, e);
        }

        private void dgv_BenhNhan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row = dgv_BenhNhan.CurrentCell.RowIndex;
                Cons.PatientId = dgv_BenhNhan.Rows[row].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        

        private void dateTime_ThanhToan_onValueChanged(object sender, EventArgs e)
        {
            
            Cons.date = dateTime_ThanhToan.Value;
            var query = from s in Cons.dataContext.Patients
                        join tr in Cons.dataContext.Treatments on s.PatientId equals tr.PatientId
                        where dateTime_ThanhToan.Value.Day == tr.dayOfTreatment.Day && dateTime_ThanhToan.Value.Month == tr.dayOfTreatment.Month && dateTime_ThanhToan.Value.Year == tr.dayOfTreatment.Year
                        select new
                        {
                            MaBenhNhan = s.PatientId,
                            HoTen = s.fullName,
                            NgaySinh = s.dateOfBirth,
                            GioiTinh = s.gender == true ? "Nam" : "Nữ",
                            SDT = s.phone,
                            DiaChi = s.address,
                            Email = s.email,
                            GhiChu = s.note

                        };
            dgv_BenhNhan.DataSource = query.Distinct();
            /*dgv_BenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //in hóa đơn đã tạo
            var query = from r in Cons.dataContext.Receipts
                        where Cons.PatientId == r.PatientId && dateTime_ThanhToan.Value.Day == r.receiptdate.Value.Day && dateTime_ThanhToan.Value.Month == r.receiptdate.Value.Day && dateTime_ThanhToan.Value.Year == r.receiptdate.Value.Year
                        select r;
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();

                _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                _PrintDocument.PrintPage += new PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                                                                                       //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                }
            }
            catch (Exception)
            {

            }
        }
        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                var queryServices = from i in Cons.dataContext.Treatments
                                    join st in Cons.dataContext.ServiceTreatments on i.TreatmentId equals st.TreatmentId
                                    join s in Cons.dataContext.Services on st.ServiceId equals s.ServiceId
                                    where Cons.PatientId == i.PatientId && i.dayOfTreatment.Day == Cons.date.Day && i.dayOfTreatment.Month == Cons.date.Month && i.dayOfTreatment.Year == Cons.date.Year
                                    select new
                                    {
                                        TenDichVu = s.nameService,
                                        GiaThanh = s.price
                                    };
                var queryMedicines = from pre in Cons.dataContext.Prescriptions
                                     join pm in Cons.dataContext.PrescriptionMedicines on pre.PrescriptionId equals pm.PrescriptionId
                                     join m in Cons.dataContext.Medicines on pm.MedicineId equals m.MedicineId
                                     where Cons.PatientId == pre.PatientId && pre.createdDate.Value.Day == Cons.date.Day && pre.createdDate.Value.Month == Cons.date.Month && pre.createdDate.Value.Year == Cons.date.Year
                                     select new
                                     {
                                         TenThuoc = m.nameMedicine,
                                         SoLuong = pm.quantity,
                                         DonGia = m.price,
                                         GiaThanh = pm.quantity * m.quantity,
                                     };

                decimal total = 0;
                Graphics graphic = e.Graphics;
                Font font = new Font("Courier New", 12);
                float FontHeight = font.GetHeight();
                int startX = 10;
                int startY = 10;
                int offset = 40;

                graphic.DrawImage(Properties.Resources.hospital, 10, 10, 50, 50);
                graphic.DrawString("PHÒNG KHÁM PTP", new Font("Courier New", 18), new SolidBrush(Color.Black), startX + 60, startY);
                graphic.DrawString("THÀNH PHỐ HỒ CHÍ MINH", new Font("Courier New", 10), new SolidBrush(Color.Black), startX + 60, startY + 25);
                graphic.DrawString("CLINICPTP.VN", new Font("Courier New", 12), new SolidBrush(Color.Black), startX + 60, startY + offset);

                Pen blackPen = new Pen(Color.Black, 1);
                PointF point1 = new PointF(startX, startY + offset + 20);
                PointF point2 = new PointF(350, startY + offset + 20);
                e.Graphics.DrawLine(blackPen, point1, point2);

                offset = offset + (int)FontHeight; //make the spacing consistent
                offset = offset + (int)FontHeight + 5; //make the spacing consistent

                graphic.DrawString("PHIẾU THU", new Font("Courier New", 22), new SolidBrush(Color.Black), startX + 105, startY + offset);


                offset = offset + (int)FontHeight; //make the spacing consistent
                offset = offset + (int)FontHeight + 5; //make the spacing consistent
                string top = "Tên Dịch Vụ".PadRight(24) + "Thành Tiền";
                graphic.DrawString(top, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)FontHeight; //make the spacing consistent
                graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)FontHeight; //make the spacing consistent
                offset = offset + (int)FontHeight + 5; //make the spacing consistent


                foreach (var item in queryServices.ToList())
                {
                    total += decimal.Parse(item.GiaThanh.ToString());
                    graphic.DrawString(item.TenDichVu, font, new SolidBrush(Color.Black), startX, startY + offset);
                    graphic.DrawString(item.GiaThanh.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                    offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                }

                offset = offset + (int)FontHeight; //make the spacing consistent
                                                   //graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
                top = "Thuốc".PadRight(24);

                graphic.DrawString(top, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)FontHeight; //make the spacing consistent
                graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent


                foreach (var item in queryMedicines.ToList())
                {
                    total += decimal.Parse(item.GiaThanh.ToString());
                    graphic.DrawString(item.TenThuoc + " x " + item.SoLuong, font, new SolidBrush(Color.Black), startX, startY + offset);
                    graphic.DrawString((decimal.Parse(item.SoLuong.ToString()) * item.DonGia).ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                    offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                }

                offset = offset + 20; //make some room so that the total stands out.



                graphic.DrawString("TỔNG TIỀN TRẢ ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(_DoiSoSangDonViTienTe(total), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("TIỀN MẶT ", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(_DoiSoSangDonViTienTe(0), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("TIỀN TRẢ ", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(_DoiSoSangDonViTienTe(0), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              

                point1 = new PointF(startX, startY + offset + 20);
                point2 = new PointF(350, startY + offset + 20);
                e.Graphics.DrawLine(blackPen, point1, point2);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent    

                graphic.DrawString(" CẢM ƠN BẠN ĐÃ GHÉ THĂM!,", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("HI VỌNG BẠN SẼ GHÉ THĂM LẠI!", font, new SolidBrush(Color.Black), startX, startY + offset);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static string _DoiSoSangDonViTienTe(object _object)
        {
            try
            {
                if (_object.ToString().Trim().Length == 0)
                { return " "; }

                if (_object.ToString() == "0")
                {
                    return "0,000";
                }

                decimal dThanhTien = Convert.ToDecimal(_object);
                string strThanhTien = string.Format("{0:#,#.}", dThanhTien);
                return strThanhTien;
            }
            catch (Exception)
            {

            }
            return "0,000";
        }

        public void Resize_L()
        {
            label1.Location = new System.Drawing.Point(this.Width / 2 - label1.Width / 2, label1.Location.Y);
            /*dgv_BenhNhan.Height = this.Height * 5 / 6;*/
        }
        private void UserControl_ThanhToan_Resize(object sender, EventArgs e)
        {
            Resize_L();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_BenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
