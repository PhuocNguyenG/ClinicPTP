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
    public partial class Frm_Edit_DichVu : Form
    {
        public Frm_Edit_DichVu()
        {
            InitializeComponent();
        }
        #region  Thuộc tính

        DentalClinicDataContext dentalClinic = new DentalClinicDataContext();

        #endregion

        private void Frm_Edit_DichVu_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler click_CloseForm = null;
        private void btnOk_Click(object sender, EventArgs e)
        {
            
            try
            {
                Service service = new Service();
                service = dentalClinic.Services.Where(ma => ma.ServiceId == Cons.temp).Single();
                service.nameService = txtTenDichVu.Text;
                service.price = decimal.Parse(txtGiaTien.Text);
                service.note = txtMoTa.Text;
                dentalClinic.SubmitChanges();
                click_CloseForm(sender, e);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu mời bạn kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtMaDichVu_TextChanged(object sender, EventArgs e)
        {
           txtMaDichVu.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtTenDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Chữ");
            }
        }
    }
}
