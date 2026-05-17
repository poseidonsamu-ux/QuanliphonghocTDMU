namespace QuanLiPhongHocTDMU
{
    partial class frmDatPhong
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

            this.pnlRightBooking = new Guna.UI2.WinForms.Guna2Panel();
            this.btnImportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txtMucDich = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMucDich = new System.Windows.Forms.Label();
            this.cboCaDat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCaDat = new System.Windows.Forms.Label();
            this.dtpNgayDat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.txtKhoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.cboMaGV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.cboMaPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTitleRight = new System.Windows.Forms.Label();

            this.pnlLeftWorkspace = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFilterCard = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgayTraCuu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbCaTraCuu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbToaNha = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFilterTitle = new System.Windows.Forms.Label();

            this.pnlGridCard = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.flpDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.pnlDetailArea = new Guna.UI2.WinForms.Guna2Panel();

            this.pnlRightBooking.SuspendLayout();
            this.pnlLeftWorkspace.SuspendLayout();
            this.pnlFilterCard.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.pnlDetailArea.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlRightBooking (CỘT PHẢI: Form đăng ký đặt phòng)
            // 
            this.pnlRightBooking.BackColor = System.Drawing.Color.White;
            this.pnlRightBooking.Controls.Add(this.btnImportExcel);
            this.pnlRightBooking.Controls.Add(this.btnXacNhan);
            this.pnlRightBooking.Controls.Add(this.txtMucDich);
            this.pnlRightBooking.Controls.Add(this.lblMucDich);
            this.pnlRightBooking.Controls.Add(this.cboCaDat);
            this.pnlRightBooking.Controls.Add(this.lblCaDat);
            this.pnlRightBooking.Controls.Add(this.dtpNgayDat);
            this.pnlRightBooking.Controls.Add(this.lblNgayDat);
            this.pnlRightBooking.Controls.Add(this.txtKhoa);
            this.pnlRightBooking.Controls.Add(this.lblKhoa);
            this.pnlRightBooking.Controls.Add(this.txtHoTen);
            this.pnlRightBooking.Controls.Add(this.lblHoTen);
            this.pnlRightBooking.Controls.Add(this.cboMaGV);
            this.pnlRightBooking.Controls.Add(this.lblMaGV);
            this.pnlRightBooking.Controls.Add(this.lblSucChua);
            this.pnlRightBooking.Controls.Add(this.cboMaPhong);
            this.pnlRightBooking.Controls.Add(this.lblMaPhong);
            this.pnlRightBooking.Controls.Add(this.lblTitleRight);
            this.pnlRightBooking.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightBooking.Location = new System.Drawing.Point(680, 0); // Đẩy sang phải
            this.pnlRightBooking.Name = "pnlRightBooking";
            this.pnlRightBooking.Size = new System.Drawing.Size(360, 720);
            this.pnlRightBooking.TabIndex = 1;

            this.lblTitleRight.AutoSize = true; this.lblTitleRight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblTitleRight.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229); this.lblTitleRight.Location = new System.Drawing.Point(20, 20); this.lblTitleRight.Text = "ĐĂNG KÝ ĐẶT PHÒNG";

            this.lblMaPhong.Location = new System.Drawing.Point(20, 70); this.lblMaPhong.Text = "Chọn phòng học:";
            this.cboMaPhong.Location = new System.Drawing.Point(20, 95); this.cboMaPhong.Size = new System.Drawing.Size(150, 36); this.cboMaPhong.SelectedIndexChanged += new System.EventHandler(this.cboMaPhong_SelectedIndexChanged);

            this.lblSucChua.Location = new System.Drawing.Point(180, 105); this.lblSucChua.Text = "Sức chứa: --"; this.lblSucChua.ForeColor = System.Drawing.Color.Green;

            this.lblMaGV.Location = new System.Drawing.Point(20, 145); this.lblMaGV.Text = "Mã giảng viên:";
            this.cboMaGV.Location = new System.Drawing.Point(20, 170); this.cboMaGV.Size = new System.Drawing.Size(315, 36); this.cboMaGV.SelectedIndexChanged += new System.EventHandler(this.cboMaGV_SelectedIndexChanged);

            this.lblHoTen.Location = new System.Drawing.Point(20, 220); this.lblHoTen.Text = "Họ tên giảng viên:";
            this.txtHoTen.Location = new System.Drawing.Point(20, 245); this.txtHoTen.Size = new System.Drawing.Size(315, 36); this.txtHoTen.ReadOnly = true;

            this.lblKhoa.Location = new System.Drawing.Point(20, 295); this.lblKhoa.Text = "Khoa / Viện:";
            this.txtKhoa.Location = new System.Drawing.Point(20, 320); this.txtKhoa.Size = new System.Drawing.Size(315, 36); this.txtKhoa.ReadOnly = true;

            this.lblNgayDat.Location = new System.Drawing.Point(20, 370); this.lblNgayDat.Text = "Ngày đăng ký đặt:";
            this.dtpNgayDat.Location = new System.Drawing.Point(20, 395); this.dtpNgayDat.Size = new System.Drawing.Size(315, 36); this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblCaDat.Location = new System.Drawing.Point(20, 445); this.lblCaDat.Text = "Ca học đăng ký:";
            this.cboCaDat.Location = new System.Drawing.Point(20, 470); this.cboCaDat.Size = new System.Drawing.Size(315, 36); this.cboCaDat.Items.AddRange(new object[] { "1", "2", "3" }); this.cboCaDat.SelectedIndex = 0;

            this.lblMucDich.Location = new System.Drawing.Point(20, 520); this.lblMucDich.Text = "Mục đích sử dụng:";
            this.txtMucDich.Location = new System.Drawing.Point(20, 545); this.txtMucDich.Size = new System.Drawing.Size(315, 60); this.txtMucDich.Multiline = true;

            // Nút Xác nhận
            this.btnXacNhan.Location = new System.Drawing.Point(20, 620); this.btnXacNhan.Size = new System.Drawing.Size(315, 40); this.btnXacNhan.Text = "XÁC NHẬN ĐẶT PHÒNG"; this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(79, 70, 229); this.btnXacNhan.ForeColor = System.Drawing.Color.White; this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnXacNhan.BorderRadius = 6; this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);

            // Nút Nhập từ Excel (Cực kỳ nổi bật)
            this.btnImportExcel.Location = new System.Drawing.Point(20, 670); this.btnImportExcel.Size = new System.Drawing.Size(315, 35); this.btnImportExcel.Text = "NHẬP EXCEL (TỪ MÁY TÍNH)"; this.btnImportExcel.FillColor = System.Drawing.Color.FromArgb(16, 185, 129); this.btnImportExcel.ForeColor = System.Drawing.Color.White; this.btnImportExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnImportExcel.BorderRadius = 6; this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);

            // 
            // pnlLeftWorkspace (CỘT TRÁI: Bảng tra cứu lớn)
            // 
            this.pnlLeftWorkspace.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlLeftWorkspace.Controls.Add(this.pnlGridCard);
            this.pnlLeftWorkspace.Controls.Add(this.pnlFilterCard);
            this.pnlLeftWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftWorkspace.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftWorkspace.Name = "pnlLeftWorkspace";
            this.pnlLeftWorkspace.Padding = new System.Windows.Forms.Padding(15);
            this.pnlLeftWorkspace.Size = new System.Drawing.Size(680, 720);
            this.pnlLeftWorkspace.TabIndex = 0;

            // pnlFilterCard
            this.pnlFilterCard.BackColor = System.Drawing.Color.White;
            this.pnlFilterCard.Controls.Add(this.lblFilterTitle);
            this.pnlFilterCard.Controls.Add(this.btnTimKiem);
            this.pnlFilterCard.Controls.Add(this.dtpNgayTraCuu);
            this.pnlFilterCard.Controls.Add(this.cmbCaTraCuu);
            this.pnlFilterCard.Controls.Add(this.cmbToaNha);
            this.pnlFilterCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterCard.Location = new System.Drawing.Point(15, 15);
            this.pnlFilterCard.Name = "pnlFilterCard";
            this.pnlFilterCard.Size = new System.Drawing.Size(650, 80);
            this.pnlFilterCard.TabIndex = 0;

            this.lblFilterTitle.AutoSize = true; this.lblFilterTitle.Location = new System.Drawing.Point(15, 10); this.lblFilterTitle.Text = "Bộ lọc tra cứu trạng thái phòng:"; this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.cmbToaNha.Location = new System.Drawing.Point(15, 35); this.cmbToaNha.Size = new System.Drawing.Size(130, 36);
            this.cmbCaTraCuu.Location = new System.Drawing.Point(155, 35); this.cmbCaTraCuu.Size = new System.Drawing.Size(90, 36);
            this.dtpNgayTraCuu.Location = new System.Drawing.Point(255, 35); this.dtpNgayTraCuu.Size = new System.Drawing.Size(180, 36); this.dtpNgayTraCuu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btnTimKiem.Location = new System.Drawing.Point(445, 35); this.btnTimKiem.Size = new System.Drawing.Size(100, 36); this.btnTimKiem.Text = "Tìm Kiếm"; this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(79, 70, 229); this.btnTimKiem.ForeColor = System.Drawing.Color.White; this.btnTimKiem.BorderRadius = 6; this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            // pnlGridCard
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.dgvPhong);
            this.pnlGridCard.Controls.Add(this.pnlDetailArea);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(15, 105);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(650, 600);
            this.pnlGridCard.TabIndex = 1;

            // Khối chi tiết thiết bị & sự cố nằm nép bên phải của Grid
            this.pnlDetailArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetailArea.Width = 220;
            this.pnlDetailArea.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlDetailArea.Controls.Add(this.flpDetail);
            this.pnlDetailArea.Controls.Add(this.lblDetailTitle);

            this.lblDetailTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailTitle.Height = 35;
            this.lblDetailTitle.Text = " Chi tiết thiết bị/sự cố:";
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.flpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDetail.AutoScroll = true;

            // dgvPhong
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhong.ColumnHeadersHeight = 35;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle3;

            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowTemplate.Height = 35;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(430, 600);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);

            // frmDatPhong
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 720);
            this.Controls.Add(this.pnlLeftWorkspace);
            this.Controls.Add(this.pnlRightBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatPhong";
            this.Text = "Quản lý đặt phòng học";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);

            this.pnlRightBooking.ResumeLayout(false);
            this.pnlRightBooking.PerformLayout();
            this.pnlLeftWorkspace.ResumeLayout(false);
            this.pnlFilterCard.ResumeLayout(false);
            this.pnlFilterCard.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.pnlDetailArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlRightBooking;
        private System.Windows.Forms.Label lblTitleRight;
        private System.Windows.Forms.Label lblMaPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaPhong;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblMaGV;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaGV;
        private System.Windows.Forms.Label lblHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label lblKhoa;
        private Guna.UI2.WinForms.Guna2TextBox txtKhoa;
        private System.Windows.Forms.Label lblNgayDat;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label lblCaDat;
        private Guna.UI2.WinForms.Guna2ComboBox cboCaDat;
        private System.Windows.Forms.Label lblMucDich;
        private Guna.UI2.WinForms.Guna2TextBox txtMucDich;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnImportExcel;

        private Guna.UI2.WinForms.Guna2Panel pnlLeftWorkspace;
        private Guna.UI2.WinForms.Guna2Panel pnlFilterCard;
        private System.Windows.Forms.Label lblFilterTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbToaNha;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCaTraCuu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTraCuu;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Panel pnlGridCard;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhong;
        private Guna.UI2.WinForms.Guna2Panel pnlDetailArea;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.FlowLayoutPanel flpDetail;
    }
}