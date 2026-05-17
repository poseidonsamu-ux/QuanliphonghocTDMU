using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDatPhong : Form
    {
        private DatPhongBLL datBll = new DatPhongBLL();
        private DataTable dtTatCaPhong;

        string role = frmDangNhap.Role;
        string selectedRoom_GV = "";

        public frmDatPhong() { InitializeComponent(); }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                pnlTeacherView.Visible = false;
                pnlLeftWorkspace.Visible = true;
                pnlRightBooking.Visible = true;

                // --- LOGIC ADMIN (GIỮ NGUYÊN 100%) ---
                dtpNgayTraCuu.Format = DateTimePickerFormat.Custom; dtpNgayTraCuu.CustomFormat = "dd/MM/yyyy";
                dtpNgayDat.Format = DateTimePickerFormat.Custom; dtpNgayDat.CustomFormat = "dd/MM/yyyy";

                cboMaGV.DataSource = datBll.LayDSGV(); cboMaGV.DisplayMember = "MaGV"; cboMaGV.ValueMember = "MaGV";
                dtTatCaPhong = datBll.LayDSPhong();
                cboMaPhong.DataSource = dtTatCaPhong; cboMaPhong.DisplayMember = "MaPhong"; cboMaPhong.ValueMember = "MaPhong";

                cmbToaNha.DataSource = datBll.LayDanhSachToaNha();
                cmbToaNha.DisplayMember = "TenKhu"; cmbToaNha.ValueMember = "MaToaNha";

                cmbCaTraCuu.Items.AddRange(new object[] { "ALL", "1", "2", "3" }); cmbCaTraCuu.SelectedIndex = 0;
                if (cboCaDat.Items.Count > 0) cboCaDat.SelectedIndex = 0;

                cmbToaNha.SelectedIndexChanged += DongBo_ToaNha_PhongDat;
                cmbCaTraCuu.SelectedIndexChanged += DongBo_CaHoc;
                dtpNgayTraCuu.ValueChanged += DongBo_NgayDat;

                btnTimKiem_Click(null, null);
            }
            else // GIẢNG VIÊN 
            {
                pnlLeftWorkspace.Visible = false;
                pnlRightBooking.Visible = false;
                pnlTeacherView.Visible = true;
                pnlTeacherView.Dock = DockStyle.Fill;

                // 1. Tự động load thông tin Giảng viên (Các Textbox này đã được set ReadOnly trong Designer)
                txtTeacherMaGV.Text = frmDangNhap.MaGV;
                DataTable dtGV = datBll.LayChiTietGV(frmDangNhap.MaGV);
                if (dtGV.Rows.Count > 0)
                {
                    txtTeacherHoTen.Text = dtGV.Rows[0]["HoTen"].ToString();
                    txtTeacherKhoa.Text = dtGV.Rows[0]["TenKhoa"].ToString();
                }

                // 2. Thiết lập định dạng cho Ngày đăng ký và Ca học trên Form Đăng ký
                dtpTeacherNgayDat.Format = DateTimePickerFormat.Custom;
                dtpTeacherNgayDat.CustomFormat = "dd/MM/yyyy";
                dtpTeacherNgayDat.Value = DateTime.Now;

                cmbTeacherCaDat.DropDownStyle = ComboBoxStyle.DropDownList; // Khóa không cho gõ bậy
                cmbTeacherCaDat.Items.AddRange(new object[] { "1", "2", "3" });
                cmbTeacherCaDat.SelectedIndex = 0;

                // Gắn sự kiện: Hễ đổi Ngày hoặc Ca bên form phải thì sơ đồ phòng bên trái tự động quét lại
                dtpTeacherNgayDat.ValueChanged += (s, ev) => LoadTeacherRooms();
                cmbTeacherCaDat.SelectedIndexChanged += (s, ev) => LoadTeacherRooms();

                // Quét phòng lần đầu khi mở form
                LoadTeacherRooms();
            }
        }

        // =========================================================
        // PHÂN HỆ GIẢNG VIÊN (SƠ ĐỒ LOAD FULL)
        // =========================================================
        private void LoadTeacherRooms()
        {
            flpTeacherRooms.Controls.Clear();

            // Clear các ô nhập liệu khi load lại sơ đồ
            selectedRoom_GV = "";
            txtTeacherMaPhong.Clear();
            lblTeacherSucChua.Text = "Sức chứa: --";
            txtTeacherEquipment.Clear();
            txtTeacherMucDich.Clear();

            DateTime ngay = dtpTeacherNgayDat.Value;
            string ca = cmbTeacherCaDat.Text;
            if (string.IsNullOrEmpty(ca)) return;

            // Quét toàn bộ phòng trong trường (truyền "ALL" vào DAL đã hỗ trợ ở bước trước)
            DataTable dtAllRooms = datBll.GetTrangThaiPhong("ALL", ngay, ca);

            // Vẽ các phòng ra giao diện
            foreach (DataRow row in dtAllRooms.Rows)
            {
                string maPhong = row["Phòng"].ToString();
                string trangThai = row["Trạng thái"].ToString();
                string loai = row["Loại"].ToString();
                string sucChua = row["Sức chứa"].ToString();

                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button
                {
                    Width = 110,
                    Height = 100,
                    Margin = new Padding(10),
                    BorderRadius = 8,
                    BorderThickness = 1,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };

                // XỬ LÝ MÀU SẮC PHÒNG THEO TRẠNG THÁI
                if (trangThai == "Đang bận")
                {
                    btn.Text = maPhong + "\n(Đã đặt)";
                    btn.FillColor = Color.FromArgb(226, 232, 240); // Xám nhạt
                    btn.ForeColor = Color.FromArgb(148, 163, 184); // Xám đậm chữ
                    btn.BorderColor = Color.FromArgb(203, 213, 225);
                    btn.Enabled = false; // Khóa tịt không cho bấm
                }
                else
                {
                    btn.Text = maPhong + "\n(Trống)";
                    btn.FillColor = Color.White;
                    btn.ForeColor = Color.FromArgb(22, 163, 74); // Xanh lá
                    btn.BorderColor = Color.FromArgb(134, 239, 172);

                    btn.Click += (s, ev) =>
                    {
                        // Đổi màu về xanh lá cho các nút trống khác
                        foreach (Control c in flpTeacherRooms.Controls)
                        {
                            if (c.Enabled && c is Guna.UI2.WinForms.Guna2Button bg)
                            {
                                bg.FillColor = Color.White;
                                bg.ForeColor = Color.FromArgb(22, 163, 74);
                            }
                        }

                        // Đổi màu Cam cháy cho nút đang chọn
                        btn.FillColor = Color.FromArgb(249, 115, 22);
                        btn.ForeColor = Color.White;

                        // Đẩy thông tin qua cột Phải
                        selectedRoom_GV = maPhong;
                        txtTeacherMaPhong.Text = maPhong;
                        lblTeacherSucChua.Text = $"Sức chứa: {sucChua} ({loai})";
                        txtTeacherEquipment.Text = datBll.GetChiTietThietBi(maPhong);
                    };
                }

                flpTeacherRooms.Controls.Add(btn);
            }
        }

        private void btnTeacherDatPhong_Click(object sender, EventArgs e)
        {
            if (selectedRoom_GV == "" || string.IsNullOrWhiteSpace(txtTeacherMucDich.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng học và nhập lý do đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LichDatPhongDTO dto = new LichDatPhongDTO
            {
                MaPhong = selectedRoom_GV,
                MaGV = frmDangNhap.MaGV,
                NgayDat = dtpTeacherNgayDat.Value,
                CaHoc = int.Parse(cmbTeacherCaDat.Text),
                TietBatDau = (int.Parse(cmbTeacherCaDat.Text) * 5) - 4,
                TietKetThuc = int.Parse(cmbTeacherCaDat.Text) * 5,
                MucDich = txtTeacherMucDich.Text
            };

            string res = datBll.XuLyDatPhong(dto, role);
            MessageBox.Show(res, "Thông báo");

            if (res == "Thành công") LoadTeacherRooms(); // Quét lại màu phòng ngay lập tức
        }

        // =========================================================
        // PHÂN HỆ ADMIN (GIỮ NGUYÊN 100%)
        // =========================================================
        private void DongBo_ToaNha_PhongDat(object sender, EventArgs e)
        {
            if (cmbToaNha.SelectedValue == null || dtTatCaPhong == null) return;
            string toaNha = cmbToaNha.SelectedValue.ToString();

            if (toaNha == "ALL") cboMaPhong.DataSource = dtTatCaPhong;
            else
            {
                DataView dv = new DataView(dtTatCaPhong);
                dv.RowFilter = $"MaPhong LIKE '{toaNha}%'";
                cboMaPhong.DataSource = dv.ToTable();
            }
            cboMaPhong.DisplayMember = "MaPhong"; cboMaPhong.ValueMember = "MaPhong";
        }

        private void DongBo_CaHoc(object sender, EventArgs e) { if (cmbCaTraCuu.Text != "ALL") cboCaDat.Text = cmbCaTraCuu.Text; }
        private void DongBo_NgayDat(object sender, EventArgs e) { dtpNgayDat.Value = dtpNgayTraCuu.Value; }

        private void cboMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaPhong.SelectedItem is DataRowView dr) lblSucChua.Text = "Sức chứa: " + dr["SucChua"].ToString();
        }

        private void cboMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaGV.SelectedValue == null || cboMaGV.SelectedValue is DataRowView) return;
            DataTable dt = datBll.LayChiTietGV(cboMaGV.SelectedValue.ToString());
            if (dt.Rows.Count > 0) { txtHoTen.Text = dt.Rows[0]["HoTen"].ToString(); txtKhoa.Text = dt.Rows[0]["TenKhoa"].ToString(); }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMucDich.Text)) { MessageBox.Show("Chưa nhập mục đích!", "Cảnh báo"); return; }
            LichDatPhongDTO dto = new LichDatPhongDTO
            {
                MaPhong = cboMaPhong.SelectedValue?.ToString(),
                MaGV = cboMaGV.SelectedValue?.ToString(),
                NgayDat = dtpNgayDat.Value,
                CaHoc = int.Parse(cboCaDat.Text),
                TietBatDau = (int.Parse(cboCaDat.Text) * 5) - 4,
                TietKetThuc = int.Parse(cboCaDat.Text) * 5,
                MucDich = txtMucDich.Text
            };
            string res = datBll.XuLyDatPhong(dto, role);
            MessageBox.Show(res, "Thông báo");
            if (res == "Thành công") btnTimKiem_Click(null, null);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = datBll.GetDanhSachPhongAdmin(dtpNgayTraCuu.Value, cmbCaTraCuu.Text, cmbToaNha.SelectedValue.ToString());
            if (dgvPhong.Columns.Contains("MaDatPhong")) dgvPhong.Columns["MaDatPhong"].Visible = false;
            if (!dgvPhong.Columns.Contains("btnXoa"))
            {
                dgvPhong.Columns.Add(new DataGridViewButtonColumn { Name = "btnXoa", HeaderText = "Thao tác", Text = "Hủy lịch", UseColumnTextForButtonValue = true });
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK) { MessageBox.Show(datBll.NhapTuExcel(ofd.FileName, role)); btnTimKiem_Click(null, null); }
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhong.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                var maDatObj = dgvPhong.Rows[e.RowIndex].Cells["MaDatPhong"].Value;
                if (maDatObj == null || maDatObj == DBNull.Value) return;
                if (MessageBox.Show("Xác nhận hủy?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    datBll.XoaLich(Convert.ToInt32(maDatObj)); btnTimKiem_Click(null, null);
                }
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhong.Columns.Contains("Phòng"))
            {
                flpDetail.Controls.Clear();
                string maPhong = dgvPhong.Rows[e.RowIndex].Cells["Phòng"].Value.ToString();
                string[] lines = datBll.GetChiTietThietBi(maPhong).Split('\n');
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Label lbl = new Label { Text = line.Trim(), AutoSize = true, Font = new Font("Segoe UI", 9.5f), Margin = new Padding(5) };
                        if (line.Contains("📺") || line.Contains("⚠️")) { lbl.Font = new Font("Segoe UI", 10f, FontStyle.Bold); lbl.ForeColor = Color.FromArgb(79, 70, 229); }
                        flpDetail.Controls.Add(lbl);
                    }
                }
            }
        }
    }
}