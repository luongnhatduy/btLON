namespace QuanLyNhaThuoc
{
    partial class frm_banhang_lichsu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.dg_hoadon = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dg_cthoadon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cthoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dg_hoadon
            // 
            this.dg_hoadon.AllowUserToAddRows = false;
            this.dg_hoadon.AllowUserToDeleteRows = false;
            this.dg_hoadon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_hoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_hoadon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_hoadon.Location = new System.Drawing.Point(99, 75);
            this.dg_hoadon.MultiSelect = false;
            this.dg_hoadon.Name = "dg_hoadon";
            this.dg_hoadon.ReadOnly = true;
            this.dg_hoadon.RowHeadersVisible = false;
            this.dg_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_hoadon.Size = new System.Drawing.Size(471, 345);
            this.dg_hoadon.TabIndex = 25;
            this.dg_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_hoadon_CellClick);
            this.dg_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_hoadon_CellContentClick);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(99, 48);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(390, 20);
            this.txttimkiem.TabIndex = 26;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // dg_cthoadon
            // 
            this.dg_cthoadon.AllowUserToAddRows = false;
            this.dg_cthoadon.AllowUserToDeleteRows = false;
            this.dg_cthoadon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_cthoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_cthoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_cthoadon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_cthoadon.Location = new System.Drawing.Point(613, 75);
            this.dg_cthoadon.MultiSelect = false;
            this.dg_cthoadon.Name = "dg_cthoadon";
            this.dg_cthoadon.ReadOnly = true;
            this.dg_cthoadon.RowHeadersVisible = false;
            this.dg_cthoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_cthoadon.Size = new System.Drawing.Size(446, 345);
            this.dg_cthoadon.TabIndex = 28;
            this.dg_cthoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_cthoadon_CellContentClick);
            // 
            // frm_banhang_lichsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 535);
            this.Controls.Add(this.dg_cthoadon);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dg_hoadon);
            this.Controls.Add(this.txttimkiem);
            this.Name = "frm_banhang_lichsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_lichsu_banhang";
            this.Load += new System.EventHandler(this.frm_banhang_lichsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cthoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dg_hoadon;
        private System.Windows.Forms.TextBox txttimkiem;
        public System.Windows.Forms.DataGridView dg_cthoadon;
    }
}