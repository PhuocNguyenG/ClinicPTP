namespace TEST
{
    partial class Form_SuaTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SuaTaiKhoan));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.bnt_CancelThemLichHen = new System.Windows.Forms.Button();
            this.bnt_OkThemLichHen = new System.Windows.Forms.Button();
            this.lbNhapLaiMK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 38);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đổi Mật Khẩu";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SpringGreen;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(16, 4);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(33, 31);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SpringGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(510, 7);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 18);
            this.lbl.TabIndex = 18;
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Enabled = false;
            this.txt_TenTK.Location = new System.Drawing.Point(200, 42);
            this.txt_TenTK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(187, 27);
            this.txt_TenTK.TabIndex = 1;
            this.txt_TenTK.TextChanged += new System.EventHandler(this.txt_TenTK_TextChanged);
            this.txt_TenTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenTK_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbNhapLaiMK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_MatKhauMoi);
            this.groupBox1.Controls.Add(this.txt_TenTK);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(510, 158);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nhập Lại Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(200, 93);
            this.txt_MatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(187, 27);
            this.txt_MatKhauMoi.TabIndex = 2;
            this.txt_MatKhauMoi.TextChanged += new System.EventHandler(this.txt_MatKhauMoi_TextChanged);
            this.txt_MatKhauMoi.Enter += new System.EventHandler(this.txt_MatKhauMoi_Enter);
            this.txt_MatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MatKhauMoi_KeyPress);
            this.txt_MatKhauMoi.Leave += new System.EventHandler(this.txt_MatKhauMoi_Leave);
            // 
            // bnt_CancelThemLichHen
            // 
            this.bnt_CancelThemLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnt_CancelThemLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_CancelThemLichHen.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CancelThemLichHen.Location = new System.Drawing.Point(297, 244);
            this.bnt_CancelThemLichHen.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_CancelThemLichHen.Name = "bnt_CancelThemLichHen";
            this.bnt_CancelThemLichHen.Size = new System.Drawing.Size(108, 39);
            this.bnt_CancelThemLichHen.TabIndex = 4;
            this.bnt_CancelThemLichHen.Text = "Cancel";
            this.bnt_CancelThemLichHen.UseVisualStyleBackColor = false;
            this.bnt_CancelThemLichHen.Click += new System.EventHandler(this.bnt_CancelThemLichHen_Click);
            // 
            // bnt_OkThemLichHen
            // 
            this.bnt_OkThemLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnt_OkThemLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_OkThemLichHen.Enabled = false;
            this.bnt_OkThemLichHen.FlatAppearance.BorderSize = 0;
            this.bnt_OkThemLichHen.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_OkThemLichHen.Location = new System.Drawing.Point(84, 244);
            this.bnt_OkThemLichHen.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_OkThemLichHen.Name = "bnt_OkThemLichHen";
            this.bnt_OkThemLichHen.Size = new System.Drawing.Size(111, 39);
            this.bnt_OkThemLichHen.TabIndex = 3;
            this.bnt_OkThemLichHen.Text = "Ok";
            this.bnt_OkThemLichHen.UseVisualStyleBackColor = false;
            this.bnt_OkThemLichHen.Click += new System.EventHandler(this.bnt_OkThemLichHen_Click);
            // 
            // lbNhapLaiMK
            // 
            this.lbNhapLaiMK.AutoSize = true;
            this.lbNhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapLaiMK.ForeColor = System.Drawing.Color.Red;
            this.lbNhapLaiMK.Location = new System.Drawing.Point(391, 96);
            this.lbNhapLaiMK.Name = "lbNhapLaiMK";
            this.lbNhapLaiMK.Size = new System.Drawing.Size(112, 20);
            this.lbNhapLaiMK.TabIndex = 21;
            this.lbNhapLaiMK.Text = "Sai quy định";
            this.lbNhapLaiMK.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "(Gồm : CHỮ (1 Hoa), SỐ, KÝ TỰ )";
            // 
            // Form_SuaTaiKhoan
            // 
            this.AcceptButton = this.bnt_OkThemLichHen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 298);
            this.Controls.Add(this.bnt_CancelThemLichHen);
            this.Controls.Add(this.bnt_OkThemLichHen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_SuaTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThemTaiKhoan";
            this.Load += new System.EventHandler(this.Form_SuaTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.TextBox txt_TenTK;
        public System.Windows.Forms.Button bnt_CancelThemLichHen;
        public System.Windows.Forms.Button bnt_OkThemLichHen;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNhapLaiMK;
    }
}