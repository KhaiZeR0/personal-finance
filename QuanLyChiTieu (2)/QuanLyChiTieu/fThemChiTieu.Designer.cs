namespace QuanLyChiTieu
{
    partial class fThemChiTieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemChiTieu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvThongtin = new System.Windows.Forms.DataGridView();
            this.btnxoainfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel7 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btndeldanhmuc = new System.Windows.Forms.Button();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnadddanhmuc = new System.Windows.Forms.Button();
            this.txtDM = new System.Windows.Forms.ComboBox();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).BeginInit();
            this.bunifuPanel7.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.dgvThongtin);
            this.bunifuPanel1.Controls.Add(this.btnxoainfo);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Location = new System.Drawing.Point(269, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(668, 522);
            this.bunifuPanel1.TabIndex = 6;
            // 
            // dgvThongtin
            // 
            this.dgvThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtin.Location = new System.Drawing.Point(25, 44);
            this.dgvThongtin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongtin.Name = "dgvThongtin";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongtin.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongtin.RowHeadersWidth = 51;
            this.dgvThongtin.RowTemplate.Height = 24;
            this.dgvThongtin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongtin.Size = new System.Drawing.Size(627, 408);
            this.dgvThongtin.TabIndex = 12;
            this.dgvThongtin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongtin_CellContentClick_1);
            // 
            // btnxoainfo
            // 
            this.btnxoainfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoainfo.Location = new System.Drawing.Point(284, 457);
            this.btnxoainfo.Name = "btnxoainfo";
            this.btnxoainfo.Size = new System.Drawing.Size(116, 46);
            this.btnxoainfo.TabIndex = 11;
            this.btnxoainfo.Text = "Xoá";
            this.btnxoainfo.UseVisualStyleBackColor = true;
            this.btnxoainfo.Click += new System.EventHandler(this.btnxoainfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chỉnh sửa thông tin";
            // 
            // bunifuPanel7
            // 
            this.bunifuPanel7.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel7.BackgroundImage")));
            this.bunifuPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel7.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel7.BorderRadius = 30;
            this.bunifuPanel7.BorderThickness = 1;
            this.bunifuPanel7.Controls.Add(this.txtSL);
            this.bunifuPanel7.Controls.Add(this.label5);
            this.bunifuPanel7.Controls.Add(this.btndeldanhmuc);
            this.bunifuPanel7.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel7.Controls.Add(this.btnadddanhmuc);
            this.bunifuPanel7.Controls.Add(this.txtDM);
            this.bunifuPanel7.Controls.Add(this.txtGC);
            this.bunifuPanel7.Controls.Add(this.label4);
            this.bunifuPanel7.Controls.Add(this.txtTien);
            this.bunifuPanel7.Controls.Add(this.label3);
            this.bunifuPanel7.Controls.Add(this.btnsave);
            this.bunifuPanel7.Controls.Add(this.label1);
            this.bunifuPanel7.Controls.Add(this.txtTen);
            this.bunifuPanel7.Controls.Add(this.label11);
            this.bunifuPanel7.Location = new System.Drawing.Point(12, 12);
            this.bunifuPanel7.Name = "bunifuPanel7";
            this.bunifuPanel7.ShowBorders = true;
            this.bunifuPanel7.Size = new System.Drawing.Size(251, 522);
            this.bunifuPanel7.TabIndex = 5;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(25, 186);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(202, 22);
            this.txtSL.TabIndex = 3;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            // 
            // btndeldanhmuc
            // 
            this.btndeldanhmuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeldanhmuc.Location = new System.Drawing.Point(138, 286);
            this.btndeldanhmuc.Name = "btndeldanhmuc";
            this.btndeldanhmuc.Size = new System.Drawing.Size(89, 32);
            this.btndeldanhmuc.TabIndex = 8;
            this.btndeldanhmuc.Text = "Xoá";
            this.btndeldanhmuc.UseVisualStyleBackColor = true;
            this.btndeldanhmuc.Click += new System.EventHandler(this.btndeldanhmuc_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 30;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.dataGridView3);
            this.bunifuPanel2.Controls.Add(this.label6);
            this.bunifuPanel2.Location = new System.Drawing.Point(254, 205);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(372, 574);
            this.bunifuPanel2.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(28, 54);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(311, 244);
            this.dataGridView3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chỉnh sửa thông tin";
            // 
            // btnadddanhmuc
            // 
            this.btnadddanhmuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddanhmuc.Location = new System.Drawing.Point(25, 286);
            this.btnadddanhmuc.Name = "btnadddanhmuc";
            this.btnadddanhmuc.Size = new System.Drawing.Size(107, 32);
            this.btnadddanhmuc.TabIndex = 7;
            this.btnadddanhmuc.Text = "Thêm";
            this.btnadddanhmuc.UseVisualStyleBackColor = true;
            this.btnadddanhmuc.Click += new System.EventHandler(this.btnadddanhmuc_Click);
            // 
            // txtDM
            // 
            this.txtDM.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDM.FormattingEnabled = true;
            this.txtDM.Location = new System.Drawing.Point(25, 259);
            this.txtDM.Name = "txtDM";
            this.txtDM.Size = new System.Drawing.Size(202, 21);
            this.txtDM.TabIndex = 4;
            // 
            // txtGC
            // 
            this.txtGC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGC.Location = new System.Drawing.Point(25, 360);
            this.txtGC.Multiline = true;
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(202, 66);
            this.txtGC.TabIndex = 5;
            this.txtGC.TextChanged += new System.EventHandler(this.txtGC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ghi chú";
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.Location = new System.Drawing.Point(25, 122);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(202, 22);
            this.txtTien.TabIndex = 2;
            this.txtTien.TextChanged += new System.EventHandler(this.txtTien_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Tiền";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(40, 446);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(172, 46);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Lưu Lại";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Mục";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(25, 63);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(202, 22);
            this.txtTen.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tên Mặt hàng/Chi tiêu";
            // 
            // fThemChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 546);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThemChiTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Chi Tiêu";
            this.Load += new System.EventHandler(this.fThemChiTieu_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).EndInit();
            this.bunifuPanel7.ResumeLayout(false);
            this.bunifuPanel7.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtDM;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnxoainfo;
        private System.Windows.Forms.Button btndeldanhmuc;
        private System.Windows.Forms.Button btnadddanhmuc;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvThongtin;
        public System.Windows.Forms.TextBox txtTen;
    }
}