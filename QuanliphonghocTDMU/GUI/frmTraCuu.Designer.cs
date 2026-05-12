namespace QuanLiPhongHocTDMU
{
    partial class frmTraCuu
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

        private void InitializeComponent()
        {
            this.pnlTopAdmin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.cmbToaNha = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.flpDetail = new System.Windows.Forms.FlowLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();

            this.SuspendLayout();

            // pnlTopAdmin
            this.pnlTopAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopAdmin.Height = 80;

            // cmbToaNha
            this.cmbToaNha.Location = new System.Drawing.Point(20, 20);
            this.cmbToaNha.Size = new System.Drawing.Size(180, 36);

            // cmbCaHoc
            this.cmbCaHoc.Location = new System.Drawing.Point(220, 20);
            this.cmbCaHoc.Size = new System.Drawing.Size(120, 36);

            // dtpNgay
            this.dtpNgay.Location = new System.Drawing.Point(360, 20);
            this.dtpNgay.Size = new System.Drawing.Size(250, 36);

            // btnTimKiem
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Location = new System.Drawing.Point(640, 20);
            this.btnTimKiem.Size = new System.Drawing.Size(120, 36);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            // add control top
            this.pnlTopAdmin.Controls.Add(this.cmbToaNha);
            this.pnlTopAdmin.Controls.Add(this.cmbCaHoc);
            this.pnlTopAdmin.Controls.Add(this.dtpNgay);
            this.pnlTopAdmin.Controls.Add(this.btnTimKiem);

            // dgvPhong
            this.dgvPhong.Location = new System.Drawing.Point(20, 100);
            this.dgvPhong.Size = new System.Drawing.Size(900, 400);
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);

            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);

            // flpDetail
            this.flpDetail.Location = new System.Drawing.Point(940, 100);
            this.flpDetail.Size = new System.Drawing.Size(300, 400);
            this.flpDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDetail.AutoScroll = true;

            // frmTraCuu
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1280, 720);

            this.Controls.Add(this.flpDetail);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.pnlTopAdmin);

            this.Name = "frmTraCuu";
            this.Text = "Tra cứu phòng";

            this.Load += new System.EventHandler(this.frmTraCuu_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();

            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel pnlTopAdmin;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cmbToaNha;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCaHoc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgay;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhong;
        private System.Windows.Forms.FlowLayoutPanel flpDetail;
    }
}