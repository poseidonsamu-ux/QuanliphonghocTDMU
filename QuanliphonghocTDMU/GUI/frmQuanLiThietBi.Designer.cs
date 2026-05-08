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

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaTB = new TextBox();
            txtTenTB = new TextBox();
            cmbLoaiTB = new ComboBox();
            dgvThietBi = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã Thiết Bị:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 2;
            label2.Text = "Tên Thiết Bị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 120);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 4;
            label3.Text = "Loại:";
            // 
            // txtMaTB
            // 
            txtMaTB.Location = new Point(130, 27);
            txtMaTB.Name = "txtMaTB";
            txtMaTB.Size = new Size(261, 25);
            txtMaTB.TabIndex = 1;
            // 
            // txtTenTB
            // 
            txtTenTB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenTB.Location = new Point(130, 72);
            txtTenTB.Name = "txtTenTB";
            txtTenTB.Size = new Size(261, 25);
            txtTenTB.TabIndex = 3;
            // 
            // cmbLoaiTB
            // 
            cmbLoaiTB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiTB.FormattingEnabled = true;
            cmbLoaiTB.Location = new Point(130, 117);
            cmbLoaiTB.Name = "cmbLoaiTB";
            cmbLoaiTB.Size = new Size(261, 25);
            cmbLoaiTB.TabIndex = 5;
            // 
            // dgvThietBi
            // 
            dgvThietBi.AllowUserToAddRows = false;
            dgvThietBi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.BackgroundColor = Color.White;
            dgvThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietBi.Location = new Point(30, 188);
            dgvThietBi.Name = "dgvThietBi";
            dgvThietBi.ReadOnly = true;
            dgvThietBi.RowHeadersWidth = 51;
            dgvThietBi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThietBi.Size = new Size(900, 330);
            dgvThietBi.TabIndex = 6;
            dgvThietBi.CellClick += dgvThietBi_CellClick;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(650, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 45);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(810, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 45);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(650, 75);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 45);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.BackColor = SystemColors.Control;
            btnLuu.Location = new Point(810, 72);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 45);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHuy.Location = new Point(650, 126);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(280, 40);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy thao tác";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmQuanLiThietBi
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 530);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvThietBi);
            Controls.Add(cmbLoaiTB);
            Controls.Add(label3);
            Controls.Add(txtTenTB);
            Controls.Add(label2);
            Controls.Add(txtMaTB);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmQuanLiThietBi";
            Text = "Quản Lý Thiết Bị - TDMU";
            Load += frmQuanLiThietBi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.ComboBox cmbLoaiTB;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}