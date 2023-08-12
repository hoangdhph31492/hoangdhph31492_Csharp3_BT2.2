using hoangdhph31492_Csharp3_BT2._2.MODEL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangdhph31492_Csharp3_BT2._2.CONTROLLER
{
    internal class SachService
    {
        SachRespository _respo;
        public SachService()
        {
            _respo = new SachRespository();
        }
        public bool checkTrung(Sach s)
        {
            foreach (var sach in _respo.GetSaches(null))
            {
                if (s.Id.Equals(sach.Id))
                {
                    return true;
                }
                
            }
            return false;
        }
        public void ThemSach(Sach sach)
        {
            if (checkTrung(sach))
            {
                MessageBox.Show("Mã sách đã tồn tại!");
                return;
            }
            if (_respo.ThemSach(sach))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        public void SuaSach(Sach sach)
        {
            if (checkTrung(sach))
            {
                MessageBox.Show("Mã sách đã tồn tại!");
                return;
            }
            if (_respo.SuaSach(sach))
            {
                MessageBox.Show("Sủa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
    }
}
