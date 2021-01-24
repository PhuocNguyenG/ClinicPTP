namespace TEST
{
    partial class Form_ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThanhToan));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPhieuThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtTienMat = new System.Windows.Forms.TextBox();
            this.txtTienTra = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txt_BenhNhan = new System.Windows.Forms.TextBox();
            this.lbl_TenBenhNhan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_KhachDua = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(413, 599);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 49);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPhieuThu
            // 
            this.txtPhieuThu.Enabled = false;
            this.txtPhieuThu.Location = new System.Drawing.Point(183, 53);
            this.txtPhieuThu.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhieuThu.Name = "txtPhieuThu";
            this.txtPhieuThu.ReadOnly = true;
            this.txtPhieuThu.Size = new System.Drawing.Size(329, 29);
            this.txtPhieuThu.TabIndex = 0;
            this.txtPhieuThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu thu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtTienMat);
            this.groupBox1.Controls.Add(this.txtTienTra);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txt_BenhNhan);
            this.groupBox1.Controls.Add(this.txtPhieuThu);
            this.groupBox1.Controls.Add(this.lbl_TenBenhNhan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_KhachDua);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 534);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập phiếu thu";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(183, 153);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(329, 157);
            this.txtNote.TabIndex = 3;
            // 
            // txtTienMat
            // 
            this.txtTienMat.Location = new System.Drawing.Point(183, 460);
            this.txtTienMat.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienMat.Name = "txtTienMat";
            this.txtTienMat.Size = new System.Drawing.Size(329, 29);
            this.txtTienMat.TabIndex = 0;
            this.txtTienMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTienMat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTienTra
            // 
            this.txtTienTra.Location = new System.Drawing.Point(183, 399);
            this.txtTienTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienTra.Name = "txtTienTra";
            this.txtTienTra.ReadOnly = true;
            this.txtTienTra.Size = new System.Drawing.Size(329, 29);
            this.txtTienTra.TabIndex = 0;
            this.txtTienTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(183, 342);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(329, 29);
            this.txtTongTien.TabIndex = 0;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_BenhNhan
            // 
            this.txt_BenhNhan.Location = new System.Drawing.Point(183, 101);
            this.txt_BenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BenhNhan.Name = "txt_BenhNhan";
            this.txt_BenhNhan.ReadOnly = true;
            this.txt_BenhNhan.Size = new System.Drawing.Size(329, 29);
            this.txt_BenhNhan.TabIndex = 0;
            this.txt_BenhNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_TenBenhNhan
            // 
            this.lbl_TenBenhNhan.AutoSize = true;
            this.lbl_TenBenhNhan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBenhNhan.Location = new System.Drawing.Point(36, 105);
            this.lbl_TenBenhNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenBenhNhan.Name = "lbl_TenBenhNhan";
            this.lbl_TenBenhNhan.Size = new System.Drawing.Size(136, 22);
            this.lbl_TenBenhNhan.TabIndex = 1;
            this.lbl_TenBenhNhan.Text = "Tên bênh nhân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 468);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tiền Mặt";
            // 
            // lbl_KhachDua
            // 
            this.lbl_KhachDua.AutoSize = true;
            this.lbl_KhachDua.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhachDua.Location = new System.Drawing.Point(36, 406);
            this.lbl_KhachDua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KhachDua.Name = "lbl_KhachDua";
            this.lbl_KhachDua.Size = new System.Drawing.Size(83, 22);
            this.lbl_KhachDua.TabIndex = 1;
            this.lbl_KhachDua.Text = "Tiền Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Các dịch vụ";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOk.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(260, 599);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 49);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 38);
            this.panel1.TabIndex = 17;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(549, 4);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Form_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 663);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThanhToan";
            this.Load += new System.EventHandler(this.Form_ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPhieuThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txt_BenhNhan;
        private System.Windows.Forms.Label lbl_TenBenhNhan;
        private System.Windows.Forms.TextBox txtTienMat;
        private System.Windows.Forms.TextBox txtTienTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_KhachDua;
    }
}