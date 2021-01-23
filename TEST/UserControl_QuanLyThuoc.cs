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
    public partial class UserControl_QuanLyThuoc : UserControl
    {
        public UserControl_QuanLyThuoc()
        {
            InitializeComponent();
            DataGrid_QuanLyThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        DentalClinicDataContext dentalClinic = new DentalClinicDataContext();
        private void UserControl_QuanLyThuoc_Load(object sender, EventArgs e)
        {

            
            var medicines = from all in dentalClinic.Medicines join t in dentalClinic.TypeMedicines on all.TypeMedicineId equals t.TypeMedicineId 
                            select new
                            {
                                 MaThuoc = all.MedicineId  , TenThuoc=all.nameMedicine , SoLuong = all.quantity,
                                NgayHetHan= all.expirationDate, DonViTinh = all.unit ,LoaiThuoc = t.nameTypeOfMedicine
                            };
                                       
            DataGrid_QuanLyThuoc.DataSource = medicines;
            
        }
        public void Resize_L()
        {
            label1.Location = new System.Drawing.Point(this.Width / 2 - label1.Width / 2, label1.Location.Y);
            /*panel_HienThi_QLBN.Height = this.Height * 5 / 6;*/
        }

        private void UserControl_QuanLyThuoc_Resize(object sender, EventArgs e)
        {
            Resize_L();
        }

        private void txtTimKiem_OnTextChange(object sender, EventArgs e)
        {
            if(txtTimKiem.text=="" || txtTimKiem.text =="Tìm kiếm")
            {
                var medicines = from all in dentalClinic.Medicines
                                join t in dentalClinic.TypeMedicines on all.TypeMedicineId equals t.TypeMedicineId
                                select new
                                {
                                    MaThuoc = all.MedicineId,
                                    TenThuoc = all.nameMedicine,
                                    
                                    NgayHetHan = all.expirationDate,
                                    DonViTinh = all.unit,
                                    LoaiThuoc = t.nameTypeOfMedicine
                                };

                DataGrid_QuanLyThuoc.DataSource = medicines;
            }
            else
            {
                var list = from s in dentalClinic.Medicines
                           join t in dentalClinic.TypeMedicines on s.TypeMedicineId equals t.TypeMedicineId
                           where s.nameMedicine.Contains(txtTimKiem.text) || s.MedicineId.Contains(txtTimKiem.text)
                           select new
                           {
                               MaThuoc = s.MedicineId,
                               TenThuoc = s.nameMedicine,
                             
                               NgayHetHan = s.expirationDate,
                               DonViTinh = s.unit,
                               LoaiThuoc = t.nameTypeOfMedicine
                           };
                DataGrid_QuanLyThuoc.DataSource = list;
            }
            
        }

        

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
           
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_AddThuoc add = new Frm_AddThuoc();           
            add.click_CloseForm += Add_click_CloseForm;
            add.ShowDialog();
            
        }

        private void Add_click_CloseForm(object sender, EventArgs e)
        {
            this.UserControl_QuanLyThuoc_Load(sender, e);
        }
        Frm_EditThuoc edit = new Frm_EditThuoc();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit.click_CloseForm += Edit_click_CloseForm;
            //edit.txtMaThuoc.Enabled = false;
            edit.ShowDialog();
            
        }

        private void Edit_click_CloseForm(object sender, EventArgs e)
        {
            this.UserControl_QuanLyThuoc_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine = dentalClinic.Medicines.Where(s => s.MedicineId == Cons.temp).Single();
            dentalClinic.Medicines.DeleteOnSubmit(medicine);
            dentalClinic.SubmitChanges();
            UserControl_QuanLyThuoc_Load(sender, e);
            
        }
        
      
        private void DataGrid_QuanLyThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Frm_EditThuoc edit = new Frm_EditThuoc();
            int i = DataGrid_QuanLyThuoc.CurrentCell.RowIndex;
            edit.txtMaThuoc.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[0].Value.ToString();
            edit.txtTenThuoc.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[1].Value.ToString();
            edit.txtSoLuong.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[2].Value.ToString();
            edit.dtpkHanSuDung.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[3].Value.ToString();
            edit.txtDonViTinh.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[4].Value.ToString();
            edit.cbLoaiThuoc.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[5].Value.ToString();
            Cons.temp = DataGrid_QuanLyThuoc.Rows[i].Cells[0].Value.ToString();
        }

     

        private void txtTimKiem_KeyDown(object sender, EventArgs e)
        {
            if (txtTimKiem.text =="Tìm kiếm")
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
                    saveExcelFile = fl.SelectedPath + "\\Thống kê thuốc.xlsx";
                }
                //string saveExcelFile = @"F:\";
                
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
                row1_TieuDe_BenhNhan.Value2 = "Thống kê danh sách thuốc";
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
                row23_MaBenhNhan.Value2 = "Mã Thuốc";
                row23_MaBenhNhan.ColumnWidth = 15;

                //Tạo Ô Tên bệnh nhân :
                Range row23_TenBenhNhan = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_TenBenhNhan.Merge();
                row23_TenBenhNhan.Font.Size = fontSizeTenTruong;
                row23_TenBenhNhan.Font.Name = fontName;
                row23_TenBenhNhan.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenBenhNhan.ColumnWidth = 30;
                row23_TenBenhNhan.Value2 = "Tên Thuốc";



                Range row23_NgaySinh = ws.get_Range("D2", "D3");//Cột C dòng 2 và dòng 3
                row23_NgaySinh.Merge();
                row23_NgaySinh.Font.Size = fontSizeTenTruong;
                row23_NgaySinh.Font.Name = fontName;
                row23_NgaySinh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_NgaySinh.ColumnWidth = 20;
                row23_NgaySinh.Value2 = "Số Lượng";


                //Tạo Ô Giới tính:
                Range row23_GioiTinh = ws.get_Range("E2", "E3");//Ô D3
                row23_GioiTinh.Merge();
                row23_GioiTinh.Font.Size = fontSizeTenTruong;
                row23_GioiTinh.Font.Name = fontName;
                row23_GioiTinh.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_GioiTinh.Value2 = "Hạn Sử Dụng";
                row23_GioiTinh.ColumnWidth = 20;

                //Tạo Ô SDT:
                Range row23_SDT = ws.get_Range("F2", "F3");//Ô E3
                row23_SDT.Merge();
                row23_SDT.Font.Size = fontSizeTenTruong;
                row23_SDT.Font.Name = fontName;
                row23_SDT.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row23_SDT.Value2 = "Đơn Vị Tính";
                row23_SDT.ColumnWidth = 10;


                

                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "F3");
                //nền xám trắng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 3;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)
                DentalClinicDataContext context = new DentalClinicDataContext();
                foreach (var sp in Cons.dataContext.Medicines)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, sp.MedicineId, sp.nameMedicine, sp.quantity, sp.expirationDate.ToString(), sp.unit };
                    Range rowData = ws.get_Range("A" + row, "F" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "F" + row));

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
    }
}
