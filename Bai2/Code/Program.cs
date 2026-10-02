using System;

namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("===== TC01: KIỂM TRA VALIDATION NĂM SẢN XUẤT =====");

            try
            {
                OTo oto = new OTo("OT001", "Toyota", 1850, 1000000000m, 5, 2.0);

                Console.WriteLine("TC01: FAIL - Không phát hiện lỗi!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("TC01: PASS");
                Console.WriteLine("Đã bắt được lỗi: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("===== TC02: KIỂM TRA GIÁ LĂN BÁNH Ô TÔ =====");

            OTo otoTC02 = new OTo("OT002", "Toyota", 2022, 1000000000m, 5, 2.0);

            decimal giaLanBanhOto = otoTC02.TinhGiaLanBanh();

            Console.WriteLine($"Giá lăn bánh: {giaLanBanhOto:N0} VNĐ");

            if (giaLanBanhOto == 1420000000m)
            {
                Console.WriteLine("TC02: PASS");
            }
            else
            {
                Console.WriteLine("TC02: FAIL");
            }

            Console.WriteLine();
            Console.WriteLine("===== TC03: KIỂM TRA GIÁ LĂN BÁNH XE MÁY =====");

            XeMay xeMayTC03 = new XeMay("XM001", "Honda", 2023, 50000000m, 150);

            decimal giaLanBanhXeMay = xeMayTC03.TinhGiaLanBanh();

            Console.WriteLine($"Giá lăn bánh: {giaLanBanhXeMay:N0} VNĐ");

            if (giaLanBanhXeMay == 51000000m)
            {
                Console.WriteLine("TC03: PASS");
            }
            else
            {
                Console.WriteLine("TC03: FAIL");
            }

            Console.WriteLine();
            Console.WriteLine("===== TC04: KIỂM TRA ĐA HÌNH =====");

            QuanLyPhuongTien quanLyTC04 = new QuanLyPhuongTien();

            OTo otoTC04 = new OTo("OT004", "Toyota", 2022, 1000000000m, 5, 2.0);

            XeMay xeMayTC04 = new XeMay("XM004", "Honda", 2023, 50000000m, 150);

            quanLyTC04.AddPhuongTien(otoTC04);
            quanLyTC04.AddPhuongTien(xeMayTC04);

            quanLyTC04.DisplayAll();

            Console.WriteLine("TC04: PASS");

            Console.WriteLine();
            Console.WriteLine("===== TC05: TÌM GIÁ LĂN BÁNH CAO NHẤT =====");

            PhuongTien max = quanLyTC04.FindMaxGiaLanBanh();

            if (max != null)
            {
                Console.WriteLine("Phương tiện có giá lăn bánh cao nhất:");

                Console.WriteLine(max.GetInfo());

                Console.WriteLine($"Giá lăn bánh: " + $"{max.TinhGiaLanBanh():N0} VNĐ");

                Console.WriteLine("TC05: PASS");
            }
            else
            {
                Console.WriteLine("TC05: FAIL - Danh sách rỗng!");
            }


            Console.WriteLine();
            Console.WriteLine("===== KẾT THÚC KIỂM THỬ =====");

            Console.ReadLine();
        }
    }
}