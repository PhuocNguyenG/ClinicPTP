namespace TEST
{
    partial class UserControl_System
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_System));
            this.lbl_System = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.transition_System = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_System = new System.Windows.Forms.Panel();
            this.pnl_ManageSystem = new System.Windows.Forms.Panel();
            this.pnl_ControlSystem = new System.Windows.Forms.Panel();
            this.separatorChoose = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbl_About = new System.Windows.Forms.Label();
            this.lbl_TroGiup = new System.Windows.Forms.Label();
            this.lbl_BackUp = new System.Windows.Forms.Label();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.pnl_System.SuspendLayout();
            this.pnl_ControlSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_System
            // 
            this.lbl_System.AutoSize = true;
            this.transition_System.SetDecoration(this.lbl_System, BunifuAnimatorNS.DecorationType.None);
            this.lbl_System.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_System.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_System.Location = new System.Drawing.Point(348, 2);
            this.lbl_System.Name = "lbl_System";
            this.lbl_System.Size = new System.Drawing.Size(258, 33);
            this.lbl_System.TabIndex = 1;
            this.lbl_System.Text = "Quản Trị Hệ Thống";
            // 
            // transition_System
            // 
            this.transition_System.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transition_System.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.transition_System.DefaultAnimation = animation3;
            // 
            // pnl_System
            // 
            this.pnl_System.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_System.Controls.Add(this.lbl_System);
            this.transition_System.SetDecoration(this.pnl_System, BunifuAnimatorNS.DecorationType.None);
            this.pnl_System.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_System.Location = new System.Drawing.Point(0, 0);
            this.pnl_System.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_System.Name = "pnl_System";
            this.pnl_System.Size = new System.Drawing.Size(955, 41);
            this.pnl_System.TabIndex = 8;
            this.pnl_System.Resize += new System.EventHandler(this.pnl_System_Resize);
            // 
            // pnl_ManageSystem
            // 
            this.pnl_ManageSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ManageSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transition_System.SetDecoration(this.pnl_ManageSystem, BunifuAnimatorNS.DecorationType.None);
            this.pnl_ManageSystem.Location = new System.Drawing.Point(0, 91);
            this.pnl_ManageSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_ManageSystem.Name = "pnl_ManageSystem";
            this.pnl_ManageSystem.Size = new System.Drawing.Size(955, 543);
            this.pnl_ManageSystem.TabIndex = 9;
            // 
            // pnl_ControlSystem
            // 
            this.pnl_ControlSystem.Controls.Add(this.separatorChoose);
            this.pnl_ControlSystem.Controls.Add(this.lbl_About);
            this.pnl_ControlSystem.Controls.Add(this.lbl_TroGiup);
            this.pnl_ControlSystem.Controls.Add(this.lbl_BackUp);
            this.pnl_ControlSystem.Controls.Add(this.lbl_TaiKhoan);
            this.transition_System.SetDecoration(this.pnl_ControlSystem, BunifuAnimatorNS.DecorationType.None);
            this.pnl_ControlSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ControlSystem.Location = new System.Drawing.Point(0, 41);
            this.pnl_ControlSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_ControlSystem.Name = "pnl_ControlSystem";
            this.pnl_ControlSystem.Size = new System.Drawing.Size(955, 46);
            this.pnl_ControlSystem.TabIndex = 0;
            // 
            // separatorChoose
            // 
            this.separatorChoose.BackColor = System.Drawing.Color.Transparent;
            this.transition_System.SetDecoration(this.separatorChoose, BunifuAnimatorNS.DecorationType.None);
            this.separatorChoose.ForeColor = System.Drawing.Color.Silver;
            this.separatorChoose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.separatorChoose.LineThickness = 2;
            this.separatorChoose.Location = new System.Drawing.Point(5, 31);
            this.separatorChoose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.separatorChoose.Name = "separatorChoose";
            this.separatorChoose.Size = new System.Drawing.Size(227, 10);
            this.separatorChoose.TabIndex = 1;
            this.separatorChoose.Transparency = 255;
            this.separatorChoose.Vertical = false;
            this.separatorChoose.Load += new System.EventHandler(this.separatorChoose_Load);
            // 
            // lbl_About
            // 
            this.lbl_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transition_System.SetDecoration(this.lbl_About, BunifuAnimatorNS.DecorationType.None);
            this.lbl_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_About.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_About.Location = new System.Drawing.Point(466, 0);
            this.lbl_About.Name = "lbl_About";
            this.lbl_About.Size = new System.Drawing.Size(256, 46);
            this.lbl_About.TabIndex = 0;
            this.lbl_About.Text = "About";
            this.lbl_About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_About.Click += new System.EventHandler(this.lbl_About_Click);
            // 
            // lbl_TroGiup
            // 
            this.transition_System.SetDecoration(this.lbl_TroGiup, BunifuAnimatorNS.DecorationType.None);
            this.lbl_TroGiup.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_TroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TroGiup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_TroGiup.Location = new System.Drawing.Point(722, 0);
            this.lbl_TroGiup.Name = "lbl_TroGiup";
            this.lbl_TroGiup.Size = new System.Drawing.Size(233, 46);
            this.lbl_TroGiup.TabIndex = 0;
            this.lbl_TroGiup.Text = "Trợ giúp";
            this.lbl_TroGiup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TroGiup.Click += new System.EventHandler(this.lbl_TroGiup_Click);
            // 
            // lbl_BackUp
            // 
            this.lbl_BackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transition_System.SetDecoration(this.lbl_BackUp, BunifuAnimatorNS.DecorationType.None);
            this.lbl_BackUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_BackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BackUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_BackUp.Location = new System.Drawing.Point(233, 0);
            this.lbl_BackUp.Name = "lbl_BackUp";
            this.lbl_BackUp.Size = new System.Drawing.Size(233, 46);
            this.lbl_BackUp.TabIndex = 0;
            this.lbl_BackUp.Text = "Sao lưu/ Khôi phục";
            this.lbl_BackUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BackUp.Click += new System.EventHandler(this.lbl_BackUp_Click);
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transition_System.SetDecoration(this.lbl_TaiKhoan, BunifuAnimatorNS.DecorationType.None);
            this.lbl_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(233, 46);
            this.lbl_TaiKhoan.TabIndex = 0;
            this.lbl_TaiKhoan.Text = "Tài khoản";
            this.lbl_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TaiKhoan.Click += new System.EventHandler(this.lbl_TaiKhoan_Click);
            // 
            // UserControl_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pnl_ManageSystem);
            this.Controls.Add(this.pnl_ControlSystem);
            this.Controls.Add(this.pnl_System);
            this.transition_System.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_System";
            this.Size = new System.Drawing.Size(955, 658);
            this.Load += new System.EventHandler(this.UserControl_System_Load);
            this.Resize += new System.EventHandler(this.UserControl_System_Resize);
            this.pnl_System.ResumeLayout(false);
            this.pnl_System.PerformLayout();
            this.pnl_ControlSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_System;
        private BunifuAnimatorNS.BunifuTransition transition_System;
        private System.Windows.Forms.Panel pnl_System;
        private System.Windows.Forms.Panel pnl_ManageSystem;
        private System.Windows.Forms.Panel pnl_ControlSystem;
        private System.Windows.Forms.Label lbl_TroGiup;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private Bunifu.Framework.UI.BunifuSeparator separatorChoose;
        private System.Windows.Forms.Label lbl_BackUp;
        private System.Windows.Forms.Label lbl_About;
    }
}
