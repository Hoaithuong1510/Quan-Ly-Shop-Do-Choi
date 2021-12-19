using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopDoChoi.DAO.Model;

namespace QuanLyShopDoChoi.BL
{
    public class Auth
    {
        private ToyStoreEntities _context;
        public Auth()
        {
            _context = new ToyStoreEntities();
        }
        public Auth(ToyStoreEntities context)
        {
            _context = context;
        }
        public NhanVien Login(string user, string pass)
        {
            try
            {
                NhanVien rs = _context.NhanViens.Where(x => x.userName == user && x.passWord == pass).FirstOrDefault();
                if (rs != null)
                    return rs;
                else return null;
            }
            catch { return null; };
        }
    }
}
