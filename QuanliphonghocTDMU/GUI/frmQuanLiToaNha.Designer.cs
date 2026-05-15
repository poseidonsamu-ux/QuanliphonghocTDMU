namespace QuanLiPhongHocTDMU
{
    partial class frmQuanLiToaNha
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

            // 1. KHỞI TẠO CONTROL
            this.gbThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoTang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaToaNha = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiMau = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvToaNha = new Guna.UI2.WinForms.Guna2DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvToaNha)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();

            // 2. gbThongTin (Khu vực nhập liệu - Cố định phía trên)
            this.gbThongTin.BorderRadius = 15;
            this.gbThongTin.CustomBorderColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.gbThongTin.Dock = System.Windows.Forms.DockStyle.Top; // Bám chặt phía trên
            this.gbThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbThongTin.ForeColor = System.Drawing.Color.White;
            this.gbThongTin.Location = new System.Drawing.Point(15, 15);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1250, 160);
            this.gbThongTin.Text = "THÔNG TIN TÒA NHÀ / KHU HỌC";
            this.gbThongTin.Controls.Add(this.txtGhiChu);
            this.gbThongTin.Controls.Add(this.txtSoTang);
            this.gbThongTin.Controls.Add(this.txtMaToaNha);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);

            // TextBox Settings
            this.txtMaToaNha.Location = new System.Drawing.Point(150, 55);
            this.txtMaToaNha.Size = new System.Drawing.Size(250, 36);
            this.txtMaToaNha.BorderRadius = 8;

            this.txtSoTang.Location = new System.Drawing.Point(150, 105);
            this.txtSoTang.Size = new System.Drawing.Size(250, 36);
            this.txtSoTang.BorderRadius = 8;

            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(520, 55);
            this.txtGhiChu.Size = new System.Drawing.Size(700, 86);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.BorderRadius = 8;

            // Labels
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Text = "Mã Tòa Nhà:";

            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Text = "Số Tầng:";

            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(440, 63);
            this.label3.Text = "Ghi Chú:";

            // 3. pnlActions (Bố cục dàn nút bấm - Nằm dưới gbThongTin)
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top; // Bám dưới GroupBox
            this.pnlActions.Location = new System.Drawing.Point(15, 175);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1250, 75);
            this.pnlActions.Controls.Add(this.btnXuatExcel);
            this.pnlActions.Controls.Add(this.btnNhapExcel);
            this.pnlActions.Controls.Add(this.btnTaiMau);
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnThem);

            // Cấu hình Nút CRUD (Căn lề trái)
            int btnWidth = 100;
            int btnHeight = 45;
            this.btnThem.Location = new System.Drawing.Point(0, 15);
            this.btnThem.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnThem.BorderRadius = 10;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.btnThem.Text = "THÊM";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(110, 15);
            this.btnSua.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnSua.BorderRadius = 10;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(220, 15);
            this.btnXoa.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLuu.Location = new System.Drawing.Point(330, 15);
            this.btnLuu.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Location = new System.Drawing.Point(440, 15);
            this.btnHuy.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // Cấu hình Nút Excel (Căn lề phải)
            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXuatExcel.Location = new System.Drawing.Point(1100, 15);
            this.btnXuatExcel.Size = new System.Drawing.Size(150, btnHeight);
            this.btnXuatExcel.BorderRadius = 10;
            this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnXuatExcel.Text = "📤 XUẤT EXCEL";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            this.btnNhapExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNhapExcel.Location = new System.Drawing.Point(940, 15);
            this.btnNhapExcel.Size = new System.Drawing.Size(150, btnHeight);
            this.btnNhapExcel.BorderRadius = 10;
            this.btnNhapExcel.FillColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnNhapExcel.Text = "📥 NHẬP EXCEL";
            this.btnNhapExcel.Click += new System.EventHandler(this.btnNhapExcel_Click);

            this.btnTaiMau.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTaiMau.Location = new System.Drawing.Point(780, 15);
            this.btnTaiMau.Size = new System.Drawing.Size(150, btnHeight);
            this.btnTaiMau.BorderRadius = 10;
            this.btnTaiMau.FillColor = System.Drawing.Color.FromArgb(251, 146, 60);
            this.btnTaiMau.Text = "📄 TẢI MẪU";
            this.btnTaiMau.Click += new System.EventHandler(this.btnTaiMau_Click);

            // 4. dgvToaNha (Lấp đầy khoảng trống còn lại)
            this.dgvToaNha.AllowUserToAddRows = false;
            this.dgvToaNha.BackgroundColor = System.Drawing.Color.White;
            this.dgvToaNha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvToaNha.Dock = System.Windows.Forms.DockStyle.Fill; // Lấp đầy vùng còn lại
            this.dgvToaNha.Location = new System.Drawing.Point(15, 250);
            this.dgvToaNha.Name = "dgvToaNha";
            this.dgvToaNha.ReadOnly = true;
            this.dgvToaNha.RowHeadersVisible = false;
            this.dgvToaNha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToaNha.Size = new System.Drawing.Size(1250, 550);

            // Style Grid: Tím
            this.dgvToaNha.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(108, 40, 217);
            this.dgvToaNha.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvToaNha.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvToaNha.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dgvToaNha.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            this.dgvToaNha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToaNha_CellClick);

            // 5. frmQuanLiToaNha
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.ClientSize = new System.Drawing.Size(1280, 815);
            this.Padding = new System.Windows.Forms.Padding(15); // Tạo khoảng cách viền 4 phía
            this.Controls.Add(this.dgvToaNha);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.gbThongTin);
            this.Name = "frmQuanLiToaNha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ TÒA NHÀ - TDMU ROOMS";
            this.Load += new System.EventHandler(this.frmQuanLiToaNha_Load);

            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaNha)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txtMaToaNha, txtSoTang, txtGhiChu;
        private System.Windows.Forms.Label label1, label2, label3;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnTaiMau, btnNhapExcel, btnXuatExcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvToaNha;
    }
}