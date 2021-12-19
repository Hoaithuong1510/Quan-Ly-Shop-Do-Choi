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
using QuanLyShopDoChoi.View.DataForm;

namespace QuanLyShopDoChoi.View
{
    public partial class MatHangUI : UserControl
    {
        private bool isAdmin;
        private List<MatHang> lsMatHang;
        private ToyStoreEntities _context;
        private LoaiHangBL blLoai;
        private MatHangBL blHang;
        public MatHangUI(bool isAdmin, ToyStoreEntities context)
        {
            this.isAdmin = isAdmin;
            this._context = context;
            blLoai = new LoaiHangBL(context);
            blHang = new MatHangBL(context);
            InitializeComponent();
        }

        private void MatHangUI_Load(object sender, EventArgs e)
        {
            this.xóaToolStripMenuItem.Enabled = isAdmin;
            if (isAdmin)
            {
                btnDel.Enabled = true;
                cmiXoaLoai.Enabled = true;
            }
            this.Dock = DockStyle.Fill;
            LoadTree();

            txtSearch.GotFocus += TxtSearch_GotFocus;
            txtSearch.LostFocus += TxtSearch_LostFocus;
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            txtSearch.Text = "tìm kiếm ... ";
            LoadView(lsMatHang);
        }

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private TreeNode MakeNode(LoaiHang x)
        {
            if (x == null) return null;
            TreeNode node = new TreeNode();
            node.Text = x.name;
            node.Tag = x.id;
            List<LoaiHang> lhCon = blLoai.GetAllLoaiCon(x.id);
            if (lhCon == null) return node;
            foreach (var i in lhCon)
            {
                if (i == null) continue;
                node.Nodes.Add(MakeNode(i));
            }
            return node;
        }
        private void LoadTree()
        {
            tvLoai.Nodes.Clear();
            tvLoai.Nodes.Add("Tất cả");
            tvLoai.Nodes[0].Tag = 0;
            List<LoaiHang> lsLh = blLoai.GetLoaiCon(0);
            foreach (var l in lsLh)
                tvLoai.Nodes[0].Nodes.Add(MakeNode(l));
            tvLoai.ExpandAll();
            tvLoai.SelectedNode = tvLoai.Nodes[0];
        }

        private void tvLoai_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((int)e.Node.Tag == 0) lsMatHang = blHang.GetAll();
            if (e.Node != null) lsMatHang = blLoai.GetAllMatHang((int)e.Node.Tag);
            lsMatHang.Sort((x,y) => x.name.CompareTo(y.name));
            LoadView(lsMatHang);
        }
        private void LoadView(List<MatHang> ls)
        {
            lvDoChoi.Items.Clear();
            foreach (var x in ls)
            {
                ListViewItem item = lvDoChoi.Items.Add(x.id.ToString());
                item.SubItems.Add(x.name);
                item.SubItems.Add(x.SoLuongTon.ToString());
                item.SubItems.Add(x.GiaBan.ToString());
                item.SubItems.Add(x.GiaNhap.ToString());
                item.SubItems.Add(x.NhaSX);
                item.SubItems.Add(x.XuatXu);
                item.SubItems.Add(x.DoTuoi);
                item.SubItems.Add(x.GhiChu);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "tìm kiếm ... " || txtSearch.Text == "") return;
            LoadView(lsMatHang.FindAll(x => x.name.Contains(txtSearch.Text)));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(lvDoChoi.SelectedItems.Count == 0) return;
            blHang.Del(int.Parse(lvDoChoi.SelectedItems[0].Text));
            lsMatHang = blLoai.GetAllMatHang((int)tvLoai.SelectedNode.Tag);
            LoadView(lsMatHang);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new DataMatHang(isAdmin, null, _context);
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Thêm thành công");
                LoadTree();
            }
        }

        private void lvDoChoi_DoubleClick(object sender, EventArgs e)
        {
            if (lvDoChoi.SelectedItems.Count == 0) return;
            MatHang x = blHang.Find(int.Parse(lvDoChoi.SelectedItems[0].Text));
            var f = new DataMatHang(isAdmin, x, _context);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Thêm thành công");
                LoadTree();
            }
        }

        private void cmiXoaLoai_Click(object sender, EventArgs e)
        {
            if(tvLoai.SelectedNode == null) return;
            if (blLoai.Del((int)tvLoai.SelectedNode.Tag))
                MessageBox.Show("Xóa loại thành công");
            LoadTree();
        }

        private void cmiAddLoai_Click(object sender, EventArgs e)
        {
            var f = new DataLoai(null, _context);
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Thêm thành công");
                LoadTree();
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDel.PerformClick();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvDoChoi.SelectedItems.Count == 0) return;
            MatHang x = blHang.Find(int.Parse(lvDoChoi.SelectedItems[0].Text));
            var f = new DataMatHang(isAdmin, x, _context);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Thêm thành công");
                LoadTree();
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick(); 
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoaiHang x = blLoai.Find((int)tvLoai.SelectedNode.Tag);
            var f = new DataLoai(x, _context);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Sửa thành công");
                LoadTree();
            }
        }

        private void tvLoai_DoubleClick(object sender, EventArgs e)
        {
            LoaiHang x = blLoai.Find((int)tvLoai.SelectedNode.Tag);
            var f = new DataLoai(x, _context);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Sửa thành công");
                LoadTree();
            }
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = int.Parse(lvDoChoi.SelectedItems[0].Text);
            var f = new KhuyenMaiUI(_context, isAdmin,i );
            f.ShowDialog();
        }
    }
}
