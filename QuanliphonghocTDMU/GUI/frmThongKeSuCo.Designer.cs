namespace QuanLiPhongHocTDMU.GUI
{
    partial class frmThongKeSuCo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSuCo;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom; // Thêm Panel để chứa nút bấm

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
            this.dgvSuCo = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top; // Ép tiêu đề luôn nằm trên cùng
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(884, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ SỰ CỐ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // Căn giữa chữ
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnXuatExcel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom; // Ép panel nằm dưới cùng
            this.pnlBottom.Location = new System.Drawing.Point(0, 410);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(884, 71);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))); // Nỏ neo nút vào góc phải dưới
            this.btnXuatExcel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Location = new System.Drawing.Point(742, 15);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(130, 40);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // dgvSuCo
            // 
            this.dgvSuCo.AllowUserToAddRows = false;
            this.dgvSuCo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuCo.Dock = System.Windows.Forms.DockStyle.Fill; // Lấp đầy khoảng trống còn lại ở giữa
            this.dgvSuCo.Location = new System.Drawing.Point(0, 60);
            this.dgvSuCo.Name = "dgvSuCo";
            this.dgvSuCo.ReadOnly = true;
            this.dgvSuCo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuCo.Size = new System.Drawing.Size(884, 350);
            this.dgvSuCo.TabIndex = 1;
            // 
            // frmThongKeSuCo
            // 
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.dgvSuCo);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmThongKeSuCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Sự Cố";
            this.Load += new System.EventHandler(this.frmThongKeSuCo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}