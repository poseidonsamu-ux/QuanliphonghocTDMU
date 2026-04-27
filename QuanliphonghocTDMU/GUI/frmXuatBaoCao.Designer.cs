namespace QuanLiPhongHocTDMU
{
    partial class frmXuatBaoCao
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHeader.Height = 80;
            this.lblHeader.Text = "HỆ THỐNG XUẤT BÁO CÁO DỮ LIỆU";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPreview
            // 
            this.dgvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreview.BackgroundColor = System.Drawing.Color.White;
            this.dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreview.Location = new System.Drawing.Point(30, 100);
            this.dgvPreview.Size = new System.Drawing.Size(940, 450);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXuatExcel.BackColor = System.Drawing.Color.Crimson;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(375, 570);
            this.btnXuatExcel.Size = new System.Drawing.Size(250, 60);
            this.btnXuatExcel.Text = "XUẤT FILE EXCEL (.XLSX)";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // frmXuatBaoCao
            // 
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.dgvPreview);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmXuatBaoCao";
            this.Text = "Xuất Báo Cáo";
            this.Load += new System.EventHandler(this.frmXuatBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblHeader;
    }
}