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

        public frmDatPhong() { InitializeComponent(); }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            cboMaPhong.DisplayMember = "MaPhong";
            cboMaPhong.ValueMember = "MaPhong";
            cboMaPhong.DataSource = bll.LayDanhSachPhong();

            cboMaGV.DisplayMember = "MaGV";
            cboMaGV.ValueMember = "MaGV";
            cboMaGV.DataSource = bll.LayDanhSachGiangVien();

            txtHoTen.ReadOnly = txtKhoaVien.ReadOnly = txtSDT.ReadOnly = txtSucChua.ReadOnly = true;
            txtTietBD.ReadOnly = txtTietKT.ReadOnly = true;

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
            if (cboMaPhong.SelectedItem is DataRowView row)
                txtSucChua.Text = row["SucChua"].ToString() + " sinh viên";
        }

        private void cboMaGV_SelectedIndexChanged(object sender, EventArgs e) => LoadThongTinChiTietGV();

        private void LoadThongTinChiTietGV()
        {
            if (cboMaGV.SelectedValue == null || cboMaGV.SelectedValue is DataRowView) return;
            DataTable dt = bll.LayChiTietGiangVien(cboMaGV.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtKhoaVien.Text = dt.Rows[0]["TenKhoa"].ToString();
                txtSDT.Text = dt.Rows[0]["SoDienThoai"].ToString();
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
            try
            {
                LichDatPhongDTO dto = new LichDatPhongDTO
                {
                    MaPhong = cboMaPhong.SelectedValue.ToString(),
                    MaGV = cboMaGV.SelectedValue.ToString(),
                    NgayDat = dtpNgayDat.Value,
                    CaHoc = int.Parse(cboCaHoc.Text),
                    TietBatDau = int.Parse(txtTietBD.Text),
                    TietKetThuc = int.Parse(txtTietKT.Text),
                    MucDich = txtMucDich.Text
                };
                string res = bll.DatPhong(dto, frmDangNhap.Role);
                MessageBox.Show(res == "Thành công" ? "Thành công!" : (res == "Trùng lịch" ? "Trùng lịch!" : "Lỗi!"));
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel|*.xlsx" })
                if (ofd.ShowDialog() == DialogResult.OK)
                    MessageBox.Show(bll.NhapTuExcel(ofd.FileName, frmDangNhap.Role));
        }
    }
}