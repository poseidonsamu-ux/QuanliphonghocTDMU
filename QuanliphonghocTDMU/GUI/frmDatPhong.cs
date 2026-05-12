using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDatPhong : Form
    {
        private DatPhongBLL bll = new DatPhongBLL();

        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            // FIX: Set DisplayMember và ValueMember TRƯỚC khi gán DataSource
            cboMaPhong.DisplayMember = "MaPhong";
            cboMaPhong.ValueMember = "MaPhong";
            cboMaPhong.DataSource = bll.LayDanhSachPhong();
            cboMaPhong.DropDownStyle = ComboBoxStyle.DropDownList;

            cboMaGV.DisplayMember = "MaGV";
            cboMaGV.ValueMember = "MaGV";
            cboMaGV.DataSource = bll.LayDanhSachGiangVien();
            cboMaGV.DropDownStyle = ComboBoxStyle.DropDownList;

            cboCaHoc.DropDownStyle = ComboBoxStyle.DropDownList;

            // Khóa các ô chỉ để hiển thị
            txtHoTen.ReadOnly = true;
            txtKhoaVien.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtSucChua.ReadOnly = true;
            txtTietBD.Enabled = false;
            txtTietKT.Enabled = false;

            // Xử lý phân quyền
            if (frmDangNhap.Role == "GiangVien")
            {
                cboMaGV.SelectedValue = frmDangNhap.MaGV;
                cboMaGV.Enabled = false;
                btnImportExcel.Visible = false;
            }

            if (cboCaHoc.Items.Count > 0) cboCaHoc.SelectedIndex = 0;
            LoadThongTinChiTietGV();
        }

        private void cboMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FIX: Kiểm tra điều kiện cẩn thận trước khi gán
            if (cboMaPhong.SelectedItem != null && cboMaPhong.SelectedItem is DataRowView)
            {
                DataRowView row = (DataRowView)cboMaPhong.SelectedItem;
                txtSucChua.Text = row["SucChua"].ToString() + " sinh viên";
            }
        }

        private void cboMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinChiTietGV();
        }

        private void LoadThongTinChiTietGV()
        {
            // FIX: Chặn lỗi DataRowView
            if (cboMaGV.SelectedValue == null || cboMaGV.SelectedValue is DataRowView) return;

            DataTable dt = bll.LayChiTietGiangVien(cboMaGV.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtKhoaVien.Text = dt.Rows[0]["TenKhoa"].ToString();
                txtSDT.Text = dt.Rows[0]["SoDienThoai"].ToString();
            }
            else
            {
                txtHoTen.Text = "";
                txtKhoaVien.Text = "";
                txtSDT.Text = "";
            }
        }

        private void cboCaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ca = cboCaHoc.SelectedItem?.ToString();
            if (ca == "1") { txtTietBD.Text = "1"; txtTietKT.Text = "5"; }
            else if (ca == "2") { txtTietBD.Text = "6"; txtTietKT.Text = "10"; }
            else if (ca == "3") { txtTietBD.Text = "11"; txtTietKT.Text = "15"; }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (cboMaPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LichDatPhongDTO dto = new LichDatPhongDTO
                {
                    MaPhong = cboMaPhong.SelectedValue.ToString(),
                    MaGV = cboMaGV.SelectedValue.ToString(),
                    NgayDat = dtpNgayDat.Value,
                    CaHoc = Convert.ToInt32(cboCaHoc.Text),
                    TietBatDau = Convert.ToInt32(txtTietBD.Text),
                    TietKetThuc = Convert.ToInt32(txtTietKT.Text),
                    MucDich = txtMucDich.Text
                };

                string res = bll.DatPhong(dto, frmDangNhap.Role);
                if (res == "Thành công")
                {
                    string msg = frmDangNhap.Role == "Admin" ? "Đặt phòng thành công. Đã duyệt!" : "Đã gửi yêu cầu đặt phòng. Chờ duyệt!";
                    MessageBox.Show(msg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMucDich.Clear();
                }
                else if (res == "Trùng lịch")
                    MessageBox.Show("Phòng đã có người đặt trong ca này!", "Trùng lịch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Lỗi hệ thống khi lưu dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xlsx;*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string thongBao = bll.NhapTuExcel(ofd.FileName, frmDangNhap.Role);
                    MessageBox.Show(thongBao, "Kết quả Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}