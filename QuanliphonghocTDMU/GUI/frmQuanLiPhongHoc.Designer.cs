namespace QuanLiPhongHocTDMU
{
    partial class frmQuanLiPhongHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaPhong = new TextBox();
            txtTenPhong = new TextBox();
            txtTang = new TextBox();
            txtSucChua = new TextBox();
            cmbToaNha = new ComboBox();
            cmbLoaiPhong = new ComboBox();
            cmbTrangThai = new ComboBox();
            dgvPhongHoc = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhongHoc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 19;
            label1.Text = "Mã Phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 18;
            label2.Text = "Tên Phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 17;
            label3.Text = "Tầng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 231);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 16;
            label4.Text = "Loại Phòng:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(600, 46);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 15;
            label5.Text = "Tòa Nhà:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(600, 108);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 14;
            label6.Text = "Sức Chứa:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(600, 169);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 13;
            label7.Text = "Trạng Thái:";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(160, 42);
            txtMaPhong.Margin = new Padding(4, 5, 4, 5);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(265, 27);
            txtMaPhong.TabIndex = 12;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(160, 103);
            txtTenPhong.Margin = new Padding(4, 5, 4, 5);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(265, 27);
            txtTenPhong.TabIndex = 11;
            // 
            // txtTang
            // 
            txtTang.Location = new Point(160, 165);
            txtTang.Margin = new Padding(4, 5, 4, 5);
            txtTang.Name = "txtTang";
            txtTang.Size = new Size(265, 27);
            txtTang.TabIndex = 10;
            // 
            // txtSucChua
            // 
            txtSucChua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSucChua.Location = new Point(707, 103);
            txtSucChua.Margin = new Padding(4, 5, 4, 5);
            txtSucChua.Name = "txtSucChua";
            txtSucChua.Size = new Size(239, 27);
            txtSucChua.TabIndex = 9;
            // 
            // cmbToaNha
            // 
            cmbToaNha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbToaNha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToaNha.Location = new Point(707, 42);
            cmbToaNha.Margin = new Padding(4, 5, 4, 5);
            cmbToaNha.Name = "cmbToaNha";
            cmbToaNha.Size = new Size(239, 28);
            cmbToaNha.TabIndex = 8;
            // 
            // cmbLoaiPhong
            // 
            cmbLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiPhong.Location = new Point(160, 226);
            cmbLoaiPhong.Margin = new Padding(4, 5, 4, 5);
            cmbLoaiPhong.Name = "cmbLoaiPhong";
            cmbLoaiPhong.Size = new Size(265, 28);
            cmbLoaiPhong.TabIndex = 7;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.Location = new Point(707, 165);
            cmbTrangThai.Margin = new Padding(4, 5, 4, 5);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(239, 28);
            cmbTrangThai.TabIndex = 6;
            // 
            // dgvPhongHoc
            // 
            dgvPhongHoc.AllowUserToAddRows = false;
            dgvPhongHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhongHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongHoc.BackgroundColor = Color.White;
            dgvPhongHoc.ColumnHeadersHeight = 29;
            dgvPhongHoc.Location = new Point(40, 308);
            dgvPhongHoc.Margin = new Padding(4, 5, 4, 5);
            dgvPhongHoc.Name = "dgvPhongHoc";
            dgvPhongHoc.ReadOnly = true;
            dgvPhongHoc.RowHeadersWidth = 51;
            dgvPhongHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhongHoc.Size = new Size(1267, 492);
            dgvPhongHoc.TabIndex = 5;
            dgvPhongHoc.CellClick += dgvPhongHoc_CellClick;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(1040, 38);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 54);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(1187, 38);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 54);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(1040, 108);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 54);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.BackColor = SystemColors.Control;
            btnLuu.Location = new Point(1187, 108);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 54);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHuy.Location = new Point(1040, 177);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(267, 54);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy thao tác";
            btnHuy.Click += btnHuy_Click;
            // 
            // frmQuanLiPhongHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 846);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvPhongHoc);
            Controls.Add(cmbTrangThai);
            Controls.Add(cmbLoaiPhong);
            Controls.Add(cmbToaNha);
            Controls.Add(txtSucChua);
            Controls.Add(txtTang);
            Controls.Add(txtTenPhong);
            Controls.Add(txtMaPhong);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmQuanLiPhongHoc";
            Text = "Quản Lý Phòng Học - TDMU";
            Load += frmQuanLiPhongHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhongHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.ComboBox cmbToaNha;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.DataGridView dgvPhongHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}