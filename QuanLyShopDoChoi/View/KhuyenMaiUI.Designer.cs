namespace QuanLyShopDoChoi.View
{
    partial class KhuyenMaiUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpDe = new System.Windows.Forms.DateTimePicker();
            this.dpDs = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvKhuyenMai = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dpKmDe = new System.Windows.Forms.DateTimePicker();
            this.dpKmDs = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dpDe);
            this.groupBox1.Controls.Add(this.dpDs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // dpDe
            // 
            this.dpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDe.Location = new System.Drawing.Point(341, 12);
            this.dpDe.Name = "dpDe";
            this.dpDe.Size = new System.Drawing.Size(115, 22);
            this.dpDe.TabIndex = 1;
            this.dpDe.ValueChanged += new System.EventHandler(this.dpDe_ValueChanged);
            // 
            // dpDs
            // 
            this.dpDs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDs.Location = new System.Drawing.Point(128, 13);
            this.dpDs.Name = "dpDs";
            this.dpDs.Size = new System.Drawing.Size(115, 22);
            this.dpDs.TabIndex = 1;
            this.dpDs.ValueChanged += new System.EventHandler(this.dpDs_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "từ";
            // 
            // lvKhuyenMai
            // 
            this.lvKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvKhuyenMai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvKhuyenMai.FullRowSelect = true;
            this.lvKhuyenMai.GridLines = true;
            this.lvKhuyenMai.HideSelection = false;
            this.lvKhuyenMai.Location = new System.Drawing.Point(12, 67);
            this.lvKhuyenMai.MultiSelect = false;
            this.lvKhuyenMai.Name = "lvKhuyenMai";
            this.lvKhuyenMai.Size = new System.Drawing.Size(374, 307);
            this.lvKhuyenMai.TabIndex = 1;
            this.lvKhuyenMai.UseCompatibleStateImageBehavior = false;
            this.lvKhuyenMai.View = System.Windows.Forms.View.Details;
            this.lvKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.lvKhuyenMai_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày bắt đầu";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày kết thúc";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Discount";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ghi chú";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.numDiscount);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.dpKmDe);
            this.groupBox2.Controls.Add(this.dpKmDs);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(392, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 307);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khuyến mãi";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(342, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(277, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(184, 271);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(87, 30);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(286, 35);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(49, 22);
            this.numDiscount.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(82, 134);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(319, 122);
            this.txtGhiChu.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 31);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 2;
            // 
            // dpKmDe
            // 
            this.dpKmDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpKmDe.Location = new System.Drawing.Point(286, 62);
            this.dpKmDe.Name = "dpKmDe";
            this.dpKmDe.Size = new System.Drawing.Size(115, 22);
            this.dpKmDe.TabIndex = 1;
            // 
            // dpKmDs
            // 
            this.dpKmDs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpKmDs.Location = new System.Drawing.Point(82, 63);
            this.dpKmDs.Name = "dpKmDs";
            this.dpKmDs.Size = new System.Drawing.Size(115, 22);
            this.dpKmDs.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // KhuyenMaiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 386);
            this.Controls.Add(this.lvKhuyenMai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhuyenMaiUI";
            this.Text = "KhuyenMaiUI";
            this.Load += new System.EventHandler(this.KhuyenMaiUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpDe;
        private System.Windows.Forms.DateTimePicker dpDs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvKhuyenMai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dpKmDe;
        private System.Windows.Forms.DateTimePicker dpKmDs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
    }
}