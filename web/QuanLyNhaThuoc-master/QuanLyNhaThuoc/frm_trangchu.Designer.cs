namespace QuanLyNhaThuoc
{
    partial class frm_trangchu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_kho = new System.Windows.Forms.Button();
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_banhang = new System.Windows.Forms.Button();
            this.panel_side = new System.Windows.Forms.Panel();
            this.btn_thuoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControl_banhang1 = new QuanLyNhaThuoc.UserControl_banhang();
            this.userControl_nhanvien1 = new QuanLyNhaThuoc.UserControl_nhanvien();
            this.userControl_khachhang1 = new QuanLyNhaThuoc.UserControl_khachhang();
            this.userControl_kho1 = new QuanLyNhaThuoc.UserControl_kho();
            this.userControl_taikhoan1 = new QuanLyNhaThuoc.UserControl_taikhoan();
            this.userControl_thuoc1 = new QuanLyNhaThuoc.UserControl_thuoc();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_khachhang);
            this.panel1.Controls.Add(this.btn_kho);
            this.panel1.Controls.Add(this.btn_taikhoan);
            this.panel1.Controls.Add(this.btn_nhanvien);
            this.panel1.Controls.Add(this.btn_banhang);
            this.panel1.Controls.Add(this.panel_side);
            this.panel1.Controls.Add(this.btn_thuoc);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 658);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.FlatAppearance.BorderSize = 0;
            this.btn_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khachhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_khachhang.Image = global::QuanLyNhaThuoc.Properties.Resources.teamwork;
            this.btn_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.Location = new System.Drawing.Point(7, 373);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(188, 72);
            this.btn_khachhang.TabIndex = 9;
            this.btn_khachhang.Text = "Khách hàng";
            this.btn_khachhang.UseVisualStyleBackColor = true;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_kho
            // 
            this.btn_kho.FlatAppearance.BorderSize = 0;
            this.btn_kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_kho.Image = global::QuanLyNhaThuoc.Properties.Resources.delivery;
            this.btn_kho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kho.Location = new System.Drawing.Point(12, 214);
            this.btn_kho.Name = "btn_kho";
            this.btn_kho.Size = new System.Drawing.Size(188, 64);
            this.btn_kho.TabIndex = 8;
            this.btn_kho.Text = "Kho";
            this.btn_kho.UseVisualStyleBackColor = true;
            this.btn_kho.Click += new System.EventHandler(this.btn_kho_Click);
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.FlatAppearance.BorderSize = 0;
            this.btn_taikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taikhoan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_taikhoan.Image = global::QuanLyNhaThuoc.Properties.Resources.settings;
            this.btn_taikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taikhoan.Location = new System.Drawing.Point(12, 459);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Size = new System.Drawing.Size(188, 72);
            this.btn_taikhoan.TabIndex = 7;
            this.btn_taikhoan.Text = "Tài khoản";
            this.btn_taikhoan.UseVisualStyleBackColor = true;
            this.btn_taikhoan.Click += new System.EventHandler(this.btn_taikhoan_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nhanvien.Image = global::QuanLyNhaThuoc.Properties.Resources.user2;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(12, 290);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(188, 72);
            this.btn_nhanvien.TabIndex = 6;
            this.btn_nhanvien.Text = "Nhân viên";
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_banhang
            // 
            this.btn_banhang.FlatAppearance.BorderSize = 0;
            this.btn_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_banhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_banhang.Image = global::QuanLyNhaThuoc.Properties.Resources.shopping_cart;
            this.btn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Location = new System.Drawing.Point(12, 140);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Size = new System.Drawing.Size(188, 64);
            this.btn_banhang.TabIndex = 5;
            this.btn_banhang.Text = "Bán hàng";
            this.btn_banhang.UseVisualStyleBackColor = true;
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click);
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_side.Location = new System.Drawing.Point(1, 70);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(7, 64);
            this.panel_side.TabIndex = 4;
            // 
            // btn_thuoc
            // 
            this.btn_thuoc.FlatAppearance.BorderSize = 0;
            this.btn_thuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thuoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thuoc.Image = global::QuanLyNhaThuoc.Properties.Resources.pills;
            this.btn_thuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thuoc.Location = new System.Drawing.Point(12, 70);
            this.btn_thuoc.Name = "btn_thuoc";
            this.btn_thuoc.Size = new System.Drawing.Size(188, 64);
            this.btn_thuoc.TabIndex = 1;
            this.btn_thuoc.Text = "Thuốc";
            this.btn_thuoc.UseVisualStyleBackColor = true;
            this.btn_thuoc.Click += new System.EventHandler(this.btn_thuoc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl_nhanvien1);
            this.panel2.Controls.Add(this.userControl_khachhang1);
            this.panel2.Controls.Add(this.userControl_kho1);
            this.panel2.Controls.Add(this.userControl_taikhoan1);
            this.panel2.Controls.Add(this.userControl_thuoc1);
            this.panel2.Controls.Add(this.userControl_banhang1);
            this.panel2.Location = new System.Drawing.Point(206, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 543);
            this.panel2.TabIndex = 4;
            // 
            // userControl_banhang1
            // 
            this.userControl_banhang1.Location = new System.Drawing.Point(0, 7);
            this.userControl_banhang1.Name = "userControl_banhang1";
            this.userControl_banhang1.Size = new System.Drawing.Size(981, 586);
            this.userControl_banhang1.TabIndex = 5;
            // 
            // userControl_nhanvien1
            // 
            this.userControl_nhanvien1.Location = new System.Drawing.Point(-3, 7);
            this.userControl_nhanvien1.Name = "userControl_nhanvien1";
            this.userControl_nhanvien1.Size = new System.Drawing.Size(979, 575);
            this.userControl_nhanvien1.TabIndex = 2;
            // 
            // userControl_khachhang1
            // 
            this.userControl_khachhang1.Location = new System.Drawing.Point(-5, 7);
            this.userControl_khachhang1.Name = "userControl_khachhang1";
            this.userControl_khachhang1.Size = new System.Drawing.Size(981, 586);
            this.userControl_khachhang1.TabIndex = 4;
            // 
            // userControl_kho1
            // 
            this.userControl_kho1.Location = new System.Drawing.Point(-3, 7);
            this.userControl_kho1.Name = "userControl_kho1";
            this.userControl_kho1.Size = new System.Drawing.Size(990, 583);
            this.userControl_kho1.TabIndex = 3;
            // 
            // userControl_taikhoan1
            // 
            this.userControl_taikhoan1.Location = new System.Drawing.Point(-5, 7);
            this.userControl_taikhoan1.Name = "userControl_taikhoan1";
            this.userControl_taikhoan1.Size = new System.Drawing.Size(992, 533);
            this.userControl_taikhoan1.TabIndex = 1;
            // 
            // userControl_thuoc1
            // 
            this.userControl_thuoc1.Location = new System.Drawing.Point(0, 7);
            this.userControl_thuoc1.Name = "userControl_thuoc1";
            this.userControl_thuoc1.Size = new System.Drawing.Size(976, 575);
            this.userControl_thuoc1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(203, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 10);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xin chào:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(206, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(990, 1);
            this.panel4.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::QuanLyNhaThuoc.Properties.Resources.power_button_off;
            this.button2.Location = new System.Drawing.Point(1144, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 37);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 656);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_trangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_trangchu";
            this.Load += new System.EventHandler(this.frm_trangchu_Load);
            this.Shown += new System.EventHandler(this.frm_trangchu_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_thuoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Button btn_banhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_taikhoan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_kho;
        private System.Windows.Forms.Button btn_khachhang;
        private UserControl_banhang userControl_banhang1;
        private UserControl_khachhang userControl_khachhang1;
        private UserControl_kho userControl_kho1;
        private UserControl_nhanvien userControl_nhanvien1;
        private UserControl_taikhoan userControl_taikhoan1;
        private UserControl_thuoc userControl_thuoc1;
        public System.Windows.Forms.Label label2;
    }
}