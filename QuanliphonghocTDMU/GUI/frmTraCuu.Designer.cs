namespace QuanLiPhongHocTDMU
{
    partial class frmTraCuu
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuu));
            pnlTopAdmin = new Panel();
            dtpNgay = new DateTimePicker();
            cmbCaHoc = new ComboBox();
            cmbToaNha = new ComboBox();
            btnTimKiem = new Button();
            splitContainer1 = new SplitContainer();
            tabMain = new TabControl();
            tabTraCuuAdmin = new TabPage();
            dgvPhong = new DataGridView();
            tabXungDotAdmin = new TabPage();
            dgvXungDot = new DataGridView();
            tabBocPhongGV = new TabPage();
            tlpGacha = new TableLayoutPanel();
            gbBocPhong = new GroupBox();
            lbl1 = new Label();
            dtpNgayGV = new DateTimePicker();
            lbl2 = new Label();
            cmbCaGV = new ComboBox();
            lbl3 = new Label();
            cmbLoaiPhongGV = new ComboBox();
            lblSucChua = new Label();
            cmbSucChuaGV = new ComboBox();
            lblMucDichChung = new Label();
            cmbMucDichChung = new ComboBox();
            lbl4 = new Label();
            txtMucDichGV = new TextBox();
            btnTienHanhBocPhong = new Button();
            gbHuongDan = new GroupBox();
            lblHuongDan = new Label();
            tabLichSuGV = new TabPage();
            dgvLichSuGV = new DataGridView();
            lblChiTiet = new Label();
            pnlTopAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabMain.SuspendLayout();
            tabTraCuuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            tabXungDotAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXungDot).BeginInit();
            tabBocPhongGV.SuspendLayout();
            tlpGacha.SuspendLayout();
            gbBocPhong.SuspendLayout();
            gbHuongDan.SuspendLayout();
            tabLichSuGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGV).BeginInit();
            SuspendLayout();
            // 
            // pnlTopAdmin
            // 
            pnlTopAdmin.Controls.Add(dtpNgay);
            pnlTopAdmin.Controls.Add(cmbCaHoc);
            pnlTopAdmin.Controls.Add(cmbToaNha);
            pnlTopAdmin.Controls.Add(btnTimKiem);
            pnlTopAdmin.Dock = DockStyle.Top;
            pnlTopAdmin.Location = new Point(0, 0);
            pnlTopAdmin.Name = "pnlTopAdmin";
            pnlTopAdmin.Size = new Size(1100, 60);
            pnlTopAdmin.TabIndex = 1;
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(20, 20);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(200, 27);
            dtpNgay.TabIndex = 0;
            // 
            // cmbCaHoc
            // 
            cmbCaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaHoc.Location = new Point(246, 18);
            cmbCaHoc.Name = "cmbCaHoc";
            cmbCaHoc.Size = new Size(80, 28);
            cmbCaHoc.TabIndex = 1;
            // 
            // cmbToaNha
            // 
            cmbToaNha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToaNha.Location = new Point(342, 18);
            cmbToaNha.Name = "cmbToaNha";
            cmbToaNha.Size = new Size(120, 28);
            cmbToaNha.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(517, 20);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 60);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabMain);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblChiTiet);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new Size(1100, 540);
            splitContainer1.SplitterDistance = 887;
            splitContainer1.TabIndex = 0;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabTraCuuAdmin);
            tabMain.Controls.Add(tabXungDotAdmin);
            tabMain.Controls.Add(tabBocPhongGV);
            tabMain.Controls.Add(tabLichSuGV);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(887, 540);
            tabMain.TabIndex = 0;
            // 
            // tabTraCuuAdmin
            // 
            tabTraCuuAdmin.Controls.Add(dgvPhong);
            tabTraCuuAdmin.Location = new Point(4, 29);
            tabTraCuuAdmin.Name = "tabTraCuuAdmin";
            tabTraCuuAdmin.Size = new Size(879, 507);
            tabTraCuuAdmin.TabIndex = 0;
            tabTraCuuAdmin.Text = "Tra Cứu Phòng";
            // 
            // dgvPhong
            // 
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.ColumnHeadersHeight = 29;
            dgvPhong.Dock = DockStyle.Fill;
            dgvPhong.Location = new Point(0, 0);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.Size = new Size(879, 507);
            dgvPhong.TabIndex = 0;
            dgvPhong.CellClick += dgvPhong_CellClick;
            // 
            // tabXungDotAdmin
            // 
            tabXungDotAdmin.Controls.Add(dgvXungDot);
            tabXungDotAdmin.Location = new Point(4, 29);
            tabXungDotAdmin.Name = "tabXungDotAdmin";
            tabXungDotAdmin.Size = new Size(879, 507);
            tabXungDotAdmin.TabIndex = 2;
            tabXungDotAdmin.Text = "Cảnh Báo Xung Đột";
            // 
            // dgvXungDot
            // 
            dgvXungDot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXungDot.ColumnHeadersHeight = 29;
            dgvXungDot.Dock = DockStyle.Fill;
            dgvXungDot.Location = new Point(0, 0);
            dgvXungDot.Name = "dgvXungDot";
            dgvXungDot.RowHeadersWidth = 51;
            dgvXungDot.Size = new Size(879, 507);
            dgvXungDot.TabIndex = 0;
            // 
            // tabBocPhongGV
            // 
            tabBocPhongGV.BackColor = Color.WhiteSmoke;
            tabBocPhongGV.Controls.Add(tlpGacha);
            tabBocPhongGV.Location = new Point(4, 29);
            tabBocPhongGV.Name = "tabBocPhongGV";
            tabBocPhongGV.Size = new Size(879, 507);
            tabBocPhongGV.TabIndex = 3;
            tabBocPhongGV.Text = "🎲 Đặt Phòng Random";
            // 
            // tlpGacha
            // 
            tlpGacha.ColumnCount = 2;
            tlpGacha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450F));
            tlpGacha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpGacha.Controls.Add(gbBocPhong, 0, 0);
            tlpGacha.Controls.Add(gbHuongDan, 1, 0);
            tlpGacha.Dock = DockStyle.Fill;
            tlpGacha.Location = new Point(0, 0);
            tlpGacha.Name = "tlpGacha";
            tlpGacha.Padding = new Padding(15);
            tlpGacha.RowCount = 1;
            tlpGacha.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpGacha.Size = new Size(879, 507);
            tlpGacha.TabIndex = 0;
            // 
            // gbBocPhong
            // 
            gbBocPhong.BackColor = Color.White;
            gbBocPhong.Controls.Add(lbl1);
            gbBocPhong.Controls.Add(dtpNgayGV);
            gbBocPhong.Controls.Add(lbl2);
            gbBocPhong.Controls.Add(cmbCaGV);
            gbBocPhong.Controls.Add(lbl3);
            gbBocPhong.Controls.Add(cmbLoaiPhongGV);
            gbBocPhong.Controls.Add(lblSucChua);
            gbBocPhong.Controls.Add(cmbSucChuaGV);
            gbBocPhong.Controls.Add(lblMucDichChung);
            gbBocPhong.Controls.Add(cmbMucDichChung);
            gbBocPhong.Controls.Add(lbl4);
            gbBocPhong.Controls.Add(txtMucDichGV);
            gbBocPhong.Controls.Add(btnTienHanhBocPhong);
            gbBocPhong.Dock = DockStyle.Fill;
            gbBocPhong.Font = new Font("Arial", 10F, FontStyle.Bold);
            gbBocPhong.Location = new Point(15, 15);
            gbBocPhong.Margin = new Padding(0, 0, 10, 0);
            gbBocPhong.Name = "gbBocPhong";
            gbBocPhong.Size = new Size(440, 477);
            gbBocPhong.TabIndex = 0;
            gbBocPhong.TabStop = false;
            gbBocPhong.Text = "📝 THÔNG TIN YÊU CẦU";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(20, 45);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(88, 19);
            lbl1.TabIndex = 0;
            lbl1.Text = "Ngày dạy:";
            // 
            // dtpNgayGV
            // 
            dtpNgayGV.Format = DateTimePickerFormat.Short;
            dtpNgayGV.Location = new Point(140, 40);
            dtpNgayGV.Name = "dtpNgayGV";
            dtpNgayGV.Size = new Size(260, 27);
            dtpNgayGV.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(20, 95);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 19);
            lbl2.TabIndex = 2;
            lbl2.Text = "Ca học:";
            // 
            // cmbCaGV
            // 
            cmbCaGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaGV.Location = new Point(140, 90);
            cmbCaGV.Name = "cmbCaGV";
            cmbCaGV.Size = new Size(260, 27);
            cmbCaGV.TabIndex = 3;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(20, 145);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(103, 19);
            lbl3.TabIndex = 4;
            lbl3.Text = "Loại phòng:";
            // 
            // cmbLoaiPhongGV
            // 
            cmbLoaiPhongGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiPhongGV.Location = new Point(140, 140);
            cmbLoaiPhongGV.Name = "cmbLoaiPhongGV";
            cmbLoaiPhongGV.Size = new Size(260, 27);
            cmbLoaiPhongGV.TabIndex = 5;
            // 
            // lblSucChua
            // 
            lblSucChua.AutoSize = true;
            lblSucChua.Location = new Point(20, 195);
            lblSucChua.Name = "lblSucChua";
            lblSucChua.Size = new Size(89, 19);
            lblSucChua.TabIndex = 10;
            lblSucChua.Text = "Số lượng:";
            // 
            // cmbSucChuaGV
            // 
            cmbSucChuaGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucChuaGV.Location = new Point(140, 190);
            cmbSucChuaGV.Name = "cmbSucChuaGV";
            cmbSucChuaGV.Size = new Size(260, 27);
            cmbSucChuaGV.TabIndex = 11;
            // 
            // lblMucDichChung
            // 
            lblMucDichChung.AutoSize = true;
            lblMucDichChung.Location = new Point(20, 245);
            lblMucDichChung.Name = "lblMucDichChung";
            lblMucDichChung.Size = new Size(85, 19);
            lblMucDichChung.TabIndex = 12;
            lblMucDichChung.Text = "Mục đích:";
            // 
            // cmbMucDichChung
            // 
            cmbMucDichChung.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMucDichChung.Location = new Point(140, 240);
            cmbMucDichChung.Name = "cmbMucDichChung";
            cmbMucDichChung.Size = new Size(260, 27);
            cmbMucDichChung.TabIndex = 13;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(20, 295);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(115, 19);
            lbl4.TabIndex = 6;
            lbl4.Text = "Chi tiết thêm:";
            // 
            // txtMucDichGV
            // 
            txtMucDichGV.Location = new Point(140, 290);
            txtMucDichGV.Multiline = true;
            txtMucDichGV.Name = "txtMucDichGV";
            txtMucDichGV.Size = new Size(260, 60);
            txtMucDichGV.TabIndex = 7;
            // 
            // btnTienHanhBocPhong
            // 
            btnTienHanhBocPhong.BackColor = Color.Gold;
            btnTienHanhBocPhong.Cursor = Cursors.Hand;
            btnTienHanhBocPhong.Location = new Point(140, 370);
            btnTienHanhBocPhong.Name = "btnTienHanhBocPhong";
            btnTienHanhBocPhong.Size = new Size(260, 50);
            btnTienHanhBocPhong.TabIndex = 8;
            btnTienHanhBocPhong.Text = "🎁 ĐẶT PHÒNG NGAY";
            btnTienHanhBocPhong.UseVisualStyleBackColor = false;
            btnTienHanhBocPhong.Click += btnTienHanhBocPhong_Click;
            // 
            // gbHuongDan
            // 
            gbHuongDan.BackColor = Color.White;
            gbHuongDan.Controls.Add(lblHuongDan);
            gbHuongDan.Dock = DockStyle.Fill;
            gbHuongDan.Font = new Font("Arial", 10F, FontStyle.Bold);
            gbHuongDan.Location = new Point(475, 15);
            gbHuongDan.Margin = new Padding(10, 0, 0, 0);
            gbHuongDan.Name = "gbHuongDan";
            gbHuongDan.Size = new Size(389, 477);
            gbHuongDan.TabIndex = 1;
            gbHuongDan.TabStop = false;
            gbHuongDan.Text = "📌 QUY CHẾ ĐẶT PHÒNG";
            // 
            // lblHuongDan
            // 
            lblHuongDan.Dock = DockStyle.Fill;
            lblHuongDan.Font = new Font("Segoe UI", 10F);
            lblHuongDan.ForeColor = Color.DarkSlateGray;
            lblHuongDan.Location = new Point(3, 23);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Padding = new Padding(15);
            lblHuongDan.Size = new Size(383, 451);
            lblHuongDan.TabIndex = 0;
            lblHuongDan.Text = resources.GetString("lblHuongDan.Text");
            // 
            // tabLichSuGV
            // 
            tabLichSuGV.Controls.Add(dgvLichSuGV);
            tabLichSuGV.Location = new Point(4, 29);
            tabLichSuGV.Name = "tabLichSuGV";
            tabLichSuGV.Size = new Size(879, 507);
            tabLichSuGV.TabIndex = 4;
            tabLichSuGV.Text = "Lịch Sử Đăng Ký Của Tôi";
            // 
            // dgvLichSuGV
            // 
            dgvLichSuGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSuGV.ColumnHeadersHeight = 29;
            dgvLichSuGV.Dock = DockStyle.Fill;
            dgvLichSuGV.Location = new Point(0, 0);
            dgvLichSuGV.Name = "dgvLichSuGV";
            dgvLichSuGV.RowHeadersWidth = 51;
            dgvLichSuGV.Size = new Size(879, 507);
            dgvLichSuGV.TabIndex = 0;
            // 
            // lblChiTiet
            // 
            lblChiTiet.BackColor = Color.White;
            lblChiTiet.Dock = DockStyle.Fill;
            lblChiTiet.Location = new Point(10, 10);
            lblChiTiet.Name = "lblChiTiet";
            lblChiTiet.Size = new Size(189, 520);
            lblChiTiet.TabIndex = 0;
            lblChiTiet.Text = "Chọn một phòng để xem Thiết bị và Sự cố...";
            // 
            // frmTraCuu
            // 
            ClientSize = new Size(1100, 600);
            Controls.Add(splitContainer1);
            Controls.Add(pnlTopAdmin);
            Name = "frmTraCuu";
            Text = "TDMU Rooms - Hệ thống Tra cứu & Đặt phòng";
            Load += frmTraCuu_Load;
            pnlTopAdmin.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabTraCuuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            tabXungDotAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXungDot).EndInit();
            tabBocPhongGV.ResumeLayout(false);
            tlpGacha.ResumeLayout(false);
            gbBocPhong.ResumeLayout(false);
            gbBocPhong.PerformLayout();
            gbHuongDan.ResumeLayout(false);
            tabLichSuGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGV).EndInit();
            ResumeLayout(false);

        }
        private System.Windows.Forms.Panel pnlTopAdmin;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cmbCaHoc;
        private System.Windows.Forms.ComboBox cmbToaNha;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTraCuuAdmin;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TabPage tabXungDotAdmin;
        private System.Windows.Forms.DataGridView dgvXungDot;
        private System.Windows.Forms.TabPage tabBocPhongGV;
        private System.Windows.Forms.TableLayoutPanel tlpGacha;
        private System.Windows.Forms.GroupBox gbBocPhong;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dtpNgayGV;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmbCaGV;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cmbLoaiPhongGV;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.ComboBox cmbSucChuaGV;
        private System.Windows.Forms.Label lblMucDichChung;
        private System.Windows.Forms.ComboBox cmbMucDichChung;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtMucDichGV;
        private System.Windows.Forms.Button btnTienHanhBocPhong;
        private System.Windows.Forms.GroupBox gbHuongDan;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.TabPage tabLichSuGV;
        private System.Windows.Forms.DataGridView dgvLichSuGV;
        private System.Windows.Forms.Label lblChiTiet;
    }
}