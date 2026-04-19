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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvPhongHoc = new DataGridView();
            label1 = new Label();
            txtMaPhong = new TextBox();
            label2 = new Label();
            cmbToaNha = new ComboBox();
            label3 = new Label();
            txtTenPhong = new TextBox();
            label4 = new Label();
            txtTang = new TextBox();
            label5 = new Label();
            cmbLoaiPhong = new ComboBox();
            label6 = new Label();
            txtSucChua = new TextBox();
            label7 = new Label();
            cmbTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhongHoc).BeginInit();
            SuspendLayout();
            // 
            // dgvPhongHoc
            // 
            dgvPhongHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhongHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongHoc.Location = new Point(30, 194);
            dgvPhongHoc.Name = "dgvPhongHoc";
            dgvPhongHoc.RowHeadersWidth = 51;
            dgvPhongHoc.Size = new Size(932, 374);
            dgvPhongHoc.TabIndex = 0;
            dgvPhongHoc.CellClick += dgvPhongHoc_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 17;
            label1.Text = "Mã Phòng";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(110, 27);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(180, 27);
            txtMaPhong.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 30);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 15;
            label2.Text = "Tòa Nhà";
            // 
            // cmbToaNha
            // 
            cmbToaNha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToaNha.Location = new Point(440, 30);
            cmbToaNha.Name = "cmbToaNha";
            cmbToaNha.Size = new Size(180, 28);
            cmbToaNha.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 30);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 13;
            label3.Text = "Tên Phòng";
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(740, 27);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(180, 27);
            txtTenPhong.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 80);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 11;
            label4.Text = "Tầng";
            // 
            // txtTang
            // 
            txtTang.Location = new Point(110, 77);
            txtTang.Name = "txtTang";
            txtTang.Size = new Size(180, 27);
            txtTang.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 80);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Loại Phòng";
            // 
            // cmbLoaiPhong
            // 
            cmbLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiPhong.Items.AddRange(new object[] { "Phòng thường", "Phòng máy", "Phòng thí nghiệm", "Giảng đường" });
            cmbLoaiPhong.Location = new Point(440, 76);
            cmbLoaiPhong.Name = "cmbLoaiPhong";
            cmbLoaiPhong.Size = new Size(180, 28);
            cmbLoaiPhong.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(650, 80);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 7;
            label6.Text = "Sức chứa";
            // 
            // txtSucChua
            // 
            txtSucChua.Location = new Point(740, 77);
            txtSucChua.Name = "txtSucChua";
            txtSucChua.Size = new Size(180, 27);
            txtSucChua.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 130);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 5;
            label7.Text = "Trạng Thái";
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.Items.AddRange(new object[] { "Sẵn sàng", "Đang học", "Bảo trì" });
            cmbTrangThai.Location = new Point(110, 127);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(180, 28);
            cmbTrangThai.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(340, 125);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 35);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(450, 125);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 35);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(560, 125);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 35);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(670, 125);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 35);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // frmQuanLiPhongHoc
            // 
            ClientSize = new Size(1000, 580);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cmbTrangThai);
            Controls.Add(label7);
            Controls.Add(txtSucChua);
            Controls.Add(label6);
            Controls.Add(cmbLoaiPhong);
            Controls.Add(label5);
            Controls.Add(txtTang);
            Controls.Add(label4);
            Controls.Add(txtTenPhong);
            Controls.Add(label3);
            Controls.Add(cmbToaNha);
            Controls.Add(label2);
            Controls.Add(txtMaPhong);
            Controls.Add(label1);
            Controls.Add(dgvPhongHoc);
            Name = "frmQuanLiPhongHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phòng Học";
            Load += frmQuanLiPhongHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhongHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbToaNha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}