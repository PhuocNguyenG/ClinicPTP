namespace TEST
{
    partial class UserControl_ThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ThanhToan));
            this.dgv_BenhNhan = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dateTime_ThanhToan = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btn_LapPhieuThu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Print = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Title_QuanLyBenhNhan = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LapPhieuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BenhNhan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_BenhNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BenhNhan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_BenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BenhNhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BenhNhan.DoubleBuffered = true;
            this.dgv_BenhNhan.EnableHeadersVisualStyles = false;
            this.dgv_BenhNhan.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_BenhNhan.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_BenhNhan.HeaderForeColor = System.Drawing.Color.Black;
            this.dgv_BenhNhan.Location = new System.Drawing.Point(0, 184);
            this.dgv_BenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_BenhNhan.Name = "dgv_BenhNhan";
            this.dgv_BenhNhan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_BenhNhan.RowHeadersWidth = 51;
            this.dgv_BenhNhan.Size = new System.Drawing.Size(1615, 582);
            this.dgv_BenhNhan.TabIndex = 0;
            this.dgv_BenhNhan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_BenhNhan_CellMouseClick);
            // 
            // dateTime_ThanhToan
            // 
            this.dateTime_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dateTime_ThanhToan.BorderRadius = 0;
            this.dateTime_ThanhToan.ForeColor = System.Drawing.Color.Black;
            this.dateTime_ThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTime_ThanhToan.FormatCustom = null;
            this.dateTime_ThanhToan.Location = new System.Drawing.Point(1206, 41);
            this.dateTime_ThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.dateTime_ThanhToan.Name = "dateTime_ThanhToan";
            this.dateTime_ThanhToan.Size = new System.Drawing.Size(404, 44);
            this.dateTime_ThanhToan.TabIndex = 1;
            this.dateTime_ThanhToan.Value = new System.DateTime(2018, 12, 11, 19, 34, 42, 128);
            this.dateTime_ThanhToan.onValueChanged += new System.EventHandler(this.dateTime_ThanhToan_onValueChanged);
            // 
            // btn_LapPhieuThu
            // 
            this.btn_LapPhieuThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LapPhieuThu.Image = ((System.Drawing.Image)(resources.GetObject("btn_LapPhieuThu.Image")));
            this.btn_LapPhieuThu.ImageActive = null;
            this.btn_LapPhieuThu.Location = new System.Drawing.Point(117, 83);
            this.btn_LapPhieuThu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LapPhieuThu.Name = "btn_LapPhieuThu";
            this.btn_LapPhieuThu.Size = new System.Drawing.Size(86, 58);
            this.btn_LapPhieuThu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_LapPhieuThu.TabIndex = 14;
            this.btn_LapPhieuThu.TabStop = false;
            this.btn_LapPhieuThu.Zoom = 10;
            this.btn_LapPhieuThu.Click += new System.EventHandler(this.btn_LapPhieuThu_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageActive = null;
            this.btn_Print.Location = new System.Drawing.Point(220, 82);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(84, 62);
            this.btn_Print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Print.TabIndex = 14;
            this.btn_Print.TabStop = false;
            this.btn_Print.Zoom = 10;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(572, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 67);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách khám";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_LapPhieuThu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Controls.Add(this.dateTime_ThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1615, 145);
            this.panel1.TabIndex = 16;
            // 
            // panel_Title_QuanLyBenhNhan
            // 
            this.panel_Title_QuanLyBenhNhan.BackColor = System.Drawing.Color.SpringGreen;
            this.panel_Title_QuanLyBenhNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title_QuanLyBenhNhan.Location = new System.Drawing.Point(0, 0);
            this.panel_Title_QuanLyBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Title_QuanLyBenhNhan.Name = "panel_Title_QuanLyBenhNhan";
            this.panel_Title_QuanLyBenhNhan.Size = new System.Drawing.Size(1615, 32);
            this.panel_Title_QuanLyBenhNhan.TabIndex = 16;
            // 
            // UserControl_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_BenhNhan);
            this.Controls.Add(this.panel_Title_QuanLyBenhNhan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_ThanhToan";
            this.Size = new System.Drawing.Size(1615, 766);
            this.Load += new System.EventHandler(this.UserControl_ThanhToan_Load);
            this.Resize += new System.EventHandler(this.UserControl_ThanhToan_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LapPhieuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_BenhNhan;
        private Bunifu.Framework.UI.BunifuDatepicker dateTime_ThanhToan;
        private Bunifu.Framework.UI.BunifuImageButton btn_LapPhieuThu;
        private Bunifu.Framework.UI.BunifuImageButton btn_Print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Title_QuanLyBenhNhan;
    }
}
