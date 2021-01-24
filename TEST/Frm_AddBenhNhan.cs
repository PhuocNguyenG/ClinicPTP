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
    public partial class Frm_AddBenhNhan : Form
    {
        public Frm_AddBenhNhan()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler click_CloseForm = null;
        private void btnOK_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.PatientId = txtMaBenhNhan.Text;
            patient.fullName = txtTenBenhNhan.Text;
            patient.dateOfBirth = dtpkNgaySinh.Value;
            if (radioButton_Nam.Checked)
            {
                patient.gender = true;
            }
            if (radioButton_Nu.Checked)
            {
                patient.gender = false;
            }
            patient.phone = txtSoDienThoai.Text;
            patient.address = txtDiaChi.Text;
            patient.email = txtEmail.Text;
            patient.note = txtGhiChu.Text;
            Cons.dataContext.Patients.InsertOnSubmit(patient);
            Cons.dataContext.SubmitChanges();
            click_CloseForm(sender,e);
            this.Close();
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
            if(txtSoDienThoai.Text.Length > 10 && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Đã quá 11 số");
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            txtMaBenhNhan.CharacterCasing = CharacterCasing.Upper;
            if (txtMaBenhNhan.Text.Length > 0 && txtTenBenhNhan.Text.Length > 0)
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        private void txtTenBenhNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Chỉ Nhập Chữ");
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('@')  & e.KeyChar != ('_') & e.KeyChar != ('.'))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập ký tự đặc biệt");
            }
        }

        private void Frm_AddBenhNhan_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;  
        }

        private void txtTenBenhNhan_TextChanged(object sender, EventArgs e)
        {
            txtTenBenhNhan.CharacterCasing = CharacterCasing.Upper;
            if (txtTenBenhNhan.Text.Length > 0 && txtMaBenhNhan.Text.Length > 0)
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }
    }
}
