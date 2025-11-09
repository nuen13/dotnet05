using System.Data;
using System.Runtime.Intrinsics.Arm;
using QuanLyThongTinNhanVien;
// +: public 


// -------------------------------------- //
// --       NhanVien                   -- //
// -------------------------------------- //
// --  + maNhanVien: int               -- //
// --  + tenNhanVien: string           -- //
// --  + luong: double                 -- //
// --  + soGioLam: double              -- //
// -------------------------------------- //
// --  + void nhapThongTinNhanVien()   -- //
// --  + void xuatThongTinNhanVien()   -- //
// -------------------------------------- // 


// --------------------------------------------  //
// --       DanhSachNhanVien                  -- //
// --------------------------------------------  //
// --  + danhSachNhanVien: List<NhanVien>     -- //
// --------------------------------------------  //
// --  + void ThemNhanVien                    -- //
// --  + void XoaNhanVien                     -- //
// --  + void TimKiemNhanVien                 -- //
// --  + void ThayDoiTenNhanVien              -- //
// --------------------------------------------  // 


DanhSachNhanVien dsnv = new DanhSachNhanVien();


while(dsnv.chucNang != 6)
{
    dsnv.LoadChucNangQuanLy();


    Console.Write($@"Nhập chức năng: ");
    dsnv.chucNang = Convert.ToInt32(Console.ReadLine());

    switch (dsnv.chucNang)
    {

        case 1:
            dsnv.ThemNhanVien();
            break;
        case 2:
            dsnv.TimKiemNhanVien();
            break;
        case 3:
            dsnv.ThayDoiTenNhanVien();
            break;
        case 4:
            dsnv.XoaNhanVien();
            break;
        case 5:
            dsnv.HienThiDanhSach();
            break;
        default:

            Console.WriteLine($@"Bạn vừa sử dụng chức năng ko hợp lệ");
            Console.WriteLine($@"Bạn có muốn thoát không");
            Console.WriteLine($@"
1. Có 
2. Không");

            Console.Write($@"Lựa chọn: ");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                dsnv.chucNang = 6;
            } 
            

        
            break; 
    }
}



