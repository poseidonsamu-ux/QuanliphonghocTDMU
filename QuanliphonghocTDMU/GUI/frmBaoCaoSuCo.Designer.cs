namespace QuanLiPhongHocTDMU
{
    partial class frmBaoCaoSuCo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.btnBaoHong = new System.Windows.Forms.Button();
            this.btnDaSua = new System.Windows.Forms.Button();
            this.lblSoLuongHong = new System.Windows.Forms.Label();
            this.numSoLuongHong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongHong)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Text = "Chọn phòng:";

            this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhong.Location = new System.Drawing.Point(180, 30);
            this.cmbPhong.Size = new System.Drawing.Size(250, 30);
            this.cmbPhong.SelectedIndexChanged += new System.EventHandler(this.cmbPhong_SelectedIndexChanged);

            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.White;
            this.dgvThietBi.Location = new System.Drawing.Point(30, 80);
            this.dgvThietBi.Size = new System.Drawing.Size(900, 370);
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvThietBi_CellFormatting);
            this.dgvThietBi.SelectionChanged += new System.EventHandler(this.dgvThietBi_SelectionChanged);

            this.btnBaoHong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnBaoHong.BackColor = System.Drawing.Color.IndianRed;
            this.btnBaoHong.ForeColor = System.Drawing.Color.White;
            this.btnBaoHong.Location = new System.Drawing.Point(780, 480);
            this.btnBaoHong.Size = new System.Drawing.Size(150, 50);
            this.btnBaoHong.Text = "⚠ BÁO HỎNG";
            this.btnBaoHong.Click += new System.EventHandler(this.btnBaoHong_Click);

            this.btnDaSua.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDaSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDaSua.ForeColor = System.Drawing.Color.White;
            this.btnDaSua.Location = new System.Drawing.Point(610, 480);
            this.btnDaSua.Size = new System.Drawing.Size(150, 50);
            this.btnDaSua.Text = "✔ ĐÃ SỬA XONG";
            this.btnDaSua.Click += new System.EventHandler(this.btnDaSua_Click);

            this.lblSoLuongHong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.lblSoLuongHong.Location = new System.Drawing.Point(400, 495);
            this.lblSoLuongHong.Text = "Số lượng hỏng:";
            this.numSoLuongHong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.numSoLuongHong.Location = new System.Drawing.Point(520, 492);
            this.numSoLuongHong.Minimum = 1;

            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.numSoLuongHong, this.lblSoLuongHong, this.btnDaSua, this.btnBaoHong, this.dgvThietBi, this.cmbPhong, this.label1 });
            this.Text = "Quản Lý Sự Cố TDMU";
            this.Load += new System.EventHandler(this.frmBaoCaoSuCo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongHong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void dgvThietBi_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvThietBi.Columns[e.ColumnIndex].Name == "Tình Trạng" && e.Value != null)
            {
                if (e.Value.ToString().Contains("Hư hỏng"))
                {
                    this.dgvThietBi.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    this.dgvThietBi.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                }
            }
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Button btnBaoHong;
        private System.Windows.Forms.Button btnDaSua;
        private System.Windows.Forms.Label lblSoLuongHong;
        private System.Windows.Forms.NumericUpDown numSoLuongHong;
    }
}