using System.Reflection.PortableExecutable;

namespace QuanLyThongTinNhanVien;



public class DanhSachNhanVien
{

    public List<NhanVien> dsnv = new List<NhanVien>();
    public int chucNang = -1;


    public void LoadChucNangQuanLy()
    {
        Console.WriteLine($@"");
        Console.WriteLine($@"--------------- Chương trình quản lý lớp học -----------------");
        Console.WriteLine($@"
1. Thêm Sinh Viên
2. Tìm kiếm thông tin dùng tên
3. Thay đổi tên
4. Xóa Nhân Viên
5. Hiển thị danh sách nhân viên 
6. Thoát
        ");
    }


    // 1. Thêm Nhân Viên 
    public void ThemNhanVien()
    {
        var nhanVienMoi = new NhanVien();
        dsnv.Add(nhanVienMoi);

        Console.WriteLine($@"");
        Console.WriteLine($@"Danh sách nhân viên sau khi thêm là");
        HienThiDanhSach();
    }

    // 2. Tìm Kiếm Thông Tin Dùng Tên
    public void TimKiemNhanVien()
    {
        Console.Write($@"Nhập tên nhân viên muốn tìm: ");
        string tenNVTimKiem = Console.ReadLine();

        int indexTenNVTimKiem = this.dsnv.FindIndex(nv => nv.tenNhanVien == tenNVTimKiem);



        if (indexTenNVTimKiem != -1)
        {
            NhanVien nv = dsnv[indexTenNVTimKiem];

            Console.WriteLine($@"Thông tin nhân viên: ");
            Console.WriteLine($@"Mã: {nv.maNhanVien}, Tên: {nv.tenNhanVien}, Lương 1h: {nv.luong}, Giờ: {nv.soGioLam}");


        }
        else
        {
            Console.WriteLine($@"Không tìm thấy nhân viên này");
        }


    }

    // 3. Thay đổi tên nhân viên
    public void ThayDoiTenNhanVien()
    {
        Console.Write($@"Nhập mã nhân viên muốn thay đổi ");
        int maNVThayDoi = Convert.ToInt32(Console.ReadLine());
        int indexNVThayDoi = this.dsnv.FindIndex(nv => nv.maNhanVien == maNVThayDoi);




        if (indexNVThayDoi != -1)
        {

            NhanVien nv = dsnv[indexNVThayDoi];
            Console.WriteLine($@"Thông tin nhân viên hiện tại: ");
            Console.WriteLine($@"Mã: {nv.maNhanVien}, Tên: {nv.tenNhanVien}, Lương 1h: {nv.luong}, Giờ: {nv.soGioLam}");

            Console.WriteLine($@"--- Thay đổi ---");   
            Console.Write($@"Tên Nhân Viên: ");
            string tenMoi = Console.ReadLine();

            Console.Write($@"Lương 1h: ");
            double luong1hMoi = Convert.ToDouble(Console.ReadLine());

            Console.Write($@"Giờ Làm: ");
            double gioLamMoi = Convert.ToDouble(Console.ReadLine());

            nv.tenNhanVien = tenMoi;
            nv.luong = luong1hMoi;
            nv.soGioLam = gioLamMoi;

            Console.WriteLine($@"Thông tin nhân viên sau khi đổi: ");
            Console.WriteLine($@"Mã: {nv.maNhanVien}, Tên: {nv.tenNhanVien}, Lương 1h: {nv.luong}, Giờ: {nv.soGioLam}");



        }
        else
        {
            Console.WriteLine($@"Không tìm thấy nhân viên này");
        }      


    }
    // 4. Xóa Nhân Viên

    public void XoaNhanVien()
    {
        Console.Write($@"Nhập mã của nhân viên muốn xóa: ");
        int maNVXoa = Convert.ToInt32(Console.ReadLine());

        int indexNVXoa = this.dsnv.FindIndex(nv => nv.maNhanVien == maNVXoa);

        if (indexNVXoa != -1)
        {
            this.dsnv.RemoveAt(indexNVXoa);
            Console.WriteLine($@"Danh Sách Nhân Viên Sau Khi Xóa: ");
            this.HienThiDanhSach();
        }
        else
        {
            Console.WriteLine($@"Không tìm thấy");
        }
    }

    // 6. Hiển Thị Danh Sách Nhân Viên 
    public void HienThiDanhSach()
    {
        Console.WriteLine("Mã NV     | Tên nhân viên       | Lương  | Giờ |");

        foreach (NhanVien nv in this.dsnv)
        {
            nv.xuatThongTinNhanVien();
        }

    }
}