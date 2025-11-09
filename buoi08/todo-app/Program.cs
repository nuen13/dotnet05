using System.Text.Json;
using ThuVienHam;

// Xây dựng ứng dụng todo để quản lý công việc cá nhân hằng ngày

// Console app: 


//Ứng dụng collection 
/*
    Input: List<object> = 
    {
        {maCongViec=1,tenCongViec = "CongViecA", trangThai: "False"},
        {maCongViec=2,tenCongViec = "CongViecB", trangThai: "True"},
        {maCongViec=3tenCongViec = "CongViecC", trangThai: "False"},
    }
*/

List<object> listTodo = new List<object>
{
    new { maCongViec = 1, tenCongViec = "bu cu", trangThai = false },
    new { maCongViec = 2, tenCongViec = "choi cuc ", trangThai = true },
    new { maCongViec = 3, tenCongViec = "an can", trangThai = false },
};

// var ob1 = new { maCongViec = 1, tenCongViec = "CongViecA", trangThai = false };




Console.WriteLine($@"{JsonSerializer.Serialize(listTodo)}");

while (true)
{
    Method.HienThiMenu();

    Console.Write($@"Chọn chức năng: ");
    int chucNang = Convert.ToInt32(Console.ReadLine());

    switch (chucNang)
    {
        case 1:
            {

                Console.WriteLine($@" --- ");
                Console.WriteLine($@"Chức Năng thêm Công việc vào danh sách");

                // Code các function cho console app

                // Gọi hàm thực thi công việc 
                Method.ThemCongViecVaoDanhSach(dsCongViec: ref listTodo);

                Console.WriteLine($@"Thêm vào thành công!!! ");

            }
            ; break;

        case 2:
            {
                Console.WriteLine($@" --- ");
                Console.WriteLine($@"Hiển Thị Danh Sách Công Việc");
                Method.InDanhSachCongViec(listTodo);
            }; break;
        case 3: 
            {
                Console.WriteLine($@" --- ");
                Console.WriteLine($@"Cập Nhật Thông Tin");
                Method.CapNhatThongTin(dsCongViec: ref listTodo);
            };break;
        case 4:
            {
                Console.WriteLine($@" --- ");
                Method.XoaCongViec(dsCongViec: ref listTodo);
                
            }; break;


        case 5:
            {
                Console.WriteLine($@"---");
                Method.TimKiemCongViec(listTodo);

            }; break;

        case 6:
            {
                Console.WriteLine($@"---");
                Method.TickHoanThanhCongViec(dsCongViec: ref listTodo);

            };break;
        case 7:
            {
                Console.WriteLine($@"---");
                Method.SapXepCongViec(dsCongViec: ref listTodo);



            };break;

        case 8:
            {
                Console.WriteLine($@"---");

            };break;        
        default:
            {
                Console.WriteLine($@"Có phải bạn muốn thoát? Bấm phím 9 để thoát");
                chucNang = Convert.ToInt32(Console.ReadLine());
            }
            ; break;
    }
    if (chucNang == 9)
    {
        break;
    }
}


