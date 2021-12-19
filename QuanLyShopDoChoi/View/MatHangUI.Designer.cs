namespace QuanLyShopDoChoi.View
{
    partial class MatHangUI
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
            this.cmstLoai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAddLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiXoaLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDoChoi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmstDoChoi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.khuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.cmstLoai.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cmstDoChoi.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvLoai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 787);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại đồ chơi";
            // 
            // tvLoai
            // 
            this.tvLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvLoai.ContextMenuStrip = this.cmstLoai;
            this.tvLoai.Location = new System.Drawing.Point(3, 18);
            this.tvLoai.Name = "tvLoai";
            this.tvLoai.Size = new System.Drawing.Size(258, 766);
            this.tvLoai.TabIndex = 0;
            this.tvLoai.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLoai_AfterSelect);
            this.tvLoai.DoubleClick += new System.EventHandler(this.tvLoai_DoubleClick);
            // 
            // cmstLoai
            // 
            this.cmstLoai.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmstLoai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiAddLoai,
            this.cmiXoaLoai,
            this.sửaToolStripMenuItem1});
            this.cmstLoai.Name = "cmstLoai";
            this.cmstLoai.Size = new System.Drawing.Size(116, 76);
            // 
            // cmiAddLoai
            // 
            this.cmiAddLoai.Name = "cmiAddLoai";
            this.cmiAddLoai.Size = new System.Drawing.Size(115, 24);
            this.cmiAddLoai.Text = "Thêm";
            this.cmiAddLoai.Click += new System.EventHandler(this.cmiAddLoai_Click);
            // 
            // cmiXoaLoai
            // 
            this.cmiXoaLoai.Enabled = false;
            this.cmiXoaLoai.Name = "cmiXoaLoai";
            this.cmiXoaLoai.Size = new System.Drawing.Size(115, 24);
            this.cmiXoaLoai.Text = "Xóa";
            this.cmiXoaLoai.Click += new System.EventHandler(this.cmiXoaLoai_Click);
            // 
            // sửaToolStripMenuItem1
            // 
            this.sửaToolStripMenuItem1.Name = "sửaToolStripMenuItem1";
            this.sửaToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.sửaToolStripMenuItem1.Text = "Sửa";
            this.sửaToolStripMenuItem1.Click += new System.EventHandler(this.sửaToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(270, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 787);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvDoChoi);
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 734);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đồ chơi";
            // 
            // lvDoChoi
            // 
            this.lvDoChoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDoChoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvDoChoi.ContextMenuStrip = this.cmstDoChoi;
            this.lvDoChoi.FullRowSelect = true;
            this.lvDoChoi.GridLines = true;
            this.lvDoChoi.HideSelection = false;
            this.lvDoChoi.Location = new System.Drawing.Point(3, 18);
            this.lvDoChoi.MultiSelect = false;
            this.lvDoChoi.Name = "lvDoChoi";
            this.lvDoChoi.Size = new System.Drawing.Size(1154, 713);
            this.lvDoChoi.TabIndex = 0;
            this.lvDoChoi.UseCompatibleStateImageBehavior = false;
            this.lvDoChoi.View = System.Windows.Forms.View.Details;
            this.lvDoChoi.DoubleClick += new System.EventHandler(this.lvDoChoi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá bán";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá nhập";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nhà Sản Xuât";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Xuất xứ";
            this.columnHeader7.Width = 97;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Độ tuổi";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ghi chú";
            this.columnHeader9.Width = 440;
            // 
            // cmstDoChoi
            // 
            this.cmstDoChoi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmstDoChoi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.khuyếnMãiToolStripMenuItem});
            this.cmstDoChoi.Name = "cmstDoChoi";
            this.cmstDoChoi.Size = new System.Drawing.Size(211, 128);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 47);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(302, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "tìm kiếm ...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(998, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(1079, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // khuyếnMãiToolStripMenuItem
            // 
            this.khuyếnMãiToolStripMenuItem.Name = "khuyếnMãiToolStripMenuItem";
            this.khuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.khuyếnMãiToolStripMenuItem.Text = "Khuyến mãi";
            this.khuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.khuyếnMãiToolStripMenuItem_Click);
            // 
            // MatHangUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MatHangUI";
            this.Size = new System.Drawing.Size(1430, 787);
            this.Load += new System.EventHandler(this.MatHangUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.cmstLoai.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.cmstDoChoi.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDoChoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ContextMenuStrip cmstLoai;
        private System.Windows.Forms.ToolStripMenuItem cmiAddLoai;
        private System.Windows.Forms.ToolStripMenuItem cmiXoaLoai;
        private System.Windows.Forms.ContextMenuStrip cmstDoChoi;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem khuyếnMãiToolStripMenuItem;
    }
}
