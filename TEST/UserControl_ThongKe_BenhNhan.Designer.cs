namespace TEST
{
    partial class UserControl_ThongKe_BenhNhan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ThongKe_BenhNhan));
            this.cartesianChart_ThongKe = new LiveCharts.WinForms.CartesianChart();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.btn_ThongKeThang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ThongKeTheoNam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_Nam = new System.Windows.Forms.ComboBox();
            this.cmb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.lbl_Nam = new System.Windows.Forms.Label();
            this.lbl_Tilte_GioiTinh = new System.Windows.Forms.Label();
            this.pnl_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChart_ThongKe
            // 
            this.cartesianChart_ThongKe.BackColor = System.Drawing.Color.Black;
            this.cartesianChart_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart_ThongKe.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart_ThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChart_ThongKe.Name = "cartesianChart_ThongKe";
            this.cartesianChart_ThongKe.Size = new System.Drawing.Size(1435, 896);
            this.cartesianChart_ThongKe.TabIndex = 3;
            this.cartesianChart_ThongKe.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart_ThongKe_ChildChanged);
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Controls.Controls.Add(this.btn_ThongKeThang);
            this.pnl_Controls.Controls.Add(this.btn_ThongKeTheoNam);
            this.pnl_Controls.Controls.Add(this.cmb_Nam);
            this.pnl_Controls.Controls.Add(this.cmb_GioiTinh);
            this.pnl_Controls.Controls.Add(this.lbl_Nam);
            this.pnl_Controls.Controls.Add(this.lbl_Tilte_GioiTinh);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Controls.ForeColor = System.Drawing.Color.Black;
            this.pnl_Controls.Location = new System.Drawing.Point(1435, 0);
            this.pnl_Controls.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(347, 896);
            this.pnl_Controls.TabIndex = 6;
            // 
            // btn_ThongKeThang
            // 
            this.btn_ThongKeThang.Activecolor = System.Drawing.Color.Indigo;
            this.btn_ThongKeThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_ThongKeThang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThongKeThang.BorderRadius = 0;
            this.btn_ThongKeThang.ButtonText = "Thống kê các tháng trong năm";
            this.btn_ThongKeThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongKeThang.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ThongKeThang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ThongKeThang.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ThongKeThang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeThang.Iconimage")));
            this.btn_ThongKeThang.Iconimage_right = null;
            this.btn_ThongKeThang.Iconimage_right_Selected = null;
            this.btn_ThongKeThang.Iconimage_Selected = null;
            this.btn_ThongKeThang.IconMarginLeft = 0;
            this.btn_ThongKeThang.IconMarginRight = 0;
            this.btn_ThongKeThang.IconRightVisible = true;
            this.btn_ThongKeThang.IconRightZoom = 0D;
            this.btn_ThongKeThang.IconVisible = true;
            this.btn_ThongKeThang.IconZoom = 90D;
            this.btn_ThongKeThang.IsTab = false;
            this.btn_ThongKeThang.Location = new System.Drawing.Point(0, 778);
            this.btn_ThongKeThang.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ThongKeThang.Name = "btn_ThongKeThang";
            this.btn_ThongKeThang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_ThongKeThang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_ThongKeThang.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ThongKeThang.selected = false;
            this.btn_ThongKeThang.Size = new System.Drawing.Size(347, 59);
            this.btn_ThongKeThang.TabIndex = 10;
            this.btn_ThongKeThang.Text = "Thống kê các tháng trong năm";
            this.btn_ThongKeThang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKeThang.Textcolor = System.Drawing.Color.White;
            this.btn_ThongKeThang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKeThang.Click += new System.EventHandler(this.btn_ThongKeThang_Click);
            // 
            // btn_ThongKeTheoNam
            // 
            this.btn_ThongKeTheoNam.Activecolor = System.Drawing.Color.Indigo;
            this.btn_ThongKeTheoNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_ThongKeTheoNam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThongKeTheoNam.BorderRadius = 0;
            this.btn_ThongKeTheoNam.ButtonText = "Thống kê các năm";
            this.btn_ThongKeTheoNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongKeTheoNam.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ThongKeTheoNam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ThongKeTheoNam.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ThongKeTheoNam.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeTheoNam.Iconimage")));
            this.btn_ThongKeTheoNam.Iconimage_right = null;
            this.btn_ThongKeTheoNam.Iconimage_right_Selected = null;
            this.btn_ThongKeTheoNam.Iconimage_Selected = null;
            this.btn_ThongKeTheoNam.IconMarginLeft = 0;
            this.btn_ThongKeTheoNam.IconMarginRight = 0;
            this.btn_ThongKeTheoNam.IconRightVisible = true;
            this.btn_ThongKeTheoNam.IconRightZoom = 0D;
            this.btn_ThongKeTheoNam.IconVisible = true;
            this.btn_ThongKeTheoNam.IconZoom = 90D;
            this.btn_ThongKeTheoNam.IsTab = false;
            this.btn_ThongKeTheoNam.Location = new System.Drawing.Point(0, 837);
            this.btn_ThongKeTheoNam.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ThongKeTheoNam.Name = "btn_ThongKeTheoNam";
            this.btn_ThongKeTheoNam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_ThongKeTheoNam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.btn_ThongKeTheoNam.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ThongKeTheoNam.selected = false;
            this.btn_ThongKeTheoNam.Size = new System.Drawing.Size(347, 59);
            this.btn_ThongKeTheoNam.TabIndex = 9;
            this.btn_ThongKeTheoNam.Text = "Thống kê các năm";
            this.btn_ThongKeTheoNam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKeTheoNam.Textcolor = System.Drawing.Color.White;
            this.btn_ThongKeTheoNam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKeTheoNam.Click += new System.EventHandler(this.btn_ThongKeTheoNam_Click);
            // 
            // cmb_Nam
            // 
            this.cmb_Nam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Nam.ForeColor = System.Drawing.Color.Black;
            this.cmb_Nam.FormattingEnabled = true;
            this.cmb_Nam.Location = new System.Drawing.Point(143, 58);
            this.cmb_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Nam.Name = "cmb_Nam";
            this.cmb_Nam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Nam.Size = new System.Drawing.Size(199, 33);
            this.cmb_Nam.TabIndex = 7;
            this.cmb_Nam.Visible = false;
            this.cmb_Nam.SelectedIndexChanged += new System.EventHandler(this.cmb_Nam_SelectedIndexChanged);
            // 
            // cmb_GioiTinh
            // 
            this.cmb_GioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cmb_GioiTinh.FormattingEnabled = true;
            this.cmb_GioiTinh.Location = new System.Drawing.Point(143, 4);
            this.cmb_GioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_GioiTinh.Name = "cmb_GioiTinh";
            this.cmb_GioiTinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_GioiTinh.Size = new System.Drawing.Size(199, 33);
            this.cmb_GioiTinh.TabIndex = 7;
            // 
            // lbl_Nam
            // 
            this.lbl_Nam.AutoSize = true;
            this.lbl_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nam.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nam.Location = new System.Drawing.Point(5, 63);
            this.lbl_Nam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nam.Name = "lbl_Nam";
            this.lbl_Nam.Size = new System.Drawing.Size(64, 29);
            this.lbl_Nam.TabIndex = 6;
            this.lbl_Nam.Text = "Năm";
            this.lbl_Nam.Visible = false;
            // 
            // lbl_Tilte_GioiTinh
            // 
            this.lbl_Tilte_GioiTinh.AutoSize = true;
            this.lbl_Tilte_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tilte_GioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lbl_Tilte_GioiTinh.Location = new System.Drawing.Point(5, 7);
            this.lbl_Tilte_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tilte_GioiTinh.Name = "lbl_Tilte_GioiTinh";
            this.lbl_Tilte_GioiTinh.Size = new System.Drawing.Size(107, 29);
            this.lbl_Tilte_GioiTinh.TabIndex = 6;
            this.lbl_Tilte_GioiTinh.Text = "Giới tính:";
            // 
            // UserControl_ThongKe_BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cartesianChart_ThongKe);
            this.Controls.Add(this.pnl_Controls);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_ThongKe_BenhNhan";
            this.Size = new System.Drawing.Size(1782, 896);
            this.Load += new System.EventHandler(this.UserControl_ThongKe_BenhNhan_Load);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart_ThongKe;
        private System.Windows.Forms.Panel pnl_Controls;
        private System.Windows.Forms.Label lbl_Tilte_GioiTinh;
        public System.Windows.Forms.ComboBox cmb_GioiTinh;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ThongKeTheoNam;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ThongKeThang;
        public System.Windows.Forms.ComboBox cmb_Nam;
        private System.Windows.Forms.Label lbl_Nam;
    }
}
