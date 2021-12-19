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
namespace QuanLyShopDoChoi.View
{
    public partial class KhuyenMaiUI : Form
    {
        KhuyenMaiBL blKm;
        List<KhuyenMai> list;
        int id;
        bool isAdmin;
        public KhuyenMaiUI(ToyStoreEntities context, bool admin, int idHang)
        {
            InitializeComponent();
            blKm = new KhuyenMaiBL(context);
            isAdmin = admin;
            id = idHang;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhuyenMaiUI_Load(object sender, EventArgs e)
        {
            dpDs.Value = DateTime.Now;
            dpDe.Value = dpDs.Value.AddMonths(1);
            if (isAdmin)
            {
                btnEnd.Enabled = true;
                btnSave.Enabled = true;
            }
            LoadList();
        }
        void LoadList()
        {
            lvKhuyenMai.Items.Clear();
            list = blKm.KMHang(id, dpDs.Value, dpDe.Value);
            if (list == null) return;
            foreach(var x in list)
            {
                LoadItem(x);
            }
        }
        void LoadItem(KhuyenMai x)
        {
            ListViewItem item = lvKhuyenMai.Items.Add(x.id.ToString());
            item.SubItems.Add(x.NgayBatDau.ToString());
            item.SubItems.Add(x.NgayKetThuc.ToString()); 
            item.SubItems.Add(x.discount.ToString());
            item.SubItems.Add(x.GhiChu);
        }
        KhuyenMai GetInfo()
        {
            KhuyenMai x = new KhuyenMai();
            x.NgayBatDau=dpDs.Value;
            x.NgayKetThuc=dpDe.Value;
            x.GhiChu=txtGhiChu.Text;
            x.idMH = id;
            x.discount = (int) numDiscount.Value;
            return x;
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            int x = Convert.ToInt32(txtID.Text);
            if(x == 0) return;
            blKm.KetThucKM(x);
            LoadList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            KhuyenMai x = GetInfo();
            blKm.Add(x);
            LoadList();
        }

        private void lvKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhuyenMai.SelectedItems.Count == 0) return;
            LoadInfo(blKm.Find(int.Parse(lvKhuyenMai.SelectedItems[0].Text)));
        }
        void LoadInfo(KhuyenMai x)
        {
            txtID.Text = x.id.ToString();
            txtGhiChu.Text = x.GhiChu;
            dpKmDs.Value = x.NgayBatDau;
            dpKmDe.Value = x.NgayKetThuc;
            numDiscount.Value = x.discount;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGhiChu.Text = "";
            txtID.Text = "";
            numDiscount.Value = 0;
        }

        private void dpDe_ValueChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void dpDs_ValueChanged(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
