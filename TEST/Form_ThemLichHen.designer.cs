namespace TEST
{
    partial class Form_ThemLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThemLichHen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaBenhNhan = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_GioHen = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenLichHen = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.lbl_NgayHen = new System.Windows.Forms.Label();
            this.dtp_NgayHen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_OkThemLichHen = new System.Windows.Forms.Button();
            this.bnt_CancelThemLichHen = new System.Windows.Forms.Button();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 38);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thêm Lịch Hẹn";
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
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(540, 4);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaBenhNhan);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dtp_GioHen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_TenLichHen);
            this.groupBox1.Controls.Add(this.txt_Note);
            this.groupBox1.Controls.Add(this.lbl_NgayHen);
            this.groupBox1.Controls.Add(this.dtp_NgayHen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(555, 450);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lịch Hẹn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbMaBenhNhan
            // 
            this.cmbMaBenhNhan.FormattingEnabled = true;
            this.cmbMaBenhNhan.Location = new System.Drawing.Point(172, 101);
            this.cmbMaBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaBenhNhan.Name = "cmbMaBenhNhan";
            this.cmbMaBenhNhan.Size = new System.Drawing.Size(280, 26);
            this.cmbMaBenhNhan.TabIndex = 9;
            this.cmbMaBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cmbMaBenhNhan_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 242);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 24);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dtp_GioHen
            // 
            this.dtp_GioHen.CustomFormat = "hh:mm:ss";
            this.dtp_GioHen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_GioHen.Location = new System.Drawing.Point(172, 190);
            this.dtp_GioHen.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_GioHen.Name = "dtp_GioHen";
            this.dtp_GioHen.Size = new System.Drawing.Size(280, 24);
            this.dtp_GioHen.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giờ kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giờ Hẹn";
            // 
            // txt_TenLichHen
            // 
            this.txt_TenLichHen.Location = new System.Drawing.Point(172, 41);
            this.txt_TenLichHen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenLichHen.Name = "txt_TenLichHen";
            this.txt_TenLichHen.Size = new System.Drawing.Size(280, 24);
            this.txt_TenLichHen.TabIndex = 1;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(172, 295);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(280, 125);
            this.txt_Note.TabIndex = 3;
            // 
            // lbl_NgayHen
            // 
            this.lbl_NgayHen.AutoSize = true;
            this.lbl_NgayHen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayHen.Location = new System.Drawing.Point(44, 144);
            this.lbl_NgayHen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayHen.Name = "lbl_NgayHen";
            this.lbl_NgayHen.Size = new System.Drawing.Size(73, 18);
            this.lbl_NgayHen.TabIndex = 1;
            this.lbl_NgayHen.Text = "Ngày Hẹn";
            // 
            // dtp_NgayHen
            // 
            this.dtp_NgayHen.CustomFormat = "dd/MM/yyy";
            this.dtp_NgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayHen.Location = new System.Drawing.Point(172, 144);
            this.dtp_NgayHen.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayHen.Name = "dtp_NgayHen";
            this.dtp_NgayHen.Size = new System.Drawing.Size(280, 24);
            this.dtp_NgayHen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lịch Hẹn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Bệnh Nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ghi Chú";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bnt_OkThemLichHen
            // 
            this.bnt_OkThemLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnt_OkThemLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_OkThemLichHen.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_OkThemLichHen.Location = new System.Drawing.Point(139, 521);
            this.bnt_OkThemLichHen.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_OkThemLichHen.Name = "bnt_OkThemLichHen";
            this.bnt_OkThemLichHen.Size = new System.Drawing.Size(111, 39);
            this.bnt_OkThemLichHen.TabIndex = 8;
            this.bnt_OkThemLichHen.Text = "Ok";
            this.bnt_OkThemLichHen.UseVisualStyleBackColor = false;
            this.bnt_OkThemLichHen.Click += new System.EventHandler(this.bnt_OkThemLichHen_Click);
            // 
            // bnt_CancelThemLichHen
            // 
            this.bnt_CancelThemLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnt_CancelThemLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_CancelThemLichHen.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CancelThemLichHen.Location = new System.Drawing.Point(341, 521);
            this.bnt_CancelThemLichHen.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_CancelThemLichHen.Name = "bnt_CancelThemLichHen";
            this.bnt_CancelThemLichHen.Size = new System.Drawing.Size(108, 39);
            this.bnt_CancelThemLichHen.TabIndex = 9;
            this.bnt_CancelThemLichHen.Text = "Cancel";
            this.bnt_CancelThemLichHen.UseVisualStyleBackColor = false;
            // 
            // Form_ThemLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(587, 588);
            this.Controls.Add(this.bnt_CancelThemLichHen);
            this.Controls.Add(this.bnt_OkThemLichHen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ThemLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_ThemLichHen";
            this.Load += new System.EventHandler(this.Form_ThemLichHen_Load);
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
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenLichHen;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label lbl_NgayHen;
        private System.Windows.Forms.DateTimePicker dtp_NgayHen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_GioHen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_CancelThemLichHen;
        private System.Windows.Forms.Button bnt_OkThemLichHen;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaBenhNhan;
    }
}