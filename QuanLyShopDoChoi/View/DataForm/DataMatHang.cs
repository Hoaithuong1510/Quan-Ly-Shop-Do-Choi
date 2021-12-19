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
    public partial class DataMatHang: Form
    {
        private bool isAdmin;
        private MatHang _mh;
        private ToyStoreEntities _context;
        private MatHangBL blHang;
        private LoaiHangBL blLoai;
        public int rid;
        public DataMatHang(bool admin, MatHang mh, ToyStoreEntities context)
        {
            InitializeComponent();
            isAdmin = admin;
            _context = context;
            _mh= mh;
            blHang = new MatHangBL(context);
            blLoai = new LoaiHangBL(context);
        }

        private void DataMatHang_Load(object sender, EventArgs e)
        {
            if (_mh!=null) LoadInfo();
            List<LoaiHang> lsLh = blLoai.GetAll();
            cbLoai.DataSource = lsLh;
            cbLoai.ValueMember = "id";
            cbLoai.DisplayMember = "name";
            if (isAdmin)
            {
                numSoLuong.ReadOnly = false;
                numGiaBan.ReadOnly = false;
                numGiaNhap.ReadOnly = false;
            }
        }
        private void LoadInfo()
        {
            txtTen.Text = _mh.name;
            numSoLuong.Value = _mh.SoLuongTon;
            numGiaBan.Value = _mh.GiaBan;
            numGiaNhap.Value= _mh.GiaNhap;
            txtNhaSanXuat.Text = _mh.NhaSX;
            txtXuatXu.Text=_mh.XuatXu;
            txtDoTuoi.Text = _mh.DoTuoi;
            txtGhiChu.Text = _mh.GhiChu;
            List<LoaiHang> lsLh = blLoai.GetAll();
            cbLoai.DataSource = lsLh;
            cbLoai.ValueMember = "id";
            cbLoai.DisplayMember ="name";
            cbLoai.SelectedValue = _mh.idLH;
        }

        private MatHang GetInfo()
        {
            MatHang m = new MatHang();
            m.name = txtTen.Text;
            m.SoLuongTon = (int) numSoLuong.Value;
            m.GiaBan =(long) numGiaBan.Value;
            m.GiaNhap = (long) numGiaNhap.Value;
            m.GhiChu = txtGhiChu.Text;
            m.NhaSX = txtNhaSanXuat.Text;
            m.XuatXu= txtXuatXu.Text;
            m.DoTuoi= txtDoTuoi.Text;
            m.idLH = (int)cbLoai.SelectedValue;
            m.active = true;
            return m;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool check = false;
            MatHang mm = GetInfo();
            rid = mm.idLH;
            if(_mh == null)
            {
                check = blHang.Add(mm);
            } else
            {
               check =  blHang.Update(_mh.id, mm);
            }
            if (check)
            {
                DialogResult= DialogResult.OK;
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
