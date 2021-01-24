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
    public partial class UserControl_DieuTri : UserControl
    {
        public UserControl_DieuTri()
        {
            InitializeComponent();
            dgv_DichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DieuTri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_BenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        

        private void UserControl_DieuTri_Load(object sender, EventArgs e)
        {
            var queryT = from p in Cons.dataContext.Patients
                        join t in Cons.dataContext.Treatments on p.PatientId equals t.PatientId
                        join s in Cons.dataContext.Staffs on t.StaffId equals s.StaffId
                        select new
                        {
                            MaDieuTri = t.TreatmentId,
                            ChuanDoan = t.diagnose,
                            PhuongPhapDieuTri = t.method,
                            NgayDieuTri = t.dayOfTreatment,
                            MaBacSi = t.StaffId,
                            TenBacSi = s.fullName,
                            MaBenhNhan = p.PatientId,
                            TenBenhNhan = p.fullName
                        };
            dgv_DieuTri.DataSource = queryT;

            
            var queryPatients = from p in Cons.dataContext.Patients
                                select new
                                {
                                    
                                    MaBenhNhan = p.PatientId,
                                    HoTen = p.fullName,
                                    NgaySinh = p.dateOfBirth,
                                    GioiTinh = p.gender == true ? "Nam" : "Nữ",
                                    SDT = p.phone,
                                    DiaChi = p.address,
                                    Email = p.email,
                                    GhiChu = p.note

                                };
            dgv_BenhNhan.DataSource = queryPatients;
            


            var queryServices = from s in Cons.dataContext.Services
                         select new
                         {
                             MaThuoc = s.ServiceId,
                             TenThuoc = s.nameService,
                             GiaTien = s.price,
                             MoTa = s.note
                         };

            dgv_DichVu.DataSource = queryServices;
            dgv_DichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*public void Resize_L()
        {
            lbl_Tilte_DieuTri.Location = new Point(322, 124);
            lbl_Tilte_DieuTri.Location = new System.Drawing.Point(this.Width / 2 - lbl_Tilte_DieuTri.Width / 2, lbl_Tilte_DieuTri.Location.Y);
            
            panel1.Height = this.Height * 9 / 11;
            pnl_Group.Height = panel1.Height - pnl_Group2.Height - 40;
            
            pnl_BenhNhan.Width = this.Width * 6 / 10;
            panel3.Width = pnl_BenhNhan.Width;
            //pnl_Group2.Height = panel1.Height - pnl_Group.Height - label1.Height;
        }*/

        private void dgv_BenhNhan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_BenhNhan.CurrentCell.RowIndex;
            add_DieuTri.txtMaBenhNhan.Text = dgv_BenhNhan.Rows[i].Cells[0].Value.ToString();
            add_DieuTri.txtTenBenhNhan.Text = dgv_BenhNhan.Rows[i].Cells[1].Value.ToString();
            add_DieuTri.dtpkNgaySinh.Text = dgv_BenhNhan.Rows[i].Cells[2].Value.ToString();
            if (dgv_BenhNhan.Rows[i].Cells[3].Value.ToString() =="Nam")
            {
                add_DieuTri.radioButton_Nam.Checked = true;
            }
            if (dgv_BenhNhan.Rows[i].Cells[3].Value.ToString() == "Nữ")
            {
                add_DieuTri.radioButton_Nu.Checked = true;

            }

            add_DieuTri.txtSoDienThoai.Text = dgv_BenhNhan.Rows[i].Cells[4].Value.ToString();
            add_DieuTri.txtDiaChi.Text = dgv_BenhNhan.Rows[i].Cells[5].Value.ToString();
            Cons.PatientId = dgv_BenhNhan.Rows[i].Cells[0].Value.ToString();
            


        }

        Frm_Add_DieuTri add_DieuTri = new Frm_Add_DieuTri();
        Frm_Edit_DieuTri edit_DieuTri = new Frm_Edit_DieuTri();
        private void btnAdd_DieuTri_Click(object sender, EventArgs e)
        {
            
            add_DieuTri.click_close += Add_DieuTri_click_close;
            add_DieuTri.ShowDialog();
            UserControl_DieuTri_Load(sender, e);


        }

        private void Add_DieuTri_click_close(object sender, EventArgs e)
        {
            UserControl_DieuTri_Load(sender, e);
        }
        private void Edit_DieuTri_click_close(object sender, EventArgs e)
        {
            UserControl_DieuTri_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Treatment treatment = new Treatment();
            treatment = Cons.dataContext.Treatments.Where(ma => ma.TreatmentId == Cons.temp).Single();
            Cons.dataContext.Treatments.DeleteOnSubmit(treatment);
            Cons.dataContext.SubmitChanges();
            UserControl_DieuTri_Load(sender, e);
        }
        Frm_DichVuDieuTri frm_DichVuDieuTri = new Frm_DichVuDieuTri();
       
        string tam = "";
        private void dgv_DieuTri_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_DieuTri.CurrentCell.RowIndex;
            frm_DichVuDieuTri.txtMaDieuTri.Text = dgv_DieuTri.Rows[i].Cells[0].Value.ToString();
            tam = dgv_DieuTri.Rows[i].Cells[0].Value.ToString();
            Cons.temp = dgv_DieuTri.Rows[i].Cells[0].Value.ToString();
            edit_DieuTri.txtMaDieuTri.Text = dgv_DieuTri.Rows[i].Cells[0].Value.ToString();
            edit_DieuTri.txtMaBenhNhan.Text = dgv_DieuTri.Rows[i].Cells[4].Value.ToString();
            edit_DieuTri.txtMaBenhNhan1.Text = dgv_DieuTri.Rows[i].Cells[6].Value.ToString();
            edit_DieuTri.txtTenBenhNhan.Text = dgv_DieuTri.Rows[i].Cells[7].Value.ToString();
            edit_DieuTri.txtChuanDoan.Text = dgv_DieuTri.Rows[i].Cells[1].Value.ToString();
            edit_DieuTri.txtDieuTri.Text = dgv_DieuTri.Rows[i].Cells[2].Value.ToString();
            edit_DieuTri.txtDiaChi.Text = dgv_DieuTri.Rows[i].Cells[5].Value.ToString();
            edit_DieuTri.txtSoDienThoai.Text = dgv_DieuTri.Rows[i].Cells[3].Value.ToString();

        }

        private void dịchVụSựDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var st = from s in Cons.dataContext.ServiceTreatments
                     join p in Cons.dataContext.Services on s.ServiceId equals p.ServiceId where s.TreatmentId == tam
                     select new 
                     {
                         p.nameService

                     };

            string temp = "";
            int i = 1;
            foreach (var item in st.ToList())
            {
                temp += i.ToString() +". "+ item.nameService +"\n";
                i++;
            }
            MessageBox.Show(temp,"Dịch vụ đã sử dụng",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void đơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaoDonThuoc_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form_TaoDonThuoc form_TaoDon = new Form_TaoDonThuoc();
            form_TaoDon.ShowDialog();
            UserControl_DieuTri_Load(sender, e);
        }

        private void UserControl_DieuTri_Resize(object sender, EventArgs e)
        {
            /*Resize_L();*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Tilte_DieuTri_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (tam != "")
                frm_DichVuDieuTri.ShowDialog();
            else
                MessageBox.Show("Chọn bản ghi điều trị !");
        }

        private void txtTimKiem_OnTextChange(object sender, EventArgs e)
        {
            if (txtTimKiem.text == "" || txtTimKiem.text == "Mã Bệnh Nhân")
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
                dgv_BenhNhan.DataSource = query;
            }
            else
            {
                var query = from s in Cons.dataContext.Patients
                            where s.PatientId.Contains(txtTimKiem.text) || s.fullName.Contains(txtTimKiem.text)
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
                dgv_BenhNhan.DataSource = query;
            }
            
        }

        private void dgv_DieuTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
            

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            edit_DieuTri.ShowDialog();
            edit_DieuTri.click_close += Edit_DieuTri_click_close;
            UserControl_DieuTri_Load(sender, e);
        }

        private void dgv_DieuTri_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
