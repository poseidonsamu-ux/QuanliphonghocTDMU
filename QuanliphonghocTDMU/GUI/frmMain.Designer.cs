namespace QuanLiPhongHocTDMU
{
    partial class frmMain
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
            mnuMain = new MenuStrip();
            menuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            menuQuanLyDanhMuc = new ToolStripMenuItem();
            mnuToaNha = new ToolStripMenuItem();
            mnuPhongHoc = new ToolStripMenuItem();
            mnuThietBi = new ToolStripMenuItem();
            mnuGiangVien = new ToolStripMenuItem();
            menuNghiepVu = new ToolStripMenuItem();
            mnuTraCuu = new ToolStripMenuItem();
            menuDuyetYeuCau = new ToolStripMenuItem();
            mnuBaoCaoSuCo = new ToolStripMenuItem();
            menuThongKe = new ToolStripMenuItem();
            mnuThongKeSuDung = new ToolStripMenuItem();
            mnuThongKeThietBi = new ToolStripMenuItem();
            mnuXuatBaoCao = new ToolStripMenuItem();
            pnlContent = new Panel();
            picHome = new PictureBox();
            lblHuongDan = new Label();
            lblLoiChao = new Label();
            mnuMain.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { menuHeThong, menuQuanLyDanhMuc, menuNghiepVu, menuThongKe });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1280, 28);
            mnuMain.TabIndex = 0;
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(88, 24);
            menuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(183, 26);
            mnuDangNhap.Text = "Đăng Nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(183, 26);
            mnuDangXuat.Text = "Đăng Xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(183, 26);
            mnuDoiMatKhau.Text = "Đổi Mật Khẩu";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(183, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // menuQuanLyDanhMuc
            // 
            menuQuanLyDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuToaNha, mnuPhongHoc, mnuThietBi, mnuGiangVien });
            menuQuanLyDanhMuc.Name = "menuQuanLyDanhMuc";
            menuQuanLyDanhMuc.Size = new Size(90, 24);
            menuQuanLyDanhMuc.Text = "Danh Mục";
            // 
            // mnuToaNha
            // 
            mnuToaNha.Name = "mnuToaNha";
            mnuToaNha.Size = new Size(165, 26);
            mnuToaNha.Text = "Tòa Nhà";
            mnuToaNha.Click += mnuToaNha_Click;
            // 
            // mnuPhongHoc
            // 
            mnuPhongHoc.Name = "mnuPhongHoc";
            mnuPhongHoc.Size = new Size(165, 26);
            mnuPhongHoc.Text = "Phòng Học";
            mnuPhongHoc.Click += mnuPhongHoc_Click;
            // 
            // mnuThietBi
            // 
            mnuThietBi.Name = "mnuThietBi";
            mnuThietBi.Size = new Size(165, 26);
            mnuThietBi.Text = "Thiết Bị";
            mnuThietBi.Click += mnuThietBi_Click;
            // 
            // mnuGiangVien
            // 
            mnuGiangVien.Name = "mnuGiangVien";
            mnuGiangVien.Size = new Size(165, 26);
            mnuGiangVien.Text = "Giảng Viên";
            mnuGiangVien.Click += mnuGiangVien_Click;
            // 
            // menuNghiepVu
            // 
            menuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { mnuTraCuu, menuDuyetYeuCau, mnuBaoCaoSuCo });
            menuNghiepVu.Name = "menuNghiepVu";
            menuNghiepVu.Size = new Size(93, 24);
            menuNghiepVu.Text = "Nghiệp Vụ";
            // 
            // mnuTraCuu
            // 
            mnuTraCuu.Name = "mnuTraCuu";
            mnuTraCuu.Size = new Size(191, 26);
            mnuTraCuu.Text = "Tra Cứu Lịch";
            mnuTraCuu.Click += mnuTraCuu_Click;
            // 
            // menuDuyetYeuCau
            // 
            menuDuyetYeuCau.Name = "menuDuyetYeuCau";
            menuDuyetYeuCau.Size = new Size(191, 26);
            menuDuyetYeuCau.Text = "Duyệt Yêu Cầu";
            menuDuyetYeuCau.Click += menuDuyetYeuCau_Click;
            // 
            // mnuBaoCaoSuCo
            // 
            mnuBaoCaoSuCo.Name = "mnuBaoCaoSuCo";
            mnuBaoCaoSuCo.Size = new Size(191, 26);
            mnuBaoCaoSuCo.Text = "Báo Cáo Sự Cố";
            mnuBaoCaoSuCo.Click += mnuBaoCaoSuCo_Click;
            // 
            // menuThongKe
            // 
            menuThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSuDung, mnuThongKeThietBi, mnuXuatBaoCao });
            menuThongKe.Name = "menuThongKe";
            menuThongKe.Size = new Size(86, 24);
            menuThongKe.Text = "Thống Kê";
            // 
            // mnuThongKeSuDung
            // 
            mnuThongKeSuDung.Name = "mnuThongKeSuDung";
            mnuThongKeSuDung.Size = new Size(216, 26);
            mnuThongKeSuDung.Text = "Thống Kê Sử Dụng";
            mnuThongKeSuDung.Click += mnuThongKeSuDung_Click;
            // 
            // mnuThongKeThietBi
            // 
            mnuThongKeThietBi.Name = "mnuThongKeThietBi";
            mnuThongKeThietBi.Size = new Size(216, 26);
            mnuThongKeThietBi.Text = "Thống Kê Thiết Bị";
            mnuThongKeThietBi.Click += mnuThongKeThietBi_Click;
            // 
            // mnuXuatBaoCao
            // 
            mnuXuatBaoCao.Name = "mnuXuatBaoCao";
            mnuXuatBaoCao.Size = new Size(216, 26);
            mnuXuatBaoCao.Text = "Xuất Báo Cáo";
            mnuXuatBaoCao.Click += mnuXuatBaoCao_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(picHome);
            pnlContent.Controls.Add(lblHuongDan);
            pnlContent.Controls.Add(lblLoiChao);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 28);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(1280, 692);
            pnlContent.TabIndex = 1;
            // 
            // picHome
            // 
            picHome.BackColor = Color.White;
            picHome.Dock = DockStyle.Fill;
            picHome.Image = Properties.Resources.tdmujmg;
            picHome.Location = new Point(20, 130);
            picHome.Name = "picHome";
            picHome.Size = new Size(1240, 542);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 2;
            picHome.TabStop = false;
            // 
            // lblHuongDan
            // 
            lblHuongDan.Dock = DockStyle.Top;
            lblHuongDan.Font = new Font("Segoe UI", 13.8F);
            lblHuongDan.ForeColor = Color.DimGray;
            lblHuongDan.Location = new Point(20, 80);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(1240, 50);
            lblHuongDan.TabIndex = 1;
            lblHuongDan.Text = "Câu Dẫn";
            lblHuongDan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoiChao
            // 
            lblLoiChao.Dock = DockStyle.Top;
            lblLoiChao.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblLoiChao.ForeColor = Color.DodgerBlue;
            lblLoiChao.Location = new Point(20, 20);
            lblLoiChao.Name = "lblLoiChao";
            lblLoiChao.Size = new Size(1240, 60);
            lblLoiChao.TabIndex = 0;
            lblLoiChao.Text = "Xin chào!";
            lblLoiChao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlContent);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phòng Học TDMU";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuToaNha;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuThietBi;
        private System.Windows.Forms.ToolStripMenuItem mnuGiangVien;
        private System.Windows.Forms.ToolStripMenuItem menuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu;
        private System.Windows.Forms.ToolStripMenuItem menuDuyetYeuCau;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoSuCo;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeSuDung;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeThietBi;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatBaoCao;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblLoiChao;
        private System.Windows.Forms.PictureBox picHome;
    }
}