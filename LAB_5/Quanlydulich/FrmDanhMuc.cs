using System;
using System.Data;
using System.Data.SqlClient; // Nếu dùng project mới đổi thành Microsoft.Data.SqlClient
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmDanhMuc : Form
    {
        // Chuỗi kết nối đến CSDL QuanLyCongTyDuLich
        private string connectionString = @"Data Source=.;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True;";

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDataPhuongTien();
            LoadDataDiemBanVe();
            LoadDataHuongDanVien();
            LoadDataDiemThamQuan();
        }

        #region 1. TAB PHƯƠNG TIỆN
        private void LoadDataPhuongTien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT MaPT AS [MaPT], TenPT AS [TenPT], GhiChu AS [GhiChu] FROM PhuongTien";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPhuongTien.DataSource = dt;
                    dgvPhuongTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải bảng Phương tiện: " + ex.Message);
                }
            }
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPT.Text) || string.IsNullOrWhiteSpace(txtTenPT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã PT và Tên PT!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO PhuongTien (MaPT, TenPT, GhiChu) VALUES (@MaPT, @TenPT, @GhiChu)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPT", txtMaPT.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenPT", txtTenPT.Text.Trim());
                        cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrEmpty(txtGhiChu.Text) ? (object)DBNull.Value : txtGhiChu.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm phương tiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataPhuongTien();
                        ClearInputsPT();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Lỗi trùng khóa chính hoặc tên PT duy nhất
                        MessageBox.Show("Mã phương tiện hoặc tên phương tiện đã tồn tại!");
                    else
                        MessageBox.Show("Lỗi SQL Server: " + ex.Message);
                }
            }
        }

        private void dgvPhuongTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhuongTien.Rows[e.RowIndex];
                txtMaPT.Text = row.Cells["MaPT"].Value?.ToString();
                txtTenPT.Text = row.Cells["TenPT"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }

        private void ClearInputsPT()
        {
            txtMaPT.Clear();
            txtTenPT.Clear();
            txtGhiChu.Clear();
            txtMaPT.Focus();
        }
        #endregion

        #region 2. KHU VỰC TẢI DỮ LIỆU CÁC TAB CÒN LẠI (Mở rộng sau)
        private void LoadDataDiemBanVe()
        {
            // Tương tự: SELECT MaDiemBan, TenDiemBan, DiaChi, DienThoai FROM DiemBanVe
        }

        private void LoadDataHuongDanVien()
        {
            // Tương tự: SELECT MaHDV, HoTen, DienThoai, LuongCoBan FROM HuongDanVien
        }

        private void LoadDataDiemThamQuan()
        {
            // Tương tự: SELECT MaDiemTQ, TenDiemTQ, DiaDiem, NoiDung FROM DiemThamQuan
        }
        #endregion

        // Nút Đóng Form
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}