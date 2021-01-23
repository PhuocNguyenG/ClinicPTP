namespace TEST
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Title = new System.Windows.Forms.Panel();
            this.btn_Zoom = new Bunifu.Framework.UI.BunifuImageButton();
            this.LogoPK = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_ChucNang = new System.Windows.Forms.Panel();
            this.panel_Select = new System.Windows.Forms.Panel();
            this.btn_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_NutMeNu = new System.Windows.Forms.Panel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_DangXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHeThong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThanhToan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThongKe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDieuTri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDichVu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyNVBS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyThuoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyLichHen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyBenhNhan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_HienThi = new System.Windows.Forms.Panel();
            this.transition_Menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Infor = new System.Windows.Forms.Label();
            this.transition_AnhGai = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel_ChucNang.SuspendLayout();
            this.panel_NutMeNu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_Title.Controls.Add(this.btn_Zoom);
            this.panel_Title.Controls.Add(this.LogoPK);
            this.panel_Title.Controls.Add(this.bunifuImageButton3);
            this.panel_Title.Controls.Add(this.bunifuImageButton2);
            this.panel_Title.Controls.Add(this.bunifuCustomLabel1);
            this.transition_AnhGai.SetDecoration(this.panel_Title, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_Title, BunifuAnimatorNS.DecorationType.None);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1600, 39);
            this.panel_Title.TabIndex = 0;
            // 
            // btn_Zoom
            // 
            this.btn_Zoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Zoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.transition_AnhGai.SetDecoration(this.btn_Zoom, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btn_Zoom, BunifuAnimatorNS.DecorationType.None);
            this.btn_Zoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_Zoom.Image")));
            this.btn_Zoom.ImageActive = null;
            this.btn_Zoom.Location = new System.Drawing.Point(1496, 0);
            this.btn_Zoom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Zoom.Name = "btn_Zoom";
            this.btn_Zoom.Size = new System.Drawing.Size(50, 39);
            this.btn_Zoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Zoom.TabIndex = 2;
            this.btn_Zoom.TabStop = false;
            this.btn_Zoom.Zoom = 10;
            this.btn_Zoom.Click += new System.EventHandler(this.btn_Zoom_Click);
            // 
            // LogoPK
            // 
            this.LogoPK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPK.BackgroundImage")));
            this.LogoPK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transition_AnhGai.SetDecoration(this.LogoPK, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.LogoPK, BunifuAnimatorNS.DecorationType.None);
            this.LogoPK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LogoPK.Location = new System.Drawing.Point(3, 0);
            this.LogoPK.Name = "LogoPK";
            this.LogoPK.Size = new System.Drawing.Size(52, 39);
            this.LogoPK.TabIndex = 0;
            this.LogoPK.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoPK_Paint);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.transition_AnhGai.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(1441, 0);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(47, 39);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.transition_AnhGai.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(1554, 0);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(46, 39);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.transition_Menu.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.transition_AnhGai.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(62, 6);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(224, 32);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Phòng Khám PTP";
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_ChucNang.Controls.Add(this.panel_Select);
            this.panel_ChucNang.Controls.Add(this.btn_home);
            this.panel_ChucNang.Controls.Add(this.panel_NutMeNu);
            this.panel_ChucNang.Controls.Add(this.btn_DangXuat);
            this.panel_ChucNang.Controls.Add(this.btnHeThong);
            this.panel_ChucNang.Controls.Add(this.btnThanhToan);
            this.panel_ChucNang.Controls.Add(this.btnThongKe);
            this.panel_ChucNang.Controls.Add(this.btnDieuTri);
            this.panel_ChucNang.Controls.Add(this.btnDichVu);
            this.panel_ChucNang.Controls.Add(this.btnQuanLyNVBS);
            this.panel_ChucNang.Controls.Add(this.btnQuanLyThuoc);
            this.panel_ChucNang.Controls.Add(this.btnQuanLyLichHen);
            this.panel_ChucNang.Controls.Add(this.btnQuanLyBenhNhan);
            this.transition_AnhGai.SetDecoration(this.panel_ChucNang, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_ChucNang, BunifuAnimatorNS.DecorationType.None);
            this.panel_ChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ChucNang.Location = new System.Drawing.Point(0, 39);
            this.panel_ChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Size = new System.Drawing.Size(250, 781);
            this.panel_ChucNang.TabIndex = 1;
            this.panel_ChucNang.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ChucNang_Paint);
            // 
            // panel_Select
            // 
            this.panel_Select.BackColor = System.Drawing.Color.DodgerBlue;
            this.transition_AnhGai.SetDecoration(this.panel_Select, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_Select, BunifuAnimatorNS.DecorationType.None);
            this.panel_Select.Location = new System.Drawing.Point(0, 71);
            this.panel_Select.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Select.Name = "panel_Select";
            this.panel_Select.Size = new System.Drawing.Size(8, 48);
            this.panel_Select.TabIndex = 4;
            // 
            // btn_home
            // 
            this.btn_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderRadius = 0;
            this.btn_home.ButtonText = " Home";
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btn_home, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btn_home, BunifuAnimatorNS.DecorationType.None);
            this.btn_home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_home.Iconimage")));
            this.btn_home.Iconimage_right = null;
            this.btn_home.Iconimage_right_Selected = null;
            this.btn_home.Iconimage_Selected = null;
            this.btn_home.IconMarginLeft = 0;
            this.btn_home.IconMarginRight = 0;
            this.btn_home.IconRightVisible = true;
            this.btn_home.IconRightZoom = 0D;
            this.btn_home.IconVisible = true;
            this.btn_home.IconZoom = 80D;
            this.btn_home.IsTab = false;
            this.btn_home.Location = new System.Drawing.Point(5, 71);
            this.btn_home.Margin = new System.Windows.Forms.Padding(5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_home.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_home.selected = true;
            this.btn_home.Size = new System.Drawing.Size(307, 50);
            this.btn_home.TabIndex = 2;
            this.btn_home.TabStop = false;
            this.btn_home.Text = " Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Textcolor = System.Drawing.Color.Black;
            this.btn_home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_NutMeNu
            // 
            this.panel_NutMeNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_NutMeNu.Controls.Add(this.btnMenu);
            this.transition_AnhGai.SetDecoration(this.panel_NutMeNu, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_NutMeNu, BunifuAnimatorNS.DecorationType.None);
            this.panel_NutMeNu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NutMeNu.Location = new System.Drawing.Point(0, 0);
            this.panel_NutMeNu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_NutMeNu.Name = "panel_NutMeNu";
            this.panel_NutMeNu.Size = new System.Drawing.Size(250, 41);
            this.panel_NutMeNu.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transition_AnhGai.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(55, 41);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_DangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DangXuat.BorderRadius = 0;
            this.btn_DangXuat.ButtonText = "  Đăng xuất";
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btn_DangXuat, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btn_DangXuat, BunifuAnimatorNS.DecorationType.None);
            this.btn_DangXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btn_DangXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_DangXuat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Iconimage")));
            this.btn_DangXuat.Iconimage_right = null;
            this.btn_DangXuat.Iconimage_right_Selected = null;
            this.btn_DangXuat.Iconimage_Selected = null;
            this.btn_DangXuat.IconMarginLeft = 0;
            this.btn_DangXuat.IconMarginRight = 0;
            this.btn_DangXuat.IconRightVisible = true;
            this.btn_DangXuat.IconRightZoom = 0D;
            this.btn_DangXuat.IconVisible = true;
            this.btn_DangXuat.IconZoom = 80D;
            this.btn_DangXuat.IsTab = false;
            this.btn_DangXuat.Location = new System.Drawing.Point(5, 662);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_DangXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_DangXuat.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_DangXuat.selected = false;
            this.btn_DangXuat.Size = new System.Drawing.Size(336, 50);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.Text = "  Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Textcolor = System.Drawing.Color.Black;
            this.btn_DangXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeThong.BorderRadius = 0;
            this.btnHeThong.ButtonText = " Hệ thống";
            this.btnHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnHeThong, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnHeThong, BunifuAnimatorNS.DecorationType.None);
            this.btnHeThong.DisabledColor = System.Drawing.Color.Gray;
            this.btnHeThong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHeThong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHeThong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Iconimage")));
            this.btnHeThong.Iconimage_right = null;
            this.btnHeThong.Iconimage_right_Selected = null;
            this.btnHeThong.Iconimage_Selected = null;
            this.btnHeThong.IconMarginLeft = 0;
            this.btnHeThong.IconMarginRight = 0;
            this.btnHeThong.IconRightVisible = true;
            this.btnHeThong.IconRightZoom = 0D;
            this.btnHeThong.IconVisible = true;
            this.btnHeThong.IconZoom = 90D;
            this.btnHeThong.IsTab = false;
            this.btnHeThong.Location = new System.Drawing.Point(5, 602);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(5);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHeThong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHeThong.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnHeThong.selected = false;
            this.btnHeThong.Size = new System.Drawing.Size(336, 50);
            this.btnHeThong.TabIndex = 2;
            this.btnHeThong.Text = " Hệ thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.Textcolor = System.Drawing.Color.Black;
            this.btnHeThong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.BorderRadius = 0;
            this.btnThanhToan.ButtonText = " Thanh toán";
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnThanhToan, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnThanhToan, BunifuAnimatorNS.DecorationType.None);
            this.btnThanhToan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThanhToan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Iconimage")));
            this.btnThanhToan.Iconimage_right = null;
            this.btnThanhToan.Iconimage_right_Selected = null;
            this.btnThanhToan.Iconimage_Selected = null;
            this.btnThanhToan.IconMarginLeft = 0;
            this.btnThanhToan.IconMarginRight = 0;
            this.btnThanhToan.IconRightVisible = true;
            this.btnThanhToan.IconRightZoom = 0D;
            this.btnThanhToan.IconVisible = true;
            this.btnThanhToan.IconZoom = 80D;
            this.btnThanhToan.IsTab = false;
            this.btnThanhToan.Location = new System.Drawing.Point(5, 542);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThanhToan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThanhToan.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThanhToan.selected = false;
            this.btnThanhToan.Size = new System.Drawing.Size(336, 50);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = " Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Textcolor = System.Drawing.SystemColors.MenuText;
            this.btnThanhToan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.BorderRadius = 0;
            this.btnThongKe.ButtonText = " Thống kê";
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.btnThongKe.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKe.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Iconimage")));
            this.btnThongKe.Iconimage_right = null;
            this.btnThongKe.Iconimage_right_Selected = null;
            this.btnThongKe.Iconimage_Selected = null;
            this.btnThongKe.IconMarginLeft = 0;
            this.btnThongKe.IconMarginRight = 0;
            this.btnThongKe.IconRightVisible = true;
            this.btnThongKe.IconRightZoom = 0D;
            this.btnThongKe.IconVisible = true;
            this.btnThongKe.IconZoom = 80D;
            this.btnThongKe.IsTab = false;
            this.btnThongKe.Location = new System.Drawing.Point(5, 482);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongKe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongKe.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThongKe.selected = false;
            this.btnThongKe.Size = new System.Drawing.Size(336, 50);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = " Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Textcolor = System.Drawing.Color.Black;
            this.btnThongKe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDieuTri
            // 
            this.btnDieuTri.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDieuTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDieuTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDieuTri.BorderRadius = 0;
            this.btnDieuTri.ButtonText = " Điều trị";
            this.btnDieuTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnDieuTri, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnDieuTri, BunifuAnimatorNS.DecorationType.None);
            this.btnDieuTri.DisabledColor = System.Drawing.Color.Gray;
            this.btnDieuTri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDieuTri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDieuTri.Iconimage")));
            this.btnDieuTri.Iconimage_right = null;
            this.btnDieuTri.Iconimage_right_Selected = null;
            this.btnDieuTri.Iconimage_Selected = null;
            this.btnDieuTri.IconMarginLeft = 0;
            this.btnDieuTri.IconMarginRight = 0;
            this.btnDieuTri.IconRightVisible = true;
            this.btnDieuTri.IconRightZoom = 0D;
            this.btnDieuTri.IconVisible = true;
            this.btnDieuTri.IconZoom = 90D;
            this.btnDieuTri.IsTab = false;
            this.btnDieuTri.Location = new System.Drawing.Point(5, 422);
            this.btnDieuTri.Margin = new System.Windows.Forms.Padding(5);
            this.btnDieuTri.Name = "btnDieuTri";
            this.btnDieuTri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDieuTri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDieuTri.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDieuTri.selected = false;
            this.btnDieuTri.Size = new System.Drawing.Size(336, 50);
            this.btnDieuTri.TabIndex = 2;
            this.btnDieuTri.Text = " Điều trị";
            this.btnDieuTri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDieuTri.Textcolor = System.Drawing.Color.Black;
            this.btnDieuTri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDieuTri.Click += new System.EventHandler(this.btnDonThuoc_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDichVu.BorderRadius = 0;
            this.btnDichVu.ButtonText = " Quản lý dịch vụ";
            this.btnDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnDichVu, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnDichVu, BunifuAnimatorNS.DecorationType.None);
            this.btnDichVu.DisabledColor = System.Drawing.Color.Gray;
            this.btnDichVu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDichVu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Iconimage")));
            this.btnDichVu.Iconimage_right = null;
            this.btnDichVu.Iconimage_right_Selected = null;
            this.btnDichVu.Iconimage_Selected = null;
            this.btnDichVu.IconMarginLeft = 0;
            this.btnDichVu.IconMarginRight = 0;
            this.btnDichVu.IconRightVisible = true;
            this.btnDichVu.IconRightZoom = 0D;
            this.btnDichVu.IconVisible = true;
            this.btnDichVu.IconZoom = 90D;
            this.btnDichVu.IsTab = false;
            this.btnDichVu.Location = new System.Drawing.Point(5, 362);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(5);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDichVu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDichVu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDichVu.selected = false;
            this.btnDichVu.Size = new System.Drawing.Size(336, 50);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.TabStop = false;
            this.btnDichVu.Text = " Quản lý dịch vụ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Textcolor = System.Drawing.Color.Black;
            this.btnDichVu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnQuanLyNVBS
            // 
            this.btnQuanLyNVBS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyNVBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyNVBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNVBS.BorderRadius = 0;
            this.btnQuanLyNVBS.ButtonText = " Quản lý nhân viên bác sĩ";
            this.btnQuanLyNVBS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnQuanLyNVBS, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnQuanLyNVBS, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyNVBS.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyNVBS.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNVBS.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNVBS.Iconimage")));
            this.btnQuanLyNVBS.Iconimage_right = null;
            this.btnQuanLyNVBS.Iconimage_right_Selected = null;
            this.btnQuanLyNVBS.Iconimage_Selected = null;
            this.btnQuanLyNVBS.IconMarginLeft = 0;
            this.btnQuanLyNVBS.IconMarginRight = 0;
            this.btnQuanLyNVBS.IconRightVisible = true;
            this.btnQuanLyNVBS.IconRightZoom = 0D;
            this.btnQuanLyNVBS.IconVisible = true;
            this.btnQuanLyNVBS.IconZoom = 80D;
            this.btnQuanLyNVBS.IsTab = false;
            this.btnQuanLyNVBS.Location = new System.Drawing.Point(5, 302);
            this.btnQuanLyNVBS.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuanLyNVBS.Name = "btnQuanLyNVBS";
            this.btnQuanLyNVBS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyNVBS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyNVBS.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnQuanLyNVBS.selected = false;
            this.btnQuanLyNVBS.Size = new System.Drawing.Size(307, 50);
            this.btnQuanLyNVBS.TabIndex = 2;
            this.btnQuanLyNVBS.TabStop = false;
            this.btnQuanLyNVBS.Text = " Quản lý nhân viên bác sĩ";
            this.btnQuanLyNVBS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNVBS.Textcolor = System.Drawing.Color.Black;
            this.btnQuanLyNVBS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNVBS.Click += new System.EventHandler(this.btnQuanLyNVBS_Click);
            // 
            // btnQuanLyThuoc
            // 
            this.btnQuanLyThuoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyThuoc.BorderRadius = 0;
            this.btnQuanLyThuoc.ButtonText = " Quản lý thuốc";
            this.btnQuanLyThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnQuanLyThuoc, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnQuanLyThuoc, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyThuoc.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyThuoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyThuoc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThuoc.Iconimage")));
            this.btnQuanLyThuoc.Iconimage_right = null;
            this.btnQuanLyThuoc.Iconimage_right_Selected = null;
            this.btnQuanLyThuoc.Iconimage_Selected = null;
            this.btnQuanLyThuoc.IconMarginLeft = 0;
            this.btnQuanLyThuoc.IconMarginRight = 0;
            this.btnQuanLyThuoc.IconRightVisible = true;
            this.btnQuanLyThuoc.IconRightZoom = 0D;
            this.btnQuanLyThuoc.IconVisible = true;
            this.btnQuanLyThuoc.IconZoom = 80D;
            this.btnQuanLyThuoc.IsTab = false;
            this.btnQuanLyThuoc.Location = new System.Drawing.Point(5, 242);
            this.btnQuanLyThuoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            this.btnQuanLyThuoc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyThuoc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyThuoc.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnQuanLyThuoc.selected = false;
            this.btnQuanLyThuoc.Size = new System.Drawing.Size(336, 50);
            this.btnQuanLyThuoc.TabIndex = 2;
            this.btnQuanLyThuoc.TabStop = false;
            this.btnQuanLyThuoc.Text = " Quản lý thuốc";
            this.btnQuanLyThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuoc.Textcolor = System.Drawing.Color.Black;
            this.btnQuanLyThuoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThuoc.Click += new System.EventHandler(this.btnQuanLyThuoc_Click);
            // 
            // btnQuanLyLichHen
            // 
            this.btnQuanLyLichHen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyLichHen.BorderRadius = 0;
            this.btnQuanLyLichHen.ButtonText = " Quản lý lịch hẹn";
            this.btnQuanLyLichHen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnQuanLyLichHen, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnQuanLyLichHen, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyLichHen.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyLichHen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyLichHen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyLichHen.Iconimage")));
            this.btnQuanLyLichHen.Iconimage_right = null;
            this.btnQuanLyLichHen.Iconimage_right_Selected = null;
            this.btnQuanLyLichHen.Iconimage_Selected = null;
            this.btnQuanLyLichHen.IconMarginLeft = 0;
            this.btnQuanLyLichHen.IconMarginRight = 0;
            this.btnQuanLyLichHen.IconRightVisible = true;
            this.btnQuanLyLichHen.IconRightZoom = 0D;
            this.btnQuanLyLichHen.IconVisible = true;
            this.btnQuanLyLichHen.IconZoom = 80D;
            this.btnQuanLyLichHen.IsTab = false;
            this.btnQuanLyLichHen.Location = new System.Drawing.Point(5, 191);
            this.btnQuanLyLichHen.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuanLyLichHen.Name = "btnQuanLyLichHen";
            this.btnQuanLyLichHen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyLichHen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyLichHen.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnQuanLyLichHen.selected = false;
            this.btnQuanLyLichHen.Size = new System.Drawing.Size(336, 50);
            this.btnQuanLyLichHen.TabIndex = 1;
            this.btnQuanLyLichHen.TabStop = false;
            this.btnQuanLyLichHen.Text = " Quản lý lịch hẹn";
            this.btnQuanLyLichHen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLichHen.Textcolor = System.Drawing.Color.Black;
            this.btnQuanLyLichHen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLichHen.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnQuanLyBenhNhan
            // 
            this.btnQuanLyBenhNhan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyBenhNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyBenhNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyBenhNhan.BorderRadius = 0;
            this.btnQuanLyBenhNhan.ButtonText = " Quản lý bệnh nhân";
            this.btnQuanLyBenhNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnQuanLyBenhNhan, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnQuanLyBenhNhan, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyBenhNhan.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyBenhNhan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuanLyBenhNhan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyBenhNhan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyBenhNhan.Iconimage")));
            this.btnQuanLyBenhNhan.Iconimage_right = null;
            this.btnQuanLyBenhNhan.Iconimage_right_Selected = null;
            this.btnQuanLyBenhNhan.Iconimage_Selected = null;
            this.btnQuanLyBenhNhan.IconMarginLeft = 0;
            this.btnQuanLyBenhNhan.IconMarginRight = 0;
            this.btnQuanLyBenhNhan.IconRightVisible = true;
            this.btnQuanLyBenhNhan.IconRightZoom = 0D;
            this.btnQuanLyBenhNhan.IconVisible = true;
            this.btnQuanLyBenhNhan.IconZoom = 90D;
            this.btnQuanLyBenhNhan.IsTab = false;
            this.btnQuanLyBenhNhan.Location = new System.Drawing.Point(5, 131);
            this.btnQuanLyBenhNhan.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuanLyBenhNhan.Name = "btnQuanLyBenhNhan";
            this.btnQuanLyBenhNhan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyBenhNhan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyBenhNhan.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnQuanLyBenhNhan.selected = false;
            this.btnQuanLyBenhNhan.Size = new System.Drawing.Size(336, 50);
            this.btnQuanLyBenhNhan.TabIndex = 0;
            this.btnQuanLyBenhNhan.TabStop = false;
            this.btnQuanLyBenhNhan.Text = " Quản lý bệnh nhân";
            this.btnQuanLyBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyBenhNhan.Textcolor = System.Drawing.Color.Black;
            this.btnQuanLyBenhNhan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBenhNhan.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel_HienThi
            // 
            this.panel_HienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_HienThi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_HienThi.BackgroundImage")));
            this.panel_HienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition_AnhGai.SetDecoration(this.panel_HienThi, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_HienThi, BunifuAnimatorNS.DecorationType.None);
            this.panel_HienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_HienThi.Location = new System.Drawing.Point(250, 39);
            this.panel_HienThi.Margin = new System.Windows.Forms.Padding(4);
            this.panel_HienThi.Name = "panel_HienThi";
            this.panel_HienThi.Size = new System.Drawing.Size(1350, 763);
            this.panel_HienThi.TabIndex = 2;
            this.panel_HienThi.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_HienThi_Paint);
            // 
            // transition_Menu
            // 
            this.transition_Menu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transition_Menu.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.transition_Menu.DefaultAnimation = animation2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_Infor);
            this.transition_AnhGai.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(250, 802);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 18);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Infor
            // 
            this.lbl_Infor.AutoSize = true;
            this.transition_Menu.SetDecoration(this.lbl_Infor, BunifuAnimatorNS.DecorationType.None);
            this.transition_AnhGai.SetDecoration(this.lbl_Infor, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Infor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Infor.Location = new System.Drawing.Point(8, 0);
            this.lbl_Infor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Infor.Name = "lbl_Infor";
            this.lbl_Infor.Size = new System.Drawing.Size(243, 17);
            this.lbl_Infor.TabIndex = 0;
            this.lbl_Infor.Text = "Bác Sĩ - Nguyễn Xuân Hoàng -Online";
            // 
            // transition_AnhGai
            // 
            this.transition_AnhGai.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.transition_AnhGai.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition_AnhGai.DefaultAnimation = animation1;
            this.transition_AnhGai.MaxAnimationTime = 3000;
            this.transition_AnhGai.TimeStep = 0.005F;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_Title;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1600, 820);
            this.Controls.Add(this.panel_HienThi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.panel_Title);
            this.transition_Menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transition_AnhGai.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel_ChucNang.ResumeLayout(false);
            this.panel_NutMeNu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_HienThi;
        private System.Windows.Forms.Panel panel_ChucNang;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Panel panel_Select;
        private BunifuAnimatorNS.BunifuTransition transition_Menu;
        private System.Windows.Forms.Panel panel_NutMeNu;
        private BunifuAnimatorNS.BunifuTransition transition_AnhGai;
        public Bunifu.Framework.UI.BunifuFlatButton btnQuanLyBenhNhan;
        public Bunifu.Framework.UI.BunifuFlatButton btnThongKe;
        public Bunifu.Framework.UI.BunifuFlatButton btnDieuTri;
        public Bunifu.Framework.UI.BunifuFlatButton btnDichVu;
        public Bunifu.Framework.UI.BunifuFlatButton btnQuanLyNVBS;
        public Bunifu.Framework.UI.BunifuFlatButton btnQuanLyThuoc;
        public Bunifu.Framework.UI.BunifuFlatButton btnQuanLyLichHen;
        public Bunifu.Framework.UI.BunifuFlatButton btnHeThong;
        public Bunifu.Framework.UI.BunifuFlatButton btnThanhToan;
        public Bunifu.Framework.UI.BunifuFlatButton btn_home;
        public Bunifu.Framework.UI.BunifuFlatButton btn_DangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Infor;
        private Bunifu.Framework.UI.BunifuImageButton btn_Zoom;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel LogoPK;
    }
}