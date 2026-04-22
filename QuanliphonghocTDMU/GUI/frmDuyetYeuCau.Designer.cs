namespace QuanLiPhongHocTDMU
{
    partial class frmDuyetYeuCau
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
            this.dgvYeuCau = new System.Windows.Forms.DataGridView();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH YÊU CẦU ĐANG CHỜ DUYỆT";

            // lblTrangThai
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrangThai.Location = new System.Drawing.Point(30, 70);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(161, 23);
            this.lblTrangThai.TabIndex = 1;
            this.lblTrangThai.Text = "Đang chọn: Chưa có";

            // dgvYeuCau
            this.dgvYeuCau.AllowUserToAddRows = false;
            this.dgvYeuCau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvYeuCau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYeuCau.Location = new System.Drawing.Point(30, 110);
            this.dgvYeuCau.Name = "dgvYeuCau";
            this.dgvYeuCau.ReadOnly = true;
            this.dgvYeuCau.RowHeadersWidth = 51;
            this.dgvYeuCau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYeuCau.Size = new System.Drawing.Size(900, 350);
            this.dgvYeuCau.TabIndex = 2;
            this.dgvYeuCau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYeuCau_CellClick);

            // btnDuyet
            this.btnDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuyet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(620, 480);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(140, 50);
            this.btnDuyet.TabIndex = 3;
            this.btnDuyet.Text = "✔ DUYỆT";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);

            // btnTuChoi
            this.btnTuChoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTuChoi.BackColor = System.Drawing.Color.IndianRed;
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTuChoi.ForeColor = System.Drawing.Color.White;
            this.btnTuChoi.Location = new System.Drawing.Point(790, 480);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(140, 50);
            this.btnTuChoi.TabIndex = 4;
            this.btnTuChoi.Text = "✖ TỪ CHỐI";
            this.btnTuChoi.UseVisualStyleBackColor = false;
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);

            // btnLamMoi
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLamMoi.Location = new System.Drawing.Point(30, 480);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới (F5)";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // frmDuyetYeuCau
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.dgvYeuCau);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.label1);
            this.Name = "frmDuyetYeuCau";
            this.Text = "Duyệt Yêu Cầu Mượn Phòng";
            this.Load += new System.EventHandler(this.frmDuyetYeuCau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.DataGridView dgvYeuCau;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Button btnTuChoi;
        private System.Windows.Forms.Button btnLamMoi;
    }
}