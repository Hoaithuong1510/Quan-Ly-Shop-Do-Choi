using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopDoChoi
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;
			string password = txtPassword.Text;
			if (userName.CompareTo("HoaiThuong") == 0 && password.CompareTo("1911213") == 0)
			{
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
			}

			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes)
            {
				this.DialogResult = DialogResult.Cancel;
            }
			Application.Exit();
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
		}
	}
}
