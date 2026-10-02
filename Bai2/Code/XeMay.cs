using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    public class XeMay : PhuongTien
    {
        private int _dungTichXiLanh;

        public int DungTichXiLanh
        {
            get
            {
                return _dungTichXiLanh;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Dung tich xi lanh phai > 0!");
                }

                _dungTichXiLanh = value;
            }
        }

        public XeMay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int dungTichXiLanh) : 
                    base (maPT, tenHang, namSanXuat, giaGoc)
        {
            DungTichXiLanh = dungTichXiLanh;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (DungTichXiLanh < 175)
            {
                return GiaGoc + GiaGoc * 0.02m;
            }

            else
            {
                return GiaGoc + GiaGoc * 0.05m;
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo + $"DungTichXiLanh: {DungTichXiLanh}cc";
        }
    }
}
