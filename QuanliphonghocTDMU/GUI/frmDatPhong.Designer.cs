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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtKhoaVien = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblCaHoc = new System.Windows.Forms.Label();
            this.cboCaHoc = new System.Windows.Forms.ComboBox();
            this.lblTietBatDau = new System.Windows.Forms.Label();
            this.txtTietBD = new System.Windows.Forms.TextBox();
            this.lblTietKetThuc = new System.Windows.Forms.Label();
            this.txtTietKT = new System.Windows.Forms.TextBox();
            this.lblMucDich = new System.Windows.Forms.Label();
            this.txtMucDich = new System.Windows.Forms.TextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐẶT PHÒNG HỌC";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaPhong.Location = new System.Drawing.Point(30, 80);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(91, 23);
            this.lblMaPhong.TabIndex = 1;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMaPhong.FormattingEnabled = true;
            this.cboMaPhong.Location = new System.Drawing.Point(150, 77);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Size = new System.Drawing.Size(120, 31);
            this.cboMaPhong.TabIndex = 2;
            this.cboMaPhong.SelectedIndexChanged += new System.EventHandler(this.cboMaPhong_SelectedIndexChanged);
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSucChua.Location = new System.Drawing.Point(280, 80);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(83, 23);
            this.lblSucChua.TabIndex = 19;
            this.lblSucChua.Text = "Sức chứa:";
            // 
            // txtSucChua
            // 
            this.txtSucChua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSucChua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtSucChua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSucChua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.txtSucChua.Location = new System.Drawing.Point(370, 77);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(150, 30);
            this.txtSucChua.TabIndex = 20;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaGV.Location = new System.Drawing.Point(30, 130);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(122, 23);
            this.lblMaGV.TabIndex = 3;
            this.lblMaGV.Text = "Mã giảng viên:";
            // 
            // cboMaGV
            // 
            this.cboMaGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(150, 127);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(370, 31);
            this.cboMaGV.TabIndex = 4;
            this.cboMaGV.SelectedIndexChanged += new System.EventHandler(this.cboMaGV_SelectedIndexChanged);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.Location = new System.Drawing.Point(30, 180);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(88, 23);
            this.lblHoTen.TabIndex = 5;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(150, 177);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(370, 30);
            this.txtHoTen.TabIndex = 6;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKhoa.Location = new System.Drawing.Point(30, 230);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(91, 23);
            this.lblKhoa.TabIndex = 7;
            this.lblKhoa.Text = "Khoa/Viện:";
            // 
            // txtKhoaVien
            // 
            this.txtKhoaVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhoaVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKhoaVien.Location = new System.Drawing.Point(150, 227);
            this.txtKhoaVien.Name = "txtKhoaVien";
            this.txtKhoaVien.Size = new System.Drawing.Size(370, 30);
            this.txtKhoaVien.TabIndex = 8;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSDT.Location = new System.Drawing.Point(30, 280);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(115, 23);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSDT.Location = new System.Drawing.Point(150, 277);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(370, 30);
            this.txtSDT.TabIndex = 10;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNgayDat.Location = new System.Drawing.Point(30, 330);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(84, 23);
            this.lblNgayDat.TabIndex = 11;
            this.lblNgayDat.Text = "Ngày đặt:";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayDat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(150, 327);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(370, 30);
            this.dtpNgayDat.TabIndex = 12;
            // 
            // lblMucDich
            // 
            this.lblMucDich.AutoSize = true;
            this.lblMucDich.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMucDich.Location = new System.Drawing.Point(30, 380);
            this.lblMucDich.Name = "lblMucDich";
            this.lblMucDich.Size = new System.Drawing.Size(86, 23);
            this.lblMucDich.TabIndex = 13;
            this.lblMucDich.Text = "Mục đích:";
            // 
            // txtMucDich
            // 
            this.txtMucDich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMucDich.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMucDich.Location = new System.Drawing.Point(150, 377);
            this.txtMucDich.Multiline = true;
            this.txtMucDich.Name = "txtMucDich";
            this.txtMucDich.Size = new System.Drawing.Size(700, 80);
            this.txtMucDich.TabIndex = 14;
            // 
            // lblCaHoc
            // 
            this.lblCaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaHoc.AutoSize = true;
            this.lblCaHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaHoc.Location = new System.Drawing.Point(550, 80);
            this.lblCaHoc.Name = "lblCaHoc";
            this.lblCaHoc.Size = new System.Drawing.Size(67, 23);
            this.lblCaHoc.TabIndex = 15;
            this.lblCaHoc.Text = "Ca học:";
            // 
            // cboCaHoc
            // 
            this.cboCaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCaHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCaHoc.FormattingEnabled = true;
            this.cboCaHoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCaHoc.Location = new System.Drawing.Point(650, 77);
            this.cboCaHoc.Name = "cboCaHoc";
            this.cboCaHoc.Size = new System.Drawing.Size(200, 31);
            this.cboCaHoc.TabIndex = 16;
            this.cboCaHoc.SelectedIndexChanged += new System.EventHandler(this.cboCaHoc_SelectedIndexChanged);
            // 
            // lblTietBatDau
            // 
            this.lblTietBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTietBatDau.AutoSize = true;
            this.lblTietBatDau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTietBatDau.Location = new System.Drawing.Point(550, 130);
            this.lblTietBatDau.Name = "lblTietBatDau";
            this.lblTietBatDau.Size = new System.Drawing.Size(104, 23);
            this.lblTietBatDau.TabIndex = 17;
            this.lblTietBatDau.Text = "Tiết bắt đầu:";
            // 
            // txtTietBD
            // 
            this.txtTietBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTietBD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTietBD.Location = new System.Drawing.Point(650, 127);
            this.txtTietBD.Name = "txtTietBD";
            this.txtTietBD.Size = new System.Drawing.Size(200, 30);
            this.txtTietBD.TabIndex = 18;
            // 
            // lblTietKetThuc
            // 
            this.lblTietKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTietKetThuc.AutoSize = true;
            this.lblTietKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTietKetThuc.Location = new System.Drawing.Point(550, 180);
            this.lblTietKetThuc.Name = "lblTietKetThuc";
            this.lblTietKetThuc.Size = new System.Drawing.Size(108, 23);
            this.lblTietKetThuc.TabIndex = 19;
            this.lblTietKetThuc.Text = "Tiết kết thúc:";
            // 
            // txtTietKT
            // 
            this.txtTietKT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTietKT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTietKT.Location = new System.Drawing.Point(650, 177);
            this.txtTietKT.Name = "txtTietKT";
            this.txtTietKT.Size = new System.Drawing.Size(200, 30);
            this.txtTietKT.TabIndex = 20;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(150, 480);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(200, 45);
            this.btnDatPhong.TabIndex = 21;
            this.btnDatPhong.Text = "Xác Nhận Đặt";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportExcel.FlatAppearance.BorderSize = 0;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Location = new System.Drawing.Point(370, 480);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(200, 45);
            this.btnImportExcel.TabIndex = 22;
            this.btnImportExcel.Text = "Nhập Từ Excel";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.txtMucDich);
            this.Controls.Add(this.lblMucDich);
            this.Controls.Add(this.txtTietKT);
            this.Controls.Add(this.lblTietKetThuc);
            this.Controls.Add(this.txtTietBD);
            this.Controls.Add(this.lblTietBatDau);
            this.Controls.Add(this.cboCaHoc);
            this.Controls.Add(this.lblCaHoc);
            this.Controls.Add(this.dtpNgayDat);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtKhoaVien);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.cboMaGV);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.lblSucChua);
            this.Controls.Add(this.cboMaPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatPhong";
            this.Text = "Đặt Phòng Học";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.ComboBox cboMaPhong;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtKhoaVien;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label lblCaHoc;
        private System.Windows.Forms.ComboBox cboCaHoc;
        private System.Windows.Forms.Label lblTietBatDau;
        private System.Windows.Forms.TextBox txtTietBD;
        private System.Windows.Forms.Label lblTietKetThuc;
        private System.Windows.Forms.TextBox txtTietKT;
        private System.Windows.Forms.Label lblMucDich;
        private System.Windows.Forms.TextBox txtMucDich;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnImportExcel;
    }
}