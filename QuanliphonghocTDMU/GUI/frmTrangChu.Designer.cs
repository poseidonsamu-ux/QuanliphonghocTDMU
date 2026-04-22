namespace QuanLiPhongHocTDMU
{
    partial class frmTrangChu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPhongDangDung = new System.Windows.Forms.Panel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblPhongDangDung = new System.Windows.Forms.Label();
            this.pnlPhongTrong = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblPhongTrong = new System.Windows.Forms.Label();
            this.pnlChoDuyet = new System.Windows.Forms.Panel();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblChoDuyet = new System.Windows.Forms.Label();
            this.dgvLichHomNay = new System.Windows.Forms.DataGridView();
            this.lblLichDayTitle = new System.Windows.Forms.Label();
            this.pnlPhongDangDung.SuspendLayout();
            this.pnlPhongTrong.SuspendLayout();
            this.pnlChoDuyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHomNay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPhongDangDung (Card Màu Xanh Dương)
            // 
            this.pnlPhongDangDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlPhongDangDung.Controls.Add(this.lblTitle1);
            this.pnlPhongDangDung.Controls.Add(this.lblPhongDangDung);
            this.pnlPhongDangDung.Location = new System.Drawing.Point(30, 30);
            this.pnlPhongDangDung.Name = "pnlPhongDangDung";
            this.pnlPhongDangDung.Size = new System.Drawing.Size(250, 120);
            this.pnlPhongDangDung.TabIndex = 0;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(15, 15);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Text = "PHÒNG ĐANG DÙNG";
            // 
            // lblPhongDangDung
            // 
            this.lblPhongDangDung.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblPhongDangDung.ForeColor = System.Drawing.Color.White;
            this.lblPhongDangDung.Location = new System.Drawing.Point(0, 45);
            this.lblPhongDangDung.Name = "lblPhongDangDung";
            this.lblPhongDangDung.Size = new System.Drawing.Size(250, 60);
            this.lblPhongDangDung.Text = "0";
            this.lblPhongDangDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPhongTrong (Card Màu Xanh Lá)
            // 
            this.pnlPhongTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlPhongTrong.Controls.Add(this.lblTitle2);
            this.pnlPhongTrong.Controls.Add(this.lblPhongTrong);
            this.pnlPhongTrong.Location = new System.Drawing.Point(310, 30);
            this.pnlPhongTrong.Name = "pnlPhongTrong";
            this.pnlPhongTrong.Size = new System.Drawing.Size(250, 120);
            this.pnlPhongTrong.TabIndex = 1;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(15, 15);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Text = "PHÒNG ĐANG TRỐNG";
            // 
            // lblPhongTrong
            // 
            this.lblPhongTrong.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblPhongTrong.ForeColor = System.Drawing.Color.White;
            this.lblPhongTrong.Location = new System.Drawing.Point(0, 45);
            this.lblPhongTrong.Name = "lblPhongTrong";
            this.lblPhongTrong.Size = new System.Drawing.Size(250, 60);
            this.lblPhongTrong.Text = "0";
            this.lblPhongTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChoDuyet (Card Màu Cam)
            // 
            this.pnlChoDuyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnlChoDuyet.Controls.Add(this.lblTitle3);
            this.pnlChoDuyet.Controls.Add(this.lblChoDuyet);
            this.pnlChoDuyet.Location = new System.Drawing.Point(590, 30);
            this.pnlChoDuyet.Name = "pnlChoDuyet";
            this.pnlChoDuyet.Size = new System.Drawing.Size(250, 120);
            this.pnlChoDuyet.TabIndex = 2;
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.ForeColor = System.Drawing.Color.White;
            this.lblTitle3.Location = new System.Drawing.Point(15, 15);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Text = "YÊU CẦU CHỜ DUYỆT";
            // 
            // lblChoDuyet
            // 
            this.lblChoDuyet.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblChoDuyet.ForeColor = System.Drawing.Color.White;
            this.lblChoDuyet.Location = new System.Drawing.Point(0, 45);
            this.lblChoDuyet.Name = "lblChoDuyet";
            this.lblChoDuyet.Size = new System.Drawing.Size(250, 60);
            this.lblChoDuyet.Text = "0";
            this.lblChoDuyet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLichDayTitle
            // 
            this.lblLichDayTitle.AutoSize = true;
            this.lblLichDayTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLichDayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLichDayTitle.Location = new System.Drawing.Point(30, 180);
            this.lblLichDayTitle.Name = "lblLichDayTitle";
            this.lblLichDayTitle.Size = new System.Drawing.Size(350, 32);
            this.lblLichDayTitle.Text = "LỊCH DẠY CỦA BẠN HÔM NAY";
            // 
            // dgvLichHomNay
            // 
            this.dgvLichHomNay.AllowUserToAddRows = false;
            this.dgvLichHomNay.AllowUserToDeleteRows = false;
            this.dgvLichHomNay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichHomNay.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHomNay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichHomNay.ColumnHeadersHeight = 40;
            this.dgvLichHomNay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvLichHomNay.Location = new System.Drawing.Point(30, 220);
            this.dgvLichHomNay.Name = "dgvLichHomNay";
            this.dgvLichHomNay.ReadOnly = true;
            this.dgvLichHomNay.RowHeadersVisible = false;
            this.dgvLichHomNay.RowTemplate.Height = 35;
            this.dgvLichHomNay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHomNay.Size = new System.Drawing.Size(810, 350);
            this.dgvLichHomNay.TabIndex = 3;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dgvLichHomNay);
            this.Controls.Add(this.lblLichDayTitle);
            this.Controls.Add(this.pnlChoDuyet);
            this.Controls.Add(this.pnlPhongTrong);
            this.Controls.Add(this.pnlPhongDangDung);
            this.Name = "frmTrangChu";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.pnlPhongDangDung.ResumeLayout(false);
            this.pnlPhongDangDung.PerformLayout();
            this.pnlPhongTrong.ResumeLayout(false);
            this.pnlPhongTrong.PerformLayout();
            this.pnlChoDuyet.ResumeLayout(false);
            this.pnlChoDuyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHomNay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPhongDangDung;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblPhongDangDung;
        private System.Windows.Forms.Panel pnlPhongTrong;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.Panel pnlChoDuyet;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblChoDuyet;
        private System.Windows.Forms.Label lblLichDayTitle;
        private System.Windows.Forms.DataGridView dgvLichHomNay;
    }
}