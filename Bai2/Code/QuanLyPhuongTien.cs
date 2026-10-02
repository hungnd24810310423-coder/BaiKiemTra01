using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    public class QuanLyPhuongTien
    {
        private List<PhuongTien> danhSachPhuongTien;

        public QuanLyPhuongTien()
        {
            danhSachPhuongTien = new List<PhuongTien>();
        }

        public void AddPhuongTien(PhuongTien phuongTien)
        {
            danhSachPhuongTien.Add(phuongTien);
        }

        public void DisplayAll()
        {
            Console.WriteLine("===== DANH SÁCH PHƯƠNG TIỆN =====");
            foreach (PhuongTien phuongTien in danhSachPhuongTien)
            {
                phuongTien.GetInfo();
                Console.WriteLine($"GiaLanBanh: {phuongTien.TinhGiaLanBanh():N0} VND");
                Console.WriteLine();
            }
        }

        public PhuongTien FindMaxGiaLanBanh()
        {
            if (danhSachPhuongTien.Count == 0)
            {
                return null;
            }

            PhuongTien max = danhSachPhuongTien[0];

            foreach (PhuongTien phuongTien
                in danhSachPhuongTien)
            {
                if (phuongTien.TinhGiaLanBanh() > max.TinhGiaLanBanh())
                {
                    max = phuongTien;
                }
            }

            return max;
        }

        public List<PhuongTien> SearchByName(string keyword)
        {
            List<PhuongTien> ketQua = new List<PhuongTien>();

            foreach (PhuongTien phuongTien in danhSachPhuongTien)
            {
                if (phuongTien.TenHang.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    ketQua.Add(phuongTien);
                }
            }

            return ketQua;
        }
    }
}
