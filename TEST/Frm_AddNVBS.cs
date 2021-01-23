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
    public partial class Frm_AddNVBS : Form
    {
        public Frm_AddNVBS()
        {
            InitializeComponent();
            var query = from s in Cons.dataContext.Positions
                        select new
                        {
                            s.PositionId,
                            s.namePosition
                        };
            cbViTri.DataSource = query.ToList();
            cbViTri.DisplayMember = "namePosition";
            cbViTri.ValueMember = "PositionId";
            //cbViTri.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
        public event EventHandler click_CloseForm = null;

        private void btnOK_Click(object sender, EventArgs e)
        {
            DentalClinicDataContext dataContext = new DentalClinicDataContext();
            Staff staff = new Staff();
            staff.StaffId = txtMaNVBS.Text;
            staff.fullName = txtTenNVBS.Text;
            staff.dateOfBirth = dtpkNgaySinh.Value;
            staff.PositionId = int.Parse(cbViTri.SelectedValue.ToString());
            if (radioButton_Nam.Checked)
            {
                staff.gender = true;
            }
            if (radioButton_Nu.Checked)
            {
                staff.gender = true;
            }
            staff.address = txtDiaChi.Text;
            staff.phone = txtSoDienThoai.Text;
            staff.identityNumber = txtCMT.Text;
            staff.experience = txtKinhNghiem.Text;
            staff.email = txtEmail.Text;
            staff.certificateId = txtBangCap.Text;
            staff.note = txtGhiChu.Text;
            dataContext.Staffs.InsertOnSubmit(staff);
            dataContext.SubmitChanges();
            click_CloseForm(sender, e);
            this.Close();
        }

        private void Frm_AddNVBS_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
            if (txtSoDienThoai.Text.Length > 10 & !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Đã quá 11 số");
            }
        }

        private void txtMaNVBS_TextChanged(object sender, EventArgs e)
        {
           txtMaNVBS.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtTenNVBS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Chữ");
            }
        }

        private void txtCMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & !char.IsControl(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('+'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
            if (txtCMT.Text.Length > 10 & !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Đã quá 11 số");
            }
        }

        private void txtCMT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('@') & e.KeyChar != ('_') & e.KeyChar != ('.'))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập ký tự đặc biệt");
            }
        }
    }
}
