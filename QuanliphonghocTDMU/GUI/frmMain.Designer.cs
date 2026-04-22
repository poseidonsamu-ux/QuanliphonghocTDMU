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
            menuStrip1 = new MenuStrip();
            menuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            menuQuanLyDanhMuc = new ToolStripMenuItem();
            mnuToaNha = new ToolStripMenuItem();
            mnuThietBi = new ToolStripMenuItem();
            mnuGiangVien = new ToolStripMenuItem();
            quảnLýPhòngHọcToolStripMenuItem = new ToolStripMenuItem();
            menuNghiepVu = new ToolStripMenuItem();
            menuDuyetYeuCau = new ToolStripMenuItem();
            mnuTraCuu = new ToolStripMenuItem();
            mnuBaoCaoSuCo = new ToolStripMenuItem();
            menuThongKe = new ToolStripMenuItem();
            mnuThongKeSuDung = new ToolStripMenuItem();
            mnuThongKeThietBi = new ToolStripMenuItem();
            mnuXuatBaoCao = new ToolStripMenuItem();
            pnlContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuHeThong, menuQuanLyDanhMuc, menuNghiepVu, menuThongKe });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(88, 24);
            menuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(224, 26);
            mnuDangNhap.Text = "Đăng nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(224, 26);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(224, 26);
            mnuDoiMatKhau.Text = "Đổi mật khẩu";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(224, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // menuQuanLyDanhMuc
            // 
            menuQuanLyDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuToaNha, mnuThietBi, mnuGiangVien, quảnLýPhòngHọcToolStripMenuItem });
            menuQuanLyDanhMuc.Name = "menuQuanLyDanhMuc";
            menuQuanLyDanhMuc.Size = new Size(90, 24);
            menuQuanLyDanhMuc.Text = "Danh Mục";
            // 
            // mnuToaNha
            // 
            mnuToaNha.Name = "mnuToaNha";
            mnuToaNha.Size = new Size(217, 26);
            mnuToaNha.Text = "Quản lý tòa nhà";
            mnuToaNha.Click += mnuToaNha_Click;
            // 
            // mnuThietBi
            // 
            mnuThietBi.Name = "mnuThietBi";
            mnuThietBi.Size = new Size(217, 26);
            mnuThietBi.Text = "Quản lý thiết bị";
            mnuThietBi.Click += mnuThietBi_Click;
            // 
            // mnuGiangVien
            // 
            mnuGiangVien.Name = "mnuGiangVien";
            mnuGiangVien.Size = new Size(217, 26);
            mnuGiangVien.Text = "Quản lý giảng viên";
            mnuGiangVien.Click += mnuGiangVien_Click;
            // 
            // quảnLýPhòngHọcToolStripMenuItem
            // 
            quảnLýPhòngHọcToolStripMenuItem.Name = "quảnLýPhòngHọcToolStripMenuItem";
            quảnLýPhòngHọcToolStripMenuItem.Size = new Size(217, 26);
            quảnLýPhòngHọcToolStripMenuItem.Text = "Quản lý phòng học";
            quảnLýPhòngHọcToolStripMenuItem.Click += quảnLýPhòngHọcToolStripMenuItem_Click;
            // 
            // menuNghiepVu
            // 
            menuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { menuDuyetYeuCau, mnuTraCuu, mnuBaoCaoSuCo });
            menuNghiepVu.Name = "menuNghiepVu";
            menuNghiepVu.Size = new Size(93, 24);
            menuNghiepVu.Text = "Nghiệp Vụ";
            // 
            // menuDuyetYeuCau
            // 
            menuDuyetYeuCau.Name = "menuDuyetYeuCau";
            menuDuyetYeuCau.Size = new Size(227, 26);
            menuDuyetYeuCau.Text = "Duyệt yêu cầu";
            menuDuyetYeuCau.Click += menuDuyetYeuCau_Click;
            // 
            // mnuTraCuu
            // 
            mnuTraCuu.Name = "mnuTraCuu";
            mnuTraCuu.Size = new Size(227, 26);
            mnuTraCuu.Text = "Tra cứu phòng trống";
            mnuTraCuu.Click += mnuTraCuu_Click;
            // 
            // mnuBaoCaoSuCo
            // 
            mnuBaoCaoSuCo.Name = "mnuBaoCaoSuCo";
            mnuBaoCaoSuCo.Size = new Size(227, 26);
            mnuBaoCaoSuCo.Text = "Báo cáo sự cố";
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
            mnuThongKeSuDung.Size = new Size(257, 26);
            mnuThongKeSuDung.Text = "Thống kê sử dụng phòng";
            mnuThongKeSuDung.Click += mnuThongKeSuDung_Click;
            // 
            // mnuThongKeThietBi
            // 
            mnuThongKeThietBi.Name = "mnuThongKeThietBi";
            mnuThongKeThietBi.Size = new Size(257, 26);
            mnuThongKeThietBi.Text = "Báo cáo thiết bị hư hỏng";
            mnuThongKeThietBi.Click += mnuThongKeThietBi_Click;
            // 
            // mnuXuatBaoCao
            // 
            mnuXuatBaoCao.Name = "mnuXuatBaoCao";
            mnuXuatBaoCao.Size = new Size(257, 26);
            mnuXuatBaoCao.Text = "Xuất báo cáo Excel/PDF";
            mnuXuatBaoCao.Click += mnuXuatBaoCao_Click;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.Location = new Point(0, 31);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1000, 719);
            pnlContent.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 750);
            Controls.Add(pnlContent);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Phòng học TDMU";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuToaNha;
        private System.Windows.Forms.ToolStripMenuItem mnuThietBi;
        private System.Windows.Forms.ToolStripMenuItem mnuGiangVien;
        private System.Windows.Forms.ToolStripMenuItem menuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnuDatPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu;
        private System.Windows.Forms.ToolStripMenuItem menuDuyetYeuCau;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoSuCo;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeSuDung;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeThietBi;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatBaoCao;
        private System.Windows.Forms.Panel pnlContent;
        private ToolStripMenuItem quảnLýPhòngHọcToolStripMenuItem;
    }
}