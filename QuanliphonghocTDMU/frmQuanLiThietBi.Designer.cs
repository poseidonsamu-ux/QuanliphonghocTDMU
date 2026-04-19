namespace QuanLiPhongHocTDMU
{
    partial class frmQuanLiThietBi
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
            dgvThietBi = new DataGridView();
            label1 = new Label();
            txtMaTB = new TextBox();
            label2 = new Label();
            txtTenTB = new TextBox();
            label3 = new Label();
            cmbLoaiTB = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).BeginInit();
            SuspendLayout();
            // 
            // dgvThietBi
            // 
            dgvThietBi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietBi.Location = new Point(30, 150);
            dgvThietBi.Name = "dgvThietBi";
            dgvThietBi.RowHeadersWidth = 51;
            dgvThietBi.Size = new Size(740, 270);
            dgvThietBi.TabIndex = 0;
            dgvThietBi.CellClick += dgvThietBi_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã Thiết Bị";
            // 
            // txtMaTB
            // 
            txtMaTB.Location = new Point(120, 27);
            txtMaTB.Name = "txtMaTB";
            txtMaTB.Size = new Size(200, 27);
            txtMaTB.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên Thiết Bị";
            // 
            // txtTenTB
            // 
            txtTenTB.Location = new Point(120, 77);
            txtTenTB.Name = "txtTenTB";
            txtTenTB.Size = new Size(200, 27);
            txtTenTB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 30);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "Loại Thiết Bị";
            // 
            // cmbLoaiTB
            // 
            cmbLoaiTB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiTB.FormattingEnabled = true;
            cmbLoaiTB.Items.AddRange(new object[] { "Điện tử", "Điện lạnh", "Âm thanh", "Nội thất", "Điện cơ" });
            cmbLoaiTB.Location = new Point(460, 27);
            cmbLoaiTB.Name = "cmbLoaiTB";
            cmbLoaiTB.Size = new Size(200, 28);
            cmbLoaiTB.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(370, 75);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(465, 75);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 30);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(560, 75);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 30);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(655, 75);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(85, 30);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // frmQuanLiThietBi
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cmbLoaiTB);
            Controls.Add(label3);
            Controls.Add(txtTenTB);
            Controls.Add(label2);
            Controls.Add(txtMaTB);
            Controls.Add(label1);
            Controls.Add(dgvThietBi);
            Name = "frmQuanLiThietBi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thiết Bị";
            Load += frmQuanLiThietBi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiTB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}