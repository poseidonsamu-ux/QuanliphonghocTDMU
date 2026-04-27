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
            tableLayoutPanelMain = new TableLayoutPanel();
            grpBoLoc = new GroupBox();
            btnTraCuu = new Button();
            cmbCa = new ComboBox();
            dtpNgay = new DateTimePicker();
            cmbToaNha = new ComboBox();
            tableLayoutPanelContent = new TableLayoutPanel();
            flpSoDo = new FlowLayoutPanel();
            pnlDetail = new Panel();
            lblNguoiDat = new Label();
            btnXoaDat = new Button();
            lblLoaiPhong = new Label();
            lblSucChua = new Label();
            lblThietBiTitle = new Label();
            lstThietBi = new ListBox();
            lblPhongChonTitle = new Label();
            txtPhongChon = new TextBox();
            lblMucDichTitle = new Label();
            txtMucDich = new TextBox();
            lblGV = new Label();
            cmbGiangVien = new ComboBox();
            btnXacNhanDat = new Button();
            tableLayoutPanelMain.SuspendLayout();
            grpBoLoc.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            pnlDetail.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(grpBoLoc, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelContent, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1200, 938);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // grpBoLoc
            // 
            grpBoLoc.Controls.Add(btnTraCuu);
            grpBoLoc.Controls.Add(cmbCa);
            grpBoLoc.Controls.Add(dtpNgay);
            grpBoLoc.Controls.Add(cmbToaNha);
            grpBoLoc.Dock = DockStyle.Fill;
            grpBoLoc.Location = new Point(3, 4);
            grpBoLoc.Margin = new Padding(3, 4, 3, 4);
            grpBoLoc.Name = "grpBoLoc";
            grpBoLoc.Padding = new Padding(3, 4, 3, 4);
            grpBoLoc.Size = new Size(1194, 92);
            grpBoLoc.TabIndex = 0;
            grpBoLoc.TabStop = false;
            grpBoLoc.Text = "Bộ lọc tra cứu";
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.DodgerBlue;
            btnTraCuu.ForeColor = Color.White;
            btnTraCuu.Location = new Point(550, 31);
            btnTraCuu.Margin = new Padding(3, 4, 3, 4);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(120, 44);
            btnTraCuu.TabIndex = 3;
            btnTraCuu.Text = "Xem Sơ Đồ";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // cmbCa
            // 
            cmbCa.Location = new Point(420, 38);
            cmbCa.Margin = new Padding(3, 4, 3, 4);
            cmbCa.Name = "cmbCa";
            cmbCa.Size = new Size(100, 28);
            cmbCa.TabIndex = 2;
            // 
            // dtpNgay
            // 
            dtpNgay.Location = new Point(200, 38);
            dtpNgay.Margin = new Padding(3, 4, 3, 4);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(200, 27);
            dtpNgay.TabIndex = 1;
            // 
            // cmbToaNha
            // 
            cmbToaNha.Location = new Point(20, 38);
            cmbToaNha.Margin = new Padding(3, 4, 3, 4);
            cmbToaNha.Name = "cmbToaNha";
            cmbToaNha.Size = new Size(160, 28);
            cmbToaNha.TabIndex = 0;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelContent.Controls.Add(flpSoDo, 0, 0);
            tableLayoutPanelContent.Controls.Add(pnlDetail, 1, 0);
            tableLayoutPanelContent.Dock = DockStyle.Fill;
            tableLayoutPanelContent.Location = new Point(3, 104);
            tableLayoutPanelContent.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 1;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelContent.Size = new Size(1194, 830);
            tableLayoutPanelContent.TabIndex = 1;
            // 
            // flpSoDo
            // 
            flpSoDo.AutoScroll = true;
            flpSoDo.BackColor = Color.White;
            flpSoDo.Dock = DockStyle.Fill;
            flpSoDo.Location = new Point(3, 4);
            flpSoDo.Margin = new Padding(3, 4, 3, 4);
            flpSoDo.Name = "flpSoDo";
            flpSoDo.Size = new Size(889, 822);
            flpSoDo.TabIndex = 0;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = SystemColors.Control;
            pnlDetail.Controls.Add(lblNguoiDat);
            pnlDetail.Controls.Add(btnXoaDat);
            pnlDetail.Controls.Add(lblLoaiPhong);
            pnlDetail.Controls.Add(lblSucChua);
            pnlDetail.Controls.Add(lblThietBiTitle);
            pnlDetail.Controls.Add(lstThietBi);
            pnlDetail.Controls.Add(lblPhongChonTitle);
            pnlDetail.Controls.Add(txtPhongChon);
            pnlDetail.Controls.Add(lblMucDichTitle);
            pnlDetail.Controls.Add(txtMucDich);
            pnlDetail.Controls.Add(lblGV);
            pnlDetail.Controls.Add(cmbGiangVien);
            pnlDetail.Controls.Add(btnXacNhanDat);
            pnlDetail.Dock = DockStyle.Fill;
            pnlDetail.Location = new Point(898, 4);
            pnlDetail.Margin = new Padding(3, 4, 3, 4);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Padding = new Padding(15, 19, 15, 19);
            pnlDetail.Size = new Size(293, 822);
            pnlDetail.TabIndex = 1;
            // 
            // lblNguoiDat
            // 
            lblNguoiDat.AutoSize = true;
            lblNguoiDat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNguoiDat.ForeColor = Color.Crimson;
            lblNguoiDat.Location = new Point(20, 292);
            lblNguoiDat.Name = "lblNguoiDat";
            lblNguoiDat.Size = new Size(126, 18);
            lblNguoiDat.TabIndex = 11;
            lblNguoiDat.Text = "Người đang đặt:";
            lblNguoiDat.Visible = false;
            // 
            // btnXoaDat
            // 
            btnXoaDat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnXoaDat.BackColor = Color.Crimson;
            btnXoaDat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaDat.ForeColor = Color.White;
            btnXoaDat.Location = new Point(20, 662);
            btnXoaDat.Margin = new Padding(3, 4, 3, 4);
            btnXoaDat.Name = "btnXoaDat";
            btnXoaDat.Size = new Size(250, 56);
            btnXoaDat.TabIndex = 12;
            btnXoaDat.Text = "HỦY LỊCH ĐẶT";
            btnXoaDat.UseVisualStyleBackColor = false;
            btnXoaDat.Visible = false;
            btnXoaDat.Click += btnXoaDat_Click;
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.ForeColor = Color.Blue;
            lblLoaiPhong.Location = new Point(20, 25);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(97, 20);
            lblLoaiPhong.TabIndex = 0;
            lblLoaiPhong.Text = "Loại phòng: -";
            // 
            // lblSucChua
            // 
            lblSucChua.AutoSize = true;
            lblSucChua.ForeColor = Color.Blue;
            lblSucChua.Location = new Point(20, 62);
            lblSucChua.Name = "lblSucChua";
            lblSucChua.Size = new Size(82, 20);
            lblSucChua.TabIndex = 1;
            lblSucChua.Text = "Sức chứa: -";
            // 
            // lblThietBiTitle
            // 
            lblThietBiTitle.AutoSize = true;
            lblThietBiTitle.Location = new Point(20, 112);
            lblThietBiTitle.Name = "lblThietBiTitle";
            lblThietBiTitle.Size = new Size(108, 20);
            lblThietBiTitle.TabIndex = 2;
            lblThietBiTitle.Text = "Thiết bị có sẵn:";
            // 
            // lstThietBi
            // 
            lstThietBi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstThietBi.FormattingEnabled = true;
            lstThietBi.Location = new Point(20, 144);
            lstThietBi.Margin = new Padding(3, 4, 3, 4);
            lstThietBi.Name = "lstThietBi";
            lstThietBi.Size = new Size(250, 124);
            lstThietBi.TabIndex = 3;
            // 
            // lblPhongChonTitle
            // 
            lblPhongChonTitle.AutoSize = true;
            lblPhongChonTitle.Location = new Point(20, 346);
            lblPhongChonTitle.Name = "lblPhongChonTitle";
            lblPhongChonTitle.Size = new Size(111, 20);
            lblPhongChonTitle.TabIndex = 4;
            lblPhongChonTitle.Text = "Phòng đã chọn:";
            // 
            // txtPhongChon
            // 
            txtPhongChon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhongChon.Location = new Point(130, 339);
            txtPhongChon.Margin = new Padding(3, 4, 3, 4);
            txtPhongChon.Name = "txtPhongChon";
            txtPhongChon.ReadOnly = true;
            txtPhongChon.Size = new Size(140, 27);
            txtPhongChon.TabIndex = 5;
            // 
            // lblMucDichTitle
            // 
            lblMucDichTitle.AutoSize = true;
            lblMucDichTitle.Location = new Point(20, 378);
            lblMucDichTitle.Name = "lblMucDichTitle";
            lblMucDichTitle.Size = new Size(129, 20);
            lblMucDichTitle.TabIndex = 6;
            lblMucDichTitle.Text = "Mục đích sử dụng:";
            // 
            // txtMucDich
            // 
            txtMucDich.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMucDich.Location = new Point(20, 419);
            txtMucDich.Margin = new Padding(3, 4, 3, 4);
            txtMucDich.Multiline = true;
            txtMucDich.Name = "txtMucDich";
            txtMucDich.Size = new Size(250, 74);
            txtMucDich.TabIndex = 7;
            // 
            // lblGV
            // 
            lblGV.AutoSize = true;
            lblGV.Location = new Point(20, 497);
            lblGV.Name = "lblGV";
            lblGV.Size = new Size(125, 20);
            lblGV.TabIndex = 8;
            lblGV.Text = "Giảng viên mượn:";
            // 
            // cmbGiangVien
            // 
            cmbGiangVien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbGiangVien.FormattingEnabled = true;
            cmbGiangVien.Location = new Point(20, 532);
            cmbGiangVien.Margin = new Padding(3, 4, 3, 4);
            cmbGiangVien.Name = "cmbGiangVien";
            cmbGiangVien.Size = new Size(250, 28);
            cmbGiangVien.TabIndex = 9;
            // 
            // btnXacNhanDat
            // 
            btnXacNhanDat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnXacNhanDat.BackColor = Color.MediumSeaGreen;
            btnXacNhanDat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXacNhanDat.ForeColor = Color.White;
            btnXacNhanDat.Location = new Point(20, 598);
            btnXacNhanDat.Margin = new Padding(3, 4, 3, 4);
            btnXacNhanDat.Name = "btnXacNhanDat";
            btnXacNhanDat.Size = new Size(250, 56);
            btnXacNhanDat.TabIndex = 10;
            btnXacNhanDat.Text = "ĐĂNG KÝ PHÒNG";
            btnXacNhanDat.UseVisualStyleBackColor = false;
            btnXacNhanDat.Click += btnXacNhanDat_Click;
            // 
            // frmTraCuu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 938);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTraCuu";
            Text = "Hệ thống Quản lý Phòng học TDMU - Tra Cứu";
            Load += frmTraCuu_Load;
            tableLayoutPanelMain.ResumeLayout(false);
            grpBoLoc.ResumeLayout(false);
            tableLayoutPanelContent.ResumeLayout(false);
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            ResumeLayout(false);

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
        private System.Windows.Forms.Label lblNguoiDat;
        private System.Windows.Forms.Label lblPhongChonTitle;
        private System.Windows.Forms.TextBox txtPhongChon;
        private System.Windows.Forms.Label lblMucDichTitle;
        private System.Windows.Forms.TextBox txtMucDich;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.ComboBox cmbGiangVien;
        private System.Windows.Forms.Button btnXacNhanDat;
        private System.Windows.Forms.Button btnXoaDat;
    }
}