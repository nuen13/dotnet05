using System.Reflection;

namespace ThuVienHam
{
    public static class Methods
    {
        public static void HienThiMenu()
        {
            Console.WriteLine(@"
--- Chức Năng --- 
1/ Thêm món ăn
2/ Hiển thị menu
3/ Xoá món ăn
4/ Cập nhật món ăn (đổi TÊN và/hoặc GIÁ theo MÃ)
5/ Sắp xếp & hiển thị theo TÊN (tăng dần)
6/ Sắp xếp & hiển thị theo GIÁ (tăng dần)
7/ Thoát
");
        }



        public static void ThemMon(ref List<object> dsMon)
        {

            int indexMa = 0;
            int maMonAn = 0; 
            


            while(indexMa != -1)
            {
                Console.Write($@"Nhập vào MÃ món ăn: ");
                maMonAn = Convert.ToInt32(Console.ReadLine());

                indexMa = dsMon.FindIndex((dynamic mon) => mon.ma == maMonAn);
                if(indexMa != -1)
                {
                    Console.WriteLine($@"Mã này đã được dùng rùi!");
                    Console.WriteLine($@"Vui lòng dùng mã khác");
                    

                }
            }


            Console.Write($@"Nhập vào TÊN món ăn: ");
            string tenMonAn = Console.ReadLine();

            Console.Write($@"Nhập vào GIÁ TIỀN món ăn: ");
            int giaMonAn = Convert.ToInt32(Console.ReadLine());


            var objectMonAn = new
            {
                ma = maMonAn,
                tenMon = tenMonAn,
                gia = giaMonAn,
            };

            dsMon.Add(objectMonAn);

        }


        public static void HienThiDsMon(List<object> dsMon)
        {
            foreach (dynamic mon in dsMon)
            {
                Console.WriteLine($@"Mã: {mon.ma} | Món: {mon.tenMon} | Giá: {mon.gia:N0} vnd");

            }

        }

        public static void XoaMonAn(ref List<object> dsMon)
        {
            Console.Write($@"Nhập MÃ món ăn muốn xóa: ");

            int maMonCanXoa = Convert.ToInt32(Console.ReadLine());

            int indexMon = dsMon.FindIndex((dynamic mon) => mon.ma == maMonCanXoa);

            if (indexMon != -1)
            {
                dynamic mon = dsMon[indexMon];

                dsMon.RemoveAt(indexMon);

                Console.WriteLine($@"Xóa món - {mon.tenMon} - thành công!!");
            }

            else
            {

                Console.WriteLine($@"Không tìm thấy mã của món này");
            }


        }

        public static void CapNhatMenu(ref List<object> dsMon)
        {
            Console.Write($@"Nhập MÃ món ăn muốn đổi: ");
            int maMonCanUpdate = Convert.ToInt32(Console.ReadLine());

            int indexMon = dsMon.FindIndex((dynamic mon) => mon.ma == maMonCanUpdate);

            if (indexMon != -1)
            {
                dynamic mon = dsMon[indexMon];
                Console.WriteLine($@"");
                Console.WriteLine($@"Tên món hiện tại: {mon.tenMon}");
                Console.WriteLine($@"Giá món hiện tại: {mon.gia}");

                Console.WriteLine($@"");

                Console.Write($@"Nhập tên món mới: ");
                string tenMonMoi = Console.ReadLine();

                Console.Write($@"Nhập giá món mới: ");
                int giaMoi = Convert.ToInt32(Console.ReadLine());


                dsMon[indexMon] = new
                {
                    ma = maMonCanUpdate,
                    tenMon = tenMonMoi,
                    gia = giaMoi,

                };

                Console.WriteLine($@"");
                Console.WriteLine($@"Cũ: {mon.tenMon} - {mon.gia}");
                Console.WriteLine($@"Mới: {tenMonMoi} - {giaMoi}");
            }
            else
            {
                Console.WriteLine($@"Không tìm thấy mã số của món này!");
            }

        }


        public static void sapXepMonAnTheoTen(List<object> dsMon)
        {
            List<object> dsMonAnSapXep = dsMon.OrderBy((dynamic mon) => mon.tenMon).ToList();

            Console.WriteLine($@"Các món ăn sắp xếp theo tên: ");
            foreach (dynamic mon in dsMonAnSapXep)
            {
                Console.WriteLine($@"Mã: {mon.ma} | Món: {mon.tenMon} | Giá: {mon.gia}");


            }
        }


        public static void sapXepMonAnTheoGia(List<object> dsMon)
        {
            List<object> dsMonAnSapXepTheoGia = dsMon.OrderBy((dynamic mon) => mon.gia).ToList();

            Console.WriteLine($@"Các món ăn sắp xếp theo tên: ");
            foreach (dynamic mon in dsMonAnSapXepTheoGia)
            {
                Console.WriteLine($@"Mã: {mon.ma} | Món: {mon.tenMon} | Giá: {mon.gia}");


            }
        }
    }
}
