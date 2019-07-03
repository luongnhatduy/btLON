namespace QuanLyNhaThuoc
{
    partial class frm_themdon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_madon = new System.Windows.Forms.TextBox();
            this.txt_tendon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.btn_anh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn:";
            // 
            // txt_madon
            // 
            this.txt_madon.Location = new System.Drawing.Point(95, 40);
            this.txt_madon.Name = "txt_madon";
            this.txt_madon.Size = new System.Drawing.Size(266, 20);
            this.txt_madon.TabIndex = 1;
            // 
            // txt_tendon
            // 
            this.txt_tendon.Location = new System.Drawing.Point(95, 75);
            this.txt_tendon.Name = "txt_tendon";
            this.txt_tendon.Size = new System.Drawing.Size(266, 20);
            this.txt_tendon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đơn:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(392, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ghi chú:";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(95, 116);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(266, 160);
            this.txt_ghichu.TabIndex = 7;
            // 
            // btn_anh
            // 
            this.btn_anh.Location = new System.Drawing.Point(392, 252);
            this.btn_anh.Name = "btn_anh";
            this.btn_anh.Size = new System.Drawing.Size(177, 23);
            this.btn_anh.TabIndex = 8;
            this.btn_anh.Text = "Chọn ảnh";
            this.btn_anh.UseVisualStyleBackColor = true;
            this.btn_anh.Click += new System.EventHandler(this.btn_anh_Click);
            // 
            // frm_themdon
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 390);
            this.Controls.Add(this.btn_anh);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_tendon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_madon);
            this.Controls.Add(this.label1);
            this.Name = "frm_themdon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_themdon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_madon;
        private System.Windows.Forms.TextBox txt_tendon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Button btn_anh;
    }
}