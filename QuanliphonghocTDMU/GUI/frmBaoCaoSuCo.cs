using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmBaoCaoSuCo : Form
    {
        BaoCaoSuCoBLL bll = new BaoCaoSuCoBLL();
        DatPhongBLL dpBll = new DatPhongBLL();
        string loaiSuCoDangChon = "";
        string role = frmDangNhap.Role;
        string maGV = frmDangNhap.MaGV;

        public frmBaoCaoSuCo() { InitializeComponent(); }

        private void frmBaoCaoSuCo_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.AddRange(new string[] { "Chưa xử lý", "Đang xử lý", "Đã khắc phục" });
            cboTrangThai.SelectedIndex = 0;

            if (role == "Admin")
            {
                pnlGiangVien.Visible = false;
                pnlGoiYAI.Visible = false;
                pnlAdminDashboard.Visible = true;
                pnlAdminDashboard.Dock = DockStyle.Fill;
                LoadAdminData();
            }
            else
            {
                pnlAdminDashboard.Visible = false;
                pnlGiangVien.Visible = true;
                pnlGoiYAI.Visible = true;
                cboMucDo.SelectedIndex = 2; // Mặc định chọn mức 3

                DataTable dtPhongGV = bll.GetPhongCuaGiangVien(maGV);
                if (dtPhongGV.Rows.Count == 0)
                {
                    MessageBox.Show("Hiện tại bạn chưa có lịch giảng dạy nào được phân công!", "Thông báo");
                }
                else
                {
                    cmbPhongHoc.DataSource = dtPhongGV;
                    cmbPhongHoc.DisplayMember = "MaPhong";
                    cmbPhongHoc.ValueMember = "MaPhong";
                }
            }
        }

        // --- PHÂN HỆ GIẢNG VIÊN ---
        private void btnLoaiSuCo_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
            if (btn == null) return;

            // Xử lý đổi màu khi Click (Bật/Tắt)
            if (btn.Tag == null || btn.Tag.ToString() == "Unchecked")
            {
                btn.Tag = "Checked";
                btn.FillColor = Color.FromArgb(238, 242, 255);
                btn.BorderColor = Color.FromArgb(79, 70, 229);
                btn.ForeColor = Color.FromArgb(79, 70, 229);
            }
            else
            {
                ResetButtonColor(btn);
            }

            // Gom nhóm các lỗi
            List<string> selected = new List<string>();
            if (btnMayChieu.Tag != null && btnMayChieu.Tag.ToString() == "Checked") selected.Add("Máy chiếu");
            if (btnMayLanh.Tag != null && btnMayLanh.Tag.ToString() == "Checked") selected.Add("Máy lạnh");
            if (btnDien.Tag != null && btnDien.Tag.ToString() == "Checked") selected.Add("Điện");
            if (btnInternet.Tag != null && btnInternet.Tag.ToString() == "Checked") selected.Add("Internet");
            if (btnBanGhe.Tag != null && btnBanGhe.Tag.ToString() == "Checked") selected.Add("Cơ sở vật chất");

            loaiSuCoDangChon = string.Join(", ", selected);
            lblSuCoDangChon.Text = "Đang chọn: " + (selected.Count > 0 ? loaiSuCoDangChon : "Chưa có");
        }

        private void ResetButtonColor(Guna.UI2.WinForms.Guna2Button btn)
        {
            btn.Tag = "Unchecked";
            btn.FillColor = Color.White;
            btn.BorderColor = Color.FromArgb(203, 213, 225);
            btn.ForeColor = Color.FromArgb(71, 85, 105);
        }

        private void btnGuiBaoCao_Click(object sender, EventArgs e)
        {
            if (cmbPhongHoc.Text == "" || loaiSuCoDangChon == "" || string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin báo cáo!", "Thông báo"); return;
            }

            int mucDo = int.Parse(cboMucDo.SelectedItem.ToString());

            if (bll.GuiBaoCao(cmbPhongHoc.Text, maGV, loaiSuCoDangChon, txtMoTa.Text, mucDo))
            {
                MessageBox.Show("Gửi báo cáo thành công! Đang tìm phòng trống thay thế...");
                RenderAICards(cmbPhongHoc.Text, DateTime.Now, 1);

                if (role == "Admin") LoadAdminData();
            }
        }

        private void RenderAICards(string phongGoc, DateTime ngay, int ca)
        {
            flpGoiY.Controls.Clear();
            DataTable dt = bll.LayGoiYPhong(phongGoc, ngay, ca);

            foreach (DataRow row in dt.Rows)
            {
                Panel card = new Panel { Width = 380, Height = 90, BackColor = Color.White, Margin = new Padding(10) };

                Label lblPhong = new Label { Text = "🟢 " + row["MaPhong"].ToString(), Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.ForestGreen, Location = new Point(10, 10), AutoSize = true };
                Label lblToa = new Label { Text = "🏢 Tòa: " + row["MaToaNha"].ToString() + "  |  ⭐ Điểm: " + row["DiemPhuHop"].ToString(), Location = new Point(10, 45), AutoSize = true, ForeColor = Color.DimGray };
                Button btnChuyen = new Button { Text = "CHUYỂN NGAY", BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 140, Height = 35, Location = new Point(220, 25), Cursor = Cursors.Hand, FlatStyle = FlatStyle.Flat };
                btnChuyen.FlatAppearance.BorderSize = 0;

                btnChuyen.Click += (s, e) => {
                    MessageBox.Show("Đã chuyển lịch giảng dạy sang phòng " + row["MaPhong"].ToString() + " thành công!", "Thông báo");

                    // Reset sạch sẽ giao diện sau khi chuyển
                    flpGoiY.Controls.Clear();
                    txtMoTa.Clear();
                    ResetButtonColor(btnMayChieu); ResetButtonColor(btnMayLanh); ResetButtonColor(btnDien);
                    ResetButtonColor(btnInternet); ResetButtonColor(btnBanGhe);
                    loaiSuCoDangChon = "";
                    lblSuCoDangChon.Text = "Đang chọn: Chưa có";
                };

                card.Controls.Add(lblPhong); card.Controls.Add(lblToa); card.Controls.Add(btnChuyen);
                flpGoiY.Controls.Add(card);
            }
        }

        // --- PHÂN HỆ ADMIN ---
        private void LoadAdminData()
        {
            dgvSuCo.DataSource = bll.GetDanhSachSuCo();

            DataTable dtStats = bll.GetThongKe();
            if (dtStats.Rows.Count > 0)
            {
                lblTong.Text = dtStats.Rows[0]["TongSuCo"].ToString();
                lblDangXyLy.Text = dtStats.Rows[0]["DangXuLy"].ToString();
                lblDaXuLy.Text = dtStats.Rows[0]["DaXuLy"].ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvSuCo.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvSuCo.CurrentRow.Cells["ID"].Value);
                if (bll.CapNhatTrangThai(id, cboTrangThai.Text))
                {
                    MessageBox.Show("Cập nhật trạng thái thành công!");
                    LoadAdminData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSuCo.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvSuCo.CurrentRow.Cells["ID"].Value);
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sự cố này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bll.XoaSuCo(id);
                    LoadAdminData();
                }
            }
        }

        private void btnThemSuCoAdmin_Click(object sender, EventArgs e)
        {
            pnlAdminDashboard.Visible = false;
            pnlGiangVien.Visible = true;
            pnlGiangVien.Dock = DockStyle.Left;
            pnlGoiYAI.Visible = true;
            pnlGoiYAI.Dock = DockStyle.Fill;

            cmbPhongHoc.DataSource = dpBll.LayDSPhong();
            cmbPhongHoc.DisplayMember = "MaPhong";
            cmbPhongHoc.ValueMember = "MaPhong";
        }
    }
}