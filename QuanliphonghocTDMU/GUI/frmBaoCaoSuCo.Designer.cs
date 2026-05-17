namespace QuanLiPhongHocTDMU
{
    partial class frmBaoCaoSuCo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlGiangVien = new System.Windows.Forms.Panel();
            this.lblPhongHoc = new System.Windows.Forms.Label();
            this.cmbPhongHoc = new System.Windows.Forms.ComboBox();
            this.lblLoaiSuCo = new System.Windows.Forms.Label();
            this.btnMayChieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnMayLanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDien = new Guna.UI2.WinForms.Guna2Button();
            this.btnInternet = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanGhe = new Guna.UI2.WinForms.Guna2Button();
            this.lblSuCoDangChon = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.cboMucDo = new System.Windows.Forms.ComboBox();
            this.btnGuiBaoCao = new System.Windows.Forms.Button();

            this.pnlGoiYAI = new System.Windows.Forms.Panel();
            this.lblGoiYTitle = new System.Windows.Forms.Label();
            this.flpGoiY = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlAdminDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTopCards = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCardTong = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.pnlCardDangXuLy = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDangXyLy = new System.Windows.Forms.Label();
            this.pnlCardDaXuLy = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDaXuLy = new System.Windows.Forms.Label();
            this.pnlGridContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSuCo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlBottomAction = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemSuCoAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();

            this.pnlGiangVien.SuspendLayout();
            this.pnlGoiYAI.SuspendLayout();
            this.pnlAdminDashboard.SuspendLayout();
            this.pnlTopCards.SuspendLayout();
            this.pnlCardTong.SuspendLayout();
            this.pnlCardDangXuLy.SuspendLayout();
            this.pnlCardDaXuLy.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).BeginInit();
            this.pnlBottomAction.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // KHU VỰC GIẢNG VIÊN 
            // =========================================================
            this.pnlGiangVien.BackColor = System.Drawing.Color.White;
            this.pnlGiangVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGiangVien.Location = new System.Drawing.Point(0, 0);
            this.pnlGiangVien.Name = "pnlGiangVien";
            this.pnlGiangVien.Size = new System.Drawing.Size(420, 720);

            this.lblPhongHoc.AutoSize = true;
            this.lblPhongHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhongHoc.Location = new System.Drawing.Point(30, 40);
            this.lblPhongHoc.Text = "Chọn phòng học:";

            this.cmbPhongHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhongHoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbPhongHoc.Location = new System.Drawing.Point(170, 36);
            this.cmbPhongHoc.Size = new System.Drawing.Size(210, 33);

            this.lblLoaiSuCo.AutoSize = true;
            this.lblLoaiSuCo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoaiSuCo.Location = new System.Drawing.Point(30, 95);
            this.lblLoaiSuCo.Text = "Nhóm sự cố:";

            this.btnMayChieu.Location = new System.Drawing.Point(30, 125);
            this.btnMayChieu.Size = new System.Drawing.Size(100, 40);
            this.btnMayChieu.Text = "Máy chiếu";
            this.btnMayChieu.BorderRadius = 6; this.btnMayChieu.BorderThickness = 1; this.btnMayChieu.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnMayChieu.FillColor = System.Drawing.Color.White; this.btnMayChieu.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnMayChieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMayChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMayChieu.Click += new System.EventHandler(this.btnLoaiSuCo_Click);

            this.btnMayLanh.Location = new System.Drawing.Point(140, 125);
            this.btnMayLanh.Size = new System.Drawing.Size(100, 40);
            this.btnMayLanh.Text = "Máy lạnh";
            this.btnMayLanh.BorderRadius = 6; this.btnMayLanh.BorderThickness = 1; this.btnMayLanh.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnMayLanh.FillColor = System.Drawing.Color.White; this.btnMayLanh.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnMayLanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMayLanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMayLanh.Click += new System.EventHandler(this.btnLoaiSuCo_Click);

            this.btnDien.Location = new System.Drawing.Point(250, 125);
            this.btnDien.Size = new System.Drawing.Size(130, 40);
            this.btnDien.Text = "Điện";
            this.btnDien.BorderRadius = 6; this.btnDien.BorderThickness = 1; this.btnDien.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnDien.FillColor = System.Drawing.Color.White; this.btnDien.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnDien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDien.Click += new System.EventHandler(this.btnLoaiSuCo_Click);

            this.btnInternet.Location = new System.Drawing.Point(30, 175);
            this.btnInternet.Size = new System.Drawing.Size(100, 40);
            this.btnInternet.Text = "Internet";
            this.btnInternet.BorderRadius = 6; this.btnInternet.BorderThickness = 1; this.btnInternet.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnInternet.FillColor = System.Drawing.Color.White; this.btnInternet.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnInternet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInternet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInternet.Click += new System.EventHandler(this.btnLoaiSuCo_Click);

            this.btnBanGhe.Location = new System.Drawing.Point(140, 175);
            this.btnBanGhe.Size = new System.Drawing.Size(240, 40);
            this.btnBanGhe.Text = "Cơ sở vật chất";
            this.btnBanGhe.BorderRadius = 6; this.btnBanGhe.BorderThickness = 1; this.btnBanGhe.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnBanGhe.FillColor = System.Drawing.Color.White; this.btnBanGhe.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnBanGhe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBanGhe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanGhe.Click += new System.EventHandler(this.btnLoaiSuCo_Click);

            this.lblSuCoDangChon.AutoSize = true;
            this.lblSuCoDangChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSuCoDangChon.ForeColor = System.Drawing.Color.DimGray;
            this.lblSuCoDangChon.Location = new System.Drawing.Point(30, 230);
            this.lblSuCoDangChon.Text = "Đang chọn: Chưa có";

            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(30, 270);
            this.lblMoTa.Text = "Mô tả chi tiết sự cố:";

            this.txtMoTa.Location = new System.Drawing.Point(30, 300);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Size = new System.Drawing.Size(350, 100);

            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMucDo.Location = new System.Drawing.Point(30, 420);
            this.lblMucDo.Text = "Mức độ ảnh hưởng (1 đến 5):";

            this.cboMucDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMucDo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboMucDo.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            this.cboMucDo.Location = new System.Drawing.Point(30, 450);
            this.cboMucDo.Size = new System.Drawing.Size(350, 33);

            this.btnGuiBaoCao.BackColor = System.Drawing.Color.Crimson;
            this.btnGuiBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuiBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnGuiBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiBaoCao.FlatAppearance.BorderSize = 0;
            this.btnGuiBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiBaoCao.Location = new System.Drawing.Point(30, 510);
            this.btnGuiBaoCao.Size = new System.Drawing.Size(350, 50);
            this.btnGuiBaoCao.Text = "🚀 GỬI BÁO CÁO";
            this.btnGuiBaoCao.Click += new System.EventHandler(this.btnGuiBaoCao_Click);

            this.pnlGiangVien.Controls.Add(this.btnGuiBaoCao);
            this.pnlGiangVien.Controls.Add(this.cboMucDo);
            this.pnlGiangVien.Controls.Add(this.lblMucDo);
            this.pnlGiangVien.Controls.Add(this.txtMoTa);
            this.pnlGiangVien.Controls.Add(this.lblMoTa);
            this.pnlGiangVien.Controls.Add(this.lblSuCoDangChon);
            this.pnlGiangVien.Controls.Add(this.btnBanGhe);
            this.pnlGiangVien.Controls.Add(this.btnInternet);
            this.pnlGiangVien.Controls.Add(this.btnDien);
            this.pnlGiangVien.Controls.Add(this.btnMayLanh);
            this.pnlGiangVien.Controls.Add(this.btnMayChieu);
            this.pnlGiangVien.Controls.Add(this.lblLoaiSuCo);
            this.pnlGiangVien.Controls.Add(this.cmbPhongHoc);
            this.pnlGiangVien.Controls.Add(this.lblPhongHoc);

            // =========================================================
            // KHU VỰC GỢI Ý PHÒNG
            // =========================================================
            this.pnlGoiYAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlGoiYAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGoiYAI.Location = new System.Drawing.Point(420, 0);
            this.pnlGoiYAI.Name = "pnlGoiYAI";
            this.pnlGoiYAI.Padding = new System.Windows.Forms.Padding(20);

            this.lblGoiYTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGoiYTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGoiYTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblGoiYTitle.Height = 40;
            this.lblGoiYTitle.Text = "GỢI Ý PHÒNG THAY THẾ";

            this.flpGoiY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGoiY.AutoScroll = true;
            this.flpGoiY.Location = new System.Drawing.Point(20, 60);

            this.pnlGoiYAI.Controls.Add(this.flpGoiY);
            this.pnlGoiYAI.Controls.Add(this.lblGoiYTitle);

            // =========================================================
            // KHU VỰC ADMIN DASHBOARD (GIỮ NGUYÊN)
            // =========================================================
            this.pnlAdminDashboard.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlAdminDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(1040, 720);
            this.pnlAdminDashboard.Visible = false;

            this.pnlTopCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopCards.Location = new System.Drawing.Point(0, 0);
            this.pnlTopCards.Size = new System.Drawing.Size(1040, 145);

            this.pnlCardTong.BorderRadius = 12; this.pnlCardTong.FillColor = System.Drawing.Color.White; this.pnlCardTong.Location = new System.Drawing.Point(20, 20); this.pnlCardTong.Size = new System.Drawing.Size(260, 110);
            this.pnlCardTong.Controls.Add(this.label1); this.pnlCardTong.Controls.Add(this.lblTong);
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(15, 15); this.label1.Text = "Tổng số sự cố"; this.label1.BackColor = System.Drawing.Color.White; this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTong.AutoSize = false; this.lblTong.Size = new System.Drawing.Size(230, 55); this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblTong.Location = new System.Drawing.Point(15, 40); this.lblTong.Text = "0"; this.lblTong.BackColor = System.Drawing.Color.White; this.lblTong.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold); this.lblTong.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);

            this.pnlCardDangXuLy.BorderRadius = 12; this.pnlCardDangXuLy.FillColor = System.Drawing.Color.White; this.pnlCardDangXuLy.Location = new System.Drawing.Point(300, 20); this.pnlCardDangXuLy.Size = new System.Drawing.Size(260, 110);
            this.pnlCardDangXuLy.Controls.Add(this.label4); this.pnlCardDangXuLy.Controls.Add(this.lblDangXyLy);
            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(15, 15); this.label4.Text = "Đang xử lý"; this.label4.BackColor = System.Drawing.Color.White; this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDangXyLy.AutoSize = false; this.lblDangXyLy.Size = new System.Drawing.Size(230, 55); this.lblDangXyLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblDangXyLy.Location = new System.Drawing.Point(15, 40); this.lblDangXyLy.Text = "0"; this.lblDangXyLy.BackColor = System.Drawing.Color.White; this.lblDangXyLy.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold); this.lblDangXyLy.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);

            this.pnlCardDaXuLy.BorderRadius = 12; this.pnlCardDaXuLy.FillColor = System.Drawing.Color.White; this.pnlCardDaXuLy.Location = new System.Drawing.Point(580, 20); this.pnlCardDaXuLy.Size = new System.Drawing.Size(260, 110);
            this.pnlCardDaXuLy.Controls.Add(this.label6); this.pnlCardDaXuLy.Controls.Add(this.lblDaXuLy);
            this.label6.AutoSize = true; this.label6.Location = new System.Drawing.Point(15, 15); this.label6.Text = "Đã khắc phục"; this.label6.BackColor = System.Drawing.Color.White; this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDaXuLy.AutoSize = false; this.lblDaXuLy.Size = new System.Drawing.Size(230, 55); this.lblDaXuLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblDaXuLy.Location = new System.Drawing.Point(15, 40); this.lblDaXuLy.Text = "0"; this.lblDaXuLy.BackColor = System.Drawing.Color.White; this.lblDaXuLy.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold); this.lblDaXuLy.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);

            this.pnlTopCards.Controls.Add(this.pnlCardTong); this.pnlTopCards.Controls.Add(this.pnlCardDangXuLy); this.pnlTopCards.Controls.Add(this.pnlCardDaXuLy);

            this.pnlGridContainer.BorderRadius = 16; this.pnlGridContainer.FillColor = System.Drawing.Color.White; this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlGridContainer.Location = new System.Drawing.Point(20, 145); this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(15);
            this.pnlGridContainer.Controls.Add(this.dgvSuCo);
            this.dgvSuCo.AllowUserToAddRows = false; this.dgvSuCo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White; this.dgvSuCo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuCo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvSuCo.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuCo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft; dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(79, 70, 229); dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White; dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(79, 70, 229); dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSuCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2; this.dgvSuCo.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft; dataGridViewCellStyle3.BackColor = System.Drawing.Color.White; dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F); dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105); dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(238, 242, 255); dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(49, 46, 129);
            this.dgvSuCo.DefaultCellStyle = dataGridViewCellStyle3; this.dgvSuCo.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvSuCo.ReadOnly = true; this.dgvSuCo.RowHeadersVisible = false; this.dgvSuCo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.pnlBottomAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomAction.Location = new System.Drawing.Point(0, 630);
            this.pnlBottomAction.Size = new System.Drawing.Size(1040, 90);

            this.btnThemSuCoAdmin.BorderRadius = 8;
            this.btnThemSuCoAdmin.FillColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnThemSuCoAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemSuCoAdmin.ForeColor = System.Drawing.Color.White;
            this.btnThemSuCoAdmin.Location = new System.Drawing.Point(20, 20);
            this.btnThemSuCoAdmin.Size = new System.Drawing.Size(150, 45);
            this.btnThemSuCoAdmin.Text = "➕ THÊM SỰ CỐ";
            this.btnThemSuCoAdmin.Click += new System.EventHandler(this.btnThemSuCoAdmin_Click);

            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.Crimson;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(180, 20);
            this.btnXoa.Size = new System.Drawing.Size(120, 45);
            this.btnXoa.Text = "🗑 XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.cboTrangThai.BorderRadius = 8;
            this.cboTrangThai.Location = new System.Drawing.Point(540, 25);
            this.cboTrangThai.Size = new System.Drawing.Size(160, 36);

            this.btnCapNhat.BorderRadius = 8;
            this.btnCapNhat.FillColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(710, 20);
            this.btnCapNhat.Size = new System.Drawing.Size(120, 45);
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.pnlBottomAction.Controls.Add(this.btnThemSuCoAdmin);
            this.pnlBottomAction.Controls.Add(this.btnXoa);
            this.pnlBottomAction.Controls.Add(this.cboTrangThai);
            this.pnlBottomAction.Controls.Add(this.btnCapNhat);

            this.pnlAdminDashboard.Controls.Add(this.pnlGridContainer);
            this.pnlAdminDashboard.Controls.Add(this.pnlTopCards);
            this.pnlAdminDashboard.Controls.Add(this.pnlBottomAction);

            // ======================================================================
            // SETUP TỔNG FORM
            // ======================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Controls.Add(this.pnlAdminDashboard);
            this.Controls.Add(this.pnlGoiYAI);
            this.Controls.Add(this.pnlGiangVien);

            this.Name = "frmBaoCaoSuCo";
            this.Text = "Quản lý & Báo Cáo Sự Cố";
            this.Load += new System.EventHandler(this.frmBaoCaoSuCo_Load);

            this.pnlGiangVien.ResumeLayout(false);
            this.pnlGiangVien.PerformLayout();
            this.pnlGoiYAI.ResumeLayout(false);
            this.pnlAdminDashboard.ResumeLayout(false);
            this.pnlTopCards.ResumeLayout(false);
            this.pnlTopCards.PerformLayout();
            this.pnlCardTong.ResumeLayout(false);
            this.pnlCardTong.PerformLayout();
            this.pnlCardDangXuLy.ResumeLayout(false);
            this.pnlCardDangXuLy.PerformLayout();
            this.pnlCardDaXuLy.ResumeLayout(false);
            this.pnlCardDaXuLy.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).EndInit();
            this.pnlBottomAction.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlGiangVien;
        private System.Windows.Forms.Label lblPhongHoc;
        private System.Windows.Forms.ComboBox cmbPhongHoc;
        private System.Windows.Forms.Label lblLoaiSuCo;
        private Guna.UI2.WinForms.Guna2Button btnBanGhe;
        private Guna.UI2.WinForms.Guna2Button btnInternet;
        private Guna.UI2.WinForms.Guna2Button btnDien;
        private Guna.UI2.WinForms.Guna2Button btnMayLanh;
        private Guna.UI2.WinForms.Guna2Button btnMayChieu;
        private System.Windows.Forms.Label lblSuCoDangChon;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.ComboBox cboMucDo;
        private System.Windows.Forms.Button btnGuiBaoCao;

        private System.Windows.Forms.Panel pnlGoiYAI;
        private System.Windows.Forms.Label lblGoiYTitle;
        private System.Windows.Forms.FlowLayoutPanel flpGoiY;

        private Guna.UI2.WinForms.Guna2Panel pnlAdminDashboard;
        private Guna.UI2.WinForms.Guna2Panel pnlTopCards;
        private Guna.UI2.WinForms.Guna2Panel pnlCardTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTong;
        private Guna.UI2.WinForms.Guna2Panel pnlCardDangXuLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDangXyLy;
        private Guna.UI2.WinForms.Guna2Panel pnlCardDaXuLy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDaXuLy;
        private Guna.UI2.WinForms.Guna2Panel pnlGridContainer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSuCo;
        private Guna.UI2.WinForms.Guna2Panel pnlBottomAction;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThemSuCoAdmin;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
    }
}