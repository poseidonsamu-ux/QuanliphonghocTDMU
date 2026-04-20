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
            lblWelcome = new Label();
            pnlPhong = new Panel();
            lblPhongTrong = new Label();
            label2 = new Label();
            pnlDuyet = new Panel();
            lblChoDuyet = new Label();
            label4 = new Label();
            pnlThietBi = new Panel();
            lblThietBi = new Label();
            label6 = new Label();
            pnlPhong.SuspendLayout();
            pnlDuyet.SuspendLayout();
            pnlThietBi.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(397, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(186, 46);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "XIN CHÀO";
            // 
            // pnlPhong
            // 
            pnlPhong.BackColor = Color.MediumSeaGreen;
            pnlPhong.Controls.Add(lblPhongTrong);
            pnlPhong.Controls.Add(label2);
            pnlPhong.Location = new Point(50, 130);
            pnlPhong.Name = "pnlPhong";
            pnlPhong.Size = new Size(260, 150);
            pnlPhong.TabIndex = 1;
            // 
            // lblPhongTrong
            // 
            lblPhongTrong.AutoSize = true;
            lblPhongTrong.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblPhongTrong.ForeColor = Color.White;
            lblPhongTrong.Location = new Point(20, 50);
            lblPhongTrong.Name = "lblPhongTrong";
            lblPhongTrong.Size = new Size(70, 81);
            lblPhongTrong.TabIndex = 1;
            lblPhongTrong.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 0;
            label2.Text = "PHÒNG SẴN SÀNG";
            // 
            // pnlDuyet
            // 
            pnlDuyet.BackColor = Color.IndianRed;
            pnlDuyet.Controls.Add(lblChoDuyet);
            pnlDuyet.Controls.Add(label4);
            pnlDuyet.Location = new Point(350, 130);
            pnlDuyet.Name = "pnlDuyet";
            pnlDuyet.Size = new Size(260, 150);
            pnlDuyet.TabIndex = 2;
            // 
            // lblChoDuyet
            // 
            lblChoDuyet.AutoSize = true;
            lblChoDuyet.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblChoDuyet.ForeColor = Color.White;
            lblChoDuyet.Location = new Point(20, 50);
            lblChoDuyet.Name = "lblChoDuyet";
            lblChoDuyet.Size = new Size(70, 81);
            lblChoDuyet.TabIndex = 1;
            lblChoDuyet.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 0;
            label4.Text = "ĐƠN CHỜ DUYỆT";
            // 
            // pnlThietBi
            // 
            pnlThietBi.BackColor = Color.CornflowerBlue;
            pnlThietBi.Controls.Add(lblThietBi);
            pnlThietBi.Controls.Add(label6);
            pnlThietBi.Location = new Point(650, 130);
            pnlThietBi.Name = "pnlThietBi";
            pnlThietBi.Size = new Size(260, 150);
            pnlThietBi.TabIndex = 3;
            // 
            // lblThietBi
            // 
            lblThietBi.AutoSize = true;
            lblThietBi.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblThietBi.ForeColor = Color.White;
            lblThietBi.Location = new Point(20, 50);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(70, 81);
            lblThietBi.TabIndex = 1;
            lblThietBi.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 0;
            label6.Text = "TỔNG THIẾT BỊ";
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(960, 560);
            Controls.Add(pnlThietBi);
            Controls.Add(pnlDuyet);
            Controls.Add(pnlPhong);
            Controls.Add(lblWelcome);
            Name = "frmTrangChu";
            Text = "Trang Chủ";
            Load += frmTrangChu_Load;
            pnlPhong.ResumeLayout(false);
            pnlPhong.PerformLayout();
            pnlDuyet.ResumeLayout(false);
            pnlDuyet.PerformLayout();
            pnlThietBi.ResumeLayout(false);
            pnlThietBi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlPhong;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDuyet;
        private System.Windows.Forms.Label lblChoDuyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlThietBi;
        private System.Windows.Forms.Label lblThietBi;
        private System.Windows.Forms.Label label6;
    }
}