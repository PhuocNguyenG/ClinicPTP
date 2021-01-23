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
    public partial class Frm_AddThuoc : Form
    {
        public Frm_AddThuoc()
        {
            InitializeComponent();

            DentalClinicDataContext dental = new DentalClinicDataContext();
            var type = from a in dental.TypeMedicines
                       select new
                       {
                           a.TypeMedicineId, a.nameTypeOfMedicine
                       };
            cbLoaiThuoc.DataSource = type.ToList();
            cbLoaiThuoc.DisplayMember = "nameTypeOfMedicine";
            cbLoaiThuoc.ValueMember = "TypeMedicineId";
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frm_AddThuoc_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        UserControl_QuanLyThuoc UserControl_QuanLyThuoc = new UserControl_QuanLyThuoc();

        public event EventHandler click_CloseForm = null;

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DentalClinicDataContext dental = new DentalClinicDataContext();
                Medicine medicine = new Medicine();
                medicine.MedicineId = txtMaThuoc.Text;
                medicine.nameMedicine = txtTenThuoc.Text;
                medicine.quantity = int.Parse(txtSoLuong.Text);
                medicine.expirationDate = dtpkHanSuDung.Value;
                medicine.unit = txtDonViTinh.Text;
                medicine.TypeMedicineId = cbLoaiThuoc.SelectedValue.ToString();
                medicine.price = decimal.Parse(txtDonGia.Text);
                dental.Medicines.InsertOnSubmit(medicine);
                dental.SubmitChanges();
                click_CloseForm(sender, e);
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Yêu cầu nhập dúng định dạng!");
            }
           
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)   && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
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

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
           
        }
    }
}
