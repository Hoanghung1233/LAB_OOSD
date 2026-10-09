using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmTour : Form
    {
        // Chuỗi kết nối CSDL SQL Server
        private string connectionString = @"Data Source=.;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True;";

        public FrmTour()
        {
            InitializeComponent();
        }

        private void FrmTour_Load(object sender, EventArgs e)
        {
            // 1. Nạp danh sách Tour vào ComboBox và DataGridView chính
            LoadComboboxTourChon();
            LoadDataTour();

            // 2. Nạp sẵn danh sách Phương tiện và Điểm tham quan vào các ComboBox phụ
            LoadComboboxPhuongTien();
            LoadComboboxDiemThamQuan();

            // 3. Nếu đã có dữ liệu Tour, tự động nạp dữ liệu chi tiết cho 3 DataGridView của 3 Tab còn lại
            if (cboTourChon.Items.Count > 0)
            {
                cboTourChon.SelectedIndex = 0; // Chọn tour đầu tiên
                string maTourDauTien = cboTourChon.SelectedValue.ToString();

                LoadDataDiemDung(maTourDauTien);
                LoadDataPhuongTienChang(maTourDauTien);
                LoadDataDiemThamQuanTour(maTourDauTien);
            }

            // Cấu hình ban đầu cho ô Hạng sao
            nudHangSaoKhachSan.Enabled = chkCoKhachSan.Checked;
        }

        #region --- DỮ LIỆU CHUNG & TAB 1: TOUR ---
        private void LoadComboboxTourChon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT MaTour, TenTour FROM Tour";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboTourChon.DataSource = dt;
                    cboTourChon.DisplayMember = "TenTour";
                    cboTourChon.ValueMember = "MaTour";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách tour: " + ex.Message);
                }
            }
        }

        private void LoadDataTour()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT MaTour, TenTour, SoNgay, SoDem, DonGiaKhach, MoTa, DangMoBan FROM Tour";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTour.DataSource = dt;
                    dgvTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải bảng Tour: " + ex.Message);
                }
            }
        }

        private void cboTourChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTourChon.SelectedValue != null && cboTourChon.SelectedValue is string maTour)
            {
                LoadDataDiemDung(maTour);
                LoadDataPhuongTienChang(maTour);
                LoadDataDiemThamQuanTour(maTour);
            }
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTour.Rows[e.RowIndex];
                string maTour = row.Cells["MaTour"].Value?.ToString();

                txtMaTour.Text = maTour;
                txtTenTour.Text = row.Cells["TenTour"].Value?.ToString();
                nudSoNgay.Value = Convert.ToDecimal(row.Cells["SoNgay"].Value ?? 1);
                nudSoDem.Value = Convert.ToDecimal(row.Cells["SoDem"].Value ?? 0);
                nudDonGiaKhach.Value = Convert.ToDecimal(row.Cells["DonGiaKhach"].Value ?? 0);
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();

                cboTourChon.SelectedValue = maTour;
            }
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTour.Text) || string.IsNullOrWhiteSpace(txtTenTour.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã tour và Tên tour!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO Tour (MaTour, TenTour, SoNgay, SoDem, DonGiaKhach, MoTa, DangMoBan) 
                                  VALUES (@MaTour, @TenTour, @SoNgay, @SoDem, @DonGiaKhach, @MoTa, 1)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTour", txtMaTour.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenTour", txtTenTour.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoNgay", (int)nudSoNgay.Value);
                        cmd.Parameters.AddWithValue("@SoDem", (int)nudSoDem.Value);
                        cmd.Parameters.AddWithValue("@DonGiaKhach", nudDonGiaKhach.Value);
                        cmd.Parameters.AddWithValue("@MoTa", string.IsNullOrEmpty(txtMoTa.Text) ? (object)DBNull.Value : txtMoTa.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm Tour mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataTour();
                        LoadComboboxTourChon();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Mã tour này đã tồn tại!");
                    else
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }
        #endregion

        #region --- TAB 2: ĐIỂM DỪNG ---
        private void LoadDataDiemDung(string maTour)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT ThuTu, TenDiemDung, DoiPhuongTien, CoNoiAn, CoKhachSan, HangSaoKhachSan, GhiChu FROM TourDiemDung WHERE MaTour = @MaTour ORDER BY ThuTu";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaTour", maTour);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTourDiemDung.DataSource = dt;
                    dgvTourDiemDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    nudThuTuDiemDung.Value = dt.Rows.Count + 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải điểm dừng: " + ex.Message);
                }
            }
        }

        private void chkCoKhachSan_CheckedChanged(object sender, EventArgs e)
        {
            nudHangSaoKhachSan.Enabled = chkCoKhachSan.Checked;
        }

        private void btnThemDiemDung_Click(object sender, EventArgs e)
        {
            if (cboTourChon.SelectedValue == null || string.IsNullOrWhiteSpace(txtTenDiemDung.Text))
            {
                MessageBox.Show("Vui lòng chọn tour và nhập tên điểm dừng!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO TourDiemDung (MaTour, ThuTu, TenDiemDung, DoiPhuongTien, CoNoiAn, CoKhachSan, HangSaoKhachSan, GhiChu)
                                  VALUES (@MaTour, @ThuTu, @TenDiemDung, @DoiPhuongTien, @CoNoiAn, @CoKhachSan, @HangSaoKhachSan, @GhiChu)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTour", cboTourChon.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@ThuTu", (int)nudThuTuDiemDung.Value);
                        cmd.Parameters.AddWithValue("@TenDiemDung", txtTenDiemDung.Text.Trim());
                        cmd.Parameters.AddWithValue("@DoiPhuongTien", chkDoiPhuongTien.Checked);
                        cmd.Parameters.AddWithValue("@CoNoiAn", chkCoNoiAn.Checked);
                        cmd.Parameters.AddWithValue("@CoKhachSan", chkCoKhachSan.Checked);
                        cmd.Parameters.AddWithValue("@HangSaoKhachSan", chkCoKhachSan.Checked ? (object)(int)nudHangSaoKhachSan.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrEmpty(txtGhiChuDiemDung.Text) ? (object)DBNull.Value : txtGhiChuDiemDung.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm điểm dừng thành công!");

                        LoadDataDiemDung(cboTourChon.SelectedValue.ToString());
                        txtTenDiemDung.Clear();
                        txtGhiChuDiemDung.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm điểm dừng: " + ex.Message);
                }
            }
        }
        #endregion

        #region --- TAB 3: PHƯƠNG TIỆN THEO CHẶNG ---
        private void LoadComboboxPhuongTien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT MaPT, TenPT FROM PhuongTien";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboPhuongTien.DataSource = dt;
                    cboPhuongTien.DisplayMember = "TenPT";
                    cboPhuongTien.ValueMember = "MaPT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải phương tiện: " + ex.Message);
                }
            }
        }

        private void LoadDataPhuongTienChang(string maTour)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT tp.ThuTuChang, pt.TenPT, tp.MaPT, tp.GhiChu 
                                  FROM TourPhuongTien tp 
                                  JOIN PhuongTien pt ON tp.MaPT = pt.MaPT 
                                  WHERE tp.MaTour = @MaTour ORDER BY tp.ThuTuChang";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaTour", maTour);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTourPhuongTien.DataSource = dt;
                    dgvTourPhuongTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải phương tiện chặng: " + ex.Message);
                }
            }
        }

        private void btnGanPhuongTien_Click(object sender, EventArgs e)
        {
            if (cboTourChon.SelectedValue == null || cboPhuongTien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tour và phương tiện!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO TourPhuongTien (MaTour, ThuTuChang, MaPT, GhiChu) 
                                  VALUES (@MaTour, @ThuTuChang, @MaPT, @GhiChu)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTour", cboTourChon.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@ThuTuChang", (int)nudThuTuChang.Value);
                        cmd.Parameters.AddWithValue("@MaPT", cboPhuongTien.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrEmpty(txtGhiChuPhuongTien.Text) ? (object)DBNull.Value : txtGhiChuPhuongTien.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Gán phương tiện thành công!");

                        LoadDataPhuongTienChang(cboTourChon.SelectedValue.ToString());
                        txtGhiChuPhuongTien.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gán phương tiện: " + ex.Message);
                }
            }
        }
        #endregion

        #region --- TAB 4: ĐIỂM THAM QUAN ---
        private void LoadComboboxDiemThamQuan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT MaDiemTQ, TenDiemTQ FROM DiemThamQuan";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboDiemThamQuan.DataSource = dt;
                    cboDiemThamQuan.DisplayMember = "TenDiemTQ";
                    cboDiemThamQuan.ValueMember = "MaDiemTQ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách điểm tham quan: " + ex.Message);
                }
            }
        }

        private void LoadDataDiemThamQuanTour(string maTour)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT tq.ThuTu, dtq.MaDiemTQ, dtq.TenDiemTQ, dtq.DiaDiem 
                                  FROM TourDiemThamQuan tq 
                                  JOIN DiemThamQuan dtq ON tq.MaDiemTQ = dtq.MaDiemTQ 
                                  WHERE tq.MaTour = @MaTour ORDER BY tq.ThuTu";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaTour", maTour);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTourDiemThamQuan.DataSource = dt;
                    dgvTourDiemThamQuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    nudThuTuDiemTQ.Value = dt.Rows.Count + 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải điểm tham quan tour: " + ex.Message);
                }
            }
        }

        private void btnGanDiemTQ_Click(object sender, EventArgs e)
        {
            if (cboTourChon.SelectedValue == null || cboDiemThamQuan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tour và điểm tham quan!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO TourDiemThamQuan (MaTour, MaDiemTQ, ThuTu) 
                                  VALUES (@MaTour, @MaDiemTQ, @ThuTu)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTour", cboTourChon.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@MaDiemTQ", cboDiemThamQuan.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@ThuTu", (int)nudThuTuDiemTQ.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Gán điểm tham quan thành công!");

                        LoadDataDiemThamQuanTour(cboTourChon.SelectedValue.ToString());
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Điểm tham quan này hoặc thứ tự này đã tồn tại trong tour!");
                    else
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }
        #endregion

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}