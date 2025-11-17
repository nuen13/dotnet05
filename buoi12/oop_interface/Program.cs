

class Program
{
    static void Main()
    {
        IGiamDocDemo gdDemo = new IGiamDocDemo();
        INhanVienDemo nvDemo = new INhanVienDemo();

        List<INhanVien> lstINhanvien = new List<INhanVien>();
        // List<IChamCong> lstIChamCong = new List<IChamCong>();

        lstINhanvien.Add(nvDemo);
        lstINhanvien.Add(gdDemo);

        foreach(INhanVien nvItem in lstINhanvien)
        {
            
            nvItem.DangNhap();
            double luong = nvItem.TinhLuong();
            Console.WriteLine($@"class { nvItem.GetType().Name} - luong: {luong}");

        }

    }
}