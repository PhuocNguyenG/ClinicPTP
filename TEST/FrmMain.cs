using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TEST
{
    public partial class FrmMain : Form
    {
        #region Properties
        private bool isFisrtStartForm;
        public event EventHandler clickCloseForm = null;
        DentalClinicDataContext DataContext = new DentalClinicDataContext();
        #endregion
        public FrmMain()
        {
            InitializeComponent();
            isFisrtStartForm = true;
            CheckForIllegalCrossThreadCalls = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            
        }
        /*private const int cCaption = 32;
        private const int cGrip = 16;
        

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }*/



        #region Button Menu


        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            /*WorkingStatus workingStatus = new WorkingStatus();
            workingStatus = DataContext.WorkingStatus.Where(a => a.WorkingStatusId == Cons.WorkingStatusId).Single();
            workingStatus.timeEnd = DateTime.Now;
            DataContext.SubmitChanges();    
            Cons.isCloseProgram = true;
            this.Close();*/
            Application.Exit();


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyBenhNhan.Top;
            panel_HienThi.Controls.Clear();
            UserControl_QuanLyBenhNhan userControl_QuanLyBenhNhan = new UserControl_QuanLyBenhNhan();
            panel_HienThi.Controls.Add(userControl_QuanLyBenhNhan);
            userControl_QuanLyBenhNhan.Dock = DockStyle.Fill;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyLichHen.Top;
            panel_HienThi.Controls.Clear();
            UserControl_LichHen userControl_LichHen = new UserControl_LichHen();
            panel_HienThi.Controls.Add(userControl_LichHen);
            userControl_LichHen.Dock = DockStyle.Fill;

        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyThuoc.Top;
            UserControl_QuanLyThuoc userControl_QuanLyThuoc = new UserControl_QuanLyThuoc();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl_QuanLyThuoc);
            userControl_QuanLyThuoc.Dock = DockStyle.Fill;
        }

        private void btnQuanLyNVBS_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyNVBS.Top;
            panel_HienThi.Controls.Clear();
            UserControl_QuanLyNVBS userControl_QuanLyNVBS = new UserControl_QuanLyNVBS();
            panel_HienThi.Controls.Add(userControl_QuanLyNVBS);
            userControl_QuanLyNVBS.Dock = DockStyle.Fill;
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnDichVu.Top;
            UserControl_QuanLyDichVu userControl_QuanLyDichVu = new UserControl_QuanLyDichVu();
            //userControl_QuanLyDichVu.Show();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl_QuanLyDichVu);
            userControl_QuanLyDichVu.Dock = DockStyle.Fill;
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnDieuTri.Top;
            panel_HienThi.Controls.Clear();
            UserControl_DieuTri userControl_DieuTri = new UserControl_DieuTri();
            panel_HienThi.Controls.Add(userControl_DieuTri);
            userControl_DieuTri.Dock = DockStyle.Fill;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnThongKe.Top;
            UserControl_ThongKe userControl_ThongKe = new UserControl_ThongKe();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl_ThongKe);
            userControl_ThongKe.Dock = DockStyle.Fill;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnThanhToan.Top;
            UserControl_ThanhToan userControl_ThanhToan = new UserControl_ThanhToan();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl_ThanhToan);
            userControl_ThanhToan.Dock = DockStyle.Fill;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnHeThong.Top;
            panel_HienThi.Controls.Clear();
            UserControl_System userControl_System = new UserControl_System();
            panel_HienThi.Controls.Add(userControl_System);
            userControl_System.Dock = DockStyle.Fill;
        }
        
        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            if(panel_ChucNang.Width == 55)
            {
                panel_ChucNang.Visible = false;
                panel_ChucNang.Width = 250;
                transition_Menu.ShowSync(panel_ChucNang);

            }
            else
            {   
                panel_ChucNang.Visible = false;
                panel_ChucNang.Width = 55;
                transition_Menu.ShowSync(panel_ChucNang);
            }
        }
        
        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btn_home.Top;
            panel_HienThi.Controls.Clear();
            /*Panel anh = new Panel();
            anh.BackgroundImage = Properties.Resources.hospital;

            panel_HienThi.Controls.Add(anh);
            anh.Dock = DockStyle.Fill;
            anh.Show();*/


        }


        #endregion


        private void FrmMain_Load(object sender, EventArgs e)
        {
            var query = from s in Cons.dataContext.Staffs
                        join a in Cons.dataContext.Accounts on s.StaffId equals a.StaffId
                        join p in Cons.dataContext.Positions on s.PositionId equals p.PositionId
                        where a.AccountId == Cons.AccountID
                        select new
                        {
                            p.namePosition,
                            s.fullName
                        };
            lbl_Infor.Text = query.ToList()[0].namePosition + " - " + query.ToList()[0].fullName + " - Online";

            btn_Zoom_Click(sender, e);  
        }

        
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            if(isFisrtStartForm)
            {
                btn_home_Click(sender, e);
                isFisrtStartForm = false;
            }
            //this.WindowState = FormWindowState.Maximized;        
            //int x = Screen.PrimaryScreen.WorkingArea.Width;
            //int y = Screen.PrimaryScreen.WorkingArea.Height;
            //this.Width = x;
            //this.Height = y;
            //this.CenterToScreen();
        }


        /// <summary>
        /// Random mã
        /// </summary>
        /// <returns></returns>
        public string ranDomId()
        {
            string id = "";
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                if (random.Next(0, 2) == 1)
                {
                    int num = random.Next(65, 91);
                    id += (char)num;
                }
                else
                {
                    int num = random.Next(48, 58);
                    id += (char)num;
                }
            }
            return id;

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            WorkingStatus workingStatus = new WorkingStatus();
            workingStatus = DataContext.WorkingStatus.Where(a => a.WorkingStatusId == Cons.WorkingStatusId).Single();
            workingStatus.timeEnd = DateTime.Now;
            DataContext.SubmitChanges();

            
            this.Hide();
            this.Close();
            
            
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            clickCloseForm(sender, e);

        }
         
        private void btn_Zoom_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
               
      
                this.WindowState = FormWindowState.Maximized;
                
                
            }
            else
            {
                
                this.WindowState = FormWindowState.Normal;
                
                this.Width = 1450;
                this.Height = 750;
                this.CenterToScreen();
            }
            
        }

        private void panel_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoPK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_ChucNang_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
