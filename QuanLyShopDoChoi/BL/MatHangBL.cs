using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopDoChoi.DAO.Model;

namespace QuanLyShopDoChoi.BL
{
    public class MatHangBL
    {
        private ToyStoreEntities _context;
        public MatHangBL()
        {
            _context = new ToyStoreEntities();
        }
        public MatHangBL(ToyStoreEntities context)
        {
            _context = context;
        }
        //lay tat ca mat hang dang dung
        public List<MatHang> GetAll()
        {
            return _context.MatHangs.Where(x => x.active).ToList();
        }
        //tim mat hang theo id
        public MatHang Find(int id)
        {
            try
            {
                MatHang rs = _context.MatHangs.Find(id);
                if (rs.active == false) return null;
                return rs;
            } catch { return null; }
        }
        
        // them mat hang
        public bool Add(MatHang mh)
        {
            try
            {
                _context.MatHangs.Add(mh);
                _context.SaveChanges();
                return true;
            }catch { return false; }
        }
        //xoa mat hang
        public bool Remove(int id)
        {
            try
            {
                MatHang mh = _context.MatHangs.Find(id);
                _context.MatHangs.Remove(mh);
                _context.SaveChanges();
                return true;
            } catch { return false; }
        }

        // xoa mat hang gay loi voi chi tiet hoa don, set active = false
        public bool Del(int id)
        {
            try
            {
                MatHang mh = _context.MatHangs.Find(id);
                mh.active = false;
                _context.SaveChanges();
                return true;
            } catch { return false; }
        }
        //sua mat hang
        public bool Update(int id, MatHang mh)
        {
            try
            {
                MatHang older = _context.MatHangs.Find(id);
                older.name = mh.name;
                older.SoLuongTon=mh.SoLuongTon;
                older.GiaBan=mh.GiaBan;
                older.GiaNhap = mh.GiaNhap;
                older.idLH = mh.idLH;
                older.NhaSX=mh.NhaSX;
                older.XuatXu=mh.XuatXu;
                older.DoTuoi=mh.DoTuoi;
                older.GhiChu = mh.GhiChu;
                older.active = mh.active;
                _context.SaveChanges();
                return true;
            } catch { return false; }
        }

        //lay tat ca id loai hang cha, id loai hang = 0 => tat ca
        public List<int> GetIdLoaiCha(MatHang mh)
        {
            List<int> rs = new List<int> { mh.idLH };
            try
            {
                LoaiHang lh = _context.LoaiHangs.Find(mh.idLH);
                while (lh != null)
                {
                    rs.Add(lh.id);
                    lh=_context.LoaiHangs.Find(lh.idLH);
                }
            } catch (Exception ex) { throw ex; };
            return rs;
        }

    }
}
