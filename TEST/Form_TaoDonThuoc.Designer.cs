namespace TEST
{
    partial class Form_TaoDonThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TaoDonThuoc));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_DonThuoc = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lbl_Thuoc = new System.Windows.Forms.Label();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmb_Thuoc = new System.Windows.Forms.ComboBox();
            this.lvs_ChiTietDonThuoc = new System.Windows.Forms.ListView();
            this.btn_TaoDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Space = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lsb_Thuoc = new System.Windows.Forms.ListBox();
            this.lbl_DanhSachChon = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txtTenDon = new System.Windows.Forms.TextBox();
            this.lbl_TenDonThuoc = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.btn_SuaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonThuoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgv_DonThuoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_DonThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DonThuoc.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_DonThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DonThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DonThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonThuoc.DoubleBuffered = true;
            this.dgv_DonThuoc.EnableHeadersVisualStyles = false;
            this.dgv_DonThuoc.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_DonThuoc.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_DonThuoc.HeaderForeColor = System.Drawing.Color.Black;
            this.dgv_DonThuoc.Location = new System.Drawing.Point(16, 75);
            this.dgv_DonThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DonThuoc.Name = "dgv_DonThuoc";
            this.dgv_DonThuoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DonThuoc.RowHeadersWidth = 51;
            this.dgv_DonThuoc.Size = new System.Drawing.Size(793, 694);
            this.dgv_DonThuoc.TabIndex = 0;
            this.dgv_DonThuoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_DonThuoc_CellMouseClick);
            // 
            // lbl_Thuoc
            // 
            this.lbl_Thuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Thuoc.AutoSize = true;
            this.lbl_Thuoc.Enabled = false;
            this.lbl_Thuoc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thuoc.Location = new System.Drawing.Point(1178, 491);
            this.lbl_Thuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Thuoc.Name = "lbl_Thuoc";
            this.lbl_Thuoc.Size = new System.Drawing.Size(64, 22);
            this.lbl_Thuoc.TabIndex = 2;
            this.lbl_Thuoc.Text = "Thuốc";
            this.lbl_Thuoc.Visible = false;
            // 
            // btn_Chon
            // 
            this.btn_Chon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Chon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Chon.Enabled = false;
            this.btn_Chon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chon.Location = new System.Drawing.Point(1265, 580);
            this.btn_Chon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(183, 55);
            this.btn_Chon.TabIndex = 3;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.UseVisualStyleBackColor = false;
            this.btn_Chon.Visible = false;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 38);
            this.panel1.TabIndex = 18;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SpringGreen;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1424, 4);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(33, 31);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // cmb_Thuoc
            // 
            this.cmb_Thuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Thuoc.Enabled = false;
            this.cmb_Thuoc.FormattingEnabled = true;
            this.cmb_Thuoc.Location = new System.Drawing.Point(1281, 491);
            this.cmb_Thuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Thuoc.Name = "cmb_Thuoc";
            this.cmb_Thuoc.Size = new System.Drawing.Size(169, 24);
            this.cmb_Thuoc.TabIndex = 1;
            this.cmb_Thuoc.Visible = false;
            // 
            // lvs_ChiTietDonThuoc
            // 
            this.lvs_ChiTietDonThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvs_ChiTietDonThuoc.HideSelection = false;
            this.lvs_ChiTietDonThuoc.Location = new System.Drawing.Point(847, 69);
            this.lvs_ChiTietDonThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.lvs_ChiTietDonThuoc.MultiSelect = false;
            this.lvs_ChiTietDonThuoc.Name = "lvs_ChiTietDonThuoc";
            this.lvs_ChiTietDonThuoc.Size = new System.Drawing.Size(604, 341);
            this.lvs_ChiTietDonThuoc.TabIndex = 19;
            this.lvs_ChiTietDonThuoc.UseCompatibleStateImageBehavior = false;
            this.lvs_ChiTietDonThuoc.View = System.Windows.Forms.View.Details;
            // 
            // btn_TaoDon
            // 
            this.btn_TaoDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_TaoDon.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoDon.Location = new System.Drawing.Point(1265, 643);
            this.btn_TaoDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TaoDon.Name = "btn_TaoDon";
            this.btn_TaoDon.Size = new System.Drawing.Size(83, 127);
            this.btn_TaoDon.TabIndex = 3;
            this.btn_TaoDon.Text = "Tạo đơn";
            this.btn_TaoDon.UseVisualStyleBackColor = false;
            this.btn_TaoDon.Click += new System.EventHandler(this.btn_TaoDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Danh sách đơn thuốc";
            // 
            // pnl_Space
            // 
            this.pnl_Space.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_Space.Location = new System.Drawing.Point(817, 46);
            this.pnl_Space.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Space.Name = "pnl_Space";
            this.pnl_Space.Size = new System.Drawing.Size(21, 724);
            this.pnl_Space.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1113, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Chi tiết đơn thuốc";
            // 
            // lsb_Thuoc
            // 
            this.lsb_Thuoc.FormattingEnabled = true;
            this.lsb_Thuoc.ItemHeight = 16;
            this.lsb_Thuoc.Location = new System.Drawing.Point(876, 447);
            this.lsb_Thuoc.Margin = new System.Windows.Forms.Padding(4);
            this.lsb_Thuoc.Name = "lsb_Thuoc";
            this.lsb_Thuoc.Size = new System.Drawing.Size(287, 292);
            this.lsb_Thuoc.TabIndex = 22;
            this.lsb_Thuoc.Visible = false;
            // 
            // lbl_DanhSachChon
            // 
            this.lbl_DanhSachChon.AutoSize = true;
            this.lbl_DanhSachChon.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhSachChon.Location = new System.Drawing.Point(931, 414);
            this.lbl_DanhSachChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DanhSachChon.Name = "lbl_DanhSachChon";
            this.lbl_DanhSachChon.Size = new System.Drawing.Size(182, 28);
            this.lbl_DanhSachChon.TabIndex = 20;
            this.lbl_DanhSachChon.Text = "Danh sách chọn";
            this.lbl_DanhSachChon.Visible = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(1356, 708);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(92, 61);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa thuốc";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTenDon
            // 
            this.txtTenDon.Location = new System.Drawing.Point(1281, 446);
            this.txtTenDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDon.Name = "txtTenDon";
            this.txtTenDon.Size = new System.Drawing.Size(169, 22);
            this.txtTenDon.TabIndex = 24;
            this.txtTenDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_TenDonThuoc
            // 
            this.lbl_TenDonThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TenDonThuoc.AutoSize = true;
            this.lbl_TenDonThuoc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDonThuoc.Location = new System.Drawing.Point(1178, 447);
            this.lbl_TenDonThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenDonThuoc.Name = "lbl_TenDonThuoc";
            this.lbl_TenDonThuoc.Size = new System.Drawing.Size(81, 22);
            this.lbl_TenDonThuoc.TabIndex = 2;
            this.lbl_TenDonThuoc.Text = "Tên đơn";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(1372, 537);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(79, 22);
            this.txtSoLuong.TabIndex = 25;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLuong.Visible = false;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Enabled = false;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(1178, 537);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(88, 22);
            this.lbl_SoLuong.TabIndex = 2;
            this.lbl_SoLuong.Text = "Số lượng";
            this.lbl_SoLuong.Visible = false;
            // 
            // btn_SuaDon
            // 
            this.btn_SuaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_SuaDon.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaDon.Location = new System.Drawing.Point(1356, 643);
            this.btn_SuaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaDon.Name = "btn_SuaDon";
            this.btn_SuaDon.Size = new System.Drawing.Size(92, 57);
            this.btn_SuaDon.TabIndex = 23;
            this.btn_SuaDon.Text = "Sửa đơn";
            this.btn_SuaDon.UseVisualStyleBackColor = false;
            this.btn_SuaDon.Click += new System.EventHandler(this.btn_SuaDon_Click);
            // 
            // Form_TaoDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1461, 785);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_SuaDon);
            this.Controls.Add(this.btn_TaoDon);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.lbl_Thuoc);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cmb_Thuoc);
            this.Controls.Add(this.lsb_Thuoc);
            this.Controls.Add(this.txtTenDon);
            this.Controls.Add(this.pnl_Space);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_DanhSachChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvs_ChiTietDonThuoc);
            this.Controls.Add(this.dgv_DonThuoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_TenDonThuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_TaoDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TaoDonThuoc";
            this.Load += new System.EventHandler(this.Form_TaoDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonThuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv_DonThuoc;
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.Label lbl_Thuoc;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.ListView lvs_ChiTietDonThuoc;
        private System.Windows.Forms.ComboBox cmb_Thuoc;
        private System.Windows.Forms.Button btn_TaoDon;
        private System.Windows.Forms.ListBox lsb_Thuoc;
        private System.Windows.Forms.Panel pnl_Space;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_DanhSachChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txtTenDon;
        private System.Windows.Forms.Label lbl_TenDonThuoc;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Button btn_SuaDon;
    }
}