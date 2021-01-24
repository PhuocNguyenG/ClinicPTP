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
    public partial class Frm_Edit_DieuTri : Form
    {
        public Frm_Edit_DieuTri()
        {
            InitializeComponent();
            var staff = from s in Cons.dataContext.Staffs
                        join a in Cons.dataContext.Accounts on s.StaffId equals a.StaffId
                        where s.PositionId == 2 && a.AccountId == Cons.AccountID
                        select new
                        {
                            s.StaffId,
                            s.fullName
                        };

            comboBox_BacSI.DataSource = staff;
            comboBox_BacSI.DisplayMember = "fullName";
            comboBox_BacSI.ValueMember = "StaffId";
            comboBox_BacSI.Enabled = false;
        }

        private void Frm_Edit_DieuTri_Load(object sender, EventArgs e)
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
             
            Treatment treatment = new Treatment();
            treatment= Cons.dataContext.Treatments.Where(ma => ma.TreatmentId == txtMaDieuTri.Text).Single();
            treatment.TreatmentId = txtMaDieuTri.Text;
            treatment.diagnose = txtChuanDoan.Text;
            treatment.method = txtDieuTri.Text;
            treatment.dayOfTreatment = dtpkNgayDieuTri.Value;         
            treatment.StaffId = comboBox_BacSI.SelectedValue.ToString();

            Cons.dataContext.SubmitChanges();

            this.Close();
        }

        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            txtMaBenhNhan.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtMaBenhNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Chữ");
            }
        }

        private void comboBox_BacSI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaBenhNhan1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
