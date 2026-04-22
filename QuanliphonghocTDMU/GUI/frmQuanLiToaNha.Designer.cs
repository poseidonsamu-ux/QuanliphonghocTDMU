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
            dgvToaNha = new DataGridView();
            label1 = new Label();
            txtMaToaNha = new TextBox();
            label2 = new Label();
            txtSoTang = new TextBox();
            label3 = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvToaNha).BeginInit();
            SuspendLayout();
            // 
            // dgvToaNha
            // 
            dgvToaNha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvToaNha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToaNha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToaNha.Location = new Point(45, 160);
            dgvToaNha.Name = "dgvToaNha";
            dgvToaNha.RowHeadersWidth = 51;
            dgvToaNha.Size = new Size(719, 278);
            dgvToaNha.TabIndex = 0;
            dgvToaNha.CellClick += dgvToaNha_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 30);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 9;
            label1.Text = "Tòa Nhà";
            // 
            // txtMaToaNha
            // 
            txtMaToaNha.Location = new Point(140, 27);
            txtMaToaNha.Name = "txtMaToaNha";
            txtMaToaNha.Size = new Size(200, 27);
            txtMaToaNha.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 70);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "Tầng Số";
            // 
            // txtSoTang
            // 
            txtSoTang.Location = new Point(140, 67);
            txtSoTang.Name = "txtSoTang";
            txtSoTang.Size = new Size(200, 27);
            txtSoTang.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 110);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(140, 107);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 27);
            txtGhiChu.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(380, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(490, 25);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(600, 25);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 30);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(380, 70);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(85, 30);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // frmQuanLiToaNha
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtGhiChu);
            Controls.Add(label3);
            Controls.Add(txtSoTang);
            Controls.Add(label2);
            Controls.Add(txtMaToaNha);
            Controls.Add(label1);
            Controls.Add(dgvToaNha);
            Name = "frmQuanLiToaNha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tòa Nhà";
            Load += frmQuanLiToaNha_Load;
            ((System.ComponentModel.ISupportInitialize)dgvToaNha).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvToaNha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaToaNha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
    }
}