namespace QuanLiPhongHocTDMU
{
    partial class frmBaoCaoSuCo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvThietBi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBaoHong = new Guna.UI2.WinForms.Guna2Button();
            this.btnDaSua = new Guna.UI2.WinForms.Guna2Button();
            this.lblSoLuongHong = new System.Windows.Forms.Label();
            this.numSoLuongHong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongHong)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cmbPhong);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.FillColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(960, 80);
            this.pnlTop.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn phòng:";
            // 
            // cmbPhong
            // 
            this.cmbPhong.BackColor = System.Drawing.Color.Transparent;
            this.cmbPhong.BorderRadius = 8;
            this.cmbPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.cmbPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.cmbPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPhong.ItemHeight = 30;
            this.cmbPhong.Location = new System.Drawing.Point(180, 20);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(300, 36);
            this.cmbPhong.TabIndex = 1;
            this.cmbPhong.SelectedIndexChanged += new System.EventHandler(this.cmbPhong_SelectedIndexChanged);
            this.cmbPhong.DropDownHeight = 600;
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThietBi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.White;
            this.dgvThietBi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThietBi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThietBi.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietBi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThietBi.EnableHeadersVisualStyles = false;
            this.dgvThietBi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThietBi.Location = new System.Drawing.Point(30, 100);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersVisible = false;
            this.dgvThietBi.RowTemplate.Height = 35;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(900, 350);
            this.dgvThietBi.TabIndex = 2;
            this.dgvThietBi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThietBi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThietBi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThietBi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvThietBi_CellFormatting);
            this.dgvThietBi.SelectionChanged += new System.EventHandler(this.dgvThietBi_SelectionChanged);
            // 
            // btnBaoHong
            // 
            this.btnBaoHong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaoHong.BorderRadius = 8;
            this.btnBaoHong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnBaoHong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBaoHong.ForeColor = System.Drawing.Color.White;
            this.btnBaoHong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBaoHong.Location = new System.Drawing.Point(780, 480);
            this.btnBaoHong.Name = "btnBaoHong";
            this.btnBaoHong.Size = new System.Drawing.Size(150, 50);
            this.btnBaoHong.TabIndex = 3;
            this.btnBaoHong.Text = "⚠ BÁO HỎNG";
            this.btnBaoHong.Click += new System.EventHandler(this.btnBaoHong_Click);
            // 
            // btnDaSua
            // 
            this.btnDaSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaSua.BorderRadius = 8;
            this.btnDaSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnDaSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDaSua.ForeColor = System.Drawing.Color.White;
            this.btnDaSua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnDaSua.Location = new System.Drawing.Point(610, 480);
            this.btnDaSua.Name = "btnDaSua";
            this.btnDaSua.Size = new System.Drawing.Size(150, 50);
            this.btnDaSua.TabIndex = 4;
            this.btnDaSua.Text = "✔ ĐÃ SỬA";
            this.btnDaSua.Click += new System.EventHandler(this.btnDaSua_Click);
            // 
            // lblSoLuongHong
            // 
            this.lblSoLuongHong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuongHong.AutoSize = true;
            this.lblSoLuongHong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongHong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblSoLuongHong.Location = new System.Drawing.Point(360, 495);
            this.lblSoLuongHong.Name = "lblSoLuongHong";
            this.lblSoLuongHong.Size = new System.Drawing.Size(134, 23);
            this.lblSoLuongHong.TabIndex = 5;
            this.lblSoLuongHong.Text = "Số lượng hỏng:";
            // 
            // numSoLuongHong
            // 
            this.numSoLuongHong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numSoLuongHong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuongHong.BorderRadius = 8;
            this.numSoLuongHong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuongHong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSoLuongHong.Location = new System.Drawing.Point(500, 490);
            this.numSoLuongHong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuongHong.Name = "numSoLuongHong";
            this.numSoLuongHong.Size = new System.Drawing.Size(90, 36);
            this.numSoLuongHong.TabIndex = 6;
            this.numSoLuongHong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmBaoCaoSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.numSoLuongHong);
            this.Controls.Add(this.lblSoLuongHong);
            this.Controls.Add(this.btnDaSua);
            this.Controls.Add(this.btnBaoHong);
            this.Controls.Add(this.dgvThietBi);
            this.Name = "frmBaoCaoSuCo";
            this.Text = "Báo Cáo Sự Cố Thiết Bị";
            this.Load += new System.EventHandler(this.frmBaoCaoSuCo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongHong)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPhong;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThietBi;
        private Guna.UI2.WinForms.Guna2Button btnBaoHong;
        private Guna.UI2.WinForms.Guna2Button btnDaSua;
        private System.Windows.Forms.Label lblSoLuongHong;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuongHong;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
    }
}