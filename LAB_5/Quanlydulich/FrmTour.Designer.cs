namespace WindowsFormsApp1
{
    partial class FrmTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboTourChon = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThemTour = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.nudDonGiaKhach = new System.Windows.Forms.NumericUpDown();
            this.nudSoDem = new System.Windows.Forms.NumericUpDown();
            this.nudSoNgay = new System.Windows.Forms.NumericUpDown();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThemDiemDung = new System.Windows.Forms.Button();
            this.txtGhiChuDiemDung = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudHangSaoKhachSan = new System.Windows.Forms.NumericUpDown();
            this.chkCoKhachSan = new System.Windows.Forms.CheckBox();
            this.chkCoNoiAn = new System.Windows.Forms.CheckBox();
            this.chkDoiPhuongTien = new System.Windows.Forms.CheckBox();
            this.txtTenDiemDung = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudThuTuDiemDung = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTourDiemDung = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGanPhuongTien = new System.Windows.Forms.Button();
            this.txtGhiChuPhuongTien = new System.Windows.Forms.TextBox();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudThuTuChang = new System.Windows.Forms.NumericUpDown();
            this.dgvTourPhuongTien = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nudThuTuDiemTQ = new System.Windows.Forms.NumericUpDown();
            this.btnGanDiemTQ = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cboDiemThamQuan = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvTourDiemThamQuan = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHangSaoKhachSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThuTuDiemDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourDiemDung)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThuTuChang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPhuongTien)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThuTuDiemTQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourDiemThamQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tour đang chọn (cho các tab hành trình):";
            // 
            // cboTourChon
            // 
            this.cboTourChon.FormattingEnabled = true;
            this.cboTourChon.Location = new System.Drawing.Point(344, 6);
            this.cboTourChon.Name = "cboTourChon";
            this.cboTourChon.Size = new System.Drawing.Size(169, 24);
            this.cboTourChon.TabIndex = 1;
            this.cboTourChon.SelectedIndexChanged += new System.EventHandler(this.cboTourChon_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 372);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnThemTour);
            this.tabPage1.Controls.Add(this.txtMoTa);
            this.tabPage1.Controls.Add(this.nudDonGiaKhach);
            this.tabPage1.Controls.Add(this.nudSoDem);
            this.tabPage1.Controls.Add(this.nudSoNgay);
            this.tabPage1.Controls.Add(this.txtTenTour);
            this.tabPage1.Controls.Add(this.txtMaTour);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvTour);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tour";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnThemTour
            // 
            this.btnThemTour.Location = new System.Drawing.Point(689, 264);
            this.btnThemTour.Name = "btnThemTour";
            this.btnThemTour.Size = new System.Drawing.Size(75, 36);
            this.btnThemTour.TabIndex = 16;
            this.btnThemTour.Text = "Thêm tour";
            this.btnThemTour.UseVisualStyleBackColor = true;
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(52, 303);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(584, 22);
            this.txtMoTa.TabIndex = 15;
            // 
            // nudDonGiaKhach
            // 
            this.nudDonGiaKhach.Location = new System.Drawing.Point(484, 260);
            this.nudDonGiaKhach.Name = "nudDonGiaKhach";
            this.nudDonGiaKhach.Size = new System.Drawing.Size(141, 22);
            this.nudDonGiaKhach.TabIndex = 14;
            // 
            // nudSoDem
            // 
            this.nudSoDem.Location = new System.Drawing.Point(274, 261);
            this.nudSoDem.Name = "nudSoDem";
            this.nudSoDem.Size = new System.Drawing.Size(81, 22);
            this.nudSoDem.TabIndex = 13;
            // 
            // nudSoNgay
            // 
            this.nudSoNgay.Location = new System.Drawing.Point(74, 266);
            this.nudSoNgay.Name = "nudSoNgay";
            this.nudSoNgay.Size = new System.Drawing.Size(81, 22);
            this.nudSoNgay.TabIndex = 12;
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(282, 221);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(354, 22);
            this.txtTenTour.TabIndex = 8;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(74, 221);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(118, 22);
            this.txtMaTour.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá/khách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số đêm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Tour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Tour:";
            // 
            // dgvTour
            // 
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Location = new System.Drawing.Point(6, 6);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.RowHeadersWidth = 51;
            this.dgvTour.RowTemplate.Height = 24;
            this.dgvTour.Size = new System.Drawing.Size(766, 195);
            this.dgvTour.TabIndex = 0;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            this.dgvTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnThemDiemDung);
            this.tabPage2.Controls.Add(this.txtGhiChuDiemDung);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.nudHangSaoKhachSan);
            this.tabPage2.Controls.Add(this.chkCoKhachSan);
            this.tabPage2.Controls.Add(this.chkCoNoiAn);
            this.tabPage2.Controls.Add(this.chkDoiPhuongTien);
            this.tabPage2.Controls.Add(this.txtTenDiemDung);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.nudThuTuDiemDung);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dgvTourDiemDung);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Điểm dừng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThemDiemDung
            // 
            this.btnThemDiemDung.Location = new System.Drawing.Point(628, 257);
            this.btnThemDiemDung.Name = "btnThemDiemDung";
            this.btnThemDiemDung.Size = new System.Drawing.Size(139, 38);
            this.btnThemDiemDung.TabIndex = 12;
            this.btnThemDiemDung.Text = "Thêm điểm dừng";
            this.btnThemDiemDung.UseVisualStyleBackColor = true;
            this.btnThemDiemDung.Click += new System.EventHandler(this.btnThemDiemDung_Click);
            // 
            // txtGhiChuDiemDung
            // 
            this.txtGhiChuDiemDung.Location = new System.Drawing.Point(72, 293);
            this.txtGhiChuDiemDung.Name = "txtGhiChuDiemDung";
            this.txtGhiChuDiemDung.Size = new System.Drawing.Size(498, 22);
            this.txtGhiChuDiemDung.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ghi chú: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hạng sao:";
            // 
            // nudHangSaoKhachSan
            // 
            this.nudHangSaoKhachSan.Location = new System.Drawing.Point(522, 254);
            this.nudHangSaoKhachSan.Name = "nudHangSaoKhachSan";
            this.nudHangSaoKhachSan.Size = new System.Drawing.Size(48, 22);
            this.nudHangSaoKhachSan.TabIndex = 8;
            // 
            // chkCoKhachSan
            // 
            this.chkCoKhachSan.AutoSize = true;
            this.chkCoKhachSan.Location = new System.Drawing.Point(299, 256);
            this.chkCoKhachSan.Name = "chkCoKhachSan";
            this.chkCoKhachSan.Size = new System.Drawing.Size(110, 20);
            this.chkCoKhachSan.TabIndex = 7;
            this.chkCoKhachSan.Text = "Có khách sạn";
            this.chkCoKhachSan.UseVisualStyleBackColor = true;
            // 
            // chkCoNoiAn
            // 
            this.chkCoNoiAn.AutoSize = true;
            this.chkCoNoiAn.Location = new System.Drawing.Point(173, 256);
            this.chkCoNoiAn.Name = "chkCoNoiAn";
            this.chkCoNoiAn.Size = new System.Drawing.Size(85, 20);
            this.chkCoNoiAn.TabIndex = 6;
            this.chkCoNoiAn.Text = "Có nơi ăn";
            this.chkCoNoiAn.UseVisualStyleBackColor = true;
            // 
            // chkDoiPhuongTien
            // 
            this.chkDoiPhuongTien.AutoSize = true;
            this.chkDoiPhuongTien.Location = new System.Drawing.Point(12, 256);
            this.chkDoiPhuongTien.Name = "chkDoiPhuongTien";
            this.chkDoiPhuongTien.Size = new System.Drawing.Size(121, 20);
            this.chkDoiPhuongTien.TabIndex = 5;
            this.chkDoiPhuongTien.Text = "Đổi phương tiện";
            this.chkDoiPhuongTien.UseVisualStyleBackColor = true;
            // 
            // txtTenDiemDung
            // 
            this.txtTenDiemDung.Location = new System.Drawing.Point(277, 208);
            this.txtTenDiemDung.Name = "txtTenDiemDung";
            this.txtTenDiemDung.Size = new System.Drawing.Size(232, 22);
            this.txtTenDiemDung.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tên điểm dừng:";
            // 
            // nudThuTuDiemDung
            // 
            this.nudThuTuDiemDung.Location = new System.Drawing.Point(74, 209);
            this.nudThuTuDiemDung.Name = "nudThuTuDiemDung";
            this.nudThuTuDiemDung.Size = new System.Drawing.Size(67, 22);
            this.nudThuTuDiemDung.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Thứ tự:";
            // 
            // dgvTourDiemDung
            // 
            this.dgvTourDiemDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourDiemDung.Location = new System.Drawing.Point(7, 7);
            this.dgvTourDiemDung.Name = "dgvTourDiemDung";
            this.dgvTourDiemDung.RowHeadersWidth = 51;
            this.dgvTourDiemDung.RowTemplate.Height = 24;
            this.dgvTourDiemDung.Size = new System.Drawing.Size(777, 189);
            this.dgvTourDiemDung.TabIndex = 0;
            this.dgvTourDiemDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            this.dgvTourDiemDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGanPhuongTien);
            this.tabPage3.Controls.Add(this.txtGhiChuPhuongTien);
            this.tabPage3.Controls.Add(this.cboPhuongTien);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.nudThuTuChang);
            this.tabPage3.Controls.Add(this.dgvTourPhuongTien);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(790, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phương tiện theo chặn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGanPhuongTien
            // 
            this.btnGanPhuongTien.Location = new System.Drawing.Point(616, 236);
            this.btnGanPhuongTien.Name = "btnGanPhuongTien";
            this.btnGanPhuongTien.Size = new System.Drawing.Size(139, 34);
            this.btnGanPhuongTien.TabIndex = 7;
            this.btnGanPhuongTien.Text = "Gán phương tiện";
            this.btnGanPhuongTien.UseVisualStyleBackColor = true;
            this.btnGanPhuongTien.Click += new System.EventHandler(this.btnGanPhuongTien_Click);
            // 
            // txtGhiChuPhuongTien
            // 
            this.txtGhiChuPhuongTien.Location = new System.Drawing.Point(86, 263);
            this.txtGhiChuPhuongTien.Name = "txtGhiChuPhuongTien";
            this.txtGhiChuPhuongTien.Size = new System.Drawing.Size(468, 22);
            this.txtGhiChuPhuongTien.TabIndex = 6;
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Location = new System.Drawing.Point(333, 216);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(221, 24);
            this.cboPhuongTien.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Ghi chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Phương tiện:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Chặng thứ:";
            // 
            // nudThuTuChang
            // 
            this.nudThuTuChang.Location = new System.Drawing.Point(86, 219);
            this.nudThuTuChang.Name = "nudThuTuChang";
            this.nudThuTuChang.Size = new System.Drawing.Size(120, 22);
            this.nudThuTuChang.TabIndex = 1;
            // 
            // dgvTourPhuongTien
            // 
            this.dgvTourPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourPhuongTien.Location = new System.Drawing.Point(9, 13);
            this.dgvTourPhuongTien.Name = "dgvTourPhuongTien";
            this.dgvTourPhuongTien.RowHeadersWidth = 51;
            this.dgvTourPhuongTien.RowTemplate.Height = 24;
            this.dgvTourPhuongTien.Size = new System.Drawing.Size(775, 185);
            this.dgvTourPhuongTien.TabIndex = 0;
            this.dgvTourPhuongTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            this.dgvTourPhuongTien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.nudThuTuDiemTQ);
            this.tabPage4.Controls.Add(this.btnGanDiemTQ);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.cboDiemThamQuan);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.dgvTourDiemThamQuan);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(790, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Điểm tham quan";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // nudThuTuDiemTQ
            // 
            this.nudThuTuDiemTQ.Location = new System.Drawing.Point(446, 217);
            this.nudThuTuDiemTQ.Name = "nudThuTuDiemTQ";
            this.nudThuTuDiemTQ.Size = new System.Drawing.Size(76, 22);
            this.nudThuTuDiemTQ.TabIndex = 6;
            // 
            // btnGanDiemTQ
            // 
            this.btnGanDiemTQ.Location = new System.Drawing.Point(651, 219);
            this.btnGanDiemTQ.Name = "btnGanDiemTQ";
            this.btnGanDiemTQ.Size = new System.Drawing.Size(111, 23);
            this.btnGanDiemTQ.TabIndex = 5;
            this.btnGanDiemTQ.Text = "Gắn điểm TQ";
            this.btnGanDiemTQ.UseVisualStyleBackColor = true;
            this.btnGanDiemTQ.Click += new System.EventHandler(this.btnGanDiemTQ_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(390, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Thứ tự: ";
            // 
            // cboDiemThamQuan
            // 
            this.cboDiemThamQuan.FormattingEnabled = true;
            this.cboDiemThamQuan.Location = new System.Drawing.Point(121, 216);
            this.cboDiemThamQuan.Name = "cboDiemThamQuan";
            this.cboDiemThamQuan.Size = new System.Drawing.Size(220, 24);
            this.cboDiemThamQuan.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Điểm tham quan:";
            // 
            // dgvTourDiemThamQuan
            // 
            this.dgvTourDiemThamQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourDiemThamQuan.Location = new System.Drawing.Point(-4, 15);
            this.dgvTourDiemThamQuan.Name = "dgvTourDiemThamQuan";
            this.dgvTourDiemThamQuan.RowHeadersWidth = 51;
            this.dgvTourDiemThamQuan.RowTemplate.Height = 24;
            this.dgvTourDiemThamQuan.Size = new System.Drawing.Size(767, 195);
            this.dgvTourDiemThamQuan.TabIndex = 0;
            this.dgvTourDiemThamQuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            this.dgvTourDiemThamQuan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboTourChon);
            this.Controls.Add(this.label1);
            this.Name = "FrmTour";
            this.Text = "FrmTour";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHangSaoKhachSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThuTuDiemDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourDiemDung)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThuTuChang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPhuongTien)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThuTuDiemTQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourDiemThamQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTourChon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemTour;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.NumericUpDown nudDonGiaKhach;
        private System.Windows.Forms.NumericUpDown nudSoDem;
        private System.Windows.Forms.NumericUpDown nudSoNgay;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvTourDiemDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudThuTuDiemDung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkCoNoiAn;
        private System.Windows.Forms.CheckBox chkDoiPhuongTien;
        private System.Windows.Forms.TextBox txtTenDiemDung;
        private System.Windows.Forms.CheckBox chkCoKhachSan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudHangSaoKhachSan;
        private System.Windows.Forms.Button btnThemDiemDung;
        private System.Windows.Forms.TextBox txtGhiChuDiemDung;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGanPhuongTien;
        private System.Windows.Forms.TextBox txtGhiChuPhuongTien;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudThuTuChang;
        private System.Windows.Forms.DataGridView dgvTourPhuongTien;
        private System.Windows.Forms.Button btnGanDiemTQ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboDiemThamQuan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvTourDiemThamQuan;
        private System.Windows.Forms.NumericUpDown nudThuTuDiemTQ;
    }
}