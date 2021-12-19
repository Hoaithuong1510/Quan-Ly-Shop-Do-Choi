using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopDoChoi.DAO.Model;
namespace QuanLyShopDoChoi.BL
{
    public class LoaiHangBL
    {
        ToyStoreEntities _context;
        public LoaiHangBL()
        {
            _context = new ToyStoreEntities();
        }
        public LoaiHangBL(ToyStoreEntities context)
        {
            _context=context;
        }
        // lay tat ca loai hang dang su dung
        public List<LoaiHang> GetAll()
        {
            try
            {
                return _context.LoaiHangs.Where(x=> x.active).ToList();
            }
            catch { return null; }
        }
        // tim loai hang theo id
        public LoaiHang Find(int id)
        {
            try
            {
                return _context.LoaiHangs.Find(id);
            }
            catch { return null; }
        }

        // them loai hang
        public bool Add(LoaiHang lh)
        {
            try
            {
                _context.LoaiHangs.Add(lh);
                _context.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        // xoa loai hang -- khong xoa chi set active = false
        public bool Del(int id)
        {
            try
            {
                LoaiHang lh = _context.LoaiHangs.Find(id);
                lh.active = false;
                _context.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        // sua loai hang
        public bool Update(int id, LoaiHang lh)
        {
            try
            {
                LoaiHang older = _context.LoaiHangs.Find(id);
                older.name = lh.name;
                older.description = lh.description;
                older.active = lh.active;
                older.idLH = lh.idLH;
                _context.SaveChanges();
                return true;

            }
            catch { return false; }
        }
        //lay tat car loai con
        public List<LoaiHang> GetAllLoaiCon(int id)
        {
            if(id ==0) return _context.LoaiHangs.Where(x=>x.active).ToList();
            try
            {
                List<LoaiHang> rs = new List<LoaiHang>();
                rs.AddRange(GetLoaiCon(id));
                for (int i = 0; i < rs.Count; i++)
                {
                    var tmp = GetLoaiCon(rs[i].id);
                    if (tmp != null) rs.AddRange(tmp);
                }

                return rs.Distinct().ToList() ;
            }
            catch { return null; }
        }
        // lay tat ca id loai hang con
        public List<int> GetAllIdLoaiCon(int id)
        {
            return GetAllLoaiCon(id).Select(x => x.id).ToList();
        }
        // lay tat ca san pham thuoc loai
        public List<MatHang> GetAllMatHang(int id)
        {
            if (id == 0) return _context.MatHangs.Where(x=>x.active).ToList();
            try
            {
                List<int> ls = GetAllIdLoaiCon(id);
                return _context.MatHangs.Where(x => x.active && (ls.Contains(x.idLH)|| x.idLH==id)).ToList();

            }catch { return null; }
        }


        // lay loai con truc tiep
        public List<LoaiHang> GetLoaiCon(int id)
        {
            if(id ==0)  return _context.LoaiHangs.Where(x=> !x.idLH.HasValue && x.active).ToList();
            return _context.LoaiHangs.Where(x => x.idLH == id && x.active).ToList();
        }
    }
}
