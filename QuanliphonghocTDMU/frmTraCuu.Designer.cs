namespace QuanLiPhongHocTDMU
{
    partial class frmTraCuu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.cmbCa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbToaNha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpSoDo = new System.Windows.Forms.FlowLayoutPanel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lstThietBi = new System.Windows.Forms.ListBox();
            this.lblThietBiTitle = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.grpDangKy = new System.Windows.Forms.GroupBox();
            this.cmbGiangVien = new System.Windows.Forms.ComboBox();
            this.lblGV = new System.Windows.Forms.Label();
            this.btnXacNhanDat = new System.Windows.Forms.Button();
            this.txtMucDich = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhongChon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.grpDangKy.SuspendLayout();
            this.SuspendLayout();

            // groupBox1
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.cmbCa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbToaNha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc tra cứu";

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tòa Nhà";

            // cmbToaNha
            this.cmbToaNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToaNha.Location = new System.Drawing.Point(89, 37);
            this.cmbToaNha.Name = "cmbToaNha";
            this.cmbToaNha.Size = new System.Drawing.Size(160, 28);
            this.cmbToaNha.TabIndex = 1;

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày";

            // dtpNgay
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(320, 37);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(130, 27);
            this.dtpNgay.TabIndex = 3;

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ca Học";

            // cmbCa
            this.cmbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCa.Location = new System.Drawing.Point(531, 37);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.Size = new System.Drawing.Size(100, 28);
            this.cmbCa.TabIndex = 5;

            // btnTraCuu
            this.btnTraCuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(650, 32);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(120, 38);
            this.btnTraCuu.TabIndex = 6;
            this.btnTraCuu.Text = "Xem Sơ Đồ";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);

            // flpSoDo
            this.flpSoDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left))));
            this.flpSoDo.AutoScroll = true;
            this.flpSoDo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpSoDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSoDo.Location = new System.Drawing.Point(20, 115);
            this.flpSoDo.Name = "flpSoDo";
            this.flpSoDo.Size = new System.Drawing.Size(650, 430);
            this.flpSoDo.TabIndex = 1;

            // grpThongTin (KHU VỰC HIỂN THỊ THÔNG TIN PHÒNG MỚI THÊM)
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.lstThietBi);
            this.grpThongTin.Controls.Add(this.lblThietBiTitle);
            this.grpThongTin.Controls.Add(this.lblSucChua);
            this.grpThongTin.Controls.Add(this.lblLoaiPhong);
            this.grpThongTin.Location = new System.Drawing.Point(685, 115);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(295, 185);
            this.grpThongTin.TabIndex = 2;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chi tiết";

            // lblLoaiPhong
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblLoaiPhong.Location = new System.Drawing.Point(15, 30);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(107, 20);
            this.lblLoaiPhong.TabIndex = 0;
            this.lblLoaiPhong.Text = "Loại phòng: -";

            // lblSucChua
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSucChua.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSucChua.Location = new System.Drawing.Point(15, 60);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(95, 20);
            this.lblSucChua.TabIndex = 1;
            this.lblSucChua.Text = "Sức chứa: -";

            // lblThietBiTitle
            this.lblThietBiTitle.AutoSize = true;
            this.lblThietBiTitle.Location = new System.Drawing.Point(15, 90);
            this.lblThietBiTitle.Name = "lblThietBiTitle";
            this.lblThietBiTitle.Size = new System.Drawing.Size(130, 20);
            this.lblThietBiTitle.TabIndex = 2;
            this.lblThietBiTitle.Text = "Thiết bị có sẵn:";

            // lstThietBi
            this.lstThietBi.BackColor = System.Drawing.Color.LightYellow;
            this.lstThietBi.FormattingEnabled = true;
            this.lstThietBi.ItemHeight = 20;
            this.lstThietBi.Location = new System.Drawing.Point(15, 115);
            this.lstThietBi.Name = "lstThietBi";
            this.lstThietBi.Size = new System.Drawing.Size(265, 64);
            this.lstThietBi.TabIndex = 3;

            // grpDangKy
            this.grpDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDangKy.Controls.Add(this.cmbGiangVien);
            this.grpDangKy.Controls.Add(this.lblGV);
            this.grpDangKy.Controls.Add(this.btnXacNhanDat);
            this.grpDangKy.Controls.Add(this.txtMucDich);
            this.grpDangKy.Controls.Add(this.label5);
            this.grpDangKy.Controls.Add(this.txtPhongChon);
            this.grpDangKy.Controls.Add(this.label4);
            this.grpDangKy.Location = new System.Drawing.Point(685, 305);
            this.grpDangKy.Name = "grpDangKy";
            this.grpDangKy.Size = new System.Drawing.Size(295, 240);
            this.grpDangKy.TabIndex = 3;
            this.grpDangKy.TabStop = false;
            this.grpDangKy.Text = "Thao tác đăng ký";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phòng chọn:";

            // txtPhongChon
            this.txtPhongChon.Enabled = false;
            this.txtPhongChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtPhongChon.Location = new System.Drawing.Point(120, 32);
            this.txtPhongChon.Name = "txtPhongChon";
            this.txtPhongChon.Size = new System.Drawing.Size(160, 27);
            this.txtPhongChon.TabIndex = 1;

            // lblGV
            this.lblGV.AutoSize = true;
            this.lblGV.Location = new System.Drawing.Point(15, 70);
            this.lblGV.Name = "lblGV";
            this.lblGV.Size = new System.Drawing.Size(81, 20);
            this.lblGV.TabIndex = 2;
            this.lblGV.Text = "Giảng viên:";

            // cmbGiangVien
            this.cmbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiangVien.Location = new System.Drawing.Point(120, 67);
            this.cmbGiangVien.Name = "cmbGiangVien";
            this.cmbGiangVien.Size = new System.Drawing.Size(160, 28);
            this.cmbGiangVien.TabIndex = 3;

            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mục đích sử dụng:";

            // txtMucDich
            this.txtMucDich.Location = new System.Drawing.Point(15, 130);
            this.txtMucDich.Multiline = true;
            this.txtMucDich.Name = "txtMucDich";
            this.txtMucDich.Size = new System.Drawing.Size(265, 45);
            this.txtMucDich.TabIndex = 5;

            // btnXacNhanDat
            this.btnXacNhanDat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXacNhanDat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDat.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDat.Location = new System.Drawing.Point(15, 185);
            this.btnXacNhanDat.Name = "btnXacNhanDat";
            this.btnXacNhanDat.Size = new System.Drawing.Size(265, 40);
            this.btnXacNhanDat.TabIndex = 6;
            this.btnXacNhanDat.Text = "ĐĂNG KÝ PHÒNG";
            this.btnXacNhanDat.UseVisualStyleBackColor = false;
            this.btnXacNhanDat.Click += new System.EventHandler(this.btnXacNhanDat_Click);

            // frmTraCuu
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.grpDangKy);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.flpSoDo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuu";
            this.Text = "Tra Cứu & Đăng Ký Trực Quan";
            this.Load += new System.EventHandler(this.frmTraCuu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDangKy.ResumeLayout(false);
            this.grpDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbToaNha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.FlowLayoutPanel flpSoDo;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblThietBiTitle;
        private System.Windows.Forms.ListBox lstThietBi;
        private System.Windows.Forms.GroupBox grpDangKy;
        private System.Windows.Forms.ComboBox cmbGiangVien;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.Button btnXacNhanDat;
        private System.Windows.Forms.TextBox txtMucDich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhongChon;
        private System.Windows.Forms.Label label4;
    }
}