namespace QuanLiPhongHocTDMU
{
    partial class frmDoiMatKhau
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
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.BorderRadius = 16;
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.lblTenDangNhap);
            this.pnlContainer.Controls.Add(this.txtTenDangNhap);
            this.pnlContainer.Controls.Add(this.lblMatKhauCu);
            this.pnlContainer.Controls.Add(this.txtMatKhauCu);
            this.pnlContainer.Controls.Add(this.lblMatKhauMoi);
            this.pnlContainer.Controls.Add(this.txtMatKhauMoi);
            this.pnlContainer.Controls.Add(this.lblXacNhan);
            this.pnlContainer.Controls.Add(this.txtXacNhan);
            this.pnlContainer.Controls.Add(this.btnDoiMatKhau);
            this.pnlContainer.FillColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(175, 40);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(35);
            this.pnlContainer.Size = new System.Drawing.Size(450, 560);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.lblTitle.Location = new System.Drawing.Point(32, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đổi Mật Khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(35, 90);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(124, 21);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderRadius = 8;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "";
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.txtTenDangNhap.Location = new System.Drawing.Point(35, 118);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập...";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.Size = new System.Drawing.Size(380, 42);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblMatKhauCu.Location = new System.Drawing.Point(35, 175);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(109, 21);
            this.lblMatKhauCu.TabIndex = 3;
            this.lblMatKhauCu.Text = "Mật khẩu cũ:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BorderRadius = 8;
            this.txtMatKhauCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauCu.DefaultText = "";
            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtMatKhauCu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.txtMatKhauCu.Location = new System.Drawing.Point(35, 203);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '●';
            this.txtMatKhauCu.PlaceholderText = "Nhập mật khẩu hiện tại...";
            this.txtMatKhauCu.SelectedText = "";
            this.txtMatKhauCu.Size = new System.Drawing.Size(380, 42);
            this.txtMatKhauCu.TabIndex = 4;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(35, 260);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(119, 21);
            this.lblMatKhauMoi.TabIndex = 5;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderRadius = 8;
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.DefaultText = "";
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(35, 288);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '●';
            this.txtMatKhauMoi.PlaceholderText = "Nhập mật khẩu mới...";
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(380, 42);
            this.txtMatKhauMoi.TabIndex = 6;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblXacNhan
            // 
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblXacNhan.Location = new System.Drawing.Point(35, 345);
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.Size = new System.Drawing.Size(161, 21);
            this.lblXacNhan.TabIndex = 7;
            this.lblXacNhan.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.BorderRadius = 8;
            this.txtXacNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhan.DefaultText = "";
            this.txtXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtXacNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.txtXacNhan.Location = new System.Drawing.Point(35, 373);
            this.txtXacNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '●';
            this.txtXacNhan.PlaceholderText = "Nhập lại mật khẩu mới...";
            this.txtXacNhan.SelectedText = "";
            this.txtXacNhan.Size = new System.Drawing.Size(380, 42);
            this.txtXacNhan.TabIndex = 8;
            this.txtXacNhan.UseSystemPasswordChar = true;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BorderRadius = 8;
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(35, 450);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(380, 48);
            this.btnDoiMatKhau.TabIndex = 9;
            this.btnDoiMatKhau.Text = "ĐỔI MẬT KHẨU";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhauCu;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnDoiMatKhau;
    }
}