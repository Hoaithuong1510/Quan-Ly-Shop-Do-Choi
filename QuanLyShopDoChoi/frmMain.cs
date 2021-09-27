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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		private void moveSidePanel(Control btn)
		{
			panelside.Top = btn.Top;
			panelside.Height = btn.Height;
		}

		private void AddControlsToPanel(Control c)
		{
			c.Dock = DockStyle.Fill;
			panelControls.Controls.Clear();
			panelControls.Controls.Add(c);
		}
		private void frmMain_Load(object sender, EventArgs e)
		{
			
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			moveSidePanel(btnAccount);
			UC_TaiKhoan uctk = new UC_TaiKhoan();
			AddControlsToPanel(uctk);
		}

		private void btnKind_Click(object sender, EventArgs e)
		{
			moveSidePanel(btnKind);
			UC_DoChoi ucdc = new UC_DoChoi();
			AddControlsToPanel(ucdc);
		}

		private void btnProduct_Click(object sender, EventArgs e)
		{
			moveSidePanel(btnProduct);
			UC_LoaiDC ucldc = new UC_LoaiDC();
			AddControlsToPanel(ucldc);
		}

		private void btnSell_Click(object sender, EventArgs e)
		{
			moveSidePanel(btnSell);
			UC_HoaDon uchd = new UC_HoaDon();
			AddControlsToPanel(uchd);
		}

		
	}
}
