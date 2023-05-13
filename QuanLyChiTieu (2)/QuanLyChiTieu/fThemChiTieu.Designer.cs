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
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnxoainfo = new System.Windows.Forms.Button();
            this.dgvThongtin = new System.Windows.Forms.DataGridView();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel7 = new Bunifu.UI.WinForms.BunifuPanel();
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
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.bunifuPanel1.Controls.Add(this.btnxoainfo);
            this.bunifuPanel1.Controls.Add(this.dgvThongtin);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Location = new System.Drawing.Point(359, 15);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(891, 553);
            this.bunifuPanel1.TabIndex = 6;
            // 
            // btnxoainfo
            // 
            this.btnxoainfo.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoainfo.Location = new System.Drawing.Point(373, 492);
            this.btnxoainfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoainfo.Name = "btnxoainfo";
            this.btnxoainfo.Size = new System.Drawing.Size(155, 57);
            this.btnxoainfo.TabIndex = 11;
            this.btnxoainfo.Text = "Xoá";
            this.btnxoainfo.UseVisualStyleBackColor = true;
            this.btnxoainfo.Click += new System.EventHandler(this.btnxoainfo_Click);
            // 
            // dgvThongtin
            // 
            this.dgvThongtin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTen,
            this.colTien,
            this.colDM,
            this.colGC});
            this.dgvThongtin.Location = new System.Drawing.Point(45, 57);
            this.dgvThongtin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThongtin.Name = "dgvThongtin";
            this.dgvThongtin.RowHeadersWidth = 51;
            this.dgvThongtin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongtin.Size = new System.Drawing.Size(805, 427);
            this.dgvThongtin.TabIndex = 6;
            this.dgvThongtin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên mặt hàng";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            // 
            // colTien
            // 
            this.colTien.HeaderText = "Số tiền bạn đã chi";
            this.colTien.MinimumWidth = 6;
            this.colTien.Name = "colTien";
            // 
            // colDM
            // 
            this.colDM.HeaderText = "Danh mục";
            this.colDM.MinimumWidth = 6;
            this.colDM.Name = "colDM";
            // 
            // colGC
            // 
            this.colGC.HeaderText = "Ghi chú";
            this.colGC.MinimumWidth = 6;
            this.colGC.Name = "colGC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 32);
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
            this.bunifuPanel7.Location = new System.Drawing.Point(16, 15);
            this.bunifuPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuPanel7.Name = "bunifuPanel7";
            this.bunifuPanel7.ShowBorders = true;
            this.bunifuPanel7.Size = new System.Drawing.Size(335, 553);
            this.bunifuPanel7.TabIndex = 5;
            // 
            // btndeldanhmuc
            // 
            this.btndeldanhmuc.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeldanhmuc.Location = new System.Drawing.Point(159, 308);
            this.btndeldanhmuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndeldanhmuc.Name = "btndeldanhmuc";
            this.btndeldanhmuc.Size = new System.Drawing.Size(141, 39);
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
            this.bunifuPanel2.Location = new System.Drawing.Point(339, 252);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(496, 706);
            this.bunifuPanel2.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(37, 66);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(415, 300);
            this.dataGridView3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chỉnh sửa thông tin";
            // 
            // btnadddanhmuc
            // 
            this.btnadddanhmuc.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddanhmuc.Location = new System.Drawing.Point(163, 228);
            this.btnadddanhmuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadddanhmuc.Name = "btnadddanhmuc";
            this.btnadddanhmuc.Size = new System.Drawing.Size(139, 39);
            this.btnadddanhmuc.TabIndex = 7;
            this.btnadddanhmuc.Text = "Thêm";
            this.btnadddanhmuc.UseVisualStyleBackColor = true;
            this.btnadddanhmuc.Click += new System.EventHandler(this.btnadddanhmuc_Click);
            // 
            // txtDM
            // 
            this.txtDM.FormattingEnabled = true;
            this.txtDM.Location = new System.Drawing.Point(33, 276);
            this.txtDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDM.Name = "txtDM";
            this.txtDM.Size = new System.Drawing.Size(268, 24);
            this.txtDM.TabIndex = 3;
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(33, 361);
            this.txtGC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGC.Multiline = true;
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(268, 80);
            this.txtGC.TabIndex = 4;
            this.txtGC.TextChanged += new System.EventHandler(this.txtGC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ghi chú";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(33, 150);
            this.txtTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(268, 22);
            this.txtTien.TabIndex = 2;
            this.txtTien.TextChanged += new System.EventHandler(this.txtTien_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Tiền";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(52, 468);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(229, 57);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Lưu Lại";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Mục";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(33, 78);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(268, 22);
            this.txtTen.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(266, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tên Mặt hàng/Chi tiêu";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(151, 186);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(107, 22);
            this.txtSL.TabIndex = 10;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            // 
            // fThemChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 583);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtTen;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvThongtin;
        private System.Windows.Forms.ComboBox txtDM;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnxoainfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGC;
        private System.Windows.Forms.Button btndeldanhmuc;
        private System.Windows.Forms.Button btnadddanhmuc;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
    }
}