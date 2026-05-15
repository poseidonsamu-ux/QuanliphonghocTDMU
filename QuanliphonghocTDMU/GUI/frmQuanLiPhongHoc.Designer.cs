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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            // 1. Khởi tạo các Control
            this.gbThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbToaNha = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSucChua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTaiMau = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPhongHoc = new Guna.UI2.WinForms.Guna2DataGridView();

            this.gbThongTin.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).BeginInit();
            this.SuspendLayout();

            // 2. gbThongTin
            this.gbThongTin.BorderRadius = 15;
            this.gbThongTin.CustomBorderColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.gbThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbThongTin.ForeColor = System.Drawing.Color.White;
            this.gbThongTin.Location = new System.Drawing.Point(15, 15);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1270, 215);
            this.gbThongTin.Text = "THÔNG TIN PHÒNG HỌC";

            // Vị trí các ô nhập liệu
            this.txtMaPhong.Location = new System.Drawing.Point(135, 55); this.txtMaPhong.Size = new System.Drawing.Size(200, 36); this.txtMaPhong.BorderRadius = 8;
            this.txtTenPhong.Location = new System.Drawing.Point(135, 105); this.txtTenPhong.Size = new System.Drawing.Size(200, 36); this.txtTenPhong.BorderRadius = 8;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(135, 155); this.cmbLoaiPhong.Size = new System.Drawing.Size(200, 36); this.cmbLoaiPhong.BorderRadius = 8;
            this.cmbToaNha.Location = new System.Drawing.Point(460, 55); this.cmbToaNha.Size = new System.Drawing.Size(300, 36); this.cmbToaNha.BorderRadius = 8;
            this.txtTang.Location = new System.Drawing.Point(460, 105); this.txtTang.Size = new System.Drawing.Size(300, 36); this.txtTang.BorderRadius = 8;
            this.txtSucChua.Location = new System.Drawing.Point(460, 155); this.txtSucChua.Size = new System.Drawing.Size(120, 36); this.txtSucChua.BorderRadius = 8;
            this.cmbTrangThai.Location = new System.Drawing.Point(600, 155); this.cmbTrangThai.Size = new System.Drawing.Size(160, 36); this.cmbTrangThai.BorderRadius = 8;

            // Labels
            this.label1.Text = "Mã Phòng:"; this.label1.Location = new System.Drawing.Point(30, 63); this.label1.ForeColor = System.Drawing.Color.Black; this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.Text = "Tên Phòng:"; this.label2.Location = new System.Drawing.Point(30, 113); this.label2.ForeColor = System.Drawing.Color.Black; this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label4.Text = "Loại Phòng:"; this.label4.Location = new System.Drawing.Point(30, 163); this.label4.ForeColor = System.Drawing.Color.Black; this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.Text = "Tòa Nhà:"; this.label5.Location = new System.Drawing.Point(370, 63); this.label5.ForeColor = System.Drawing.Color.Black; this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label3.Text = "Tầng:"; this.label3.Location = new System.Drawing.Point(370, 113); this.label3.ForeColor = System.Drawing.Color.Black; this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label6.Text = "Sức Chứa:"; this.label6.Location = new System.Drawing.Point(370, 163); this.label6.ForeColor = System.Drawing.Color.Black; this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label7.Text = "Trạng Thái:"; this.label7.Location = new System.Drawing.Point(595, 137); this.label7.Visible = false; // Ẩn label7 dư thừa nếu muốn

            this.gbThongTin.Controls.AddRange(new System.Windows.Forms.Control[] { this.cmbTrangThai, this.cmbLoaiPhong, this.cmbToaNha, this.txtSucChua, this.txtTang, this.txtTenPhong, this.txtMaPhong, this.label7, this.label6, this.label5, this.label4, this.label3, this.label2, this.label1 });

            // 3. pnlActions
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(15, 230);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1270, 80);
            this.pnlActions.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnTaiMau, this.btnXuatExcel, this.btnNhapExcel, this.btnHuy, this.btnLuu, this.btnXoa, this.btnSua, this.btnThem });

            // Cấu hình Nút
            int btnH = 45;
            this.btnThem.Location = new System.Drawing.Point(0, 15); this.btnThem.Size = new System.Drawing.Size(100, btnH); this.btnThem.BorderRadius = 10; this.btnThem.FillColor = System.Drawing.Color.FromArgb(108, 40, 217); this.btnThem.Text = "THÊM"; this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Location = new System.Drawing.Point(110, 15); this.btnSua.Size = new System.Drawing.Size(100, btnH); this.btnSua.BorderRadius = 10; this.btnSua.FillColor = System.Drawing.Color.FromArgb(108, 40, 217); this.btnSua.Text = "SỬA"; this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Location = new System.Drawing.Point(220, 15); this.btnXoa.Size = new System.Drawing.Size(100, btnH); this.btnXoa.BorderRadius = 10; this.btnXoa.FillColor = System.Drawing.Color.FromArgb(220, 38, 38); this.btnXoa.Text = "XÓA"; this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnLuu.Location = new System.Drawing.Point(330, 15); this.btnLuu.Size = new System.Drawing.Size(100, btnH); this.btnLuu.BorderRadius = 10; this.btnLuu.FillColor = System.Drawing.Color.FromArgb(22, 163, 74); this.btnLuu.Text = "LƯU"; this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnHuy.Location = new System.Drawing.Point(440, 15); this.btnHuy.Size = new System.Drawing.Size(100, btnH); this.btnHuy.BorderRadius = 10; this.btnHuy.FillColor = System.Drawing.Color.FromArgb(156, 163, 175); this.btnHuy.Text = "HỦY"; this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.Right; this.btnXuatExcel.Location = new System.Drawing.Point(1110, 15); this.btnXuatExcel.Size = new System.Drawing.Size(160, btnH); this.btnXuatExcel.BorderRadius = 10; this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(31, 41, 55); this.btnXuatExcel.Text = "📤 XUẤT EXCEL"; this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            this.btnNhapExcel.Anchor = System.Windows.Forms.AnchorStyles.Right; this.btnNhapExcel.Location = new System.Drawing.Point(940, 15); this.btnNhapExcel.Size = new System.Drawing.Size(160, btnH); this.btnNhapExcel.BorderRadius = 10; this.btnNhapExcel.FillColor = System.Drawing.Color.FromArgb(21, 128, 61); this.btnNhapExcel.Text = "📥 NHẬP EXCEL"; this.btnNhapExcel.Click += new System.EventHandler(this.btnNhapExcel_Click);
            this.btnTaiMau.Anchor = System.Windows.Forms.AnchorStyles.Right; this.btnTaiMau.Location = new System.Drawing.Point(770, 15); this.btnTaiMau.Size = new System.Drawing.Size(160, btnH); this.btnTaiMau.BorderRadius = 10; this.btnTaiMau.FillColor = System.Drawing.Color.FromArgb(251, 146, 60); this.btnTaiMau.Text = "📄 TẢI FILE MẪU"; this.btnTaiMau.Click += new System.EventHandler(this.btnTaiMau_Click);

            // 4. dgvPhongHoc
            this.dgvPhongHoc.AllowUserToAddRows = false;
            this.dgvPhongHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhongHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongHoc.Location = new System.Drawing.Point(15, 310);
            this.dgvPhongHoc.Name = "dgvPhongHoc";
            this.dgvPhongHoc.ReadOnly = true;
            this.dgvPhongHoc.RowHeadersVisible = false;
            this.dgvPhongHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.dgvPhongHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhongHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvPhongHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongHoc_CellClick);

            // 5. Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.ClientSize = new System.Drawing.Size(1300, 850);
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Controls.Add(this.dgvPhongHoc);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.gbThongTin);
            this.Name = "frmQuanLiPhongHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Học - TDMU Rooms";
            this.Load += new System.EventHandler(this.frmQuanLiPhongHoc_Load);

            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // KHAI BÁO BIẾN - SỬA LỖI THIẾU label7 TẠI ĐÂY
        private Guna.UI2.WinForms.Guna2GroupBox gbThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhong, txtTenPhong, txtTang, txtSucChua;
        private Guna.UI2.WinForms.Guna2ComboBox cmbToaNha, cmbLoaiPhong, cmbTrangThai;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnTaiMau, btnNhapExcel, btnXuatExcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhongHoc;
    }
}