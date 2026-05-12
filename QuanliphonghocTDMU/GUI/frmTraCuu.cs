using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmTraCuu : Form
    {
        TraCuuBLL bll = new TraCuuBLL();

        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu Ca học
            cmbCaHoc.Items.Clear();
            cmbCaHoc.Items.AddRange(new object[] { "ALL", "1", "2", "3" });
            cmbCaHoc.SelectedIndex = 0;

            // Nạp dữ liệu Tòa nhà
            try
            {
                cmbToaNha.DataSource = bll.GetToaNhaCombobox();
                cmbToaNha.DisplayMember = "TenKhu";
                cmbToaNha.ValueMember = "MaToaNha";
            }
            catch { }

            // Gọi tìm kiếm lần đầu
            btnTimKiem_Click(null, null);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string toaNha = cmbToaNha.SelectedValue?.ToString() ?? "";
                dgvPhong.DataSource = bll.GetDanhSachPhong(dtpNgay.Value, cmbCaHoc.Text, toaNha, false);

                // Định dạng lưới cho đẹp
                dgvPhong.AllowUserToAddRows = false;
                dgvPhong.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhong.Columns.Contains("Phòng"))
            {
                string maP = dgvPhong.Rows[e.RowIndex].Cells["Phòng"].Value.ToString();
                flpDetail.Controls.Clear();

                // 1. Lấy dữ liệu chi tiết
                string rawData = bll.GetChiTietPhong(maP);
                string[] lines = rawData.Split('\n');

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Tạo Panel Card cho mỗi dòng thông tin
                    Guna.UI2.WinForms.Guna2Panel card = new Guna.UI2.WinForms.Guna2Panel();
                    card.Size = new Size(flpDetail.Width - 25, 45);
                    card.FillColor = line.Contains("SỰ CỐ") ? Color.FromArgb(254, 242, 242) : Color.White;
                    card.BorderRadius = 8;
                    card.BorderThickness = 1;
                    card.BorderColor = Color.FromArgb(230, 230, 230);
                    card.Margin = new Padding(0, 0, 0, 8);

                    Label lbl = new Label();
                    lbl.Text = line.Trim();
                    lbl.Dock = DockStyle.Fill;
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Padding = new Padding(10, 0, 0, 0);
                    lbl.ForeColor = line.Contains("SỰ CỐ") ? Color.Red : Color.Black;
                    lbl.Font = new Font("Segoe UI", 9, line.Contains("THIẾT BỊ") ? FontStyle.Bold : FontStyle.Regular);

                    card.Controls.Add(lbl);
                    flpDetail.Controls.Add(card);
                }
            }
        }
    }
}