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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoLoc = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.cmbCa = new System.Windows.Forms.ComboBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cmbToaNha = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.flpSoDo = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.lblThietBiTitle = new System.Windows.Forms.Label();
            this.lstThietBi = new System.Windows.Forms.ListBox();
            this.lblPhongChonTitle = new System.Windows.Forms.Label();
            this.txtPhongChon = new System.Windows.Forms.TextBox();
            this.lblMucDichTitle = new System.Windows.Forms.Label();
            this.txtMucDich = new System.Windows.Forms.TextBox();
            this.lblGV = new System.Windows.Forms.Label();
            this.cmbGiangVien = new System.Windows.Forms.ComboBox();
            this.btnXacNhanDat = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.grpBoLoc.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain (Chia hàng dọc: Lọc và Nội dung)
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.grpBoLoc, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelContent, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1200, 750);
            // 
            // grpBoLoc
            // 
            this.grpBoLoc.Controls.Add(this.btnTraCuu);
            this.grpBoLoc.Controls.Add(this.cmbCa);
            this.grpBoLoc.Controls.Add(this.dtpNgay);
            this.grpBoLoc.Controls.Add(this.cmbToaNha);
            this.grpBoLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoLoc.Location = new System.Drawing.Point(3, 3);
            this.grpBoLoc.Name = "grpBoLoc";
            this.grpBoLoc.Size = new System.Drawing.Size(1194, 74);
            this.grpBoLoc.TabIndex = 0;
            this.grpBoLoc.TabStop = false;
            this.grpBoLoc.Text = "Bộ lọc tra cứu";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(550, 25);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(120, 35);
            this.btnTraCuu.TabIndex = 3;
            this.btnTraCuu.Text = "Xem Sơ Đồ";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // cmbToaNha, dtpNgay, cmbCa
            this.cmbToaNha.Location = new System.Drawing.Point(20, 30); this.cmbToaNha.Size = new System.Drawing.Size(160, 24);
            this.dtpNgay.Location = new System.Drawing.Point(200, 30); this.dtpNgay.Size = new System.Drawing.Size(200, 24);
            this.cmbCa.Location = new System.Drawing.Point(420, 30); this.cmbCa.Size = new System.Drawing.Size(100, 24);
            // 
            // tableLayoutPanelContent (Chia cột ngang: 75% Sơ đồ, 25% Chi tiết)
            // 
            this.tableLayoutPanelContent.ColumnCount = 2;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelContent.Controls.Add(this.flpSoDo, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.pnlDetail, 1, 0);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 1;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(1194, 664);
            // 
            // flpSoDo
            // 
            this.flpSoDo.AutoScroll = true;
            this.flpSoDo.BackColor = System.Drawing.Color.White;
            this.flpSoDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSoDo.Location = new System.Drawing.Point(3, 3);
            this.flpSoDo.Name = "flpSoDo";
            this.flpSoDo.Size = new System.Drawing.Size(889, 658);
            // 
            // pnlDetail (KHUNG THÔNG TIN CHI TIẾT BÊN PHẢI)
            // 
            this.pnlDetail.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDetail.Controls.Add(this.lblLoaiPhong);
            this.pnlDetail.Controls.Add(this.lblSucChua);
            this.pnlDetail.Controls.Add(this.lblThietBiTitle);
            this.pnlDetail.Controls.Add(this.lstThietBi);
            this.pnlDetail.Controls.Add(this.lblPhongChonTitle);
            this.pnlDetail.Controls.Add(this.txtPhongChon);
            this.pnlDetail.Controls.Add(this.lblMucDichTitle);
            this.pnlDetail.Controls.Add(this.txtMucDich);
            this.pnlDetail.Controls.Add(this.lblGV);
            this.pnlDetail.Controls.Add(this.cmbGiangVien);
            this.pnlDetail.Controls.Add(this.btnXacNhanDat);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(898, 3);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetail.Size = new System.Drawing.Size(293, 658);
            // 
            // lblLoaiPhong & lblSucChua
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(20, 20);
            this.lblLoaiPhong.Text = "Loại phòng: -";
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Blue;

            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(20, 50);
            this.lblSucChua.Text = "Sức chứa: -";
            this.lblSucChua.ForeColor = System.Drawing.Color.Blue;

            // Thiết bị
            this.lblThietBiTitle.AutoSize = true;
            this.lblThietBiTitle.Location = new System.Drawing.Point(20, 90);
            this.lblThietBiTitle.Text = "Thiết bị có sẵn:";

            this.lstThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lstThietBi.Location = new System.Drawing.Point(20, 115);
            this.lstThietBi.Size = new System.Drawing.Size(250, 120);

            // Phòng chọn
            this.lblPhongChonTitle.AutoSize = true;
            this.lblPhongChonTitle.Location = new System.Drawing.Point(20, 255);
            this.lblPhongChonTitle.Text = "Phòng đã chọn:";

            this.txtPhongChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhongChon.Location = new System.Drawing.Point(130, 252);
            this.txtPhongChon.ReadOnly = true;
            this.txtPhongChon.Size = new System.Drawing.Size(140, 22);

            // Mục đích
            this.lblMucDichTitle.AutoSize = true;
            this.lblMucDichTitle.Location = new System.Drawing.Point(20, 290);
            this.lblMucDichTitle.Text = "Mục đích sử dụng:";

            this.txtMucDich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMucDich.Location = new System.Drawing.Point(20, 315);
            this.txtMucDich.Multiline = true;
            this.txtMucDich.Size = new System.Drawing.Size(250, 60);

            // Giảng viên
            this.lblGV.AutoSize = true;
            this.lblGV.Location = new System.Drawing.Point(20, 390);
            this.lblGV.Text = "Giảng viên mượn:";

            this.cmbGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGiangVien.Location = new System.Drawing.Point(20, 415);
            this.cmbGiangVien.Size = new System.Drawing.Size(250, 24);

            // Nút đăng ký
            this.btnXacNhanDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhanDat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXacNhanDat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDat.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDat.Location = new System.Drawing.Point(20, 470);
            this.btnXacNhanDat.Name = "btnXacNhanDat";
            this.btnXacNhanDat.Size = new System.Drawing.Size(250, 45);
            this.btnXacNhanDat.Text = "ĐĂNG KÝ PHÒNG";
            this.btnXacNhanDat.UseVisualStyleBackColor = false;
            this.btnXacNhanDat.Click += new System.EventHandler(this.btnXacNhanDat_Click);
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "frmTraCuu";
            this.Text = "Hệ thống Quản lý Phòng học TDMU - Tra Cứu";
            this.Load += new System.EventHandler(this.frmTraCuu_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.grpBoLoc.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox grpBoLoc;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.ComboBox cmbCa;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cmbToaNha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private System.Windows.Forms.FlowLayoutPanel flpSoDo;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblThietBiTitle;
        private System.Windows.Forms.ListBox lstThietBi;
        private System.Windows.Forms.Label lblPhongChonTitle;
        private System.Windows.Forms.TextBox txtPhongChon;
        private System.Windows.Forms.Label lblMucDichTitle;
        private System.Windows.Forms.TextBox txtMucDich;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.ComboBox cmbGiangVien;
        private System.Windows.Forms.Button btnXacNhanDat;
    }
}