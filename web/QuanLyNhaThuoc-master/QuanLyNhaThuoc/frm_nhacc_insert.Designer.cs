namespace QuanLyNhaThuoc
{
    partial class frm_nhacc_insert
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tencc = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.txt_macc = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(148, 340);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(291, 58);
            this.btn_ok.TabIndex = 21;
            this.btn_ok.Text = "Lưu";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(148, 153);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(291, 20);
            this.txt_sdt.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số điện thoại:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(148, 197);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(291, 113);
            this.txt_diachi.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Địa chỉ:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(148, 118);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(291, 20);
            this.txt_email.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email:";
            // 
            // txt_tencc
            // 
            this.txt_tencc.Location = new System.Drawing.Point(148, 87);
            this.txt_tencc.Name = "txt_tencc";
            this.txt_tencc.Size = new System.Drawing.Size(291, 20);
            this.txt_tencc.TabIndex = 14;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(67, 90);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(62, 13);
            this.b.TabIndex = 13;
            this.b.Text = "Tên nhàcc:";
            // 
            // txt_macc
            // 
            this.txt_macc.Location = new System.Drawing.Point(148, 52);
            this.txt_macc.Name = "txt_macc";
            this.txt_macc.Size = new System.Drawing.Size(291, 20);
            this.txt_macc.TabIndex = 12;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(67, 55);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(61, 13);
            this.a.TabIndex = 11;
            this.a.Text = "Mã nhà cc:";
            // 
            // frm_nhacc_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tencc);
            this.Controls.Add(this.b);
            this.Controls.Add(this.txt_macc);
            this.Controls.Add(this.a);
            this.Name = "frm_nhacc_insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_nhacc_insert";
            this.Load += new System.EventHandler(this.frm_nhacc_insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tencc;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txt_macc;
        private System.Windows.Forms.Label a;
    }
}