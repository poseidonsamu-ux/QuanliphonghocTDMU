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
            this.pnlGiangVien = new System.Windows.Forms.Panel();
            this.btnGuiBaoCao = new System.Windows.Forms.Button();
            this.trkMucDo = new System.Windows.Forms.TrackBar();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblSuCoDangChon = new System.Windows.Forms.Label();
            this.btnBanGhe = new System.Windows.Forms.Button();
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnDien = new System.Windows.Forms.Button();
            this.btnMayLanh = new System.Windows.Forms.Button();
            this.btnMayChieu = new System.Windows.Forms.Button();
            this.lblLoaiSuCo = new System.Windows.Forms.Label();
            this.cmbPhongHoc = new System.Windows.Forms.ComboBox();
            this.lblPhongHoc = new System.Windows.Forms.Label();
            this.pnlGoiYAI = new System.Windows.Forms.Panel();
            this.flpGoiY = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGoiYTitle = new System.Windows.Forms.Label();
            this.pnlAdminDashboard = new System.Windows.Forms.Panel();
            this.btnXacNhanSuaXong = new System.Windows.Forms.Button();
            this.dgvSuCo = new System.Windows.Forms.DataGridView();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblDaXuLy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDangXyLy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGiangVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMucDo)).BeginInit();
            this.pnlGoiYAI.SuspendLayout();
            this.pnlAdminDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGiangVien
            // 
            this.pnlGiangVien.BackColor = System.Drawing.Color.White;
            this.pnlGiangVien.Controls.Add(this.btnGuiBaoCao);
            this.pnlGiangVien.Controls.Add(this.trkMucDo);
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
            this.pnlGiangVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGiangVien.Location = new System.Drawing.Point(0, 0);
            this.pnlGiangVien.Name = "pnlGiangVien";
            this.pnlGiangVien.Size = new System.Drawing.Size(400, 600);
            this.pnlGiangVien.TabIndex = 0;
            // 
            // btnGuiBaoCao
            // 
            this.btnGuiBaoCao.BackColor = System.Drawing.Color.Crimson;
            this.btnGuiBaoCao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuiBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnGuiBaoCao.Location = new System.Drawing.Point(20, 520);
            this.btnGuiBaoCao.Name = "btnGuiBaoCao";
            this.btnGuiBaoCao.Size = new System.Drawing.Size(350, 50);
            this.btnGuiBaoCao.TabIndex = 13;
            this.btnGuiBaoCao.Text = "🚀 GỬI BÁO CÁO";
            this.btnGuiBaoCao.UseVisualStyleBackColor = false;
            this.btnGuiBaoCao.Click += new System.EventHandler(this.btnGuiBaoCao_Click);
            // 
            // trkMucDo
            // 
            this.trkMucDo.Location = new System.Drawing.Point(20, 450);
            this.trkMucDo.Maximum = 5;
            this.trkMucDo.Minimum = 1;
            this.trkMucDo.Name = "trkMucDo";
            this.trkMucDo.Size = new System.Drawing.Size(350, 56);
            this.trkMucDo.TabIndex = 12;
            this.trkMucDo.Value = 3;
            // 
            // lblMucDo
            // 
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMucDo.Location = new System.Drawing.Point(20, 420);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(262, 19);
            this.lblMucDo.TabIndex = 11;
            this.lblMucDo.Text = "Mức độ nghiêm trọng (1 đến 5):";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(20, 310);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(350, 90);
            this.txtMoTa.TabIndex = 10;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(20, 280);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(117, 19);
            this.lblMoTa.TabIndex = 9;
            this.lblMoTa.Text = "Mô tả chi tiết:";
            // 
            // lblSuCoDangChon
            // 
            this.lblSuCoDangChon.AutoSize = true;
            this.lblSuCoDangChon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.lblSuCoDangChon.ForeColor = System.Drawing.Color.DimGray;
            this.lblSuCoDangChon.Location = new System.Drawing.Point(20, 240);
            this.lblSuCoDangChon.Name = "lblSuCoDangChon";
            this.lblSuCoDangChon.Size = new System.Drawing.Size(161, 20);
            this.lblSuCoDangChon.TabIndex = 8;
            this.lblSuCoDangChon.Text = "Đang chọn: Chưa có";
            // 
            // btnBanGhe
            // 
            this.btnBanGhe.Location = new System.Drawing.Point(20, 190);
            this.btnBanGhe.Name = "btnBanGhe";
            this.btnBanGhe.Size = new System.Drawing.Size(100, 40);
            this.btnBanGhe.TabIndex = 7;
            this.btnBanGhe.Text = "Bàn ghế";
            this.btnBanGhe.UseVisualStyleBackColor = true;
            this.btnBanGhe.Click += new System.EventHandler(this.btnLoaiSuCo_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.Location = new System.Drawing.Point(240, 140);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(100, 40);
            this.btnInternet.TabIndex = 6;
            this.btnInternet.Text = "Internet";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnLoaiSuCo_Click);
            // 
            // btnDien
            // 
            this.btnDien.Location = new System.Drawing.Point(130, 140);
            this.btnDien.Name = "btnDien";
            this.btnDien.Size = new System.Drawing.Size(100, 40);
            this.btnDien.TabIndex = 5;
            this.btnDien.Text = "Điện";
            this.btnDien.UseVisualStyleBackColor = true;
            this.btnDien.Click += new System.EventHandler(this.btnLoaiSuCo_Click);
            // 
            // btnMayLanh
            // 
            this.btnMayLanh.Location = new System.Drawing.Point(240, 90);
            this.btnMayLanh.Name = "btnMayLanh";
            this.btnMayLanh.Size = new System.Drawing.Size(100, 40);
            this.btnMayLanh.TabIndex = 4;
            this.btnMayLanh.Text = "Máy lạnh";
            this.btnMayLanh.UseVisualStyleBackColor = true;
            this.btnMayLanh.Click += new System.EventHandler(this.btnLoaiSuCo_Click);
            // 
            // btnMayChieu
            // 
            this.btnMayChieu.Location = new System.Drawing.Point(130, 90);
            this.btnMayChieu.Name = "btnMayChieu";
            this.btnMayChieu.Size = new System.Drawing.Size(100, 40);
            this.btnMayChieu.TabIndex = 3;
            this.btnMayChieu.Text = "Máy chiếu";
            this.btnMayChieu.UseVisualStyleBackColor = true;
            this.btnMayChieu.Click += new System.EventHandler(this.btnLoaiSuCo_Click);
            // 
            // lblLoaiSuCo
            // 
            this.lblLoaiSuCo.AutoSize = true;
            this.lblLoaiSuCo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoaiSuCo.Location = new System.Drawing.Point(20, 100);
            this.lblLoaiSuCo.Name = "lblLoaiSuCo";
            this.lblLoaiSuCo.Size = new System.Drawing.Size(100, 19);
            this.lblLoaiSuCo.TabIndex = 2;
            this.lblLoaiSuCo.Text = "Loại sự cố:";
            // 
            // cmbPhongHoc
            // 
            this.cmbPhongHoc.FormattingEnabled = true;
            // GIẢ LẬP VÀI PHÒNG, Má có thể load từ DB lên
            this.cmbPhongHoc.Items.AddRange(new object[] {
            "A1.101", "C1.101", "I1.201", "A3.102", "B1.101"});
            this.cmbPhongHoc.Location = new System.Drawing.Point(130, 30);
            this.cmbPhongHoc.Name = "cmbPhongHoc";
            this.cmbPhongHoc.Size = new System.Drawing.Size(210, 24);
            this.cmbPhongHoc.TabIndex = 1;
            // 
            // lblPhongHoc
            // 
            this.lblPhongHoc.AutoSize = true;
            this.lblPhongHoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhongHoc.Location = new System.Drawing.Point(20, 30);
            this.lblPhongHoc.Name = "lblPhongHoc";
            this.lblPhongHoc.Size = new System.Drawing.Size(98, 19);
            this.lblPhongHoc.TabIndex = 0;
            this.lblPhongHoc.Text = "Phòng học:";
            // 
            // pnlGoiYAI
            // 
            this.pnlGoiYAI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGoiYAI.Controls.Add(this.flpGoiY);
            this.pnlGoiYAI.Controls.Add(this.lblGoiYTitle);
            this.pnlGoiYAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGoiYAI.Location = new System.Drawing.Point(400, 0);
            this.pnlGoiYAI.Name = "pnlGoiYAI";
            this.pnlGoiYAI.Padding = new System.Windows.Forms.Padding(20);
            this.pnlGoiYAI.Size = new System.Drawing.Size(600, 600);
            this.pnlGoiYAI.TabIndex = 1;
            // 
            // flpGoiY
            // 
            this.flpGoiY.AutoScroll = true;
            this.flpGoiY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGoiY.Location = new System.Drawing.Point(20, 60);
            this.flpGoiY.Name = "flpGoiY";
            this.flpGoiY.Size = new System.Drawing.Size(560, 520);
            this.flpGoiY.TabIndex = 1;
            // 
            // lblGoiYTitle
            // 
            this.lblGoiYTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGoiYTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblGoiYTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblGoiYTitle.Location = new System.Drawing.Point(20, 20);
            this.lblGoiYTitle.Name = "lblGoiYTitle";
            this.lblGoiYTitle.Size = new System.Drawing.Size(560, 40);
            this.lblGoiYTitle.TabIndex = 0;
            this.lblGoiYTitle.Text = "🤖 AI GỢI Ý PHÒNG THAY THẾ";
            // 
            // pnlAdminDashboard
            // 
            this.pnlAdminDashboard.Controls.Add(this.btnXacNhanSuaXong);
            this.pnlAdminDashboard.Controls.Add(this.dgvSuCo);
            this.pnlAdminDashboard.Controls.Add(this.pnlStats);
            this.pnlAdminDashboard.Location = new System.Drawing.Point(461, 30);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(434, 490);
            this.pnlAdminDashboard.TabIndex = 2;
            this.pnlAdminDashboard.Visible = false;
            // 
            // btnXacNhanSuaXong
            // 
            this.btnXacNhanSuaXong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXacNhanSuaXong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXacNhanSuaXong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanSuaXong.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanSuaXong.Location = new System.Drawing.Point(0, 440);
            this.btnXacNhanSuaXong.Name = "btnXacNhanSuaXong";
            this.btnXacNhanSuaXong.Size = new System.Drawing.Size(434, 50);
            this.btnXacNhanSuaXong.TabIndex = 2;
            this.btnXacNhanSuaXong.Text = "✅ XÁC NHẬN ĐÃ SỬA XONG";
            this.btnXacNhanSuaXong.UseVisualStyleBackColor = false;
            this.btnXacNhanSuaXong.Click += new System.EventHandler(this.btnXacNhanSuaXong_Click);
            // 
            // dgvSuCo
            // 
            this.dgvSuCo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuCo.Location = new System.Drawing.Point(0, 100);
            this.dgvSuCo.Name = "dgvSuCo";
            this.dgvSuCo.RowHeadersWidth = 51;
            this.dgvSuCo.RowTemplate.Height = 24;
            this.dgvSuCo.Size = new System.Drawing.Size(434, 390);
            this.dgvSuCo.TabIndex = 1;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.White;
            this.pnlStats.Controls.Add(this.lblDaXuLy);
            this.pnlStats.Controls.Add(this.label6);
            this.pnlStats.Controls.Add(this.lblDangXyLy);
            this.pnlStats.Controls.Add(this.label4);
            this.pnlStats.Controls.Add(this.lblTong);
            this.pnlStats.Controls.Add(this.label1);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 0);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(434, 100);
            this.pnlStats.TabIndex = 0;
            // 
            // lblDaXuLy
            // 
            this.lblDaXuLy.AutoSize = true;
            this.lblDaXuLy.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblDaXuLy.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDaXuLy.Location = new System.Drawing.Point(300, 40);
            this.lblDaXuLy.Name = "lblDaXuLy";
            this.lblDaXuLy.Size = new System.Drawing.Size(42, 46);
            this.lblDaXuLy.TabIndex = 5;
            this.lblDaXuLy.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(300, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đã xử lý";
            // 
            // lblDangXyLy
            // 
            this.lblDangXyLy.AutoSize = true;
            this.lblDangXyLy.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblDangXyLy.ForeColor = System.Drawing.Color.Orange;
            this.lblDangXyLy.Location = new System.Drawing.Point(160, 40);
            this.lblDangXyLy.Name = "lblDangXyLy";
            this.lblDangXyLy.Size = new System.Drawing.Size(42, 46);
            this.lblDangXyLy.TabIndex = 3;
            this.lblDangXyLy.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(160, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đang xử lý";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTong.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTong.Location = new System.Drawing.Point(20, 40);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(42, 46);
            this.lblTong.TabIndex = 1;
            this.lblTong.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng sự cố";
            // 
            // frmBaoCaoSuCo
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlAdminDashboard);
            this.Controls.Add(this.pnlGoiYAI);
            this.Controls.Add(this.pnlGiangVien);
            this.Name = "frmBaoCaoSuCo";
            this.Text = "Quản lý & Báo Cáo Sự Cố";
            this.Load += new System.EventHandler(this.frmBaoCaoSuCo_Load);
            this.pnlGiangVien.ResumeLayout(false);
            this.pnlGiangVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMucDo)).EndInit();
            this.pnlGoiYAI.ResumeLayout(false);
            this.pnlAdminDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGiangVien;
        private System.Windows.Forms.Panel pnlGoiYAI;
        private System.Windows.Forms.Label lblPhongHoc;
        private System.Windows.Forms.ComboBox cmbPhongHoc;
        private System.Windows.Forms.Label lblLoaiSuCo;
        private System.Windows.Forms.Button btnBanGhe;
        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnDien;
        private System.Windows.Forms.Button btnMayLanh;
        private System.Windows.Forms.Button btnMayChieu;
        private System.Windows.Forms.Label lblSuCoDangChon;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.TrackBar trkMucDo;
        private System.Windows.Forms.Button btnGuiBaoCao;
        private System.Windows.Forms.Label lblGoiYTitle;
        private System.Windows.Forms.FlowLayoutPanel flpGoiY;
        private System.Windows.Forms.Panel pnlAdminDashboard;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaXuLy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDangXyLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.DataGridView dgvSuCo;
        private System.Windows.Forms.Button btnXacNhanSuaXong;
    }
}