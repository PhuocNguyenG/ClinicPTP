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
    public partial class UserControl_ThongKe : UserControl
    {
        public UserControl_ThongKe()
        {
            InitializeComponent();
            UserControl_ThongKe_Resize(this, new EventArgs());
        }

        private void btnThongKeBenhNhan_Click(object sender, EventArgs e)
        {
            panel_Choose.Left = btnThongKeBenhNhan.Left;
            panel_HienThiThongKe.Controls.Clear();
            UserControl_ThongKe_BenhNhan userControl_ThongKe_BenhNhan = new UserControl_ThongKe_BenhNhan();
            panel_HienThiThongKe.Controls.Add(userControl_ThongKe_BenhNhan);
            userControl_ThongKe_BenhNhan.Dock = DockStyle.Fill;

        }

        private void btnThongKeThuoc_Click(object sender, EventArgs e)
        {
            panel_Choose.Left = btnThongKeThuoc.Left;
            panel_HienThiThongKe.Controls.Clear();
            Frm_ThongKeThuoc frm_ThongKeThuoc = new Frm_ThongKeThuoc();
            frm_ThongKeThuoc.TopLevel = false;
            this.panel_HienThiThongKe.Controls.Add(frm_ThongKeThuoc);
            frm_ThongKeThuoc.Dock = DockStyle.Fill;
            frm_ThongKeThuoc.Show();

           
        }

        private void UserControl_ThongKe_Resize(object sender, EventArgs e)
        {
            btnThongKeBenhNhan.Width = this.Width / 3;
            btnThongKeDoanhThu.Width = this.Width / 3;
            panel_Choose.Width = btnThongKeBenhNhan.Width;
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            panel_Choose.Left = btnThongKeDoanhThu.Left;
            UserControl1_ThongKe_DoanhThu userControl1_ThongKe_DoanhThu = new UserControl1_ThongKe_DoanhThu();
            panel_HienThiThongKe.Controls.Clear();
            panel_HienThiThongKe.Controls.Add(userControl1_ThongKe_DoanhThu);
            userControl1_ThongKe_DoanhThu.Dock = DockStyle.Fill;
        }
    }
}
