namespace QuanLyNhaThuoc
{
    partial class frm_banhang_mnv
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
            this.userControl_khachhang1 = new QuanLyNhaThuoc.UserControl_khachhang();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(140, 498);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(788, 44);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Chọn";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // userControl_khachhang1
            // 
            this.userControl_khachhang1.Location = new System.Drawing.Point(61, 26);
            this.userControl_khachhang1.Name = "userControl_khachhang1";
            this.userControl_khachhang1.Size = new System.Drawing.Size(935, 495);
            this.userControl_khachhang1.TabIndex = 2;
            // 
            // frm_banhang_mnv
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 587);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.userControl_khachhang1);
            this.Name = "frm_banhang_mnv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_banhang_mnv";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ok;
        private UserControl_khachhang userControl_khachhang1;
    }
}