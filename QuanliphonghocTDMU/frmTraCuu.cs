using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmTraCuu : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            DataTable dtToaNha = kn.ExecuteQuery("SELECT MaToaNha, TenKhu FROM ToaNha");
            DataRow dr = dtToaNha.NewRow();
            dr["MaToaNha"] = "ALL";
            dr["TenKhu"] = "-- Tất cả các dãy --";
            dtToaNha.Rows.InsertAt(dr, 0);
            cmbToaNha.DataSource = dtToaNha;
            cmbToaNha.DisplayMember = "TenKhu";
            cmbToaNha.ValueMember = "MaToaNha";
            cmbToaNha.SelectedIndex = 0;

            cmbCa.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCa.SelectedIndex = 0;

            if (frmDangNhap.Role == "Admin")
            {
                cmbGiangVien.DataSource = kn.ExecuteQuery("SELECT MaGV, HoTen FROM GiangVien");
                cmbGiangVien.DisplayMember = "HoTen";
                cmbGiangVien.ValueMember = "MaGV";
            }
            else
            {
                lblGV.Visible = false;
                cmbGiangVien.Visible = false;
            }

            btnTraCuu.PerformClick();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            flpSoDo.Controls.Clear();
            txtPhongChon.Clear();
            txtMucDich.Clear();
            lblLoaiPhong.Text = "Loại phòng: -";
            lblSucChua.Text = "Sức chứa: -";
            lstThietBi.Items.Clear();

            string maToaNha = cmbToaNha.SelectedValue.ToString();
            string ngay = dtpNgay.Value.ToString("yyyy-MM-dd");
            string ca = cmbCa.SelectedItem.ToString();

            // Sửa câu SQL ở đây: Lấy thêm LoaiPhong và SucChua từ CSDL
            string sqlPhong = maToaNha == "ALL" ? "SELECT MaPhong, TenPhong, LoaiPhong, SucChua FROM PhongHoc WHERE TrangThai = N'Sẵn sàng'"
                : string.Format("SELECT MaPhong, TenPhong, LoaiPhong, SucChua FROM PhongHoc WHERE MaToaNha = '{0}' AND TrangThai = N'Sẵn sàng'", maToaNha);
            DataTable dtTatCa = kn.ExecuteQuery(sqlPhong);

            string sqlDat = string.Format("SELECT MaPhong FROM LichDatPhong WHERE NgayDat = '{0}' AND CaHoc = {1} AND TrangThaiDuyet != N'Từ chối'", ngay, ca);
            DataTable dtBiDat = kn.ExecuteQuery(sqlDat);

            foreach (DataRow row in dtTatCa.Rows)
            {
                string ma = row["MaPhong"].ToString();
                string loai = row["LoaiPhong"].ToString();
                string sucChua = row["SucChua"].ToString();

                Button btn = new Button { Width = 100, Height = 100, Margin = new Padding(8), FlatStyle = FlatStyle.Flat };
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                bool isBận = dtBiDat.Select(string.Format("MaPhong = '{0}'", ma)).Length > 0;

                if (isBận)
                {
                    btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.White;
                    btn.Text = ma + "\n(Bận)";
                }
                else
                {
                    btn.BackColor = Color.LightBlue;
                    btn.Text = ma + "\n(Trống)";
                }

                // SỰ KIỆN CLICK VÀO PHÒNG BẤT KỲ ĐỂ XEM THÔNG TIN
                btn.Click += (s, ev) =>
                {
                    // 1. Cập nhật bảng Thông tin
                    lblLoaiPhong.Text = "Loại phòng: " + loai;
                    lblSucChua.Text = "Sức chứa: " + sucChua + " người";
                    lstThietBi.Items.Clear();

                    // Móc dữ liệu từ bảng TrangBiPhong kết hợp ThietBi
                    string sqlTB = string.Format("SELECT tb.TenTB, tbp.SoLuong FROM TrangBiPhong tbp JOIN ThietBi tb ON tbp.MaTB = tb.MaTB WHERE tbp.MaPhong = '{0}'", ma);
                    DataTable dtTB = kn.ExecuteQuery(sqlTB);
                    if (dtTB.Rows.Count > 0)
                    {
                        foreach (DataRow r in dtTB.Rows)
                        {
                            lstThietBi.Items.Add(string.Format("- {0} (SL: {1})", r["TenTB"], r["SoLuong"]));
                        }
                    }
                    else
                    {
                        lstThietBi.Items.Add("- Không có thiết bị gắn kèm");
                    }

                    // 2. Xử lý phần Đăng ký bên dưới
                    if (isBận)
                    {
                        txtPhongChon.Clear(); // Không cho điền mã phòng để không đặt được
                        MessageBox.Show("Phòng này đã có lịch. Vui lòng chọn phòng trống (Màu xanh)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        txtPhongChon.Text = ma; // Điền tự động mã phòng vào ô text để sẵn sàng đăng ký
                    }
                };

                flpSoDo.Controls.Add(btn);
            }
        }

        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhongChon.Text) || string.IsNullOrEmpty(txtMucDich.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 phòng trống trên sơ đồ và nhập mục đích sử dụng!", "Cảnh báo");
                return;
            }

            string maGV = frmDangNhap.Role == "Admin" ? cmbGiangVien.SelectedValue.ToString() : frmDangNhap.MaGV;
            string trangThai = frmDangNhap.Role == "Admin" ? "Đã duyệt" : "Chờ duyệt";
            int tietBD = cmbCa.Text == "1" ? 1 : (cmbCa.Text == "2" ? 6 : 11);

            string sql = string.Format("INSERT INTO LichDatPhong (MaPhong, MaGV, NgayDat, CaHoc, TietBatDau, TietKetThuc, MucDich, TrangThaiDuyet) VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, N'{6}', N'{7}')",
                txtPhongChon.Text, maGV, dtpNgay.Value.ToString("yyyy-MM-dd"), cmbCa.Text, tietBD, tietBD + 4, txtMucDich.Text, trangThai);

            if (kn.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Đăng ký mượn phòng thành công!", "Thông báo");
                btnTraCuu.PerformClick(); // Load lại sơ đồ để phòng vừa đăng ký chuyển sang màu cam
            }
        }
    }
}