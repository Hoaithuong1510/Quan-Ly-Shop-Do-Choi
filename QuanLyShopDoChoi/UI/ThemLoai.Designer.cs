
namespace QuanLyShopDoChoi.Resources
{
    partial class ThemLoai
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIDLoaiHang = new System.Windows.Forms.TextBox();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.cboLoaiCha = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Loại Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Hàng Cha";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(151, 207);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Xác Nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtIDLoaiHang
            // 
            this.txtIDLoaiHang.Location = new System.Drawing.Point(151, 41);
            this.txtIDLoaiHang.Name = "txtIDLoaiHang";
            this.txtIDLoaiHang.Size = new System.Drawing.Size(214, 22);
            this.txtIDLoaiHang.TabIndex = 5;
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Location = new System.Drawing.Point(151, 91);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(214, 22);
            this.txtLoaiHang.TabIndex = 6;
            // 
            // cboLoaiCha
            // 
            this.cboLoaiCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiCha.FormattingEnabled = true;
            this.cboLoaiCha.Location = new System.Drawing.Point(151, 145);
            this.cboLoaiCha.Name = "cboLoaiCha";
            this.cboLoaiCha.Size = new System.Drawing.Size(214, 24);
            this.cboLoaiCha.TabIndex = 7;
            // 
            // ThemLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 244);
            this.Controls.Add(this.cboLoaiCha);
            this.Controls.Add(this.txtLoaiHang);
            this.Controls.Add(this.txtIDLoaiHang);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemLoai";
            this.Text = "ThemLoai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtIDLoaiHang;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.ComboBox cboLoaiCha;
    }
}