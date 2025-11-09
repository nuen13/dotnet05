using ThuVienHam;

// Xây dựng ứng dụng quản lý thức đơn 
// Mục Tiêu: 
// - List + anonymous type + "(ko tạo class dữ liệu)
// - vận dụng linq cơ bản: `FindIndex`, `FindAll`, `OrderBy`, ` OrderByDescending` (nếu cần)
// - Thao tác I/O console, kiểm tra nhập liêu an toàn 


// --------------- DEFINE MENU --------------- // 

List<object> dsMon = new List<object>
{
    new {ma = 1, tenMon = "Phở", gia = 20 },
    new {ma = 2, tenMon = "Bún Bò Huế", gia = 21 },
    new {ma = 3, tenMon = "Thịt Bò Quấn Lá Lốt", gia = 12 },
};


while (true)
{
    Methods.HienThiMenu();

    Console.Write($@"Chọn 1 chức năng (1 - 7): ");
    string chucNang = Console.ReadLine();
    Console.WriteLine($@"-------------------------");


    switch (chucNang)
    {


        // -- Thêm món ăn -- 
        case "1":
            Console.WriteLine($@"");
            Console.WriteLine($@"--- Thêm món mới vào Menu --- ");

            Methods.ThemMon(ref dsMon);
            Console.WriteLine($@"-------------------------");

            break;
        case "2":

            Console.WriteLine($@"");
            Console.WriteLine($@"--- Hiển thị các món trong menu ---");

            Methods.HienThiDsMon(dsMon);
            Console.WriteLine($@"-------------------------");


            break;

        case "3":
            Console.WriteLine($@"");
            Console.WriteLine($@"--- Xóa 1 món trong menu ---");

            Methods.XoaMonAn(ref dsMon);

            Console.WriteLine($@"-------------------------");

            break;

        case "4":


            Console.WriteLine($@"");
            Console.WriteLine($@"--- Update 1 món trong menu ---");

            Methods.CapNhatMenu(ref dsMon);

            Console.WriteLine($@"-------------------------");
            break;

        case "5":

            Console.WriteLine($@"");
            Console.WriteLine($@"--- Sắp xếp và hiển thị các món theo TÊN (tăng dần)---");

            Methods.sapXepMonAnTheoTen(dsMon);

            Console.WriteLine($@"-------------------------");
            break;

        case "6":
            Console.WriteLine($@"");
            Console.WriteLine($@"--- Sắp xếp và hiển thị các món theo GIÁ (tăng dần)---");

            Methods.sapXepMonAnTheoGia(dsMon);

            Console.WriteLine($@"-------------------------");
            break;

        case "7":
            Console.WriteLine($@"Có phải bạn muốn thoát?? Nhấp 'p' để thoát: ");
            chucNang = Console.ReadLine();

            break;

        default:
            Console.WriteLine($@"Chức năng nhập vào không hợp lệ");
            break;
    }
    
    if (chucNang == "7")
    {
        break;
    }
}
