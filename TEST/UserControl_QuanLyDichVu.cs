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
    public partial class UserControl_QuanLyDichVu : UserControl
    {
        public UserControl_QuanLyDichVu()
        {
            InitializeComponent();
            DataGrid_QuanLyDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #region Thuộc tính
        DentalClinicDataContext dentalClinic = new DentalClinicDataContext();
        #endregion

        public void Resize_L()
        {
            /*label1.Location = new System.Drawing.Point(this.Width / 2 - label1.Width / 2, label1.Location.Y);*/
/*            panel_HienThi_QLDV.Height = this.Height * 5 / 6;*/
        }

        private void UserControl_QuanLyDichVu_Resize(object sender, EventArgs e)
        {
            Resize_L();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Xử lý thêm sửa xóa tìm kiếm

        
        private void UserControl_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            var query = from s in dentalClinic.Services
                        select new
                        {
                            MaDichVu = s.ServiceId, TenDichVu = s.nameService , GiaTien = s.price, MoTa = s.note
                        };
            DataGrid_QuanLyDichVu.DataSource = query;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_AddDichVu add = new Frm_AddDichVu();
            add.click_CloseForm += Add_click_CloseForm;
            add.ShowDialog();
            
        }

        private void Add_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_QuanLyDichVu_Load(sender, e);
        }

        Frm_Edit_DichVu edit = new Frm_Edit_DichVu();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit.txtMaDichVu.Enabled = false;
            edit.click_CloseForm += Edit_click_CloseForm;
            edit.ShowDialog();
        }

        private void Edit_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_QuanLyDichVu_Load(sender, e);
        }

        private void DataGrid_QuanLyDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = DataGrid_QuanLyDichVu.CurrentCell.RowIndex;
            edit.txtMaDichVu.Text = DataGrid_QuanLyDichVu.Rows[i].Cells[0].Value.ToString();
            edit.txtTenDichVu.Text = DataGrid_QuanLyDichVu.Rows[i].Cells[1].Value.ToString();
            edit.txtGiaTien.Text = DataGrid_QuanLyDichVu.Rows[i].Cells[2].Value.ToString();
            edit.txtMoTa.Text = DataGrid_QuanLyDichVu.Rows[i].Cells[3].Value.ToString();           
            Cons.temp = DataGrid_QuanLyDichVu.Rows[i].Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service = dentalClinic.Services.Where(ma => ma.ServiceId == Cons.temp).Single();
            dentalClinic.Services.DeleteOnSubmit(service);
            dentalClinic.SubmitChanges();
            UserControl_QuanLyDichVu_Load(sender, e);
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
                var query = from s in Cons.dataContext.Services
                            select new
                            {
                                MaThuoc = s.ServiceId,
                                TenThuoc = s.nameService,
                                GiaTien = s.price,
                                MoTa = s.note
                            };
                DataGrid_QuanLyDichVu.DataSource = query;
            }
            else
            {
               /* var query = dentalClinic.Services.Where(c => c.nameService.Contains(txtTimKiem.Text));*/
                 var query = from s in Cons.dataContext.Services
                            where s.nameService.Contains(txtTimKiem.Text)
                            select new
                            {
                                MaThuoc = s.ServiceId,
                                TenThuoc = s.nameService,
                                GiaTien = s.price,
                                MoTa = s.note
                            };
                DataGrid_QuanLyDichVu.DataSource = query;
            }

        }

        #endregion

        #region Xuất file excel


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
                    saveExcelFile = fl.SelectedPath + "\\Excel_Report_Service.xlsx";
                }

                //string saveExcelFile = @"F:\Excel_Report_Service.xlsx";

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
                Range row1_TieuDe_BenhNhan = ws.get_Range("A1", "D1");
                row1_TieuDe_BenhNhan.Merge();
                row1_TieuDe_BenhNhan.Font.Size = fontSizeTieuDe;
                row1_TieuDe_BenhNhan.Font.Name = fontName;
                row1_TieuDe_BenhNhan.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_BenhNhan.Value2 = "Thống kê danh sách dịch vụ";
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
                row23_MaBenhNhan.Value2 = "Mã Dịch Vụ";
                row23_MaBenhNhan.ColumnWidth = 6;

                //Tạo Ô Tên bệnh nhân :
                Range row23_TenBenhNhan = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_TenBenhNhan.Merge();
                row23_TenBenhNhan.Font.Size = fontSizeTenTruong;
                row23_TenBenhNhan.Font.Name = fontName;
                row23_TenBenhNhan.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenBenhNhan.ColumnWidth = 30;
                row23_TenBenhNhan.Value2 = "Tên Dịch Vụ";



                Range row23_NgaySinh = ws.get_Range("D2", "D3");//Cột C dòng 2 và dòng 3
                row23_NgaySinh.Merge();
                row23_NgaySinh.Font.Size = fontSizeTenTruong;
                row23_NgaySinh.Font.Name = fontName;
                row23_NgaySinh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_NgaySinh.ColumnWidth = 20;
                row23_NgaySinh.Value2 = "Giá Thành";


                

                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "D3");
                //nền xám trắng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 3;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)
                DentalClinicDataContext context = new DentalClinicDataContext();
                foreach (var sp in Cons.dataContext.Services)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, sp.ServiceId, sp.nameService, sp.price };
                    Range rowData = ws.get_Range("A" + row, "D" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "D" + row));

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
        #endregion

        private void DataGrid_QuanLyDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
