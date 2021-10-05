
namespace QuanLyShopDoChoi.UI
{
    partial class UI_Kind
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvLoai = new System.Windows.Forms.TreeView();
            this.cmstLoaiDoChoi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ttmiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiSua = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbDoChoi = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.txtDoTuoi = new System.Windows.Forms.TextBox();
            this.txtGiaXuat = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvDoChoi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.chkDoTuoi = new System.Windows.Forms.CheckBox();
            this.chkHangSX = new System.Windows.Forms.CheckBox();
            this.chkTen = new System.Windows.Forms.CheckBox();
            this.chkGia = new System.Windows.Forms.CheckBox();
            this.chkNuocSX = new System.Windows.Forms.CheckBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.mktbGia = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.cmstLoaiDoChoi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoChoi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tvLoai);
            this.groupBox1.Location = new System.Drawing.Point(35, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 739);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại đồ chơi";
            // 
            // tvLoai
            // 
            this.tvLoai.ContextMenuStrip = this.cmstLoaiDoChoi;
            this.tvLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLoai.Location = new System.Drawing.Point(3, 18);
            this.tvLoai.Name = "tvLoai";
            this.tvLoai.Size = new System.Drawing.Size(379, 718);
            this.tvLoai.TabIndex = 0;
            // 
            // cmstLoaiDoChoi
            // 
            this.cmstLoaiDoChoi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmstLoaiDoChoi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiThem,
            this.ttmiSua,
            this.ttmiXoa});
            this.cmstLoaiDoChoi.Name = "contextMenuStrip1";
            this.cmstLoaiDoChoi.Size = new System.Drawing.Size(116, 76);
            // 
            // ttmiThem
            // 
            this.ttmiThem.Name = "ttmiThem";
            this.ttmiThem.Size = new System.Drawing.Size(115, 24);
            this.ttmiThem.Text = "Thêm";
            // 
            // ttmiSua
            // 
            this.ttmiSua.Name = "ttmiSua";
            this.ttmiSua.Size = new System.Drawing.Size(115, 24);
            this.ttmiSua.Text = "Sửa";
            // 
            // ttmiXoa
            // 
            this.ttmiXoa.Name = "ttmiXoa";
            this.ttmiXoa.Size = new System.Drawing.Size(115, 24);
            this.ttmiXoa.Text = "Xóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnChonHinh);
            this.groupBox2.Controls.Add(this.txtDoTuoi);
            this.groupBox2.Controls.Add(this.txtGiaXuat);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.txtHinh);
            this.groupBox2.Controls.Add(this.txtHang);
            this.groupBox2.Controls.Add(this.txtNuocSX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(466, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đồ chơi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbDoChoi);
            this.groupBox4.Location = new System.Drawing.Point(34, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 216);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ảnh";
            // 
            // pbDoChoi
            // 
            this.pbDoChoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDoChoi.InitialImage = null;
            this.pbDoChoi.Location = new System.Drawing.Point(3, 18);
            this.pbDoChoi.Name = "pbDoChoi";
            this.pbDoChoi.Size = new System.Drawing.Size(161, 195);
            this.pbDoChoi.TabIndex = 1;
            this.pbDoChoi.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(697, 211);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(567, 211);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(434, 211);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(697, 170);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonHinh.TabIndex = 13;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // txtDoTuoi
            // 
            this.txtDoTuoi.Location = new System.Drawing.Point(353, 103);
            this.txtDoTuoi.Name = "txtDoTuoi";
            this.txtDoTuoi.ReadOnly = true;
            this.txtDoTuoi.Size = new System.Drawing.Size(156, 22);
            this.txtDoTuoi.TabIndex = 12;
            // 
            // txtGiaXuat
            // 
            this.txtGiaXuat.Location = new System.Drawing.Point(616, 103);
            this.txtGiaXuat.Name = "txtGiaXuat";
            this.txtGiaXuat.ReadOnly = true;
            this.txtGiaXuat.Size = new System.Drawing.Size(156, 22);
            this.txtGiaXuat.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(353, 71);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(156, 22);
            this.txtTen.TabIndex = 10;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(616, 71);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(156, 22);
            this.txtGiaNhap.TabIndex = 9;
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(353, 170);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(338, 22);
            this.txtHinh.TabIndex = 9;
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(353, 136);
            this.txtHang.Name = "txtHang";
            this.txtHang.ReadOnly = true;
            this.txtHang.Size = new System.Drawing.Size(156, 22);
            this.txtHang.TabIndex = 9;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(616, 136);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.ReadOnly = true;
            this.txtNuocSX.Size = new System.Drawing.Size(156, 22);
            this.txtNuocSX.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Độ tuổi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hình min họa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hãng SX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nước SX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đồ chơi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvDoChoi);
            this.groupBox3.Location = new System.Drawing.Point(466, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 419);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đồ chơi";
            // 
            // lvDoChoi
            // 
            this.lvDoChoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvDoChoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDoChoi.FullRowSelect = true;
            this.lvDoChoi.GridLines = true;
            this.lvDoChoi.HideSelection = false;
            this.lvDoChoi.Location = new System.Drawing.Point(3, 18);
            this.lvDoChoi.Name = "lvDoChoi";
            this.lvDoChoi.Size = new System.Drawing.Size(902, 398);
            this.lvDoChoi.TabIndex = 0;
            this.lvDoChoi.UseCompatibleStateImageBehavior = false;
            this.lvDoChoi.View = System.Windows.Forms.View.Details;
            this.lvDoChoi.SelectedIndexChanged += new System.EventHandler(this.lvDoChoi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nước SX";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hãng SX";
            this.columnHeader4.Width = 156;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá nhập";
            this.columnHeader5.Width = 132;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá bán";
            this.columnHeader6.Width = 131;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 76);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            this.columnHeader7.Width = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(616, 36);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(156, 22);
            this.txtSoLuong.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.mktbGia);
            this.groupBox5.Controls.Add(this.txtTimKiem);
            this.groupBox5.Controls.Add(this.chkNuocSX);
            this.groupBox5.Controls.Add(this.chkGia);
            this.groupBox5.Controls.Add(this.chkTen);
            this.groupBox5.Controls.Add(this.chkHangSX);
            this.groupBox5.Controls.Add(this.chkDoTuoi);
            this.groupBox5.Controls.Add(this.chkID);
            this.groupBox5.Location = new System.Drawing.Point(468, 268);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(902, 66);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Location = new System.Drawing.Point(6, 21);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(43, 21);
            this.chkID.TabIndex = 0;
            this.chkID.Text = "ID";
            this.chkID.UseVisualStyleBackColor = true;
            // 
            // chkDoTuoi
            // 
            this.chkDoTuoi.AutoSize = true;
            this.chkDoTuoi.Location = new System.Drawing.Point(6, 45);
            this.chkDoTuoi.Name = "chkDoTuoi";
            this.chkDoTuoi.Size = new System.Drawing.Size(75, 21);
            this.chkDoTuoi.TabIndex = 1;
            this.chkDoTuoi.Text = "Độ tuổi";
            this.chkDoTuoi.UseVisualStyleBackColor = true;
            // 
            // chkHangSX
            // 
            this.chkHangSX.AutoSize = true;
            this.chkHangSX.Location = new System.Drawing.Point(193, 45);
            this.chkHangSX.Name = "chkHangSX";
            this.chkHangSX.Size = new System.Drawing.Size(86, 21);
            this.chkHangSX.TabIndex = 2;
            this.chkHangSX.Text = "Hãng SX";
            this.chkHangSX.UseVisualStyleBackColor = true;
            // 
            // chkTen
            // 
            this.chkTen.AutoSize = true;
            this.chkTen.Location = new System.Drawing.Point(193, 21);
            this.chkTen.Name = "chkTen";
            this.chkTen.Size = new System.Drawing.Size(55, 21);
            this.chkTen.TabIndex = 2;
            this.chkTen.Text = "Tên";
            this.chkTen.UseVisualStyleBackColor = true;
            // 
            // chkGia
            // 
            this.chkGia.AutoSize = true;
            this.chkGia.Location = new System.Drawing.Point(351, 21);
            this.chkGia.Name = "chkGia";
            this.chkGia.Size = new System.Drawing.Size(52, 21);
            this.chkGia.TabIndex = 3;
            this.chkGia.Text = "Giá";
            this.chkGia.UseVisualStyleBackColor = true;
            // 
            // chkNuocSX
            // 
            this.chkNuocSX.AutoSize = true;
            this.chkNuocSX.Location = new System.Drawing.Point(351, 45);
            this.chkNuocSX.Name = "chkNuocSX";
            this.chkNuocSX.Size = new System.Drawing.Size(85, 21);
            this.chkNuocSX.TabIndex = 4;
            this.chkNuocSX.Text = "Nước SX";
            this.chkNuocSX.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(614, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(223, 22);
            this.txtTimKiem.TabIndex = 5;
            // 
            // mktbGia
            // 
            this.mktbGia.Enabled = false;
            this.mktbGia.Location = new System.Drawing.Point(614, 15);
            this.mktbGia.Mask = "000000000-000000000";
            this.mktbGia.Name = "mktbGia";
            this.mktbGia.Size = new System.Drawing.Size(170, 22);
            this.mktbGia.TabIndex = 6;
            this.mktbGia.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(562, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nội dung tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // UI_Kind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UI_Kind";
            this.Size = new System.Drawing.Size(1430, 787);
            this.groupBox1.ResumeLayout(false);
            this.cmstLoaiDoChoi.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDoChoi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvLoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvDoChoi;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox txtDoTuoi;
        private System.Windows.Forms.TextBox txtGiaXuat;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip cmstLoaiDoChoi;
        private System.Windows.Forms.ToolStripMenuItem ttmiThem;
        private System.Windows.Forms.ToolStripMenuItem ttmiSua;
        private System.Windows.Forms.ToolStripMenuItem ttmiXoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbDoChoi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mktbGia;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.CheckBox chkNuocSX;
        private System.Windows.Forms.CheckBox chkGia;
        private System.Windows.Forms.CheckBox chkTen;
        private System.Windows.Forms.CheckBox chkHangSX;
        private System.Windows.Forms.CheckBox chkDoTuoi;
        private System.Windows.Forms.CheckBox chkID;
    }
}
