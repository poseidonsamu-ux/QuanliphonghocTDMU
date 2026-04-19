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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToaNha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhongHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThietBi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuyetYeuCau = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLyDanhMuc,
            this.menuNghiepVu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // menuHeThong
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(85, 24);
            this.menuHeThong.Text = "Hệ thống";

            // mnuThoat
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(130, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);

            // menuQuanLyDanhMuc
            this.menuQuanLyDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToaNha,
            this.mnuPhongHoc,
            this.mnuThietBi,
            this.mnuGiangVien});
            this.menuQuanLyDanhMuc.Name = "menuQuanLyDanhMuc";
            this.menuQuanLyDanhMuc.Size = new System.Drawing.Size(142, 24);
            this.menuQuanLyDanhMuc.Text = "Quản lý danh mục";

            // mnuToaNha
            this.mnuToaNha.Name = "mnuToaNha";
            this.mnuToaNha.Size = new System.Drawing.Size(217, 26);
            this.mnuToaNha.Text = "Quản lý tòa nhà";
            this.mnuToaNha.Click += new System.EventHandler(this.mnuToaNha_Click);

            // mnuPhongHoc
            this.mnuPhongHoc.Name = "mnuPhongHoc";
            this.mnuPhongHoc.Size = new System.Drawing.Size(217, 26);
            this.mnuPhongHoc.Text = "Quản lý phòng học";
            this.mnuPhongHoc.Click += new System.EventHandler(this.mnuPhongHoc_Click);

            // mnuThietBi
            this.mnuThietBi.Name = "mnuThietBi";
            this.mnuThietBi.Size = new System.Drawing.Size(217, 26);
            this.mnuThietBi.Text = "Quản lý thiết bị";
            this.mnuThietBi.Click += new System.EventHandler(this.mnuThietBi_Click);

            // mnuGiangVien
            this.mnuGiangVien.Name = "mnuGiangVien";
            this.mnuGiangVien.Size = new System.Drawing.Size(217, 26);
            this.mnuGiangVien.Text = "Quản lý giảng viên";
            this.mnuGiangVien.Click += new System.EventHandler(this.mnuGiangVien_Click);

            // menuNghiepVu
            this.menuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatPhong,
            this.mnuTraCuu,
            this.menuDuyetYeuCau});
            this.menuNghiepVu.Name = "menuNghiepVu";
            this.menuNghiepVu.Size = new System.Drawing.Size(91, 24);
            this.menuNghiepVu.Text = "Nghiệp vụ";

            // mnuDatPhong
            this.mnuDatPhong.Name = "mnuDatPhong";
            this.mnuDatPhong.Size = new System.Drawing.Size(227, 26);
            this.mnuDatPhong.Text = "Đặt phòng / Mượn";
            this.mnuDatPhong.Click += new System.EventHandler(this.mnuDatPhong_Click);

            // mnuTraCuu
            this.mnuTraCuu.Name = "mnuTraCuu";
            this.mnuTraCuu.Size = new System.Drawing.Size(227, 26);
            this.mnuTraCuu.Text = "Tra cứu phòng trống";
            this.mnuTraCuu.Click += new System.EventHandler(this.mnuTraCuu_Click);

            // menuDuyetYeuCau
            this.menuDuyetYeuCau.Name = "menuDuyetYeuCau";
            this.menuDuyetYeuCau.Size = new System.Drawing.Size(227, 26);
            this.menuDuyetYeuCau.Text = "Duyệt yêu cầu";
            this.menuDuyetYeuCau.Click += new System.EventHandler(this.menuDuyetYeuCau_Click);

            // pnlContent
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.Location = new System.Drawing.Point(0, 31);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 719);
            this.pnlContent.TabIndex = 2;

            // frmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Phòng học TDMU";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuToaNha;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuThietBi;
        private System.Windows.Forms.ToolStripMenuItem mnuGiangVien;
        private System.Windows.Forms.ToolStripMenuItem menuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnuDatPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu;
        private System.Windows.Forms.ToolStripMenuItem menuDuyetYeuCau;
        private System.Windows.Forms.Panel pnlContent;
    }
}