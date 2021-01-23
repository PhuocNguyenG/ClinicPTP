using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TEST
{
    public partial class Form_ThemTaiKhoan : Form
    {
        public Form_ThemTaiKhoan()
        {
            InitializeComponent();
            bnt_OkThemLichHen.Enabled = false;
        }
        public event EventHandler click_CloseForm = null;

        private void bnt_OkThemLichHen_Click(object sender, EventArgs e)
        {
            string username = txt_TenTaiKhoan.Text;
            string password = txt_MatKhauMoi.Text;
            if (Login(username, password))
            {
                Account account = new Account();
                account.userName = txt_TenTaiKhoan.Text;
                account.passWord = txt_MatKhauMoi.Text;
                account.StaffId = cmbNhanVien.SelectedValue.ToString();

                Cons.dataContext.Accounts.InsertOnSubmit(account);
                Cons.dataContext.SubmitChanges();
                Cons.temp = "";

                this.Close();
            }

        }
        private bool Login(string username, string password)
        {
            var user = username;
            var pass = password;
            /*ErrorMessage = string.Empty;*/

            if (string.IsNullOrWhiteSpace(pass))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(pass) && !hasLowerChar.IsMatch(user))
            {
                MessageBox.Show("phải có kí tự chữ");
                return false;
            }
            else if (!hasUpperChar.IsMatch(pass))
            {
                MessageBox.Show("Phải có ít nhất 1 chữ hoa");
                return false;
            }

            else if (!hasNumber.IsMatch(pass))
            {
                MessageBox.Show("Phải có số");
                return false;
            }

            else if (!hasSymbols.IsMatch(pass))
            {
                MessageBox.Show("Phải có 1 ký tự đặc biệt");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void Form_ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            var query = from s in Cons.dataContext.Staffs
                        select s;
            cmbNhanVien.DataSource = query.ToList();
            cmbNhanVien.DisplayMember = "fullName";// fullName
            cmbNhanVien.ValueMember = "StaffId";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_CancelThemLichHen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txt_TenTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (char.IsWhiteSpace(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)

            {
                e.Handled = true;
                MessageBox.Show("Không khoảng trắng");
            }
            if (!char.IsNumber(e.KeyChar) & !char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & !char.IsWhiteSpace(e.KeyChar) & e.KeyChar != ('.') & e.KeyChar != ('_'))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập kí tự đặc biệt");
            }
        }



        private void lbTenTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void lbMatKhauMoi_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_TenTaiKhoan_Leave(object sender, EventArgs e)
        {
            /*if (txt_TenTaiKhoan.Text.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập tài khoản trên 8 ký tự");
                bnt_OkThemLichHen.Enabled = false;
            }
            if (txt_TenTaiKhoan.Text.Length >= 6 && txt_MatKhauMoi.Text != "" && txt_MatKhauMoi.Text.Length >= 6)
            {
                bnt_OkThemLichHen.Enabled = true;
            
            }*/
        }

        private void txt_TenTaiKhoan_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txt_TenTaiKhoan.Text.Length < 6)
            {
                lbTenTaiKhoan.Visible = true;
                bnt_OkThemLichHen.Enabled = false;
            }
            else if (txt_TenTaiKhoan.Text.Length == 6)
            {
                lbTenTaiKhoan.Visible = false;
            }
            else if (txt_TenTaiKhoan.Text.Length > 6)
            {
                lbTenTaiKhoan.Visible = false;
            }

            else if(txt_TenTaiKhoan.Text.Length >= 6 && txt_MatKhauMoi.Text != "" && txt_MatKhauMoi.Text.Length >= 6)
            {
                bnt_OkThemLichHen.Enabled = true;

            }

        } 

        private void txt_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhauMoi.Text.Length < 6)
            {
                lbMatKhauMoi.Visible = true;
                bnt_OkThemLichHen.Enabled = false;
            }
            else if (txt_MatKhauMoi.Text.Length == 6)
            {
                lbMatKhauMoi.Visible = false;
            }
            else if (txt_MatKhauMoi.Text.Length > 6)
            {
                lbMatKhauMoi.Visible = false;
            }
        
            if (txt_TenTaiKhoan.Text.Length >= 6 && txt_MatKhauMoi.Text != "" && txt_MatKhauMoi.Text.Length >= 6)
            {
                bnt_OkThemLichHen.Enabled = true;
            
            }
        }
    }
}
