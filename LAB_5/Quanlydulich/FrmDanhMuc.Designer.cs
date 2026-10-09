namespace WindowsFormsApp1
{
    partial class FrmDanhMuc
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHuongDanVien = new System.Windows.Forms.TabPage();
            this.tabPageDiemBanVe = new System.Windows.Forms.TabPage();
            this.tabPagePhuongTien = new System.Windows.Forms.TabPage();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhuongTien = new System.Windows.Forms.DataGridView();
            this.tabPageDiemThamQuan = new System.Windows.Forms.TabPage();
            this.btnDong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPagePhuongTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePhuongTien);
            this.tabControl1.Controls.Add(this.tabPageDiemBanVe);
            this.tabControl1.Controls.Add(this.tabPageHuongDanVien);
            this.tabControl1.Controls.Add(this.tabPageDiemThamQuan);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHuongDanVien
            // 
            this.tabPageHuongDanVien.Location = new System.Drawing.Point(4, 25);
            this.tabPageHuongDanVien.Name = "tabPageHuongDanVien";
            this.tabPageHuongDanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHuongDanVien.Size = new System.Drawing.Size(793, 373);
            this.tabPageHuongDanVien.TabIndex = 0;
            this.tabPageHuongDanVien.Text = "Hướng dẫn viên";
            this.tabPageHuongDanVien.UseVisualStyleBackColor = true;
            // 
            // tabPageDiemBanVe
            // 
            this.tabPageDiemBanVe.Location = new System.Drawing.Point(4, 25);
            this.tabPageDiemBanVe.Name = "tabPageDiemBanVe";
            this.tabPageDiemBanVe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiemBanVe.Size = new System.Drawing.Size(793, 373);
            this.tabPageDiemBanVe.TabIndex = 1;
            this.tabPageDiemBanVe.Text = "Điểm bán vé";
            this.tabPageDiemBanVe.UseVisualStyleBackColor = true;
            // 
            // tabPagePhuongTien
            // 
            this.tabPagePhuongTien.Controls.Add(this.btnThemPT);
            this.tabPagePhuongTien.Controls.Add(this.txtGhiChu);
            this.tabPagePhuongTien.Controls.Add(this.txtTenPT);
            this.tabPagePhuongTien.Controls.Add(this.txtMaPT);
            this.tabPagePhuongTien.Controls.Add(this.label3);
            this.tabPagePhuongTien.Controls.Add(this.label2);
            this.tabPagePhuongTien.Controls.Add(this.label1);
            this.tabPagePhuongTien.Controls.Add(this.dgvPhuongTien);
            this.tabPagePhuongTien.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhuongTien.Name = "tabPagePhuongTien";
            this.tabPagePhuongTien.Size = new System.Drawing.Size(793, 373);
            this.tabPagePhuongTien.TabIndex = 2;
            this.tabPagePhuongTien.Text = "Phương tiện";
            this.tabPagePhuongTien.UseVisualStyleBackColor = true;
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(609, 297);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(97, 37);
            this.btnThemPT.TabIndex = 7;
            this.btnThemPT.Text = "Thêm";
            this.btnThemPT.UseVisualStyleBackColor = true;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(110, 325);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(425, 22);
            this.txtGhiChu.TabIndex = 6;
            // 
            // txtTenPT
            // 
            this.txtTenPT.Location = new System.Drawing.Point(434, 242);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(236, 22);
            this.txtTenPT.TabIndex = 5;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(106, 242);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(232, 22);
            this.txtMaPT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên PT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã PT:";
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuongTien.Location = new System.Drawing.Point(0, 3);
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.RowHeadersWidth = 51;
            this.dgvPhuongTien.RowTemplate.Height = 24;
            this.dgvPhuongTien.Size = new System.Drawing.Size(784, 218);
            this.dgvPhuongTien.TabIndex = 0;
            this.dgvPhuongTien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuongTien_CellClick);
            // 
            // tabPageDiemThamQuan
            // 
            this.tabPageDiemThamQuan.Location = new System.Drawing.Point(4, 25);
            this.tabPageDiemThamQuan.Name = "tabPageDiemThamQuan";
            this.tabPageDiemThamQuan.Size = new System.Drawing.Size(793, 373);
            this.tabPageDiemThamQuan.TabIndex = 3;
            this.tabPageDiemThamQuan.Text = "Điểm tham quan";
            this.tabPageDiemThamQuan.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(699, 407);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 31);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDanhMuc";
            this.Text = "FrmDanhMuc";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePhuongTien.ResumeLayout(false);
            this.tabPagePhuongTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHuongDanVien;
        private System.Windows.Forms.TabPage tabPageDiemBanVe;
        private System.Windows.Forms.TabPage tabPagePhuongTien;
        private System.Windows.Forms.TabPage tabPageDiemThamQuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhuongTien;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}