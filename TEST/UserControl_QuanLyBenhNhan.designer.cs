namespace TEST
{
    partial class UserControl_QuanLyBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_QuanLyBenhNhan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Title_QuanLyBenhNhan = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.lbl_Tilte_QLBN = new System.Windows.Forms.Label();
            this.btn_ExportExcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGrid_QuanLyBenhNhan = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ExportExcel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title_QuanLyBenhNhan
            // 
            this.panel_Title_QuanLyBenhNhan.BackColor = System.Drawing.Color.SpringGreen;
            this.panel_Title_QuanLyBenhNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title_QuanLyBenhNhan.Location = new System.Drawing.Point(0, 0);
            this.panel_Title_QuanLyBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Title_QuanLyBenhNhan.Name = "panel_Title_QuanLyBenhNhan";
            this.panel_Title_QuanLyBenhNhan.Size = new System.Drawing.Size(1700, 32);
            this.panel_Title_QuanLyBenhNhan.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(216, 54);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 63);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 17;
            this.btnDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDelete, "Xóa");
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(118, 54);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 63);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 16;
            this.btnEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEdit, "Sửa");
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(20, 54);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 63);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Thêm");
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.BackgroundImage")));
            this.txtTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.Icon")));
            this.txtTimKiem.Location = new System.Drawing.Point(1381, 63);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(264, 39);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.text = "Tìm kiếm";
            this.toolTip1.SetToolTip(this.txtTimKiem, "Mã Bệnh Nhân");
            this.txtTimKiem.OnTextChange += new System.EventHandler(this.txtTimKiem_OnTextChange);
            this.txtTimKiem.KeyDown += new System.EventHandler(this.txtTimKiem_KeyDown);
            this.txtTimKiem.KeyUp += new System.EventHandler(this.txtTimKiem_KeyUp);
            // 
            // lbl_Tilte_QLBN
            // 
            this.lbl_Tilte_QLBN.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tilte_QLBN.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Tilte_QLBN.Location = new System.Drawing.Point(600, 4);
            this.lbl_Tilte_QLBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tilte_QLBN.Name = "lbl_Tilte_QLBN";
            this.lbl_Tilte_QLBN.Size = new System.Drawing.Size(611, 66);
            this.lbl_Tilte_QLBN.TabIndex = 18;
            this.lbl_Tilte_QLBN.Text = "Quản lý bệnh nhân";
            this.lbl_Tilte_QLBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExportExcel.Image")));
            this.btn_ExportExcel.ImageActive = null;
            this.btn_ExportExcel.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_ExportExcel.InitialImage")));
            this.btn_ExportExcel.Location = new System.Drawing.Point(347, 54);
            this.btn_ExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(83, 63);
            this.btn_ExportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ExportExcel.TabIndex = 15;
            this.btn_ExportExcel.TabStop = false;
            this.btn_ExportExcel.Zoom = 10;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btn_ExportExcel);
            this.panel1.Controls.Add(this.lbl_Tilte_QLBN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 131);
            this.panel1.TabIndex = 1;
            // 
            // DataGrid_QuanLyBenhNhan
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_QuanLyBenhNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_QuanLyBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_QuanLyBenhNhan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGrid_QuanLyBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_QuanLyBenhNhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_QuanLyBenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_QuanLyBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_QuanLyBenhNhan.DoubleBuffered = true;
            this.DataGrid_QuanLyBenhNhan.EnableHeadersVisualStyles = false;
            this.DataGrid_QuanLyBenhNhan.GridColor = System.Drawing.SystemColors.Control;
            this.DataGrid_QuanLyBenhNhan.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGrid_QuanLyBenhNhan.HeaderForeColor = System.Drawing.Color.Empty;
            this.DataGrid_QuanLyBenhNhan.Location = new System.Drawing.Point(0, 170);
            this.DataGrid_QuanLyBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_QuanLyBenhNhan.Name = "DataGrid_QuanLyBenhNhan";
            this.DataGrid_QuanLyBenhNhan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_QuanLyBenhNhan.RowHeadersWidth = 51;
            this.DataGrid_QuanLyBenhNhan.Size = new System.Drawing.Size(1700, 526);
            this.DataGrid_QuanLyBenhNhan.TabIndex = 0;
            this.DataGrid_QuanLyBenhNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_QuanLyBenhNhan_CellContentClick);
            this.DataGrid_QuanLyBenhNhan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_QuanLyBenhNhan_CellMouseClick);
            // 
            // UserControl_QuanLyBenhNhan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGrid_QuanLyBenhNhan);
            this.Controls.Add(this.panel_Title_QuanLyBenhNhan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_QuanLyBenhNhan";
            this.Size = new System.Drawing.Size(1700, 700);
            this.Load += new System.EventHandler(this.UserControl_QuanLyBenhNhan_Load);
            this.Resize += new System.EventHandler(this.UserControl_QuanLyBenhNhan_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ExportExcel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title_QuanLyBenhNhan;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuTextbox txtTimKiem;
        private System.Windows.Forms.Label lbl_Tilte_QLBN;
        private Bunifu.Framework.UI.BunifuImageButton btn_ExportExcel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_QuanLyBenhNhan;
    }
}
