using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmXuatBaoCao : Form
    {
        BaoCaoBLL bll = new BaoCaoBLL();

        public frmXuatBaoCao()
        {
            InitializeComponent();
        }

        private void frmXuatBaoCao_Load(object sender, EventArgs e)
        {
            // Tự động load dữ liệu mẫu lên lưới để người dùng xem trước
            dgvPreview.DataSource = bll.TaiLichSu();

            if (dgvPreview.Columns["Ngày Đặt"] != null)
            {
                dgvPreview.Columns["Ngày Đặt"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            // Bật tính năng nhấp vào tiêu đề cột để sắp xếp (Sort)
            if (dgvPreview.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dgvPreview.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvPreview.Rows.Count > 0)
            {
                MessageBox.Show("Hệ thống đang gọi API Excel để khởi tạo tệp tin...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bll.ExportToExcel(dgvPreview);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}