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
    public partial class Frm_EditThuoc : Form
    {
        DentalClinicDataContext dental = new DentalClinicDataContext();
        public Frm_EditThuoc()
        {
            InitializeComponent();
            
            var type = from a in dental.TypeMedicines

                       select new
                       {
                           a.TypeMedicineId,
                           a.nameTypeOfMedicine
                       };
            cbLoaiThuoc.DataSource = type.ToList();
            cbLoaiThuoc.DisplayMember = "nameTypeOfMedicine";
            cbLoaiThuoc.ValueMember = "TypeMedicineId";


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler click_CloseForm = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Medicine medicine = new Medicine();
                medicine = dental.Medicines.Where(ma => ma.MedicineId == Cons.temp).Single();
                medicine.MedicineId = txtMaThuoc.Text;
                medicine.nameMedicine = txtTenThuoc.Text;
                medicine.quantity = int.Parse(txtSoLuong.Text);
                medicine.expirationDate = dtpkHanSuDung.Value;
                medicine.unit = txtDonViTinh.Text;
                medicine.price = decimal.Parse(txtDonGia.Text);
                medicine.TypeMedicineId = cbLoaiThuoc.SelectedValue.ToString();                
                dental.SubmitChanges();
                click_CloseForm(sender, e);
                this.Close();
            }
            catch
            {                
                MessageBox.Show("Lỗi dữ liệu mời bạn kiểm tra lại", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {
            txtMaThuoc.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Chữ");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
            if (txtSoLuong.Text.Length > 10 & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Đã quá 11 số");
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {
            txtTenThuoc.CharacterCasing = CharacterCasing.Upper;
            if (txtTenThuoc.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void Frm_EditThuoc_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }
    }
}
