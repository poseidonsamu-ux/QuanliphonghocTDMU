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

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaToaNha = new TextBox();
            txtSoTang = new TextBox();
            txtGhiChu = new TextBox();
            dgvToaNha = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvToaNha).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 11;
            label1.Text = "Mã Tòa Nhà:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 10;
            label2.Text = "Số Tầng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 9;
            label3.Text = "Ghi Chú:";
            // 
            // txtMaToaNha
            // 
            txtMaToaNha.Location = new Point(160, 42);
            txtMaToaNha.Margin = new Padding(4, 5, 4, 5);
            txtMaToaNha.Name = "txtMaToaNha";
            txtMaToaNha.Size = new Size(199, 27);
            txtMaToaNha.TabIndex = 8;
            // 
            // txtSoTang
            // 
            txtSoTang.Location = new Point(160, 103);
            txtSoTang.Margin = new Padding(4, 5, 4, 5);
            txtSoTang.Name = "txtSoTang";
            txtSoTang.Size = new Size(199, 27);
            txtSoTang.TabIndex = 7;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGhiChu.Location = new Point(160, 165);
            txtGhiChu.Margin = new Padding(4, 5, 4, 5);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(199, 27);
            txtGhiChu.TabIndex = 6;
            // 
            // dgvToaNha
            // 
            dgvToaNha.AllowUserToAddRows = false;
            dgvToaNha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvToaNha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToaNha.BackgroundColor = Color.White;
            dgvToaNha.ColumnHeadersHeight = 29;
            dgvToaNha.Location = new Point(40, 247);
            dgvToaNha.Margin = new Padding(4, 5, 4, 5);
            dgvToaNha.Name = "dgvToaNha";
            dgvToaNha.ReadOnly = true;
            dgvToaNha.RowHeadersWidth = 51;
            dgvToaNha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvToaNha.Size = new Size(1200, 522);
            dgvToaNha.TabIndex = 5;
            dgvToaNha.CellClick += dgvToaNha_CellClick;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(396, 37);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(108, 35);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(523, 37);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(396, 101);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(108, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.BackColor = SystemColors.Control;
            btnLuu.Location = new Point(523, 101);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 34);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHuy.Location = new Point(396, 164);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(219, 29);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy thao tác";
            btnHuy.Click += btnHuy_Click;
            // 
            // frmQuanLiToaNha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 815);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvToaNha);
            Controls.Add(txtGhiChu);
            Controls.Add(txtSoTang);
            Controls.Add(txtMaToaNha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmQuanLiToaNha";
            Text = "Quản Lý Tòa Nhà - TDMU";
            Load += frmQuanLiToaNha_Load;
            ((System.ComponentModel.ISupportInitialize)dgvToaNha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaToaNha;
        private System.Windows.Forms.TextBox txtSoTang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgvToaNha;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}