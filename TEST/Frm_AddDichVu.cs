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
    public partial class Frm_AddDichVu : Form
    {
        public Frm_AddDichVu()
        {
            InitializeComponent();
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
                DentalClinicDataContext dentalClinic = new DentalClinicDataContext();
                Service service = new Service();
                service.ServiceId = txtDichVu.Text;
                service.nameService = txtTenDichVu.Text;
                service.price = decimal.Parse(txtGiaTien.Text);
                service.note = txtMoTa.Text;
                dentalClinic.Services.InsertOnSubmit(service);
                dentalClinic.SubmitChanges();
                click_CloseForm(sender, e);
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Yêu cầu nhập đúng định dạng và không trùng !");
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDichVu_TextChanged(object sender, EventArgs e)
        {
            txtDichVu.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtTenDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Chữ");
            }
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (','))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
            
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
