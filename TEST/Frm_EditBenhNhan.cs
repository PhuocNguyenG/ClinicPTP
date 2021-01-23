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
    public partial class Frm_EditBenhNhan : Form
    {
        public Frm_EditBenhNhan()
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
            patient = Cons.dataContext.Patients.Where(ma => ma.PatientId == txtMaBenhNhan.Text).Single();           
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
            Cons.dataContext.SubmitChanges();
            click_CloseForm(sender, e);
            this.Close();
        }

        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            txtMaBenhNhan.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtTenBenhNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Chữ");
            }
        }
    }
}
