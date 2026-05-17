using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmBaoCaoSuCo : Form
    {
        BaoCaoSuCoBLL bll = new BaoCaoSuCoBLL();
        string loaiSuCoDangChon = "";
        string role = frmDangNhap.Role;
        string maGV = frmDangNhap.MaGV;

        public frmBaoCaoSuCo() { InitializeComponent(); }

        private void frmBaoCaoSuCo_Load(object sender, EventArgs e)
        {
            // Thiết lập ComboBox trạng thái
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
                trkMucDo.Minimum = 1; trkMucDo.Maximum = 5; trkMucDo.Value = 3;
            }
        }

        // --- CHỨC NĂNG GIẢNG VIÊN ---
        private void btnLoaiSuCo_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            loaiSuCoDangChon = btn.Text;
            lblSuCoDangChon.Text = "Đang chọn: " + loaiSuCoDangChon;
        }

        private void btnGuiBaoCao_Click(object sender, EventArgs e)
        {
            if (cmbPhongHoc.Text == "" || loaiSuCoDangChon == "" || txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!"); return;
            }

            if (bll.GuiBaoCao(cmbPhongHoc.Text, maGV, loaiSuCoDangChon, txtMoTa.Text, trkMucDo.Value))
            {
                MessageBox.Show("Gửi báo cáo thành công! AI đang tìm phòng thay thế...");
                RenderAICards(cmbPhongHoc.Text, DateTime.Now, 1);

                // NẾU LÀ ADMIN ĐANG DÙNG KÉ FORM NÀY THÌ LOAD LẠI LƯỚI SAU KHI GỬI
                if (role == "Admin") LoadAdminData();
            }
        }

        private void RenderAICards(string phongGoc, DateTime ngay, int ca)
        {
            flpGoiY.Controls.Clear();
            DataTable dt = bll.LayGoiYPhong(phongGoc, ngay, ca);

            foreach (DataRow row in dt.Rows)
            {
                Panel card = new Panel { Width = 280, Height = 120, BackColor = Color.White, Margin = new Padding(10) };
                Label lblPhong = new Label { Text = "🟢 " + row["MaPhong"].ToString(), Font = new Font("Arial", 14, FontStyle.Bold), ForeColor = Color.ForestGreen, Location = new Point(10, 10), AutoSize = true };
                Label lblToa = new Label { Text = "🏢 Tòa: " + row["MaToaNha"].ToString(), Location = new Point(10, 40), AutoSize = true };
                Label lblDiem = new Label { Text = "⭐ Điểm phù hợp: " + row["DiemPhuHop"].ToString(), Font = new Font("Arial", 10, FontStyle.Bold), ForeColor = Color.Orange, Location = new Point(10, 65), AutoSize = true };
                Button btnChuyen = new Button { Text = "CHUYỂN NGAY", BackColor = Color.DodgerBlue, ForeColor = Color.White, Width = 120, Height = 35, Location = new Point(140, 75), Cursor = Cursors.Hand };

                btnChuyen.Click += (s, e) => { MessageBox.Show("Đã chuyển lịch sang phòng " + row["MaPhong"].ToString()); };

                card.Controls.Add(lblPhong); card.Controls.Add(lblToa); card.Controls.Add(lblDiem); card.Controls.Add(btnChuyen);
                flpGoiY.Controls.Add(card);
            }
        }

        // --- CHỨC NĂNG ADMIN ---
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

        private void btnXacNhanSuaXong_Click(object sender, EventArgs e)
        {
            if (dgvSuCo.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvSuCo.CurrentRow.Cells["ID"].Value);
                if (bll.XacNhanDaXuLy(id))
                {
                    MessageBox.Show("Đã cập nhật trạng thái thành Đã khắc phục!");
                    LoadAdminData();
                }
            }
        }

        // --- CÁC HÀM CRUD MỚI ---
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvSuCo.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvSuCo.CurrentRow.Cells["ID"].Value);
                string trangThaiMoi = cboTrangThai.Text;

                if (bll.CapNhatTrangThai(id, trangThaiMoi))
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
            // Mượn panel của GV để Admin tự nhập sự cố
            pnlAdminDashboard.Visible = false;
            pnlGiangVien.Visible = true;
            pnlGiangVien.Dock = DockStyle.Fill;
        }
    }
}