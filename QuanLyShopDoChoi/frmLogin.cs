using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopDoChoi.DAO.Model;
using QuanLyShopDoChoi.BL;
namespace QuanLyShopDoChoi
{
	public partial class frmLogin : Form
	{
		public NhanVien _nv;
		public ToyStoreEntities _context;
		public frmLogin(ToyStoreEntities context)
		{
			InitializeComponent();
			_context = context;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Auth login = new Auth(_context);
			string userName = txtUserName.Text;
			string password = txtPassword.Text;
			_nv = login.Login(userName, password);
			if (_nv!=null)
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
