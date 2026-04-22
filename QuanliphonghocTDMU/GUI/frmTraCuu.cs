using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public partial class frmTraCuu : Form
    {
        TraCuuBLL bll = new TraCuuBLL();
        public frmTraCuu() { InitializeComponent(); }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            try
            {
                // Load Toà nhà
                DataTable dt = bll.GetToaNha();
                DataRow dr = dt.NewRow();
                dr["MaToaNha"] = "ALL"; dr["TenKhu"] = "-- Tất cả dãy --";
                dt.Rows.InsertAt(dr, 0);
                cmbToaNha.DataSource = dt; cmbToaNha.DisplayMember = "TenKhu"; cmbToaNha.ValueMember = "MaToaNha";

                // Load Ca học
                cmbCa.Items.Clear();
                cmbCa.Items.AddRange(new object[] { "1", "2", "3" });
                cmbCa.SelectedIndex = 0;

                // Phân quyền cho Admin
                if (frmDangNhap.Role == "Admin")
                {
                    cmbGiangVien.DataSource = bll.GetGiangVien();
                    cmbGiangVien.DisplayMember = "HoTen"; cmbGiangVien.ValueMember = "MaGV";
                }
                else
                {
                    if (lblGV != null) lblGV.Visible = false;
                    if (cmbGiangVien != null) cmbGiangVien.Visible = false;
                }

                // Tự động bấm nút Xem sơ đồ khi vừa mở Form
                btnTraCuu_Click(null, null);
            }
            catch { }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (flpSoDo == null) return;
            flpSoDo.Controls.Clear();

            string maTN = cmbToaNha.SelectedValue?.ToString() ?? "ALL";
            if (maTN == "System.Data.DataRowView") maTN = "ALL";

            DataTable dtPhong = bll.GetPhongHoc(maTN);
            DataTable dtDat = bll.GetPhongBiDat(dtpNgay.Value.ToString("yyyy-MM-dd"), cmbCa.Text);

            foreach (DataRow r in dtPhong.Rows)
            {
                string ma = r["MaPhong"].ToString();
                Button btn = new Button { Width = 90, Height = 90, Margin = new Padding(8), FlatStyle = FlatStyle.Flat };
                btn.FlatAppearance.BorderSize = 1;
                btn.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                bool isBan = dtDat.Select(string.Format("MaPhong = '{0}'", ma)).Length > 0;
                btn.BackColor = isBan ? Color.Orange : Color.LightBlue;
                btn.Text = ma + (isBan ? "\n(Bận)" : "\n(Trống)");

                // SỰ KIỆN KHI CLICK VÀO TỪNG NÚT PHÒNG
                btn.Click += (s, ev) => {
                    lblLoaiPhong.Text = "Loại: " + r["LoaiPhong"];
                    lblSucChua.Text = "Sức chứa: " + r["SucChua"];
                    txtPhongChon.Text = isBan ? "" : ma;

                    // --- ĐOẠN FIX LỖI HIỂN THỊ THIẾT BỊ ---
                    lstThietBi.Items.Clear(); // Xóa trắng danh sách cũ
                    DataTable dtTB = bll.GetThietBi(ma); // Gọi BLL lấy thiết bị của phòng này
                    if (dtTB != null && dtTB.Rows.Count > 0)
                    {
                        foreach (DataRow rowTB in dtTB.Rows)
                        {
                            // Thêm từng thiết bị vào ListBox
                            lstThietBi.Items.Add(string.Format("{0} (SL: {1})", rowTB["TenTB"], rowTB["SoLuong"]));
                        }
                    }
                    else
                    {
                        lstThietBi.Items.Add("Phòng chưa có thiết bị.");
                    }
                    // ---------------------------------------

                    if (isBan) MessageBox.Show("Phòng này đã có lịch đặt, vui lòng chọn phòng khác màu xanh!", "Thông báo");
                };

                flpSoDo.Controls.Add(btn);
            }
        }

        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhongChon.Text))
            {
                MessageBox.Show("Vui lòng chọn một phòng còn trống (màu xanh)!");
                return;
            }

            LichDatPhongDTO ld = new LichDatPhongDTO
            {
                MaPhong = txtPhongChon.Text,
                MaGV = frmDangNhap.Role == "Admin" ? cmbGiangVien.SelectedValue.ToString() : frmDangNhap.MaGV,
                NgayDat = dtpNgay.Value,
                CaHoc = cmbCa.Text,
                MucDich = txtMucDich.Text,
                TrangThaiDuyet = frmDangNhap.Role == "Admin" ? "Đã duyệt" : "Chờ duyệt"
            };

            if (bll.ThucHienDatPhong(ld))
            {
                MessageBox.Show("Đăng ký thành công!");
                btnTraCuu_Click(null, null); // Load lại sơ đồ để cập nhật màu cam
            }
        }
    }
}