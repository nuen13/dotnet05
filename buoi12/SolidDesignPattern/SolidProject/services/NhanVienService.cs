public class NhanVienService
{   

    public void NhapThongTin(ref NhanVien nv)
    {
        Console.Write($@"Nhập mã: ");
        nv.Id = Console.ReadLine();

        Console.Write($@"Nhập họ tên: ");
        nv.hoTen = Console.ReadLine();

        Console.Write($@"Nhập Email: ");
        nv.email = Console.ReadLine();

        Console.Write($@"Nhập Lương: ");
        nv.luongCoBan = Convert.ToDouble(Console.ReadLine());

        Console.Write($@"Nhập Chức Vụ (1, 2, 3): ");
        nv.chucVu = Enum.Parse<chucVu>(Console.ReadLine());
    }
    
    public double TinhLuong(NhanVien nv)
    {
        double luong = nv.chucVu switch
        {
            chucVu.NhanVien => nv.luongCoBan * 1, 
            chucVu.QuanLy => nv.luongCoBan * 2, 
            chucVu.GiamDoc => nv.luongCoBan * 3, 
            _  => 0, 
        };


        return luong;
        
    }

}