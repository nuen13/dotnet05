using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace ThuVienHam;


public static class Method
{

    public static void HienThiMenu()
    {
        Console.WriteLine($@"
----- Hãy chọn 1 trong những chức năng sau của todo-app -----

1. Thêm công việc vào danh sách.
2. Hiển thị danh sách công việc.
3. Cập nhật thông tin công việc (tên, mô tả, ngày đến hạn, trạng thái).
4. Xóa công việc theo tên công việc.
5. Tìm kiếm công việc theo tên công việc.
6. Tick Hoan Thanh Cong Viec
7. Sắp xếp và hiển thị công việc chưa hoàn thành
8. Lọc và hiển thị công việc đã hoàn thành theo thứ tự.

9. Thoát
        ");
    }



    // 1. Them cong viec vao danh sach
    public static void ThemCongViecVaoDanhSach(ref List<object> dsCongViec)
    {
        // Them cong viec vao list 

        Console.Write($@"Nhập vào MÃ công việc: ");
        int maCongViec = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($@"");
        Console.Write($@"Nhập vào TÊN công việc: ");
        string tenCongViec = Console.ReadLine();


        bool trangThai = false;

        // sau khi đã có 3 thông tin từ người dùng nhập -> đưa vào list


        var obCongViec = new
        {
            maCongViec = maCongViec,
            tenCongViec = tenCongViec,
            trangThai = trangThai,
        };

        // obCOngViec = {maCongViec=1,tenCongViec = "CongViecA", trangThai: "False"},}


        // đưa object công việc vào list
        dsCongViec.Add(obCongViec);

    }

    public static void InDanhSachCongViec(List<object> dsCongViec)
    {

        string trangThaiString = "";
        foreach (dynamic item in dsCongViec)
        {
            trangThaiString = (item.trangThai) ? "Rồi" : "Chưa";
            Console.WriteLine($@"{item.maCongViec}. {item.tenCongViec} -- {trangThaiString}");

        }

    }

    public static void XoaCongViec(ref List<object> dsCongViec)
    {
        Console.Write($@"Nhập mã công việc cần xóa: ");
        int indexCanXoa = Convert.ToInt32(Console.ReadLine());

        int indexXoa = dsCongViec.FindIndex((dynamic item) => item.maCongViec == indexCanXoa);

        if (indexXoa != -1)
        {
            dsCongViec.RemoveAt(indexXoa);
            Console.Write($@"Xóa Thành Công!!");
        }
        else
        {
            Console.WriteLine($@"Không Tìm Thấy Mã Công Việc Cần Xóa");
        }


    }

    public static void CapNhatThongTin(ref List<object> dsCongViec)
    {

        // Bước 1: Tìm ra object trong list, hoặc tìm ra index trong list
        Console.Write($@"Nhập Mã Công Việc Cần Thay Đổi: ");
        int maCongViecCanDoi = Convert.ToInt32(Console.ReadLine());

        // Tìm ra object trong list dựa vào mã
        int indexCongViecUpdate = dsCongViec.FindIndex((dynamic item) => item.maCongViec == maCongViecCanDoi);

        if (indexCongViecUpdate != -1)
        {
            bool trangThai = ((dynamic)dsCongViec[indexCongViecUpdate]).trangThai;

            Console.Write($@"Nhập vào tên công việc mới: ");

            dsCongViec[indexCongViecUpdate] = new
            {
                maCongViec = maCongViecCanDoi,
                tenCongViec = Console.ReadLine(),
                trangThai = trangThai
            };
        }
        else
        {
            Console.WriteLine($@"Không tìm thấy mã công việc tương ứng");
        }


    }

    public static void TimKiemCongViec(List<object> dsCongViec)
    {
        Console.Write($@"Tim Kiem Ten Cong Viec: ");
        string tuKhoa = Console.ReadLine();
        string trangThaiString = "";

        List<object> lstCongViecTimKiem = dsCongViec.FindAll((dynamic item) => item.tenCongViec.ToLower().Contains(tuKhoa));

        if (lstCongViecTimKiem.Count() > 0)
        {
            foreach (dynamic item in lstCongViecTimKiem)
            {
                trangThaiString = (item.trangThai) ? "Rồi" : "Chưa";
                Console.WriteLine($@"{item.maCongViec}. {item.tenCongViec} -- {trangThaiString}");
            }
        }
        else
        {
            Console.WriteLine($@"khong tim thay cong viec nao chua {tuKhoa}");
        }
    }

    public static void TickHoanThanhCongViec(ref List<object> dsCongViec)
    {
        Console.Write($@"Nhap MA so cong viec ban muon tick: ");
        int maCongViec = Convert.ToInt32(Console.ReadLine());

        int indexTrangThai = dsCongViec.FindIndex((dynamic item) => item.maCongViec == maCongViec);


        dsCongViec[indexTrangThai] = new
        {
            maCongViec = maCongViec,
            tenCongViec = ((dynamic)dsCongViec[indexTrangThai]).tenCongViec,
            trangThai = true
        };


    }
    

    public static void SapXepCongViec(ref List<object> dsCongViec)
    {

        List<object> dsCongViecOrderByTrangThai = dsCongViec.OrderBy((dynamic item) => item.trangThai).ToList();
        List<object> dsCongViecOrderByTen = dsCongViecOrderByTrangThai.OrderBy((dynamic item) => item.tenCongViec).ToList();
        

        Console.WriteLine($@"Hien Thi Cong Viec: ");
        
        foreach (dynamic item in dsCongViecOrderByTen)
        {
            string trangThaiString = (item.trangThai) ? "Rồi" : "Chưa";
            Console.WriteLine($@"{item.maCongViec}. {item.tenCongViec} -- {trangThaiString}");
    
        }


        


        


    }
}