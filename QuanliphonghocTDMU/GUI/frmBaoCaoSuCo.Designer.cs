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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.btnBaoHong = new System.Windows.Forms.Button();
            this.btnDaSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn phòng cần báo cáo: ";

            // cmbPhong
            this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(298, 30);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(250, 31);
            this.cmbPhong.TabIndex = 1;
            this.cmbPhong.SelectedIndexChanged += new System.EventHandler(this.cmbPhong_SelectedIndexChanged);

            // dgvThietBi
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Location = new System.Drawing.Point(30, 110);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.ReadOnly = true;
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(900, 340);
            this.dgvThietBi.TabIndex = 2;

            // btnBaoHong
            this.btnBaoHong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaoHong.BackColor = System.Drawing.Color.IndianRed;
            this.btnBaoHong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaoHong.ForeColor = System.Drawing.Color.White;
            this.btnBaoHong.Location = new System.Drawing.Point(780, 480);
            this.btnBaoHong.Name = "btnBaoHong";
            this.btnBaoHong.Size = new System.Drawing.Size(150, 50);
            this.btnBaoHong.TabIndex = 3;
            this.btnBaoHong.Text = "⚠ BÁO HỎNG";
            this.btnBaoHong.UseVisualStyleBackColor = false;
            this.btnBaoHong.Click += new System.EventHandler(this.btnBaoHong_Click);

            // btnDaSua
            this.btnDaSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDaSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDaSua.ForeColor = System.Drawing.Color.White;
            this.btnDaSua.Location = new System.Drawing.Point(610, 480);
            this.btnDaSua.Name = "btnDaSua";
            this.btnDaSua.Size = new System.Drawing.Size(150, 50);
            this.btnDaSua.TabIndex = 4;
            this.btnDaSua.Text = "✔ ĐÃ SỬA XONG";
            this.btnDaSua.UseVisualStyleBackColor = false;
            this.btnDaSua.Click += new System.EventHandler(this.btnDaSua_Click);

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "* Click chọn một thiết bị bên dưới để thao tác";

            // frmBaoCaoSuCo
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDaSua);
            this.Controls.Add(this.btnBaoHong);
            this.Controls.Add(this.dgvThietBi);
            this.Controls.Add(this.cmbPhong);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoSuCo";
            this.Text = "Báo Cáo Sự Cố Thiết Bị";
            this.Load += new System.EventHandler(this.frmBaoCaoSuCo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Button btnBaoHong;
        private System.Windows.Forms.Button btnDaSua;
        private System.Windows.Forms.Label label2;
    }
}