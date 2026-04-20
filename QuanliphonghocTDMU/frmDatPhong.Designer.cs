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
            groupBox1 = new GroupBox();
            btnTimPhong = new Button();
            cmbCaHoc = new ComboBox();
            label2 = new Label();
            dtpNgayDat = new DateTimePicker();
            label1 = new Label();
            dgvPhongTrong = new DataGridView();
            groupBox2 = new GroupBox();
            cmbGiangVien = new ComboBox();
            lblGiangVien = new Label();
            btnDatPhong = new Button();
            txtMucDich = new TextBox();
            label4 = new Label();
            txtPhongChon = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongTrong).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimPhong);
            groupBox1.Controls.Add(cmbCaHoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpNgayDat);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BƯỚC 1: TÌM PHÒNG TRỐNG";
            // 
            // btnTimPhong
            // 
            btnTimPhong.BackColor = Color.MediumSeaGreen;
            btnTimPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimPhong.ForeColor = Color.White;
            btnTimPhong.Location = new Point(673, 35);
            btnTimPhong.Name = "btnTimPhong";
            btnTimPhong.Size = new Size(120, 40);
            btnTimPhong.TabIndex = 4;
            btnTimPhong.Text = "Tìm Phòng";
            btnTimPhong.UseVisualStyleBackColor = false;
            btnTimPhong.Click += btnTimPhong_Click;
            // 
            // cmbCaHoc
            // 
            cmbCaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaHoc.FormattingEnabled = true;
            cmbCaHoc.Location = new Point(447, 41);
            cmbCaHoc.Name = "cmbCaHoc";
            cmbCaHoc.Size = new Size(150, 28);
            cmbCaHoc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 44);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Ca học";
            // 
            // dtpNgayDat
            // 
            dtpNgayDat.Format = DateTimePickerFormat.Short;
            dtpNgayDat.Location = new Point(130, 42);
            dtpNgayDat.Name = "dtpNgayDat";
            dtpNgayDat.Size = new Size(150, 27);
            dtpNgayDat.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày đặt";
            // 
            // dgvPhongTrong
            // 
            dgvPhongTrong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhongTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongTrong.Location = new Point(30, 140);
            dgvPhongTrong.Name = "dgvPhongTrong";
            dgvPhongTrong.RowHeadersWidth = 51;
            dgvPhongTrong.Size = new Size(900, 250);
            dgvPhongTrong.TabIndex = 1;
            dgvPhongTrong.CellClick += dgvPhongTrong_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(cmbGiangVien);
            groupBox2.Controls.Add(lblGiangVien);
            groupBox2.Controls.Add(btnDatPhong);
            groupBox2.Controls.Add(txtMucDich);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPhongChon);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(30, 410);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(900, 120);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "BƯỚC 2: XÁC NHẬN MƯỢN";
            // 
            // cmbGiangVien
            // 
            cmbGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGiangVien.FormattingEnabled = true;
            cmbGiangVien.Location = new Point(520, 32);
            cmbGiangVien.Name = "cmbGiangVien";
            cmbGiangVien.Size = new Size(180, 28);
            cmbGiangVien.TabIndex = 6;
            // 
            // lblGiangVien
            // 
            lblGiangVien.AutoSize = true;
            lblGiangVien.Location = new Point(430, 35);
            lblGiangVien.Name = "lblGiangVien";
            lblGiangVien.Size = new Size(79, 20);
            lblGiangVien.TabIndex = 5;
            lblGiangVien.Text = "Giảng viên";
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.DodgerBlue;
            btnDatPhong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(740, 45);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(130, 45);
            btnDatPhong.TabIndex = 4;
            btnDatPhong.Text = "Xác nhận";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // txtMucDich
            // 
            txtMucDich.Location = new Point(130, 77);
            txtMucDich.Name = "txtMucDich";
            txtMucDich.Size = new Size(570, 27);
            txtMucDich.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 80);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 2;
            label4.Text = "Mục đích";
            // 
            // txtPhongChon
            // 
            txtPhongChon.Enabled = false;
            txtPhongChon.Location = new Point(130, 32);
            txtPhongChon.Name = "txtPhongChon";
            txtPhongChon.Size = new Size(150, 27);
            txtPhongChon.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(40, 35);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 0;
            label3.Text = "Phòng đặt";
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 560);
            Controls.Add(groupBox2);
            Controls.Add(dgvPhongTrong);
            Controls.Add(groupBox1);
            Name = "frmDatPhong";
            Text = "Đăng Ký Mượn Phòng";
            Load += frmDatPhong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongTrong).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimPhong;
        private System.Windows.Forms.ComboBox cmbCaHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhongTrong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.TextBox txtMucDich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhongChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGiangVien;
        private System.Windows.Forms.Label lblGiangVien;
    }
}