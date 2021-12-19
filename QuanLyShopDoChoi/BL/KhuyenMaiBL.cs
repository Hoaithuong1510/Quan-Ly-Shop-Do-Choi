using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopDoChoi.DAO.Model;

namespace QuanLyShopDoChoi.BL
{
    public class KhuyenMaiBL
    {
        ToyStoreEntities _context;
        public KhuyenMaiBL(ToyStoreEntities context)
        {
            _context = context;
        }
        public KhuyenMai Find(int id)
        {
            return _context.KhuyenMais.Find(id);
        }
        public bool Add(KhuyenMai km)
        {
            try
            {
                _context.KhuyenMais.Add(km);
                _context.SaveChanges();
                return true;
            } catch { return false; }
        }
        public bool KetThucKM(int id)
        {
            try
            {
                KhuyenMai km = _context.KhuyenMais.Find(id);
                km.NgayKetThuc = DateTime.Now;
                _context.SaveChanges();
                return true;
            }catch { return false; }
        }
        public KhuyenMai GetKhuyenMai(int idHang, DateTime ds, DateTime de)
        {
            try
            {
                List<KhuyenMai> ls = _context.KhuyenMais.Where(x => checkNgay(x, ds, de) && x.idMH==idHang).ToList();
                return ls.OrderByDescending(t=>t.discount).First();
            }
            catch { return null; }
        }
        public List<KhuyenMai> KMHang(int idHang, DateTime ds, DateTime de)
        {
            try
            {
                List<KhuyenMai> ls = _context.KhuyenMais.Where(x => x.idMH == idHang).ToList();
                return ls;
            }
            catch { return null; }
        }
        public List<dynamic> GetAllKhuyenMai(DateTime ds, DateTime de)
        {
            try
            {
                var data = _context.KhuyenMais
                    .Where(x => checkNgay(x,ds,de))                    
                    .Join(
                    _context.MatHangs,
                    km => km.idMH,
                    mh => mh.id,
                    (km, mh) => new
                    {
                        id = km.id,
                        ds = km.NgayBatDau,
                        de = km.NgayKetThuc,
                        dis = km.discount,
                        note=km.GhiChu,
                        tenhang = mh.name
                    }).ToList<dynamic>();
                return data;
            }catch { return null; }
        }

        public bool checkNgay(KhuyenMai km, DateTime ds, DateTime de)
        {
            //if (ds.CompareTo(km.NgayKetThuc) > 0 || de.CompareTo(km.NgayBatDau) < 0) return false;
            return true;
        }
    }
}
