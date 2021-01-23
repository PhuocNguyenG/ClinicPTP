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
    public partial class Form_SuaTaiKhoan : Form
    {
        public Form_SuaTaiKhoan()
        {
            InitializeComponent();
            bnt_OkThemLichHen.Enabled = false;
        }

      

        private void Form_SuaTaiKhoan_Load(object sender, EventArgs e)
        {
           
        }

        private void bnt_CancelThemLichHen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler click_CloseForm = null;
        private void bnt_OkThemLichHen_Click(object sender, EventArgs e)
        {
            string password = txt_MatKhauMoi.Text;
            if (Login(password))
            {


                try
                {

                    var account = Cons.dataContext.Accounts.Where(ma => ma.userName == txt_TenTK.Text).SingleOrDefault();
                    account.passWord = txt_MatKhauMoi.Text;

                    Cons.dataContext.SubmitChanges();

                    click_CloseForm(sender, e);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu mời bạn kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private bool Login(string password)
        {
           
            var pass = password;
            

            if (string.IsNullOrWhiteSpace(pass))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(pass) )
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

        private void txt_TenTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_MatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không khoảng trắng");
            }
        }

        private void txt_MatKhauMoi_Enter(object sender, EventArgs e)
        {
            txt_MatKhauMoi.Text = "";
        }

        private void txt_MatKhauMoi_Leave(object sender, EventArgs e)
        {

            if (txt_MatKhauMoi.Text == "")
            {
                txt_MatKhauMoi.Text = "Password";
            }
        }

        private void txt_TenTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_IDtk_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhauMoi.Text.Length < 6)
            {
                lbNhapLaiMK.Visible = true;
                bnt_OkThemLichHen.Enabled = false;
            }
            else if (txt_MatKhauMoi.Text.Length == 6)
            {
                lbNhapLaiMK.Visible = false;
            }
            else if (txt_MatKhauMoi.Text.Length > 6)
            {
                lbNhapLaiMK.Visible = false;
            }

            if (lbNhapLaiMK.Text.Length >= 6  )
            {
                bnt_OkThemLichHen.Enabled = true;

            }
        }
    }
    }



   
