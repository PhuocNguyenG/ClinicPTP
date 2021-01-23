using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class UserControl_LichHen : UserControl
    {
        DentalClinicDataContext dataContext = new DentalClinicDataContext();
        public UserControl_LichHen()
        {
            InitializeComponent();
        }

        private void bnt_ThemLichHen_Click(object sender, EventArgs e)
        {
            Form_ThemLichHen formThemLichHen = new Form_ThemLichHen();
            formThemLichHen.click_CloseForm += FormThemLichHen_click_CloseForm;
            formThemLichHen.ShowDialog();
        }

        private void FormThemLichHen_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_LichHen_Load(sender, e);
        }
        Form_SuaLichHencs formSuaLichHen = new Form_SuaLichHencs();

        private void bnt_SuaLichHen_Click(object sender, EventArgs e)
        {
            formSuaLichHen.click_CloseForm += FormThemLichHen_click_CloseForm;
            formSuaLichHen.ShowDialog();
        }

        

        private void bnt_XoaLichHen_Click(object sender, EventArgs e)
        {
            Form_XoaLichHen formXoaLichHen = new Form_XoaLichHen();
            formXoaLichHen.click_CloseForm += FormThemLichHen_click_CloseForm;
            formXoaLichHen.ShowDialog();
        }

        private void UserControl_LichHen_Load(object sender, EventArgs e)
        {
            dgv_LichHen.DataSource = from a in dataContext.Appointments
                                     join p in dataContext.Patients on a.PatientId equals p.PatientId
                                     select new
                                     {
                                         MaLichHen = a.AppointmentId,
                                         TenLichHen = a.nameAppointment,
                                         NgayHen = a.scheduleDate,
                                         GioBatDau = a.timeBegin,
                                         GioiKetThuc = a.timeEnd,
                                         GhiChu = a.note,
                                         TenBenhNhan = p.fullName
                                     };
            dgv_LichHen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            

           
        }


        public void Resize_L()
        {
            lbl_Tilte_LichHen.Location = new System.Drawing.Point(this.Width / 2 - lbl_Tilte_LichHen.Width / 2, lbl_Tilte_LichHen.Location.Y);
            /*panel1.Height = this.Height * 5 / 6;*/
        }
        private void dgv_LichHen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rows = dgv_LichHen.CurrentCell.RowIndex;
            formSuaLichHen.txt_TenLichHen.Text = dgv_LichHen.Rows[rows].Cells[1].Value.ToString() ;
            formSuaLichHen.cmbMaBenhNhan.Text = dgv_LichHen.Rows[rows].Cells[6].Value.ToString();
            formSuaLichHen.dtp_NgayHen.Text = dgv_LichHen.Rows[rows].Cells[2].Value.ToString();

            string[] words = dgv_LichHen.Rows[rows].Cells[3].Value.ToString().Split(':');
            //MessageBox.Show(words[0]);
            formSuaLichHen.nud_GioBatDau.Value = int.Parse(words[0]);
            formSuaLichHen.nud_PhutBatDau.Value = int.Parse(words[1]);

            words = dgv_LichHen.Rows[rows].Cells[4].Value.ToString().Split(':');

            formSuaLichHen.nud_GioKetThuc.Value = int.Parse(words[0]);
            formSuaLichHen.nud_PhutKetThuc.Value = int.Parse(words[1]);

            formSuaLichHen.txtNote.Text = dgv_LichHen.Rows[rows].Cells[5].Value.ToString();
            Cons.temp = dgv_LichHen.Rows[rows].Cells[0].Value.ToString();
        }

        private void txt_TimKiem_OnTextChange(object sender, EventArgs e)
        {

           
                var filteredOrders = from a in dataContext.Appointments
                                      join p in dataContext.Patients on a.PatientId equals p.PatientId
                                      where p.fullName.Contains(txt_TimKiem.text) || a.AppointmentId.Contains(txt_TimKiem.text)
                                      select new
                                      {
                                          MaLichHen = a.AppointmentId,
                                          TenLichHen = a.nameAppointment,
                                          NgayHen = a.scheduleDate,
                                          GioBatDau = a.timeBegin,
                                          GioiKetThuc = a.timeEnd,
                                          GhiChu = a.note,
                                          TenBenhNhan = p.fullName
                                      };


                dgv_LichHen.DataSource = filteredOrders;
          
        }

       

     

        private void txt_TimKiem_KeyUp(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
            {
                txt_TimKiem.Text = "Tìm kiếm";
            }
        }

        private void txt_TimKiem_KeyDown(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Tìm kiếm")
            {
                txt_TimKiem.Text = "";
            }
        }

      
        private void UserControl_LichHen_Resize(object sender, EventArgs e)
        {
            Resize_L();
        }
    }
}
