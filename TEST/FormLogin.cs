using System;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TEST
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            DentalClinicDataContext dataContext = new DentalClinicDataContext();


            var query = from a in dataContext.Accounts
                        join s in dataContext.Staffs on a.StaffId equals s.StaffId
                        join p in dataContext.Positions on s.PositionId equals p.PositionId

                        select new
                        {
                            a.AccountId,
                            a.userName,
                            a.passWord,
                            p.PositionId

                        };

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            /*if (Login(username, password))
            {*/
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    foreach (var item in query.ToList())
                    {
                        if (item.userName == txtUsername.Text && item.passWord == txtPassword.Text)
                        {
                            Cons.permission = item.PositionId;  //gắn quyền.

                            if (item.PositionId == 1)
                            {
                                // Chèn dữ liệu login
                                Cons.AccountID = item.AccountId;
                                WorkingStatus workingStatus = new WorkingStatus();
                                workingStatus.WorkingStatusId = Cons.ranDomId();
                                workingStatus.AccountId = item.AccountId;
                                workingStatus.timeBegin = DateTime.Now;

                                Cons.WorkingStatusId = workingStatus.WorkingStatusId;   // luư lại.

                                dataContext.WorkingStatus.InsertOnSubmit(workingStatus);
                                dataContext.SubmitChanges();


                                CreateFormMain_Staff();

                            }
                            if (item.PositionId == 2)
                            {
                                // Chèn dữ liệu login
                                Cons.AccountID = item.AccountId;
                                WorkingStatus workingStatus = new WorkingStatus();
                                workingStatus.WorkingStatusId = Cons.ranDomId();
                                workingStatus.AccountId = item.AccountId;
                                workingStatus.timeBegin = DateTime.Now;

                                Cons.WorkingStatusId = workingStatus.WorkingStatusId;   // luư lại.

                                dataContext.WorkingStatus.InsertOnSubmit(workingStatus);
                                dataContext.SubmitChanges();


                                CreateFormMain_Doctor();

                            }

                            if (item.PositionId == 3)
                            {
                                // Chèn dữ liệu login
                                Cons.AccountID = item.AccountId;
                                WorkingStatus workingStatus = new WorkingStatus();
                                workingStatus.WorkingStatusId = Cons.ranDomId();
                                workingStatus.AccountId = item.AccountId;
                                workingStatus.timeBegin = DateTime.Now;

                                Cons.WorkingStatusId = workingStatus.WorkingStatusId;   // luư lại.
                                dataContext.WorkingStatus.InsertOnSubmit(workingStatus);
                                dataContext.SubmitChanges();

                                CreateFormMain_Manager();

                            }
                            return;
                        }
                        else
                        {
                            error_transition.Show(lbl_Error);
                        }
                    }
                }
            
            
        }
        

        private void FrmMain_clickCloseForm(object sender, EventArgs e)
        {
            if (!Cons.isCloseProgram)
            {
                this.Show();
                this.ShowInTaskbar = true;
                this.Focus();
            }
            else
            {
                Application.Exit();
            }


        }


        

        public void CreateFormMain_Staff()
        {
            FrmMain frmMain = new FrmMain();
            frmMain.clickCloseForm += FrmMain_clickCloseForm;

            this.Hide();

            frmMain.btnDieuTri.Visible = false;
            frmMain.btnDieuTri.Enabled = false;

            frmMain.btnThongKe.Location = new Point(5, 422);
            frmMain.btnThanhToan.Location = new Point(5,482);
            frmMain.btnHeThong.Location = new Point(5,542);
            
            frmMain.btn_DangXuat.Location = new Point(5, 602); 
            this.ShowInTaskbar = false;
            frmMain.ShowDialog();
            /*this.Show();*/
            this.Focus();
        }

        public void CreateFormMain_Doctor()
        {
            FrmMain frmMain = new FrmMain();
            frmMain.clickCloseForm += FrmMain_clickCloseForm;
            this.Hide();

            

            frmMain.btnQuanLyThuoc.Visible = false;
            frmMain.btnQuanLyThuoc.Enabled = false;

          

            frmMain.btnQuanLyNVBS.Visible = false;
            frmMain.btnQuanLyNVBS.Enabled = false;

            frmMain.btnDichVu.Visible = false;
            frmMain.btnDichVu.Enabled = false;

            frmMain.btnThanhToan.Visible = false;
            frmMain.btnThanhToan.Enabled = false;

            frmMain.btnThongKe.Visible = false;
            frmMain.btnThongKe.Enabled = false;

            frmMain.btnHeThong.Visible = false;
            frmMain.btnHeThong.Enabled = false;

            frmMain.btnDieuTri.Location = new Point(5, 242);
            frmMain.btn_DangXuat.Location = new Point(5, 302);




            this.ShowInTaskbar = false;
            frmMain.ShowDialog();
            /*this.Show();*/
            this.Focus();
        }

        public void CreateFormMain_Manager()
        {

            FrmMain frmMain = new FrmMain();
            frmMain.clickCloseForm += FrmMain_clickCloseForm;
            this.Hide();

            this.ShowInTaskbar = false;
            frmMain.ShowDialog();
            /*this.Show();*/
            this.Focus();

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Error_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
            
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text != "")
            {

            }
            else
            txtUsername.Text = "";

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            txtPassword.Text = "";

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)

            {
                e.Handled = true;
                MessageBox.Show("Không khoảng trắng");
            }
            if (!char.IsDigit(e.KeyChar) & !char.IsLetter(e.KeyChar)  & !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập kí tự đặc biệt");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không khoảng trắng");
            }
        }
    }





    /*alo*/
}

