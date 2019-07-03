namespace QuanLyNhaThuoc
{
    partial class frm_kho_thuoc
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
            this.userControl_thuoc1 = new QuanLyNhaThuoc.UserControl_thuoc();
            this.txt_chon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl_thuoc1
            // 
            this.userControl_thuoc1.Location = new System.Drawing.Point(39, 12);
            this.userControl_thuoc1.Name = "userControl_thuoc1";
            this.userControl_thuoc1.Size = new System.Drawing.Size(870, 495);
            this.userControl_thuoc1.TabIndex = 0;
            this.userControl_thuoc1.Load += new System.EventHandler(this.userControl_thuoc1_Load);
            // 
            // txt_chon
            // 
            this.txt_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chon.Location = new System.Drawing.Point(52, 427);
            this.txt_chon.Name = "txt_chon";
            this.txt_chon.Size = new System.Drawing.Size(312, 42);
            this.txt_chon.TabIndex = 22;
            this.txt_chon.Text = "Chọn";
            this.txt_chon.UseVisualStyleBackColor = true;
            this.txt_chon.Click += new System.EventHandler(this.txt_chon_Click);
            // 
            // frm_kho_thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 597);
            this.Controls.Add(this.txt_chon);
            this.Controls.Add(this.userControl_thuoc1);
            this.Name = "frm_kho_thuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_kho_thuoc";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_thuoc userControl_thuoc1;
        public System.Windows.Forms.Button txt_chon;
    }
}