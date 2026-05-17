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
        private TraCuuBLL traBll = new TraCuuBLL();

        // Dùng dtTatCaPhong như một bộ nhớ tạm (Cache) chứa sẵn danh sách tất cả phòng.
        // Chút nữa khi chọn "Tòa Nhà", ta chỉ việc lọc ngay trên biến này, không cần gọi xuống Database nữa cho nhẹ máy.
        private DataTable dtTatCaPhong;

        public frmDatPhong() { InitializeComponent(); }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            dtpNgayTraCuu.Format = DateTimePickerFormat.Custom;
            dtpNgayTraCuu.CustomFormat = "dd/MM/yyyy";
            dtpNgayDat.Format = DateTimePickerFormat.Custom;
            dtpNgayDat.CustomFormat = "dd/MM/yyyy";

            cboMaGV.DataSource = datBll.LayDSGV();
            cboMaGV.DisplayMember = "MaGV"; cboMaGV.ValueMember = "MaGV";

            dtTatCaPhong = datBll.LayDSPhong();
            cboMaPhong.DataSource = dtTatCaPhong;
            cboMaPhong.DisplayMember = "MaPhong"; cboMaPhong.ValueMember = "MaPhong";

            cmbToaNha.DataSource = traBll.GetToaNhaCombobox();
            cmbToaNha.DisplayMember = "TenKhu"; cmbToaNha.ValueMember = "MaToaNha";

            cmbCaTraCuu.Items.AddRange(new object[] { "ALL", "1", "2", "3" });
            cmbCaTraCuu.SelectedIndex = 0;

            if (cboCaDat.Items.Count > 0) cboCaDat.SelectedIndex = 0;

            if (frmDangNhap.Role == "GiangVien")
            {
                cboMaGV.SelectedValue = frmDangNhap.MaGV;
                cboMaGV.Enabled = false;
                btnImportExcel.Visible = false;
            }

            cmbToaNha.SelectedIndexChanged += DongBo_ToaNha_PhongDat;
            cmbCaTraCuu.SelectedIndexChanged += DongBo_CaHoc;
            dtpNgayTraCuu.ValueChanged += DongBo_NgayDat;

            btnTimKiem_Click(null, null);
        }

        private void DongBo_ToaNha_PhongDat(object sender, EventArgs e)
        {
            if (cmbToaNha.SelectedValue == null || dtTatCaPhong == null) return;
            string toaNha = cmbToaNha.SelectedValue.ToString();

            if (toaNha == "ALL") cboMaPhong.DataSource = dtTatCaPhong;
            else
            {
                // DataView giúp lọc dữ liệu ngay trên RAM (như xài Filter trong Excel)
                // RowFilter = "MaPhong LIKE 'B1%'" nghĩa là tìm các mã phòng bắt đầu bằng chữ "B1"
                DataView dv = new DataView(dtTatCaPhong);
                dv.RowFilter = $"MaPhong LIKE '{toaNha}%'";
                cboMaPhong.DataSource = dv.ToTable();
            }
            cboMaPhong.DisplayMember = "MaPhong";
            cboMaPhong.ValueMember = "MaPhong";
        }

        private void DongBo_CaHoc(object sender, EventArgs e)
        {
            if (cmbCaTraCuu.Text != "ALL") cboCaDat.Text = cmbCaTraCuu.Text;
        }

        private void DongBo_NgayDat(object sender, EventArgs e)
        {
            dtpNgayDat.Value = dtpNgayTraCuu.Value;
        }

        private void cboMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaPhong.SelectedItem is DataRowView dr)
                lblSucChua.Text = "Sức chứa: " + dr["SucChua"].ToString();
        }

        private void cboMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaGV.SelectedValue == null || cboMaGV.SelectedValue is DataRowView) return;
            DataTable dt = datBll.LayChiTietGV(cboMaGV.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtKhoa.Text = dt.Rows[0]["TenKhoa"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMucDich.Text))
            {
                MessageBox.Show("Chưa nhập mục đích!", "Cảnh báo"); return;
            }

            LichDatPhongDTO dto = new LichDatPhongDTO
            {
                MaPhong = cboMaPhong.SelectedValue?.ToString(),
                MaGV = cboMaGV.SelectedValue?.ToString(),
                NgayDat = dtpNgayDat.Value,
                CaHoc = int.Parse(cboCaDat.Text),

                // Công thức quy đổi Ca học sang Tiết: 
                // Ví dụ Ca 2: (2 * 5) - 4 = Tiết 6 (Bắt đầu). Tiết kết thúc = 2 * 5 = Tiết 10.
                TietBatDau = (int.Parse(cboCaDat.Text) * 5) - 4,
                TietKetThuc = int.Parse(cboCaDat.Text) * 5,

                MucDich = txtMucDich.Text
            };

            string res = datBll.XuLyDatPhong(dto, frmDangNhap.Role);
            MessageBox.Show(res, "Thông báo");
            if (res == "Thành công") btnTimKiem_Click(null, null); // Load lại bảng Tra cứu để thấy phòng vừa đặt chuyển sang "Đang bận"
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = traBll.GetDanhSachPhong(dtpNgayTraCuu.Value, cmbCaTraCuu.Text, cmbToaNha.SelectedValue.ToString(), false);

            // Cột MaDatPhong chứa ID ẩn dùng để xóa, nên ta phải ẩn nó đi không cho người dùng thấy
            if (dgvPhong.Columns.Contains("MaDatPhong"))
                dgvPhong.Columns["MaDatPhong"].Visible = false;

            // Kiểm tra nếu chưa có cột Nút "Hủy lịch" thì mới add vào, tránh bị add trùng nhiều lần khi bấm Tìm kiếm liên tục
            if (!dgvPhong.Columns.Contains("btnXoa"))
            {
                dgvPhong.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "btnXoa",
                    HeaderText = "Thao tác",
                    Text = "Hủy lịch",
                    UseColumnTextForButtonValue = true
                });
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(datBll.NhapTuExcel(ofd.FileName, frmDangNhap.Role));
                    btnTimKiem_Click(null, null);
                }
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có bấm đúng vào cột chứa nút "Hủy lịch" không
            if (e.RowIndex >= 0 && dgvPhong.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                var maDatObj = dgvPhong.Rows[e.RowIndex].Cells["MaDatPhong"].Value;
                if (maDatObj == null || maDatObj == DBNull.Value) return; // Nếu phòng trống, MaDatPhong sẽ null nên bỏ qua

                if (MessageBox.Show("Xác nhận hủy?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    traBll.XoaLich(Convert.ToInt32(maDatObj));
                    btnTimKiem_Click(null, null);
                }
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhong.Columns.Contains("Phòng"))
            {
                flpDetail.Controls.Clear();
                string maPhong = dgvPhong.Rows[e.RowIndex].Cells["Phòng"].Value.ToString();

                // Tách chuỗi chi tiết phòng (ngăn cách bởi dấu \n) thành từng dòng nhỏ để tạo Label
                string[] lines = traBll.GetChiTietPhong(maPhong).Split('\n');

                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Label lbl = new Label { Text = line.Trim(), AutoSize = true, Font = new Font("Segoe UI", 9.5f), Margin = new Padding(5) };
                        // Nếu dòng đó có chứa icon màn hình hoặc cảnh báo thì in đậm và tô màu lên cho đẹp
                        if (line.Contains("📺") || line.Contains("⚠️"))
                        {
                            lbl.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                            lbl.ForeColor = Color.FromArgb(79, 70, 229);
                        }
                        flpDetail.Controls.Add(lbl);
                    }
                }
            }
        }
    }
}