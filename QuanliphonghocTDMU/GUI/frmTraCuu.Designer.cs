namespace QuanLiPhongHocTDMU
{
    partial class frmTraCuu
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlTopAdmin = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cmbCaHoc = new System.Windows.Forms.ComboBox();
            this.cmbToaNha = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTraCuuAdmin = new System.Windows.Forms.TabPage();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.tabQuyTrinhAdmin = new System.Windows.Forms.TabPage();
            this.dgvYeuCau = new System.Windows.Forms.DataGridView();
            this.pnlDuyet = new System.Windows.Forms.Panel();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.tabXungDotAdmin = new System.Windows.Forms.TabPage();
            this.dgvXungDot = new System.Windows.Forms.DataGridView();
            this.tabBocPhongGV = new System.Windows.Forms.TabPage();
            this.tlpGacha = new System.Windows.Forms.TableLayoutPanel();
            this.gbBocPhong = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtpNgayGV = new System.Windows.Forms.DateTimePicker();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbCaGV = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cmbLoaiPhongGV = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtMucDichGV = new System.Windows.Forms.TextBox();
            this.btnTienHanhBocPhong = new System.Windows.Forms.Button();
            this.gbHuongDan = new System.Windows.Forms.GroupBox();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.tabLichSuGV = new System.Windows.Forms.TabPage();
            this.dgvLichSuGV = new System.Windows.Forms.DataGridView();
            this.lblChiTiet = new System.Windows.Forms.Label();

            this.pnlTopAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabTraCuuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tabQuyTrinhAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).BeginInit();
            this.pnlDuyet.SuspendLayout();
            this.tabXungDotAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXungDot)).BeginInit();
            this.tabBocPhongGV.SuspendLayout();
            this.tlpGacha.SuspendLayout();
            this.gbBocPhong.SuspendLayout();
            this.gbHuongDan.SuspendLayout();
            this.tabLichSuGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuGV)).BeginInit();
            this.SuspendLayout();

            // --- ADMIN HEADER ---
            this.pnlTopAdmin.Controls.AddRange(new System.Windows.Forms.Control[] { this.dtpNgay, this.cmbCaHoc, this.cmbToaNha, this.btnTimKiem });
            this.pnlTopAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopAdmin.Height = 60;
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(20, 20);
            this.cmbCaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaHoc.Location = new System.Drawing.Point(150, 20);
            this.cmbCaHoc.Width = 80;
            this.cmbToaNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToaNha.Location = new System.Drawing.Point(250, 20);
            this.cmbToaNha.Width = 120;
            this.btnTimKiem.Location = new System.Drawing.Point(390, 18);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            // --- SPLIT CONTAINER & MAIN TABS ---
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.Panel1.Controls.Add(this.tabMain);
            this.tabMain.Controls.AddRange(new System.Windows.Forms.TabPage[] { this.tabTraCuuAdmin, this.tabQuyTrinhAdmin, this.tabXungDotAdmin, this.tabBocPhongGV, this.tabLichSuGV });
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;

            // --- ADMIN GRIDS ---
            this.tabTraCuuAdmin.Text = "Tra Cứu Phòng";
            this.tabTraCuuAdmin.Controls.Add(this.dgvPhong);
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);

            this.tabQuyTrinhAdmin.Text = "Yêu Cầu Mượn Phòng";
            this.tabQuyTrinhAdmin.Controls.Add(this.dgvYeuCau);
            this.tabQuyTrinhAdmin.Controls.Add(this.pnlDuyet);
            this.dgvYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYeuCau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.pnlDuyet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDuyet.Height = 50;
            this.pnlDuyet.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnDuyet, this.btnTuChoi });
            this.btnDuyet.Location = new System.Drawing.Point(20, 10);
            this.btnDuyet.Text = "Phê Duyệt";
            this.btnDuyet.BackColor = System.Drawing.Color.LightGreen;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            this.btnTuChoi.Location = new System.Drawing.Point(120, 10);
            this.btnTuChoi.Text = "Từ Chối";
            this.btnTuChoi.BackColor = System.Drawing.Color.LightCoral;
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);

            this.tabXungDotAdmin.Text = "Cảnh Báo Xung Đột";
            this.tabXungDotAdmin.Controls.Add(this.dgvXungDot);
            this.dgvXungDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXungDot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // =========================================================
            // --- GIAO DIỆN GIẢNG VIÊN (DÙNG TABLE LAYOUT PANEL) ---
            // =========================================================
            this.tabBocPhongGV.Text = "🎲 Bốc Phòng Random";
            this.tabBocPhongGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabBocPhongGV.Controls.Add(this.tlpGacha);

            // TableLayoutPanel setup
            this.tlpGacha.ColumnCount = 2;
            this.tlpGacha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tlpGacha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGacha.RowCount = 1;
            this.tlpGacha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGacha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGacha.Controls.Add(this.gbBocPhong, 0, 0);
            this.tlpGacha.Controls.Add(this.gbHuongDan, 1, 0);
            this.tlpGacha.Padding = new System.Windows.Forms.Padding(15);

            // Bảng 1: Nhập Yêu Cầu
            this.gbBocPhong.Text = "📝 THÔNG TIN YÊU CẦU";
            this.gbBocPhong.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbBocPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBocPhong.BackColor = System.Drawing.Color.White;
            this.gbBocPhong.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);

            this.lbl1.Text = "Ngày dạy:"; this.lbl1.Location = new System.Drawing.Point(20, 50); this.lbl1.AutoSize = true;
            this.dtpNgayGV.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayGV.Location = new System.Drawing.Point(120, 45); this.dtpNgayGV.Width = 280;

            this.lbl2.Text = "Ca học:"; this.lbl2.Location = new System.Drawing.Point(20, 105); this.lbl2.AutoSize = true;
            this.cmbCaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbCaGV.Location = new System.Drawing.Point(120, 100); this.cmbCaGV.Width = 280;

            this.lbl3.Text = "Loại phòng:"; this.lbl3.Location = new System.Drawing.Point(20, 160); this.lbl3.AutoSize = true;
            this.cmbLoaiPhongGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbLoaiPhongGV.Location = new System.Drawing.Point(120, 155); this.cmbLoaiPhongGV.Width = 280;

            this.lbl4.Text = "Mục đích:"; this.lbl4.Location = new System.Drawing.Point(20, 215); this.lbl4.AutoSize = true;
            this.txtMucDichGV.Multiline = true; this.txtMucDichGV.Location = new System.Drawing.Point(120, 210); this.txtMucDichGV.Size = new System.Drawing.Size(280, 80);

            this.btnTienHanhBocPhong.Text = "🎁 BỐC PHÒNG NGAY";
            this.btnTienHanhBocPhong.Location = new System.Drawing.Point(120, 320);
            this.btnTienHanhBocPhong.Size = new System.Drawing.Size(280, 50);
            this.btnTienHanhBocPhong.BackColor = System.Drawing.Color.Gold;
            this.btnTienHanhBocPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTienHanhBocPhong.Click += new System.EventHandler(this.btnTienHanhBocPhong_Click);

            this.gbBocPhong.Controls.AddRange(new System.Windows.Forms.Control[] { this.lbl1, this.dtpNgayGV, this.lbl2, this.cmbCaGV, this.lbl3, this.cmbLoaiPhongGV, this.lbl4, this.txtMucDichGV, this.btnTienHanhBocPhong });

            // Bảng 2: Hướng dẫn
            this.gbHuongDan.Text = "📌 QUY CHẾ BỐC PHÒNG";
            this.gbHuongDan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbHuongDan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHuongDan.BackColor = System.Drawing.Color.White;
            this.gbHuongDan.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);

            this.lblHuongDan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHuongDan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHuongDan.Padding = new System.Windows.Forms.Padding(15);
            this.lblHuongDan.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG GACHA PHÒNG HỌC TDMU!\n\n\n" +
                                     "1. Khai báo thông tin:\n" +
                                     "   - Chọn [Ngày], [Ca học], [Loại phòng] và ghi rõ [Mục đích].\n\n" +
                                     "2. Hệ thống bốc phòng ngẫu nhiên:\n" +
                                     "   - Hệ thống tự động quét và bốc 1 phòng trống phù hợp cho bạn.\n\n" +
                                     "3. Đảm bảo công bằng:\n" +
                                     "   - Không được chọn đích danh phòng giúp dàn đều tần suất sử dụng.\n\n" +
                                     "4. Phê duyệt yêu cầu:\n" +
                                     "   - Lệnh mượn phòng sẽ được chuyển cho Admin duyệt. Xem tại tab [Lịch sử].";
            this.gbHuongDan.Controls.Add(this.lblHuongDan);

            // Tab Lịch Sử
            this.tabLichSuGV.Text = "Lịch Sử Đăng Ký Của Tôi";
            this.tabLichSuGV.Controls.Add(this.dgvLichSuGV);
            this.dgvLichSuGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSuGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // --- ADMIN RIGHT PANEL (CHI TIẾT SỰ CỐ) ---
            this.lblChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChiTiet.BackColor = System.Drawing.Color.White;
            this.lblChiTiet.Text = "Chọn một phòng để xem Thiết bị và Sự cố...";
            this.splitContainer1.Panel2.Controls.Add(this.lblChiTiet);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);

            // --- FORM ---
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTopAdmin);
            this.Name = "frmTraCuu";
            this.Text = "TDMU Rooms - Hệ thống Tra cứu & Đặt phòng";
            this.Load += new System.EventHandler(this.frmTraCuu_Load);

            this.pnlTopAdmin.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabTraCuuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tabQuyTrinhAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).EndInit();
            this.pnlDuyet.ResumeLayout(false);
            this.tabXungDotAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXungDot)).EndInit();
            this.tabBocPhongGV.ResumeLayout(false);
            this.tlpGacha.ResumeLayout(false);
            this.gbBocPhong.ResumeLayout(false);
            this.gbBocPhong.PerformLayout();
            this.gbHuongDan.ResumeLayout(false);
            this.tabLichSuGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuGV)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTopAdmin, pnlDuyet;
        private System.Windows.Forms.DateTimePicker dtpNgay, dtpNgayGV;
        private System.Windows.Forms.ComboBox cmbCaHoc, cmbToaNha, cmbCaGV, cmbLoaiPhongGV;
        private System.Windows.Forms.Button btnTimKiem, btnDuyet, btnTuChoi, btnTienHanhBocPhong;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTraCuuAdmin, tabQuyTrinhAdmin, tabXungDotAdmin, tabBocPhongGV, tabLichSuGV;
        private System.Windows.Forms.DataGridView dgvPhong, dgvYeuCau, dgvXungDot, dgvLichSuGV;
        private System.Windows.Forms.Label lblChiTiet, lbl1, lbl2, lbl3, lbl4, lblHuongDan;
        private System.Windows.Forms.GroupBox gbBocPhong, gbHuongDan;
        private System.Windows.Forms.TextBox txtMucDichGV;
        private System.Windows.Forms.TableLayoutPanel tlpGacha;
    }
}