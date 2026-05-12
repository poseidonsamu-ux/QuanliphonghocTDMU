namespace QuanLiPhongHocTDMU
{
    partial class frmQuanLiThietBi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle cellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.gbThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbLoaiTB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaTB = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.dgvThietBi = new Guna.UI2.WinForms.Guna2DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();

            // gbThongTin
            this.gbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTin.BorderRadius = 15;
            this.gbThongTin.CustomBorderColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.gbThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbThongTin.ForeColor = System.Drawing.Color.White;
            this.gbThongTin.Location = new System.Drawing.Point(30, 20);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(900, 140);
            this.gbThongTin.Text = "THÔNG TIN THIẾT BỊ";
            this.gbThongTin.Controls.Add(this.cmbLoaiTB);
            this.gbThongTin.Controls.Add(this.txtTenTB);
            this.gbThongTin.Controls.Add(this.txtMaTB);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);

            // TextBox & ComboBox
            this.txtMaTB.Location = new System.Drawing.Point(20, 80);
            this.txtMaTB.Size = new System.Drawing.Size(220, 36);
            this.txtMaTB.BorderRadius = 8;
            this.txtTenTB.Location = new System.Drawing.Point(260, 80);
            this.txtTenTB.Size = new System.Drawing.Size(270, 36);
            this.txtTenTB.BorderRadius = 8;
            this.cmbLoaiTB.Location = new System.Drawing.Point(550, 80);
            this.cmbLoaiTB.Size = new System.Drawing.Size(250, 36);
            this.cmbLoaiTB.BorderRadius = 8;

            // Labels - Viết tường minh từng dòng cho Designer nó hiểu
            this.label1.AutoSize = true; this.label1.BackColor = System.Drawing.Color.Transparent; this.label1.ForeColor = System.Drawing.Color.Black; this.label1.Location = new System.Drawing.Point(20, 55); this.label1.Text = "Mã Thiết Bị:";
            this.label2.AutoSize = true; this.label2.BackColor = System.Drawing.Color.Transparent; this.label2.ForeColor = System.Drawing.Color.Black; this.label2.Location = new System.Drawing.Point(260, 55); this.label2.Text = "Tên Thiết Bị:";
            this.label3.AutoSize = true; this.label3.BackColor = System.Drawing.Color.Transparent; this.label3.ForeColor = System.Drawing.Color.Black; this.label3.Location = new System.Drawing.Point(550, 55); this.label3.Text = "Loại Thiết Bị:";

            // pnlActions
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.Location = new System.Drawing.Point(30, 170);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(900, 60);
            this.pnlActions.Controls.Add(this.btnTaiMau);
            this.pnlActions.Controls.Add(this.btnXuatExcel);
            this.pnlActions.Controls.Add(this.btnNhapExcel);
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnThem);

            // Buttons - BO GÓC 10 chuẩn Hải muốn
            this.btnThem.BorderRadius = 10; this.btnThem.FillColor = System.Drawing.Color.FromArgb(108, 40, 217); this.btnThem.Location = new System.Drawing.Point(0, 5); this.btnThem.Size = new System.Drawing.Size(90, 45); this.btnThem.Text = "THÊM"; this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.BorderRadius = 10; this.btnSua.FillColor = System.Drawing.Color.FromArgb(108, 40, 217); this.btnSua.Location = new System.Drawing.Point(100, 5); this.btnSua.Size = new System.Drawing.Size(90, 45); this.btnSua.Text = "SỬA"; this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.BorderRadius = 10; this.btnXoa.FillColor = System.Drawing.Color.FromArgb(220, 38, 38); this.btnXoa.Location = new System.Drawing.Point(200, 5); this.btnXoa.Size = new System.Drawing.Size(90, 45); this.btnXoa.Text = "XÓA"; this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnLuu.BorderRadius = 10; this.btnLuu.FillColor = System.Drawing.Color.FromArgb(22, 163, 74); this.btnLuu.Location = new System.Drawing.Point(300, 5); this.btnLuu.Size = new System.Drawing.Size(90, 45); this.btnLuu.Text = "LƯU"; this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnHuy.BorderRadius = 10; this.btnHuy.FillColor = System.Drawing.Color.FromArgb(156, 163, 175); this.btnHuy.Location = new System.Drawing.Point(400, 5); this.btnHuy.Size = new System.Drawing.Size(90, 45); this.btnHuy.Text = "HỦY"; this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // FIX CỨNG NÚT TẢI MẪU (MÀU CAM)
            this.btnTaiMau.BorderRadius = 10;
            this.btnTaiMau.FillColor = System.Drawing.Color.FromArgb(251, 146, 60);
            this.btnTaiMau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaiMau.ForeColor = System.Drawing.Color.White;
            this.btnTaiMau.Location = new System.Drawing.Point(500, 5);
            this.btnTaiMau.Size = new System.Drawing.Size(130, 45);
            this.btnTaiMau.Text = "📄 TẢI MẪU";
            this.btnTaiMau.Click += new System.EventHandler(this.btnTaiMau_Click);

            this.btnNhapExcel.BorderRadius = 10; this.btnNhapExcel.FillColor = System.Drawing.Color.FromArgb(21, 128, 61); this.btnNhapExcel.Location = new System.Drawing.Point(640, 5); this.btnNhapExcel.Size = new System.Drawing.Size(120, 45); this.btnNhapExcel.Text = "📥 NHẬP"; this.btnNhapExcel.Click += new System.EventHandler(this.btnNhapExcel_Click);
            this.btnXuatExcel.BorderRadius = 10; this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(31, 41, 55); this.btnXuatExcel.Location = new System.Drawing.Point(770, 5); this.btnXuatExcel.Size = new System.Drawing.Size(120, 45); this.btnXuatExcel.Text = "📤 XUẤT"; this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // dgvThietBi (KHÔNG DÙNG DÒNG .Theme LỖI)
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.RowHeadersVisible = false;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.White;
            this.dgvThietBi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThietBi.Location = new System.Drawing.Point(30, 240);
            this.dgvThietBi.Size = new System.Drawing.Size(900, 310);
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            // Header Tím Đậm
            this.dgvThietBi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.dgvThietBi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThietBi.ThemeStyle.HeaderStyle.Height = 35;

            // Selection Tím Nhạt
            this.dgvThietBi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvThietBi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            this.dgvThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThietBi_CellClick);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.ClientSize = new System.Drawing.Size(960, 580);
            this.Controls.Add(this.dgvThietBi);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.gbThongTin);
            this.Name = "frmQuanLiThietBi";
            this.Text = "Quản Lý Thiết Bị - TDMU Rooms";
            this.Load += new System.EventHandler(this.frmQuanLiThietBi_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTB, txtTenTB;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiTB;
        private System.Windows.Forms.Label label1, label2, label3;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnTaiMau, btnNhapExcel, btnXuatExcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThietBi;
    }
}