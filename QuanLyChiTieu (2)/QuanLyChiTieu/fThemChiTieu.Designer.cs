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
            this.bunifuPanel1.Location = new System.Drawing.Point(269, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(668, 449);
            this.bunifuPanel1.TabIndex = 6;
            // 
            // btnxoainfo
            // 
            this.btnxoainfo.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoainfo.Location = new System.Drawing.Point(280, 400);
            this.btnxoainfo.Name = "btnxoainfo";
            this.btnxoainfo.Size = new System.Drawing.Size(116, 46);
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
            this.dgvThongtin.Location = new System.Drawing.Point(34, 46);
            this.dgvThongtin.Name = "dgvThongtin";
            this.dgvThongtin.RowHeadersWidth = 51;
            this.dgvThongtin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongtin.Size = new System.Drawing.Size(604, 347);
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
            this.label2.Location = new System.Drawing.Point(20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 26);
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
            this.bunifuPanel7.Size = new System.Drawing.Size(251, 449);
            this.bunifuPanel7.TabIndex = 5;
            // 
            // btndeldanhmuc
            // 
            this.btndeldanhmuc.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeldanhmuc.Location = new System.Drawing.Point(119, 250);
            this.btndeldanhmuc.Name = "btndeldanhmuc";
            this.btndeldanhmuc.Size = new System.Drawing.Size(106, 32);
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
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chỉnh sửa thông tin";
            // 
            // btnadddanhmuc
            // 
            this.btnadddanhmuc.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddanhmuc.Location = new System.Drawing.Point(122, 185);
            this.btnadddanhmuc.Name = "btnadddanhmuc";
            this.btnadddanhmuc.Size = new System.Drawing.Size(104, 32);
            this.btnadddanhmuc.TabIndex = 7;
            this.btnadddanhmuc.Text = "Thêm";
            this.btnadddanhmuc.UseVisualStyleBackColor = true;
            this.btnadddanhmuc.Click += new System.EventHandler(this.btnadddanhmuc_Click);
            // 
            // txtDM
            // 
            this.txtDM.FormattingEnabled = true;
            this.txtDM.Location = new System.Drawing.Point(25, 224);
            this.txtDM.Name = "txtDM";
            this.txtDM.Size = new System.Drawing.Size(202, 21);
            this.txtDM.TabIndex = 7;
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(25, 293);
            this.txtGC.Multiline = true;
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(202, 66);
            this.txtGC.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ghi chú";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(25, 141);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(202, 20);
            this.txtTien.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Tiền";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(39, 380);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Mục";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(25, 63);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(202, 20);
            this.txtTen.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tên Mặt hàng/Chi tiêu";
            // 
            // fThemChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 474);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThemChiTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fdienchitieu";
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
    }
}