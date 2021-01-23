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
    public partial class UserControl_QuanLyNVBS : UserControl
    {
        public UserControl_QuanLyNVBS()
        {
            InitializeComponent();
            DataGrid_QuanLyNVBS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #region Khai báo
        
        Frm_EditNVBS edit = new Frm_EditNVBS();
        #endregion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Resize_L()
        {
            label1.Location = new System.Drawing.Point(this.Width / 2 - label1.Width / 2, label1.Location.Y);
            /*panel_HienThi.Height = this.Height * 5 / 6;*/
        }

        private void UserControl_QuanLyNVBS_Load(object sender, EventArgs e)
        {
            var query = from s in Cons.dataContext.Staffs join t in Cons.dataContext.Positions on s.PositionId equals t.PositionId
                        select new
                        {
                            MaNV =s.StaffId,                            
                            HoTen = s.fullName,
                            NgaySinh = s.dateOfBirth,
                            ViTri = t.namePosition,
                            GioiTinh = s.gender ==true ? "Nam":"Nữ",
                            DiaChi = s.address,
                            SDT = s.phone,
                            CMT = s.identityNumber,
                            KinhNghiem = s.experience,
                            Email = s.email,
                            BangCap = s.certificateId,
                            GhiChu = s.note
                        };
            DataGrid_QuanLyNVBS.DataSource = query;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_AddNVBS add = new Frm_AddNVBS();
            add.click_CloseForm += Add_click_CloseForm;
            add.ShowDialog();
        }

        private void Add_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_QuanLyNVBS_Load(sender, e);
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff = Cons.dataContext.Staffs.Where(ma => ma.StaffId == Cons.temp).Single();
            Cons.dataContext.Staffs.DeleteOnSubmit(staff);
            Cons.dataContext.SubmitChanges();
            UserControl_QuanLyNVBS_Load(sender, e);
        }

        private void DataGrid_QuanLyNVBS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = DataGrid_QuanLyNVBS.CurrentCell.RowIndex;
            edit.txtMaNVBS.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[0].Value.ToString();
            edit.txtTenNVBS.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[1].Value.ToString();
            edit.dtpkNgaySinh.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[2].Value.ToString();
            edit.cbViTri.Text =  DataGrid_QuanLyNVBS.Rows[i].Cells[3].Value.ToString();
            if (DataGrid_QuanLyNVBS.Rows[i].Cells[4].Value.ToString() == "Nam")
            {
                edit.radioButton_Nam.Checked = true;
            }
            if (DataGrid_QuanLyNVBS.Rows[i].Cells[4].Value.ToString() == "Nữ")
            {
                edit.radioButton_Nu.Checked = true;
            }
            edit.txtDiaChi.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[5].Value.ToString();
            edit.txtSoDienThoai.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[6].Value.ToString();
            edit.txtCMT.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[7].Value.ToString();
            edit.txtKinhNghiem.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[8].Value.ToString();
            edit.txtEmail.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[9].Value.ToString();
            edit.txtBangCap.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[10].Value.ToString();
            edit.txtGhiChu.Text = DataGrid_QuanLyNVBS.Rows[i].Cells[11].Value.ToString();
            Cons.temp = DataGrid_QuanLyNVBS.Rows[i].Cells[0].Value.ToString();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit.txtMaNVBS.Enabled = false;
            edit.click_CloseForm += Edit_click_CloseForm;
            edit.ShowDialog();
        }

        private void Edit_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_QuanLyNVBS_Load(sender, e);
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
            if (txtTimKiem.text == "" || txtTimKiem.text == "Tìm kiếm")
            {
                var query = from s in Cons.dataContext.Staffs
                            join t in Cons.dataContext.Positions on s.PositionId equals t.PositionId
                            select new
                            {
                                MaNV = s.StaffId,
                                HoTen = s.fullName,
                                NgaySinh = s.dateOfBirth,
                                ViTri = t.namePosition,
                                GioiTinh = s.gender == true ? "Nam" : "Nữ",
                                DiaChi = s.address,
                                SDT = s.phone,
                                CMT = s.identityNumber,
                                KinhNghiem = s.experience,
                                Email = s.email,
                                BangCap = s.certificateId,
                                GhiChu = s.note
                            };
                DataGrid_QuanLyNVBS.DataSource = query;
            }
            else
            {
                var query = from s in Cons.dataContext.Staffs
                            join t in Cons.dataContext.Positions on s.PositionId equals t.PositionId where s.StaffId.Contains(txtTimKiem.text) || s.fullName.Contains(txtTimKiem.text)
                            select new
                            {
                                MaNV = s.StaffId,
                                HoTen = s.fullName,
                                NgaySinh = s.dateOfBirth,
                                ViTri = t.namePosition,
                                GioiTinh = s.gender == true ? "Nam" : "Nữ",
                                DiaChi = s.address,
                                SDT = s.phone,
                                CMT = s.identityNumber,
                                KinhNghiem = s.experience,
                                Email = s.email,
                                BangCap = s.certificateId,
                                GhiChu = s.note
                            };
                DataGrid_QuanLyNVBS.DataSource = query;
            }
        }
        
        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            XuatFile();
        }




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
                    saveExcelFile = fl.SelectedPath + "\\excel_report_Staff.xlsx";
                }
                //string saveExcelFile = @"F:\excel_report_Staff.xlsx";

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
                Range row1_TieuDe_NhanVien = ws.get_Range("A1", "L1");
                row1_TieuDe_NhanVien.Merge();
                row1_TieuDe_NhanVien.Font.Size = fontSizeTieuDe;
                row1_TieuDe_NhanVien.Font.Name = fontName;
                row1_TieuDe_NhanVien.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_NhanVien.Value2 = "Thống kê danh sách nhân viên/bác sĩ";
                row1_TieuDe_NhanVien.RowHeight = 30;

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2", "A3");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã bệnh nhân :
                Range row23_MaNhanVien = ws.get_Range("B2", "B3");//Cột B dòng 2 và dòng 3
                row23_MaNhanVien.Merge();
                row23_MaNhanVien.Font.Size = fontSizeTenTruong;
                row23_MaNhanVien.Font.Name = fontName;
                row23_MaNhanVien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaNhanVien.Value2 = "Mã Nhân Viên";
                row23_MaNhanVien.ColumnWidth = 20;

                //Tạo Ô Tên bệnh nhân :
                Range row23_CMND = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_CMND.Merge();
                row23_CMND.Font.Size = fontSizeTenTruong;
                row23_CMND.Font.Name = fontName;
                row23_CMND.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_CMND.ColumnWidth = 30;
                row23_CMND.Value2 = "Chứng Minh Nhân Dân";



                Range row23_TenNhanVien = ws.get_Range("D2", "D3");//Cột C dòng 2 và dòng 3
                row23_TenNhanVien.Merge();
                row23_TenNhanVien.Font.Size = fontSizeTenTruong;
                row23_TenNhanVien.Font.Name = fontName;
                row23_TenNhanVien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenNhanVien.ColumnWidth = 25;
                row23_TenNhanVien.Value2 = "Họ Và Tên";


                //Tạo Ô Giới tính:
                Range row23_NgaySinh = ws.get_Range("E2", "E3");//Ô D3
                row23_NgaySinh.Merge();
                row23_NgaySinh.Font.Size = fontSizeTenTruong;
                row23_NgaySinh.Font.Name = fontName;
                row23_NgaySinh.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_NgaySinh.Value2 = "Ngày Sinh";
                row23_NgaySinh.ColumnWidth = 26;

                //Tạo Ô SDT:
                Range row23_GioiTinh = ws.get_Range("F2", "F3");//Ô E3
                row23_GioiTinh.Merge();
                row23_GioiTinh.Font.Size = fontSizeTenTruong;
                row23_GioiTinh.Font.Name = fontName;
                row23_GioiTinh.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_GioiTinh.Value2 = "Giới Tính";
                row23_GioiTinh.ColumnWidth = 12;


                //Tạo Ô Địa chỉ
                Range row23_DiaChi = ws.get_Range("G2", "G3");//Ô E3
                row23_DiaChi.Merge();
                row23_DiaChi.Font.Size = fontSizeTenTruong;
                row23_DiaChi.Font.Name = fontName;
                row23_DiaChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_DiaChi.Value2 = "Địa Chỉ";
                row23_DiaChi.ColumnWidth = 50;


                

                //Tạo Ô ghi chú
                Range row23_SDT = ws.get_Range("H2", "H3");//Ô E3
                row23_SDT.Merge();
                row23_SDT.Font.Size = fontSizeTenTruong;
                row23_SDT.Font.Name = fontName;
                row23_SDT.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_SDT.Value2 = "Số Điện Thoại";
                row23_SDT.ColumnWidth = 16;


                Range row23_KinhNghiem = ws.get_Range("I2", "I3");//Ô E3
                row23_KinhNghiem.Merge();
                row23_KinhNghiem.Font.Size = fontSizeTenTruong;
                row23_KinhNghiem.Font.Name = fontName;
                row23_KinhNghiem.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_KinhNghiem.Value2 = "Kinh Nghiệm";
                row23_KinhNghiem.ColumnWidth = 20;

                //Tạo Ô email
                Range row23_Email = ws.get_Range("J2", "J3");//Ô E3
                row23_Email.Merge();
                row23_Email.Font.Size = fontSizeTenTruong;
                row23_Email.Font.Name = fontName;
                row23_Email.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_Email.Value2 = "Email";
                row23_Email.ColumnWidth = 35;

                Range row23_Note = ws.get_Range("K2", "K3");//Ô E3
                row23_Note.Merge();
                row23_Note.Font.Size = fontSizeTenTruong;
                row23_Note.Font.Name = fontName;
                row23_Note.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_Note.Value2 = "Ghi Chú";
                row23_Note.ColumnWidth = 50;


                Range row23_TrinhDo = ws.get_Range("L2", "L3");//Ô E3
                row23_TrinhDo.Merge();
                row23_TrinhDo.Font.Size = fontSizeTenTruong;
                row23_TrinhDo.Font.Name = fontName;
                row23_TrinhDo.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_TrinhDo.Value2 = "Trình Độ";
                row23_TrinhDo.ColumnWidth = 25;


                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "L3");
                //nền xám trắng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 3;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)
                DentalClinicDataContext context = new DentalClinicDataContext();
                foreach (var sp in Cons.dataContext.Staffs)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, sp.StaffId, sp.identityNumber,sp.fullName, sp.dateOfBirth.ToString(), sp.gender == true ? "Nam" : "Nữ", sp.address, sp.phone.ToString(),sp.experience, sp.email, sp.note,sp.certificateId };
                    Range rowData = ws.get_Range("A" + row, "L" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "L" + row));

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

        private void UserControl_QuanLyNVBS_Resize(object sender, EventArgs e)
        {
            Resize_L();
        }
    }
}
