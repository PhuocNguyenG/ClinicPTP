using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace TEST
{
    public partial class UserControl_QuanLyBenhNhan : UserControl
    {
        public UserControl_QuanLyBenhNhan()
        {
            InitializeComponent();
            DataGrid_QuanLyBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region khai báo
        
        Frm_EditBenhNhan edit = new Frm_EditBenhNhan();
        #endregion

        private void UserControl_QuanLyBenhNhan_Load(object sender, EventArgs e)
        {

           

            var query = from s in Cons.dataContext.Patients
                        select new 
                        {
                            
                            MaBenhNhan = s.PatientId , HoTen= s.fullName , NgaySinh = s.dateOfBirth,GioiTinh = s.gender == true? "Nam" : "Nữ", SDT = s.phone,DiaChi = s.address,Email=s.email,GhiChu=s.note
                           
                        };
            DataGrid_QuanLyBenhNhan.DataSource = query;
        }


        public void Resize_L()
        {
            lbl_Tilte_QLBN.Location = new System.Drawing.Point(this.Width / 2 - lbl_Tilte_QLBN.Width / 2, lbl_Tilte_QLBN.Location.Y);
            /*panel_HienThi_QLDV.Height = this.Height * 5 / 6;*/
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_AddBenhNhan add = new Frm_AddBenhNhan();
            add.click_CloseForm += Add_click_CloseForm;
            add.ShowDialog();
        }

        private void Add_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_QuanLyBenhNhan_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit.txtMaBenhNhan.Enabled = false;
            edit.click_CloseForm += Edit_click_CloseForm;
            edit.ShowDialog();
        }

        private void Edit_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_QuanLyBenhNhan_Load(sender, e);
        }

        private void DataGrid_QuanLyBenhNhan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = DataGrid_QuanLyBenhNhan.CurrentCell.RowIndex;
            edit.txtMaBenhNhan.Text = DataGrid_QuanLyBenhNhan.Rows[i].Cells[0].Value.ToString();
            edit.txtTenBenhNhan.Text = DataGrid_QuanLyBenhNhan.Rows[i].Cells[1].Value.ToString();
            edit.dtpkNgaySinh.Text = DataGrid_QuanLyBenhNhan.Rows[i].Cells[2].Value.ToString();
            if (DataGrid_QuanLyBenhNhan.Rows[i].Cells[3].Value.ToString() == "Nam")
            {
                edit.radioButton_Nam.Checked = true;
            }
            if (DataGrid_QuanLyBenhNhan.Rows[i].Cells[3].Value.ToString() == "Nữ")
            {
                edit.radioButton_Nu.Checked = true;
            }
            edit.txtSoDienThoai.Text = DataGrid_QuanLyBenhNhan.Rows[i].Cells[4].Value.ToString();
            edit.txtDiaChi.Text = DataGrid_QuanLyBenhNhan.Rows[i].Cells[5].Value.ToString();
            edit.txtEmail.Text = DataGrid_QuanLyBenhNhan.Rows[i].Cells[6].Value.ToString();
            edit.txtGhiChu.Text = DataGrid_QuanLyBenhNhan.Rows[i].Cells[7].Value.ToString();
            Cons.temp = DataGrid_QuanLyBenhNhan.Rows[i].Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient = Cons.dataContext.Patients.Where(ma => ma.PatientId == Cons.temp).Single();
            Cons.dataContext.Patients.DeleteOnSubmit(patient);
            Cons.dataContext.SubmitChanges();
            UserControl_QuanLyBenhNhan_Load(sender, e);
        }

        private void txtTimKiem_KeyDown(object sender, EventArgs e)
        {
            if (txtTimKiem.text == "Tìm kiếm")
            {
                txtTimKiem.text = "";
            }
        }

        private void txtTimKiem_KeyUp(object sender, EventArgs e)
        {
            if (txtTimKiem.text == "")
            {
                txtTimKiem.text = "Tìm kiếm";
            }
        }

        private void txtTimKiem_OnTextChange(object sender, EventArgs e)
        {
            if (txtTimKiem.text =="" || txtTimKiem.text =="Tìm kiếm")
            {
                var query = from s in Cons.dataContext.Patients
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
                DataGrid_QuanLyBenhNhan.DataSource = query;
            }
            else
            {
                var query = from s in Cons.dataContext.Patients where s.PatientId.Contains(txtTimKiem.text) || s.fullName.Contains(txtTimKiem.text)
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
                DataGrid_QuanLyBenhNhan.DataSource = query;
            }
        }








        #region Xuất file excel

        
        public void XuatFile()
        {
            try
            {
                FolderBrowserDialog fl = new FolderBrowserDialog();
                fl.SelectedPath = "c:\\windows\\system32";//co the lay duong dan tu file 
                fl.ShowNewFolderButton = true;
                string saveExcelFile = "";
                if (fl.ShowDialog() == DialogResult.OK)
                {
                    saveExcelFile = fl.SelectedPath + "\\excel_QuanLyBenhNhan_report.xlsx";
                }
               // string saveExcelFile = @"F:\excel_QuanLyBenhNhan_report.xlsx";

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;

                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe_BenhNhan = ws.get_Range("A1", "I1");
                row1_TieuDe_BenhNhan.Merge();
                row1_TieuDe_BenhNhan.Font.Size = fontSizeTieuDe;
                row1_TieuDe_BenhNhan.Font.Name = fontName;
                row1_TieuDe_BenhNhan.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_BenhNhan.Value2 = "Thống kê danh sách bệnh nhân";
                row1_TieuDe_BenhNhan.RowHeight = 30;

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2", "A3");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã bệnh nhân :
                Range row23_MaBenhNhan = ws.get_Range("B2", "B3");//Cột B dòng 2 và dòng 3
                row23_MaBenhNhan.Merge();
                row23_MaBenhNhan.Font.Size = fontSizeTenTruong;
                row23_MaBenhNhan.Font.Name = fontName;
                row23_MaBenhNhan.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaBenhNhan.Value2 = "Mã Bệnh Nhân";
                row23_MaBenhNhan.ColumnWidth = 30;

                //Tạo Ô Tên bệnh nhân :
                Range row23_TenBenhNhan = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_TenBenhNhan.Merge();
                row23_TenBenhNhan.Font.Size = fontSizeTenTruong;
                row23_TenBenhNhan.Font.Name = fontName;
                row23_TenBenhNhan.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenBenhNhan.ColumnWidth = 30;
                row23_TenBenhNhan.Value2 = "Tên Bệnh Nhân";



                Range row23_NgaySinh = ws.get_Range("D2", "D3");//Cột C dòng 2 và dòng 3
                row23_NgaySinh.Merge();
                row23_NgaySinh.Font.Size = fontSizeTenTruong;
                row23_NgaySinh.Font.Name = fontName;
                row23_NgaySinh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_NgaySinh.ColumnWidth = 20;
                row23_NgaySinh.Value2 = "Ngày Sinh";


                //Tạo Ô Giới tính:
                Range row23_GioiTinh = ws.get_Range("E2", "E3");//Ô D3
                row23_GioiTinh.Merge();
                row23_GioiTinh.Font.Size = fontSizeTenTruong;
                row23_GioiTinh.Font.Name = fontName;
                row23_GioiTinh.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_GioiTinh.Value2 = "Giới tính";
                row23_GioiTinh.ColumnWidth = 20;

                //Tạo Ô SDT:
                Range row23_SDT = ws.get_Range("F2", "F3");//Ô E3
                row23_SDT.Merge();
                row23_SDT.Font.Size = fontSizeTenTruong;
                row23_SDT.Font.Name = fontName;
                row23_SDT.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_SDT.Value2 = "Số Điện Thoại";
                row23_SDT.ColumnWidth = 30;


                //Tạo Ô Địa chỉ
                Range row23_DiaChi = ws.get_Range("G2", "G3");//Ô E3
                row23_DiaChi.Merge();
                row23_DiaChi.Font.Size = fontSizeTenTruong;
                row23_DiaChi.Font.Name = fontName;
                row23_DiaChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_DiaChi.Value2 = "Địa Chỉ";
                row23_DiaChi.ColumnWidth = 50;


                //Tạo Ô email
                Range row23_Email = ws.get_Range("H2", "H3");//Ô E3
                row23_Email.Merge();
                row23_Email.Font.Size = fontSizeTenTruong;
                row23_Email.Font.Name = fontName;
                row23_Email.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_Email.Value2 = "Email";
                row23_Email.ColumnWidth = 45;

                //Tạo Ô ghi chú
                Range row23_Note = ws.get_Range("I2", "I3");//Ô E3
                row23_Note.Merge();
                row23_Note.Font.Size = fontSizeTenTruong;
                row23_Note.Font.Name = fontName;
                row23_Note.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_Note.Value2 = "Ghi chú";
                row23_Note.ColumnWidth = 20;

                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "I3");
                //nền xám trắng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 3;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)
                DentalClinicDataContext context = new DentalClinicDataContext();
                foreach (var sp in Cons.dataContext.Patients)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, sp.PatientId, sp.fullName, sp.dateOfBirth.ToString(), sp.gender==true?"Nam":"Nữ",sp.phone.ToString(),sp.address,sp.email,sp.note };
                    Range rowData = ws.get_Range("A" + row, "I" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "I" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            XuatFile();

        }
        #endregion

        private void UserControl_QuanLyBenhNhan_Resize(object sender, EventArgs e)
        {
            Resize_L();
        }

        private void DataGrid_QuanLyBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
