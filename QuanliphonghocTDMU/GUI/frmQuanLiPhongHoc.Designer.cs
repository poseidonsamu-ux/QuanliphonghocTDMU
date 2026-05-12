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

            // gbThongTin
            this.gbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTin.BorderRadius = 15;
            this.gbThongTin.CustomBorderColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.gbThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbThongTin.ForeColor = System.Drawing.Color.White;
            this.gbThongTin.Location = new System.Drawing.Point(30, 20);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1220, 210);
            this.gbThongTin.Text = "THÔNG TIN PHÒNG HỌC";
            this.gbThongTin.Controls.Add(this.cmbTrangThai);
            this.gbThongTin.Controls.Add(this.cmbLoaiPhong);
            this.gbThongTin.Controls.Add(this.cmbToaNha);
            this.gbThongTin.Controls.Add(this.txtSucChua);
            this.gbThongTin.Controls.Add(this.txtTang);
            this.gbThongTin.Controls.Add(this.txtTenPhong);
            this.gbThongTin.Controls.Add(this.txtMaPhong);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);

            // Tọa độ Control
            this.txtMaPhong.Location = new System.Drawing.Point(168, 60); this.txtMaPhong.Size = new System.Drawing.Size(250, 36); this.txtMaPhong.BorderRadius = 8;
            this.txtTenPhong.Location = new System.Drawing.Point(168, 110); this.txtTenPhong.Size = new System.Drawing.Size(250, 36); this.txtTenPhong.BorderRadius = 8;
            this.cmbToaNha.Location = new System.Drawing.Point(550, 60); this.cmbToaNha.Size = new System.Drawing.Size(300, 36); this.cmbToaNha.BorderRadius = 8;
            this.txtTang.Location = new System.Drawing.Point(550, 110); this.txtTang.Size = new System.Drawing.Size(300, 36); this.txtTang.BorderRadius = 8;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(168, 160); this.cmbLoaiPhong.Size = new System.Drawing.Size(250, 36); this.cmbLoaiPhong.BorderRadius = 8;
            this.txtSucChua.Location = new System.Drawing.Point(550, 160); this.txtSucChua.Size = new System.Drawing.Size(120, 36); this.txtSucChua.BorderRadius = 8;
            this.cmbTrangThai.Location = new System.Drawing.Point(750, 160); this.cmbTrangThai.Size = new System.Drawing.Size(150, 36); this.cmbTrangThai.BorderRadius = 8;

            // Labels
            foreach (System.Windows.Forms.Control c in this.gbThongTin.Controls) if (c is System.Windows.Forms.Label) { c.ForeColor = System.Drawing.Color.Black; c.AutoSize = true; this.gbThongTin.BackColor = System.Drawing.Color.Transparent; }
            this.label1.Text = "Mã Phòng:"; this.label1.Location = new System.Drawing.Point(30, 68);
            this.label2.Text = "Tên Phòng:"; this.label2.Location = new System.Drawing.Point(30, 118);
            this.label4.Text = "Loại Phòng:"; this.label4.Location = new System.Drawing.Point(30, 168);
            this.label5.Text = "Tòa Nhà:"; this.label5.Location = new System.Drawing.Point(430, 68);
            this.label3.Text = "Tầng:"; this.label3.Location = new System.Drawing.Point(430, 118);
            this.label6.Text = "Sức Chứa:"; this.label6.Location = new System.Drawing.Point(430, 168);
            this.label7.Text = "Trạng Thái:"; this.label7.Location = new System.Drawing.Point(680, 168);

            // pnlActions
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.Location = new System.Drawing.Point(30, 240);
            this.pnlActions.Size = new System.Drawing.Size(1220, 70);
            this.pnlActions.Controls.Add(this.btnTaiMau);
            this.pnlActions.Controls.Add(this.btnXuatExcel);
            this.pnlActions.Controls.Add(this.btnNhapExcel);
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnThem);

            // Cấu hình Nút (BO GÓC 10px)
            this.btnThem.BorderRadius = 10; this.btnThem.Location = new System.Drawing.Point(0, 10); this.btnThem.Size = new System.Drawing.Size(110, 45); this.btnThem.FillColor = System.Drawing.Color.FromArgb(108, 40, 217); this.btnThem.Text = "THÊM"; this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.BorderRadius = 10; this.btnSua.Location = new System.Drawing.Point(120, 10); this.btnSua.Size = new System.Drawing.Size(110, 45); this.btnSua.FillColor = System.Drawing.Color.FromArgb(108, 40, 217); this.btnSua.Text = "SỬA"; this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.BorderRadius = 10; this.btnXoa.Location = new System.Drawing.Point(240, 10); this.btnXoa.Size = new System.Drawing.Size(110, 45); this.btnXoa.FillColor = System.Drawing.Color.FromArgb(220, 38, 38); this.btnXoa.Text = "XÓA"; this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnLuu.BorderRadius = 10; this.btnLuu.Location = new System.Drawing.Point(360, 10); this.btnLuu.Size = new System.Drawing.Size(110, 45); this.btnLuu.FillColor = System.Drawing.Color.FromArgb(22, 163, 74); this.btnLuu.Text = "LƯU"; this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnHuy.BorderRadius = 10; this.btnHuy.Location = new System.Drawing.Point(480, 10); this.btnHuy.Size = new System.Drawing.Size(110, 45); this.btnHuy.FillColor = System.Drawing.Color.FromArgb(156, 163, 175); this.btnHuy.Text = "HỦY"; this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.btnTaiMau.BorderRadius = 10; this.btnTaiMau.Location = new System.Drawing.Point(670, 10); this.btnTaiMau.Size = new System.Drawing.Size(170, 45); this.btnTaiMau.FillColor = System.Drawing.Color.FromArgb(251, 146, 60); this.btnTaiMau.Text = "📄 TẢI FILE MẪU"; this.btnTaiMau.Click += new System.EventHandler(this.btnTaiMau_Click);
            this.btnNhapExcel.BorderRadius = 10; this.btnNhapExcel.Location = new System.Drawing.Point(850, 10); this.btnNhapExcel.Size = new System.Drawing.Size(170, 45); this.btnNhapExcel.FillColor = System.Drawing.Color.FromArgb(21, 128, 61); this.btnNhapExcel.Text = "📥 NHẬP EXCEL"; this.btnNhapExcel.Click += new System.EventHandler(this.btnNhapExcel_Click);
            this.btnXuatExcel.BorderRadius = 10; this.btnXuatExcel.Location = new System.Drawing.Point(1030, 10); this.btnXuatExcel.Size = new System.Drawing.Size(170, 45); this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(31, 41, 55); this.btnXuatExcel.Text = "📤 XUẤT EXCEL"; this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // dgvPhongHoc (ÉP THEME CHUẨN)
            this.dgvPhongHoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPhongHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhongHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhongHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhongHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(108, 40, 217);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(108, 40, 217);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhongHoc.ColumnHeadersHeight = 35;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongHoc.DefaultCellStyle = dataGridViewCellStyle3;

            this.dgvPhongHoc.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvPhongHoc.Location = new System.Drawing.Point(30, 320);
            this.dgvPhongHoc.Name = "dgvPhongHoc";
            this.dgvPhongHoc.RowHeadersVisible = false;
            this.dgvPhongHoc.Size = new System.Drawing.Size(1220, 460);
            this.dgvPhongHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.dgvPhongHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvPhongHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongHoc_CellClick);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.ClientSize = new System.Drawing.Size(1300, 846);
            this.Controls.Add(this.dgvPhongHoc);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.gbThongTin);
            this.Name = "frmQuanLiPhongHoc";
            this.Text = "Hệ thống Quản lý Phòng học - TDMU Rooms";
            this.Load += new System.EventHandler(this.frmQuanLiPhongHoc_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhong, txtTenPhong, txtTang, txtSucChua;
        private Guna.UI2.WinForms.Guna2ComboBox cmbToaNha, cmbLoaiPhong, cmbTrangThai;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnTaiMau, btnNhapExcel, btnXuatExcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhongHoc;
    }
}