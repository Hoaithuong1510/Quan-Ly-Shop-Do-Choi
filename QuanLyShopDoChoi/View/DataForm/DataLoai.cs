using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopDoChoi.BL;
using QuanLyShopDoChoi.DAO.Model;

namespace QuanLyShopDoChoi.View.DataForm
{
    public partial class DataLoai : Form
    {
        LoaiHangBL blLoai;
        LoaiHang lh;
        public DataLoai(LoaiHang l,ToyStoreEntities context)
        {
            InitializeComponent();
            blLoai = new LoaiHangBL(context);
            this.lh = l;
        }
        private LoaiHang GetInfo()
        {
            LoaiHang x = new LoaiHang();
            x.name = txtTen.Text;
            x.description = txtGhiChu.Text;
            if ((int)cbLoai.SelectedValue >= 0) x.idLH = (int)cbLoai.SelectedValue;
            else x.idLH = null;
            x.active = true;
            return x;
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lh == null)
            {
                blLoai.Add(GetInfo());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                blLoai.Update(lh.id, GetInfo());
                this.DialogResult=DialogResult=DialogResult.OK;
                this.Close();
            }
        }

        private void DataLoai_Load(object sender, EventArgs e)
        {
            List<LoaiHang> ls = blLoai.GetAll();
            cbLoai.DataSource = ls;
            ls.Add(new LoaiHang() { name = "none", id = -1 });
            if(lh !=null) ls.RemoveAll(i => i.id==lh.id);
            cbLoai.DisplayMember = "name";
            cbLoai.ValueMember = "id";
            
            if (lh != null) LoadInfo();
        }
        private void LoadInfo()
        {
            txtGhiChu.Text = lh.description;
            txtTen.Text = lh.name;
            if (lh.idLH.HasValue) cbLoai.SelectedValue = lh.idLH;
            else cbLoai.SelectedValue = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
