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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlPhongDangDung = new System.Windows.Forms.Panel();
            this.lblPhongDangDung = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pnlPhongTrong = new System.Windows.Forms.Panel();
            this.lblPhongTrong = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pnlChoDuyet = new System.Windows.Forms.Panel();
            this.lblChoDuyet = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.chartThietBi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlPhongDangDung.SuspendLayout();
            this.pnlPhongTrong.SuspendLayout();
            this.pnlChoDuyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).BeginInit();
            this.SuspendLayout();

            this.pnlPhongDangDung.BackColor = System.Drawing.Color.Orange;
            this.pnlPhongDangDung.Controls.Add(this.lblPhongDangDung);
            this.pnlPhongDangDung.Controls.Add(this.lblTitle1);
            this.pnlPhongDangDung.Location = new System.Drawing.Point(30, 30);
            this.pnlPhongDangDung.Name = "pnlPhongDangDung";
            this.pnlPhongDangDung.Size = new System.Drawing.Size(250, 150);
            this.pnlPhongDangDung.TabIndex = 0;

            this.lblPhongDangDung.AutoSize = true;
            this.lblPhongDangDung.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblPhongDangDung.ForeColor = System.Drawing.Color.White;
            this.lblPhongDangDung.Location = new System.Drawing.Point(20, 50);
            this.lblPhongDangDung.Name = "lblPhongDangDung";
            this.lblPhongDangDung.Size = new System.Drawing.Size(70, 81);
            this.lblPhongDangDung.TabIndex = 1;
            this.lblPhongDangDung.Text = "0";

            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(20, 20);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(193, 28);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "PHÒNG ĐANG BẬN";

            this.pnlPhongTrong.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPhongTrong.Controls.Add(this.lblPhongTrong);
            this.pnlPhongTrong.Controls.Add(this.lblTitle2);
            this.pnlPhongTrong.Location = new System.Drawing.Point(310, 30);
            this.pnlPhongTrong.Name = "pnlPhongTrong";
            this.pnlPhongTrong.Size = new System.Drawing.Size(250, 150);
            this.pnlPhongTrong.TabIndex = 1;

            this.lblPhongTrong.AutoSize = true;
            this.lblPhongTrong.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblPhongTrong.ForeColor = System.Drawing.Color.Black;
            this.lblPhongTrong.Location = new System.Drawing.Point(20, 50);
            this.lblPhongTrong.Name = "lblPhongTrong";
            this.lblPhongTrong.Size = new System.Drawing.Size(70, 81);
            this.lblPhongTrong.TabIndex = 1;
            this.lblPhongTrong.Text = "0";

            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.Black;
            this.lblTitle2.Location = new System.Drawing.Point(20, 20);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(161, 28);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "PHÒNG TRỐNG";

            this.pnlChoDuyet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlChoDuyet.Controls.Add(this.lblChoDuyet);
            this.pnlChoDuyet.Controls.Add(this.lblTitle3);
            this.pnlChoDuyet.Location = new System.Drawing.Point(590, 30);
            this.pnlChoDuyet.Name = "pnlChoDuyet";
            this.pnlChoDuyet.Size = new System.Drawing.Size(250, 150);
            this.pnlChoDuyet.TabIndex = 2;

            this.lblChoDuyet.AutoSize = true;
            this.lblChoDuyet.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblChoDuyet.ForeColor = System.Drawing.Color.White;
            this.lblChoDuyet.Location = new System.Drawing.Point(20, 50);
            this.lblChoDuyet.Name = "lblChoDuyet";
            this.lblChoDuyet.Size = new System.Drawing.Size(70, 81);
            this.lblChoDuyet.TabIndex = 1;
            this.lblChoDuyet.Text = "0";

            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.ForeColor = System.Drawing.Color.White;
            this.lblTitle3.Location = new System.Drawing.Point(20, 20);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(206, 28);
            this.lblTitle3.TabIndex = 0;
            this.lblTitle3.Text = "YÊU CẦU CHỜ DUYỆT";

            this.chartThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartThietBi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThietBi.Legends.Add(legend1);
            this.chartThietBi.Location = new System.Drawing.Point(30, 210);
            this.chartThietBi.Name = "chartThietBi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "ThietBi";
            this.chartThietBi.Series.Add(series1);
            this.chartThietBi.Size = new System.Drawing.Size(810, 320);
            this.chartThietBi.TabIndex = 3;
            this.chartThietBi.Text = "chart1";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.chartThietBi);
            this.Controls.Add(this.pnlChoDuyet);
            this.Controls.Add(this.pnlPhongTrong);
            this.Controls.Add(this.pnlPhongDangDung);
            this.Name = "frmTrangChu";
            this.Text = "Dashboard Thống Kê";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.pnlPhongDangDung.ResumeLayout(false);
            this.pnlPhongDangDung.PerformLayout();
            this.pnlPhongTrong.ResumeLayout(false);
            this.pnlPhongTrong.PerformLayout();
            this.pnlChoDuyet.ResumeLayout(false);
            this.pnlChoDuyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlPhongDangDung;
        private System.Windows.Forms.Label lblPhongDangDung;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel pnlPhongTrong;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Panel pnlChoDuyet;
        private System.Windows.Forms.Label lblChoDuyet;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThietBi;
    }
}