namespace TEST
{
    partial class UserControl_BackUp_Restore
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
            this.lbl_Title_BackUp = new System.Windows.Forms.Label();
            this.lbl_Tilte_Restore = new System.Windows.Forms.Label();
            this.txt_BackUp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Restore = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_LinkBackUp = new System.Windows.Forms.Button();
            this.btn_LinkRestore = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title_BackUp
            // 
            this.lbl_Title_BackUp.AutoSize = true;
            this.lbl_Title_BackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_BackUp.ForeColor = System.Drawing.Color.Black;
            this.lbl_Title_BackUp.Location = new System.Drawing.Point(45, 38);
            this.lbl_Title_BackUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title_BackUp.Name = "lbl_Title_BackUp";
            this.lbl_Title_BackUp.Size = new System.Drawing.Size(372, 46);
            this.lbl_Title_BackUp.TabIndex = 0;
            this.lbl_Title_BackUp.Text = "Đường dẫn sao lưu";
            // 
            // lbl_Tilte_Restore
            // 
            this.lbl_Tilte_Restore.AutoSize = true;
            this.lbl_Tilte_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tilte_Restore.ForeColor = System.Drawing.Color.Black;
            this.lbl_Tilte_Restore.Location = new System.Drawing.Point(45, 254);
            this.lbl_Tilte_Restore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tilte_Restore.Name = "lbl_Tilte_Restore";
            this.lbl_Tilte_Restore.Size = new System.Drawing.Size(417, 46);
            this.lbl_Tilte_Restore.TabIndex = 0;
            this.lbl_Tilte_Restore.Text = "Đường dẫn khôi phục";
            // 
            // txt_BackUp
            // 
            this.txt_BackUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BackUp.ForeColor = System.Drawing.Color.Black;
            this.txt_BackUp.HintForeColor = System.Drawing.Color.Empty;
            this.txt_BackUp.HintText = "";
            this.txt_BackUp.isPassword = false;
            this.txt_BackUp.LineFocusedColor = System.Drawing.Color.Indigo;
            this.txt_BackUp.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.txt_BackUp.LineMouseHoverColor = System.Drawing.Color.Indigo;
            this.txt_BackUp.LineThickness = 4;
            this.txt_BackUp.Location = new System.Drawing.Point(55, 90);
            this.txt_BackUp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_BackUp.Name = "txt_BackUp";
            this.txt_BackUp.Size = new System.Drawing.Size(767, 60);
            this.txt_BackUp.TabIndex = 1;
            this.txt_BackUp.Text = "C:\\";
            this.txt_BackUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Restore
            // 
            this.txt_Restore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Restore.ForeColor = System.Drawing.Color.Black;
            this.txt_Restore.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Restore.HintText = "";
            this.txt_Restore.isPassword = false;
            this.txt_Restore.LineFocusedColor = System.Drawing.Color.Indigo;
            this.txt_Restore.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.txt_Restore.LineMouseHoverColor = System.Drawing.Color.Indigo;
            this.txt_Restore.LineThickness = 4;
            this.txt_Restore.Location = new System.Drawing.Point(55, 327);
            this.txt_Restore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Restore.Name = "txt_Restore";
            this.txt_Restore.Size = new System.Drawing.Size(767, 60);
            this.txt_Restore.TabIndex = 1;
            this.txt_Restore.Text = "C:\\";
            this.txt_Restore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_LinkBackUp
            // 
            this.btn_LinkBackUp.Location = new System.Drawing.Point(844, 112);
            this.btn_LinkBackUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LinkBackUp.Name = "btn_LinkBackUp";
            this.btn_LinkBackUp.Size = new System.Drawing.Size(67, 38);
            this.btn_LinkBackUp.TabIndex = 2;
            this.btn_LinkBackUp.Text = "...";
            this.btn_LinkBackUp.UseVisualStyleBackColor = true;
            this.btn_LinkBackUp.Click += new System.EventHandler(this.btn_LinkBackUp_Click);
            // 
            // btn_LinkRestore
            // 
            this.btn_LinkRestore.Location = new System.Drawing.Point(844, 350);
            this.btn_LinkRestore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LinkRestore.Name = "btn_LinkRestore";
            this.btn_LinkRestore.Size = new System.Drawing.Size(67, 38);
            this.btn_LinkRestore.TabIndex = 2;
            this.btn_LinkRestore.Text = "...";
            this.btn_LinkRestore.UseVisualStyleBackColor = true;
            this.btn_LinkRestore.Click += new System.EventHandler(this.btn_LinkRestore_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(780, 176);
            this.btnBackUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(131, 43);
            this.btnBackUp.TabIndex = 2;
            this.btnBackUp.Text = "Sao lưu";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Location = new System.Drawing.Point(780, 409);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(131, 43);
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.Text = "Khôi phục";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // UserControl_BackUp_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btn_LinkRestore);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btn_LinkBackUp);
            this.Controls.Add(this.txt_Restore);
            this.Controls.Add(this.txt_BackUp);
            this.Controls.Add(this.lbl_Tilte_Restore);
            this.Controls.Add(this.lbl_Title_BackUp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_BackUp_Restore";
            this.Size = new System.Drawing.Size(955, 501);
            this.Load += new System.EventHandler(this.UserControl_BackUp_Restore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title_BackUp;
        private System.Windows.Forms.Label lbl_Tilte_Restore;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_BackUp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Restore;
        private System.Windows.Forms.Button btn_LinkBackUp;
        private System.Windows.Forms.Button btn_LinkRestore;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btn_Restore;
    }
}
