using QuanLyShopDoChoi.DAO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopDoChoi.View;

namespace QuanLyShopDoChoi
{
	public partial class frmMain : Form
	{
		private NhanVien _curNv;
		ToyStoreEntities _context;
		public frmMain()
		{
			InitializeComponent();
			_context = new ToyStoreEntities();
			var f = new frmLogin(_context);
			f.ShowDialog(this);
			if (f.DialogResult == DialogResult.OK)
			{
				_curNv = f._nv;
			}
			else {
				_curNv = null;
			}
		}
		private void moveSidePanel(Control btn)
		{
			panelside.Top = btn.Top;
			panelside.Height = btn.Height;
		}

		private void AddControlsToPanel(Control c)
		{
		}
		private void frmMain_Load(object sender, EventArgs e)
		{
			if (_curNv == null) Application.Exit();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			moveSidePanel(btnAccount);
			
			
		}

		private void btnKind_Click(object sender, EventArgs e)
		{
			moveSidePanel(btnKind);
			
			
		}

		private void btnProduct_Click(object sender, EventArgs e)
		{
			moveSidePanel(btnProduct);
			MatHangUI f = new MatHangUI(_curNv.VaiTro, _context);
			pnMain.Controls.Clear();
			pnMain.Controls.Add(f);
			
		}

		private void btnSell_Click(object sender, EventArgs e)
		{
			moveSidePanel(btnSell);
		}

		
	}
}
