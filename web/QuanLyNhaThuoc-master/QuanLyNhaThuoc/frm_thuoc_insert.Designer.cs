namespace QuanLyNhaThuoc
{
    partial class frm_thuoc_insert
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
            this.txt_mathuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenthuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_loaithuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hsd = new System.Windows.Forms.NumericUpDown();
            this.cb_hsd = new System.Windows.Forms.ComboBox();
            this.txt_congdung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_tacdungphu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_chongchidinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_donvitinh = new System.Windows.Forms.ComboBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hsd)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mathuoc
            // 
            this.txt_mathuoc.Location = new System.Drawing.Point(140, 71);
            this.txt_mathuoc.Name = "txt_mathuoc";
            this.txt_mathuoc.Size = new System.Drawing.Size(234, 20);
            this.txt_mathuoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thuốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thuốc:";
            // 
            // txt_tenthuoc
            // 
            this.txt_tenthuoc.Location = new System.Drawing.Point(140, 115);
            this.txt_tenthuoc.Name = "txt_tenthuoc";
            this.txt_tenthuoc.Size = new System.Drawing.Size(234, 20);
            this.txt_tenthuoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại thuốc:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(505, 433);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(273, 56);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Lưu";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_loaithuoc
            // 
            this.txt_loaithuoc.Location = new System.Drawing.Point(505, 71);
            this.txt_loaithuoc.Multiline = true;
            this.txt_loaithuoc.Name = "txt_loaithuoc";
            this.txt_loaithuoc.Size = new System.Drawing.Size(273, 61);
            this.txt_loaithuoc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hạn sử dụng:";
            // 
            // txt_hsd
            // 
            this.txt_hsd.Location = new System.Drawing.Point(140, 160);
            this.txt_hsd.Name = "txt_hsd";
            this.txt_hsd.Size = new System.Drawing.Size(80, 20);
            this.txt_hsd.TabIndex = 10;
            // 
            // cb_hsd
            // 
            this.cb_hsd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hsd.FormattingEnabled = true;
            this.cb_hsd.Location = new System.Drawing.Point(226, 160);
            this.cb_hsd.Name = "cb_hsd";
            this.cb_hsd.Size = new System.Drawing.Size(148, 21);
            this.cb_hsd.TabIndex = 11;
            this.cb_hsd.SelectedIndexChanged += new System.EventHandler(this.cb_hsd_SelectedIndexChanged);
            // 
            // txt_congdung
            // 
            this.txt_congdung.Location = new System.Drawing.Point(505, 160);
            this.txt_congdung.Multiline = true;
            this.txt_congdung.Name = "txt_congdung";
            this.txt_congdung.Size = new System.Drawing.Size(273, 77);
            this.txt_congdung.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Công dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Thuốc đặc biệt:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(140, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(39, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Có";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_tacdungphu
            // 
            this.txt_tacdungphu.Location = new System.Drawing.Point(140, 256);
            this.txt_tacdungphu.Multiline = true;
            this.txt_tacdungphu.Name = "txt_tacdungphu";
            this.txt_tacdungphu.Size = new System.Drawing.Size(234, 81);
            this.txt_tacdungphu.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tác dụng phụ:";
            // 
            // txt_chongchidinh
            // 
            this.txt_chongchidinh.Location = new System.Drawing.Point(505, 256);
            this.txt_chongchidinh.Multiline = true;
            this.txt_chongchidinh.Name = "txt_chongchidinh";
            this.txt_chongchidinh.Size = new System.Drawing.Size(273, 81);
            this.txt_chongchidinh.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Chống chỉ định:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Đơn giá:";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(505, 374);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(115, 20);
            this.txt_dongia.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(638, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Đơn vị tính:";
            // 
            // cb_donvitinh
            // 
            this.cb_donvitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_donvitinh.FormattingEnabled = true;
            this.cb_donvitinh.Location = new System.Drawing.Point(707, 373);
            this.cb_donvitinh.Name = "cb_donvitinh";
            this.cb_donvitinh.Size = new System.Drawing.Size(71, 21);
            this.cb_donvitinh.TabIndex = 24;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(135, 377);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(239, 112);
            this.txt_ghichu.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ghi chú:";
            // 
            // frm_thuoc_insert
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 530);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_donvitinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_chongchidinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tacdungphu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_congdung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_hsd);
            this.Controls.Add(this.txt_hsd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_loaithuoc);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenthuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mathuoc);
            this.Name = "frm_thuoc_insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_thuoc_insert";
            this.Load += new System.EventHandler(this.frm_thuoc_insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_hsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mathuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenthuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_loaithuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txt_hsd;
        private System.Windows.Forms.ComboBox cb_hsd;
        private System.Windows.Forms.TextBox txt_congdung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_tacdungphu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_chongchidinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_donvitinh;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label11;
    }
}