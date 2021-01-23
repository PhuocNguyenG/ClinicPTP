using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form_TaoDonThuoc : Form
    {
        public Form_TaoDonThuoc()
        {
            InitializeComponent();
        }

        private void Form_TaoDonThuoc_Load(object sender, EventArgs e)
        {
            

            
            var queryP = from p in Cons.dataContext.Patients
                         join pp in Cons.dataContext.Prescriptions on p.PatientId equals pp.PatientId
                         join s in Cons.dataContext.Staffs on pp.StaffId equals s.StaffId
                         where p.PatientId == Cons.PatientId
                         select new
                         {
                             MaDonThuoc = pp.PrescriptionId,
                             TenDonThuoc = pp.namePrescription,              
                             TenBenhNhan = p.fullName,
                             TenBacSi = s.fullName,
                             NgayTaoDon = pp.createdDate

                         };
            dgv_DonThuoc.DataSource = queryP.ToList();
            dgv_DonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // add cột cho lsv
            lvs_ChiTietDonThuoc.Columns.Add("STT");
            lvs_ChiTietDonThuoc.Columns.Add("Mã Thuốc");
            lvs_ChiTietDonThuoc.Columns.Add("Tên Thuốc");
            lvs_ChiTietDonThuoc.Columns.Add("Số Lượng");
            lvs_ChiTietDonThuoc.Columns.Add("Đơn vị tính");
            lvs_ChiTietDonThuoc.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // đẩy dữ liệu vào combo
            var queryT = from m in Cons.dataContext.Medicines
                         select m;
            cmb_Thuoc.DataSource = queryT;
            cmb_Thuoc.DisplayMember = "nameMedicine";
            cmb_Thuoc.ValueMember = "MedicineId";

        }
        string temp = "";

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            PrescriptionMedicine prescriptionMedicine = new PrescriptionMedicine();
            prescriptionMedicine.PrescriptionId = temp_Pre;
            prescriptionMedicine.MedicineId = cmb_Thuoc.SelectedValue.ToString();
            prescriptionMedicine.quantity = int.Parse(txtSoLuong.Text);

            Cons.dataContext.PrescriptionMedicines.InsertOnSubmit(prescriptionMedicine);
            Cons.dataContext.SubmitChanges();
            // đẩy ra listbox

            var query_pre = from pm in Cons.dataContext.PrescriptionMedicines
                            join m in Cons.dataContext.Medicines on pm.MedicineId equals m.MedicineId
                            where temp_Pre == pm.PrescriptionId
                            select new
                            {
                                pm.PrescriptionMedicineID,
                                m.nameMedicine
                                
                            };

            //lsb_Thuoc.Items.Clear();
            lsb_Thuoc.DataSource = query_pre.ToList();
            lsb_Thuoc.DisplayMember = "nameMedicine";
            lsb_Thuoc.ValueMember = "PrescriptionMedicineID";
        }

        string temp_Pre = "";
        private void btn_TaoDon_Click(object sender, EventArgs e)
        {
            try
            {
                Prescription prescription = new Prescription();
                prescription.PrescriptionId = Cons.ranDomId();

                temp_Pre = prescription.PrescriptionId;
                prescription.namePrescription = txtTenDon.Text;

                prescription.createdDate = DateTime.Now;
                prescription.PatientId = Cons.PatientId;

                var staff = from s in Cons.dataContext.Staffs
                            join a in Cons.dataContext.Accounts on s.StaffId equals a.StaffId
                            where Cons.AccountID == a.AccountId
                            select new
                            { s.StaffId };
                prescription.StaffId = staff.ToList()[0].StaffId;
                Cons.dataContext.Prescriptions.InsertOnSubmit(prescription);
                Cons.dataContext.SubmitChanges();

                // load lại dgv
                var queryP = from p in Cons.dataContext.Patients
                             join pp in Cons.dataContext.Prescriptions on p.PatientId equals pp.PatientId
                             join s in Cons.dataContext.Staffs on pp.StaffId equals s.StaffId
                             where p.PatientId == Cons.PatientId
                             select new
                             {
                                 MaDonThuoc = pp.PrescriptionId,
                                 TenDonThuoc = pp.namePrescription,
                                 TenBenhNhan = p.fullName,
                                 TenBacSi = s.fullName,
                                 NgayTaoDon = pp.createdDate

                             };
                dgv_DonThuoc.DataSource = queryP.ToList();
                dgv_DonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                //hiển thị cmb 
                cmb_Thuoc.Visible = true;
                cmb_Thuoc.Enabled = true;
                btn_Chon.Enabled = true;
                btn_Chon.Visible = true;
                lbl_Thuoc.Visible = true;

                lbl_SoLuong.Visible = true;
                txtSoLuong.Visible = true;
                txtSoLuong.Enabled = true;

                lbl_DanhSachChon.Visible = true;
                lsb_Thuoc.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void dgv_DonThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row = dgv_DonThuoc.CurrentCell.RowIndex;
                temp = dgv_DonThuoc.Rows[row].Cells[0].Value.ToString();    // lưu mã.
                                                                            // load sang bảng listview 
                var query = from pm in Cons.dataContext.PrescriptionMedicines
                            join m in Cons.dataContext.Medicines on pm.MedicineId equals m.MedicineId
                            where pm.PrescriptionId == temp
                            select new
                            {
                                MaThuoc = pm.MedicineId,
                                TenThuoc = m.nameMedicine,
                                SoLuong = pm.quantity,
                                DonViTinh = m.unit
                            };
                int i = 1;

                lvs_ChiTietDonThuoc.Items.Clear();
                foreach (var item in query.ToList())
                {
                    ListViewItem listViewItem = new ListViewItem(i.ToString());
                    listViewItem.SubItems.Add(item.MaThuoc);
                    listViewItem.SubItems.Add(item.TenThuoc);
                    listViewItem.SubItems.Add(item.SoLuong.ToString());
                    listViewItem.SubItems.Add(item.DonViTinh);

                    lvs_ChiTietDonThuoc.Items.Add(listViewItem);
                    i++;
                }

                // đẩy ra listbox

                var query_pre = from pm in Cons.dataContext.PrescriptionMedicines
                                join m in Cons.dataContext.Medicines on pm.MedicineId equals m.MedicineId
                                where temp == pm.PrescriptionId
                                select new
                                {
                                    pm.PrescriptionMedicineID,
                                    m.nameMedicine

                                };

                //lsb_Thuoc.Items.Clear();
                lsb_Thuoc.DataSource = query_pre.ToList();
                lsb_Thuoc.DisplayMember = "nameMedicine";
                lsb_Thuoc.ValueMember = "PrescriptionMedicineID";
            }
            catch (Exception)
            {

                throw;
            }
           
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(lsb_Thuoc.SelectedValue.ToString());
                PrescriptionMedicine prescriptionMedicine = new PrescriptionMedicine();
                prescriptionMedicine = (from i in Cons.dataContext.PrescriptionMedicines where i.PrescriptionMedicineID == ma select i).Single();
                Cons.dataContext.PrescriptionMedicines.DeleteOnSubmit(prescriptionMedicine);
                Cons.dataContext.SubmitChanges();

                // load lại dgv
                var queryP = from p in Cons.dataContext.Patients
                             join pp in Cons.dataContext.Prescriptions on p.PatientId equals pp.PatientId
                             join s in Cons.dataContext.Staffs on pp.StaffId equals s.StaffId
                             where p.PatientId == Cons.PatientId
                             select new
                             {
                                 MaDonThuoc = pp.PrescriptionId,
                                 TenDonThuoc = pp.namePrescription,
                                 TenBenhNhan = p.fullName,
                                 TenBacSi = s.fullName,
                                 NgayTaoDon = pp.createdDate

                             };
                dgv_DonThuoc.DataSource = queryP.ToList();
                dgv_DonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {

                MessageBox.Show("Chọn thuốc cần xóa");
            }

        }

        private void btn_SuaDon_Click(object sender, EventArgs e)
        {
            //hiển thị cmb 
            cmb_Thuoc.Visible = true;
            cmb_Thuoc.Enabled = true;
            btn_Chon.Enabled = true;
            btn_Chon.Visible = true;
            lbl_Thuoc.Visible = true;

            lbl_SoLuong.Visible = true;
            txtSoLuong.Visible = true;
            txtSoLuong.Enabled = true;

            lbl_DanhSachChon.Visible = true;
            lsb_Thuoc.Visible = true;



        }
    }
}
