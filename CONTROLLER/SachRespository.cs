using hoangdhph31492_Csharp3_BT2._2.MODEL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hoangdhph31492_Csharp3_BT2._2.MODEL.Context;

namespace hoangdhph31492_Csharp3_BT2._2.CONTROLLER
{
    internal class SachRespository
    {
        DBContext db;
        public SachRespository()
        {
            db = new DBContext();
        }
        public List<Sach> GetSaches(string input)
        {
            if (input == null)
            {
                var data = db.Saches.ToList();
                return data;
            }
            return db.Saches.Where(s => s.Ten.StartsWith(input)).ToList();
        }
        public Nxb GetTenNxb(Guid id)
        {
            
            
            return db.Nxbs.FirstOrDefault(nxb => nxb.Id == id);
        }
        public List<Nxb> GetNxbs()
        {
            
            return db.Nxbs.ToList();
        }
        public bool ThemSach(Sach s)
        {
            if (s == null)
            {
                return false;
            }
            else
            {
                s.Id = Guid.NewGuid();
                db.Add(s);
                db.SaveChanges();
                return true;
            }
        }
        public bool SuaSach(Sach s)
        {
            if (s == null)
            {
                return false;
            }
            else
            {

                db.Update(s);
                db.SaveChanges();
                return true;
            }
        }
    }
}
