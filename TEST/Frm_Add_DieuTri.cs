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
    public partial class Frm_Add_DieuTri : Form
    {
        public Frm_Add_DieuTri()
        {
            InitializeComponent();
            var staff = from s in Cons.dataContext.Staffs
                        join a in Cons.dataContext.Accounts on s.StaffId equals a.StaffId
                        where s.PositionId == 2 && a.AccountId == Cons.AccountID
                        select new
                        {
                            s.StaffId,s.fullName
                        };
            
            comboBox_BacSI.DataSource = staff;
            comboBox_BacSI.DisplayMember = "fullName";
            comboBox_BacSI.ValueMember = "StaffId";
            comboBox_BacSI.Enabled = false;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler click_close = null;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBox_BacSI.Text == "")
            {
                MessageBox.Show("Chỉ có bác sĩ mới được thêm!");
            }
            else
            {


                Treatment treatment = new Treatment();
                treatment.TreatmentId = txtMaDieuTri.Text;
                treatment.diagnose = txtChuanDoan.Text;
                treatment.method = txtDieuTri.Text;
                treatment.dayOfTreatment = dtpkNgayDieuTri.Value;
                treatment.PatientId = txtMaBenhNhan.Text;
                treatment.StaffId = comboBox_BacSI.SelectedValue.ToString();
                Cons.dataContext.Treatments.InsertOnSubmit(treatment);
                Cons.dataContext.SubmitChanges();
                click_close(sender, e);
                this.Close();

            }
            

        }

        private void txtMaDieuTri_TextChanged(object sender, EventArgs e)
        {
            txtMaDieuTri.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtTenBenhNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Chữ");
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBox_BacSI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
