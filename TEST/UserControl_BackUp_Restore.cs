using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TEST
{
    public partial class UserControl_BackUp_Restore : UserControl
    {
        SqlConnection con = new SqlConnection(TEST.Properties.Settings.Default.DentalClinic_DatabaseConnectionString);

        public UserControl_BackUp_Restore()
        {
            InitializeComponent();
        }

        private void btn_LinkBackUp_Click(object sender, EventArgs e)
        {
           FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_BackUp.Text = dlg.SelectedPath;
                btnBackUp.Enabled = true;
            }
        }

        private void UserControl_BackUp_Restore_Load(object sender, EventArgs e)
        {
            btnBackUp.Enabled = false;
            btn_Restore.Enabled = false;    
        }

        private void btn_LinkRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_Restore.Text = dlg.FileName;
                btn_Restore.Enabled = true;
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            MessageBox.Show(database);
            try
            {
                if (txt_BackUp.Text == string.Empty)
                {
                    MessageBox.Show("Thiếu đường dẫn sao lưu");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txt_BackUp.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))

                    {
                        con.Open();

                        command.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Đã sao sao thành công!");
                        btnBackUp.Enabled = false;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txt_Restore.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Đã khôi phục dữ liệu thành công!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
