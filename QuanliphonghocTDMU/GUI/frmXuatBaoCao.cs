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
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvPreview.Rows.Count > 0)
            {
                MessageBox.Show("Hệ thống đang gọi API Excel để khởi tạo tệp tin...", "Thông báo");
                bll.ExportToExcel(dgvPreview);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
            }
        }
    }
}