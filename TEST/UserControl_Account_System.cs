using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class UserControl_Account_System : UserControl

    {
        DentalClinicDataContext dataContext = new DentalClinicDataContext();
        public UserControl_Account_System()
        {
            InitializeComponent();
        }

        private void UserControl_Account_System_Resize(object sender, EventArgs e)
        {

            pnl_Manage.Size = new Size(70, 478);
            
             
        }

        private void UserControl_Account_System_Load(object sender, EventArgs e)
        {
            var query = from a in dataContext.Accounts
                                              select new
                                              {
                                                  ID = a.AccountId,
                                                  TaiKhoan = a.userName,
                                                  MatKhau = a.passWord
                                              };
            datagridview_Account.DataSource = query;
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            form_SuaTaiKhoan.click_CloseForm += Form_SuaTaiKhoan_click_CloseForm;
            form_SuaTaiKhoan.ShowDialog();
            UserControl_Account_System_Load(sender, e);


        }

        private void Form_SuaTaiKhoan_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_Account_System_Load(sender, e);
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            Form_ThemTaiKhoan form_ThemTaiKhoan = new Form_ThemTaiKhoan();
            form_ThemTaiKhoan.click_CloseForm += Form_ThemTaiKhoan_click_CloseForm;
            form_ThemTaiKhoan.ShowDialog();
            
            UserControl_Account_System_Load(sender, e);

        }
        

        private void Form_ThemTaiKhoan_click_CloseForm(object sender, EventArgs e)
        {
            UserControl_Account_System_Load(sender, e);
        }
        
   
        Form_SuaTaiKhoan form_SuaTaiKhoan = new Form_SuaTaiKhoan();
        

        private void datagridview_Account_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int row = datagridview_Account.CurrentCell.RowIndex;

            
            form_SuaTaiKhoan.txt_TenTK.Text = datagridview_Account.Rows[row].Cells[1].Value.ToString();
            form_SuaTaiKhoan.txt_MatKhauMoi.Text= datagridview_Account.Rows[row].Cells[2].Value.ToString();
            Cons.temp = datagridview_Account.Rows[row].Cells[0].Value.ToString();


        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {

                Account account = new Account();

                account = Cons.dataContext.Accounts.Where(a => a.AccountId == int.Parse(Cons.temp)).SingleOrDefault();
                Cons.dataContext.Accounts.DeleteOnSubmit(account);
                Cons.dataContext.SubmitChanges();
                MessageBox.Show("Đã Xóa TK");
                UserControl_Account_System_Load(sender, e); 
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa xóa");
            }
            

        }

        private void datagridview_Account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_Manage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
