using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TEST.Xử_Lý_hóa_đơn;

namespace TEST
{
    public partial class Form_ThanhToan : Form
    {
        

        decimal total = 0;
        decimal tienMat = 0;
        decimal tienTra = 0;
        public Form_ThanhToan()
        {
            InitializeComponent();
        }

        private void Form_ThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                txtPhieuThu.Text = Cons.ranDomId();
                txt_BenhNhan.Text = (from i in Cons.dataContext.Patients where Cons.PatientId == i.PatientId select i).Single().fullName;

                // Add các dịch vụ vào note
                var queryServices = from i in Cons.dataContext.Treatments
                                    join st in Cons.dataContext.ServiceTreatments on i.TreatmentId equals st.TreatmentId
                                    join s in Cons.dataContext.Services on st.ServiceId equals s.ServiceId
                                    where Cons.PatientId == i.PatientId && i.dayOfTreatment.Day == Cons.date.Day && i.dayOfTreatment.Month == Cons.date.Month && i.dayOfTreatment.Year == Cons.date.Year
                                    select new
                                    {
                                        TenDichVu = s.nameService,
                                        GiaThanh = s.price
                                    };

                //Add tổng tiền thuốc.
                var queryMedicines = from pre in Cons.dataContext.Prescriptions
                                     join pm in Cons.dataContext.PrescriptionMedicines on pre.PrescriptionId equals pm.PrescriptionId
                                     join m in Cons.dataContext.Medicines on pm.MedicineId equals m.MedicineId
                                     where Cons.PatientId == pre.PatientId && pre.createdDate.Value.Day == Cons.date.Day && pre.createdDate.Value.Month == Cons.date.Month && pre.createdDate.Value.Year == Cons.date.Year
                                     select new
                                     {
                                         TenThuoc = m.nameMedicine,
                                         SoLuong = pm.quantity,
                                         DonGia = m.price,
                                         GiaThanh = pm.quantity*m.price,
                                     };



                

                txtNote.Text = "Danh sách dịch vụ\r\n";

                foreach (var item in queryServices)
                {
                    total += item.GiaThanh.Value;
                    txtNote.Text += item.TenDichVu + " - " + item.GiaThanh.ToString() + "VNĐ\r\n";
                }

                txtNote.Text += "Danh sách Thuốc\r\n";
                foreach (var item in queryMedicines)
                {
                    txtNote.Text += item.TenThuoc + " - " + item.SoLuong.ToString() + " - " + item.DonGia.ToString() + " - " + item.GiaThanh.ToString() + "VNĐ\r\n";
                    total += item.GiaThanh.Value;
                }

                txtTongTien.Text = total.ToString();
            }
            catch (Exception)
            {

                
            }
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler closeForm = null;

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Receipt receipt = new Receipt();
                receipt.ReceiptId = Cons.ranDomId();
                receipt.receiptdate = DateTime.Now;
                receipt.statusReceipt = true;
                receipt.PatientId = Cons.PatientId; 
                receipt.note = txtNote.Text;
                receipt.total = decimal.Parse(txtTongTien.Text);
                receipt.StaffId = (from a in Cons.dataContext.Accounts join s in Cons.dataContext.Staffs on a.StaffId equals s.StaffId where Cons.AccountID == a.AccountId select s).Single().StaffId;
                Cons.dataContext.Receipts.InsertOnSubmit(receipt);
                Cons.dataContext.SubmitChanges();
                //


                PrintReceipt();



                //
                closeForm(sender, e);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !");
            }
           


        }



        public void PrintReceipt()
        {
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


                Graphics graphic = e.Graphics;
                Font font = new Font("Courier New", 12);
                float FontHeight = font.GetHeight();
                int startX = 10;
                int startY = 10;
                int offset = 40;

                graphic.DrawImage(Properties.Resources.hospital, 10, 10, 50, 50);
                graphic.DrawString("PHÒNG KHÁM PTP", new Font("Courier New", 18), new SolidBrush(Color.Black), startX + 20, startY);
                graphic.DrawString("HỒ CHÍ MINH", new Font("Courier New", 10), new SolidBrush(Color.Black), startX + 30, startY + 25);
                graphic.DrawString("CLINICPTP.VN", new Font("Courier New", 12), new SolidBrush(Color.Black), startX + 30, startY + offset);

                Pen blackPen = new Pen(Color.Black, 1);
                PointF point1 = new PointF(startX, startY + offset + 20);
                PointF point2 = new PointF(350, startY + offset + 20);
                e.Graphics.DrawLine(blackPen, point1, point2);

                offset = offset + (int)FontHeight; //make the spacing consistent
                offset = offset + (int)FontHeight + 5; //make the spacing consistent

                graphic.DrawString("PHIẾU THU", new Font("Courier New", 22), new SolidBrush(Color.Black), startX + 95, startY + offset);


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

                    graphic.DrawString(item.TenThuoc + " x " + item.SoLuong, font, new SolidBrush(Color.Black), startX, startY + offset);
                    graphic.DrawString((decimal.Parse(item.SoLuong.ToString()) * item.DonGia).ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                    offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                }

                offset = offset + 20; //make some room so that the total stands out.



                graphic.DrawString("TỔNG TIỀN TRẢ ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(_DoiSoSangDonViTienTe(total), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 210, startY + offset);
                graphic.DrawString(" VNĐ", font, new SolidBrush(Color.Black), startX + 300, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("TIỀN MẶT ", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(_DoiSoSangDonViTienTe(tienMat), font, new SolidBrush(Color.Black), startX + 210, startY + offset);
                graphic.DrawString(" VNĐ", font, new SolidBrush(Color.Black), startX + 300, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("TIỀN THỪA ", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(_DoiSoSangDonViTienTe(tienTra), font, new SolidBrush(Color.Black), startX + 210, startY + offset);
                graphic.DrawString(" VNĐ", font, new SolidBrush(Color.Black), startX + 300, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              

                point1 = new PointF(startX, startY + offset + 20);
                point2 = new PointF(350, startY + offset + 20);
                e.Graphics.DrawLine(blackPen, point1, point2);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent    

                graphic.DrawString(" CẢM ƠN BẠN ĐÃ GHÉ THĂM!,", font, new SolidBrush(Color.Black), startX + 10, startY + offset);
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
            /*CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");*/
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            try
            {
                if (_object.ToString().Trim().Length == 0)
                { return " "; }

                if (_object.ToString() == "0")
                {
                    return "0";
                }
                
                Decimal dThanhTien = Convert.ToDecimal(_object);
                string strThanhTien = string.Format("{0:C0}", _object);
                return strThanhTien;
            }
            catch (Exception)
            {

            }
            return "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tienMat = decimal.Parse(txtTienMat.Text);
            tienTra = tienMat - total;
            txtTienTra.Text = tienTra.ToString();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
