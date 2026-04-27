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

                btnTraCuu_Click(null, null);
            }
            catch { }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (flpSoDo == null) return;
            flpSoDo.Controls.Clear();
            txtPhongChon.Text = "";
            lblNguoiDat.Visible = false;
            btnXoaDat.Visible = false;
            btnXacNhanDat.Enabled = true;

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

                bool isBan = false;
                string tenGVDat = "";

                // Kiểm tra xem phòng này có trong danh sách bị đặt không
                DataRow[] dongDat = dtDat.Select(string.Format("MaPhong = '{0}'", ma));
                if (dongDat.Length > 0)
                {
                    isBan = true;
                    tenGVDat = dongDat[0]["HoTen"].ToString(); // Lấy tên Giảng viên đã đặt
                }

                btn.BackColor = isBan ? Color.Orange : Color.LightBlue;
                btn.Text = ma + (isBan ? "\n(Bận)" : "\n(Trống)");

                // SỰ KIỆN CLICK VÀO TỪNG NÚT PHÒNG
                btn.Click += (s, ev) => {
                    lblLoaiPhong.Text = "Loại: " + r["LoaiPhong"];
                    lblSucChua.Text = "Sức chứa: " + r["SucChua"];
                    txtPhongChon.Text = ma; // Luôn hiển thị tên phòng để biết đang chọn phòng nào

                    lstThietBi.Items.Clear();
                    DataTable dtTB = bll.GetThietBi(ma);
                    if (dtTB != null && dtTB.Rows.Count > 0)
                    {
                        foreach (DataRow rowTB in dtTB.Rows)
                        {
                            lstThietBi.Items.Add(string.Format("{0} (SL: {1})", rowTB["TenTB"], rowTB["SoLuong"]));
                        }
                    }
                    else
                    {
                        lstThietBi.Items.Add("Phòng chưa có thiết bị.");
                    }

                    // Nếu phòng màu Cam (Đã Bận)
                    if (isBan)
                    {
                        lblNguoiDat.Text = "Người đặt: " + tenGVDat;
                        lblNguoiDat.Visible = true;
                        btnXacNhanDat.Enabled = false; // Khóa nút Đăng ký

                        // Chỉ Admin mới được quyền xóa
                        if (frmDangNhap.Role == "Admin")
                        {
                            btnXoaDat.Visible = true;
                        }
                    }
                    // Nếu phòng màu Xanh (Còn Trống)
                    else
                    {
                        lblNguoiDat.Visible = false;
                        btnXoaDat.Visible = false;
                        btnXacNhanDat.Enabled = true; // Mở lại nút Đăng ký
                    }
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
                btnTraCuu_Click(null, null); // Load lại sơ đồ
            }
        }

        // SỰ KIỆN KHI BẤM NÚT "HỦY LỊCH ĐẶT" (CHỈ DÀNH CHO ADMIN)
        private void btnXoaDat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhongChon.Text)) return;
            string maPhong = txtPhongChon.Text;
            string ngay = dtpNgay.Value.ToString("yyyy-MM-dd");
            string ca = cmbCa.Text;

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn HỦY lịch đặt của phòng {maPhong} (Ca {ca} - Ngày {dtpNgay.Value.ToString("dd/MM/yyyy")}) không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (bll.HuyDatPhong(maPhong, ngay, ca))
                {
                    MessageBox.Show("Đã hủy lịch đặt phòng thành công!");
                    btnTraCuu_Click(null, null); // Gọi lại để load lại màu sơ đồ
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi hủy lịch đặt!");
                }
            }
        }
    }
}