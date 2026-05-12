using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmTraCuu : Form
    {
        private TraCuuBLL bll = new TraCuuBLL();

        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            cmbCaHoc.Items.Clear();
            cmbCaHoc.Items.AddRange(new object[] { "ALL", "1", "2", "3" });
            cmbCaHoc.SelectedIndex = 0;

            try
            {
                cmbToaNha.DataSource = bll.GetToaNhaCombobox();
                cmbToaNha.DisplayMember = "TenKhu";
                cmbToaNha.ValueMember = "MaToaNha";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnTimKiem_Click(null, null);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string toaNha = cmbToaNha.SelectedValue?.ToString() ?? "ALL";

                DataTable dt = bll.GetDanhSachPhong(
                    dtpNgay.Value,
                    cmbCaHoc.Text,
                    toaNha,
                    false
                );

                dgvPhong.DataSource = dt;

                if (dgvPhong.Columns.Contains("MaDatPhong"))
                    dgvPhong.Columns["MaDatPhong"].Visible = false;

                if (!dgvPhong.Columns.Contains("btnXoa"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Name = "btnXoa";
                    btn.HeaderText = "Thao tác";
                    btn.Text = "Hủy lịch";
                    btn.UseColumnTextForButtonValue = true;

                    dgvPhong.Columns.Add(btn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvPhong.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                var maDatObj = dgvPhong.Rows[e.RowIndex].Cells["MaDatPhong"].Value;

                if (maDatObj == null || maDatObj == DBNull.Value)
                {
                    MessageBox.Show("Không có lịch để xóa!");
                    return;
                }

                int maDat = Convert.ToInt32(maDatObj);

                DialogResult rs = MessageBox.Show(
                    "Xác nhận hủy lịch?",
                    "Thông báo",
                    MessageBoxButtons.YesNo
                );

                if (rs == DialogResult.Yes)
                {
                    if (bll.XoaLich(maDat))
                    {
                        MessageBox.Show("Đã xóa!");

                        btnTimKiem_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                if (dgvPhong.Columns.Contains("Phòng"))
                {
                    string maPhong = dgvPhong.Rows[e.RowIndex]
                        .Cells["Phòng"]
                        .Value
                        .ToString();

                    flpDetail.Controls.Clear();

                    string raw = bll.GetChiTietPhong(maPhong);

                    string[] lines = raw.Split('\n');

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        Label lbl = new Label();

                        lbl.Text = line.Trim();
                        lbl.AutoSize = true;
                        lbl.Font = new Font("Segoe UI", 10);
                        lbl.Margin = new Padding(5);

                        flpDetail.Controls.Add(lbl);
                    }
                }
            }
            catch
            {
            }
        }
    }
}