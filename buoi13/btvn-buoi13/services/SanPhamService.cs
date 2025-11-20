public class SanPhamService
{   

    





    // --- // 
    List<SanPham> lstSanPham  = new List<SanPham>(); 
    DienTu dt = new DienTu();
    ThoiTrang tt = new ThoiTrang();
    ThucPham tp = new ThucPham();
    // --- // 
    public void ThemSanPham()
    {
        Console.WriteLine($@"
Chọn loại sản phẩm:
1. Điện tử 
2. Thời Trang 
3. Thực Phẩm");
        Console.Write($@"Lựa chọn: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($@"");
        Console.Write($@"Nhập mã sản phẩm: ");
        string curMaSanPham  = Console.ReadLine();

        Console.Write($@"Nhập tên sản phẩm: ");
        string curTenSanPham = Console.ReadLine();

        Console.Write($@"Nhập giá gốc: ");
        double curGiaGoc =Convert.ToDouble(Console.ReadLine());


        switch (choice)
        {
            case 1:  
                dt.MaSanPham = curMaSanPham;
                dt.TenSanPham = curTenSanPham;
                dt.GiaGoc = curGiaGoc;

                Console.Write($@"Nhập thuế bảo hành(%): ");
                dt.ThueBaoHanh = Convert.ToDouble(Console.ReadLine());

                lstSanPham.Add(dt);
                break;

            case 2:
                tt.MaSanPham = curMaSanPham;
                tt.TenSanPham = curTenSanPham;
                tt.GiaGoc = curGiaGoc;

                Console.Write($@"Nhập % giảm giá(%): ");
                tt.GiamGia = Convert.ToDouble(Console.ReadLine());

                lstSanPham.Add(tt);
                break;
            case 3:
                tp.MaSanPham = curMaSanPham;
                tp.TenSanPham = curTenSanPham;
                tp.GiaGoc = curGiaGoc;

                Console.Write($@"Nhập phí vận chuyển: ");
                tp.PhiVanChuyen = Convert.ToDouble(Console.ReadLine());
                
                lstSanPham.Add(tp);
                break;

            default: 
                Console.WriteLine($@"Chọn Sai");
                break;
            
        }
    }

    public void HienThiDanhSach()
    {   
        Console.WriteLine($@"--------------------------------");
        foreach (var sp in lstSanPham)
        {
            sp.HienThiThongTin();
            Console.WriteLine($@"---");
        }
        Console.WriteLine($@"--------------------------------");
    }


    public double TinhTongDoanhThu()
    {
        double tong = 0;
        foreach(var sp in lstSanPham)
        {
            tong += sp.TinhGiaBan();
           
        }
        return tong;
    }

    public void XoaSanPham()
    {
        Console.WriteLine($@"");
        Console.WriteLine($@"--- Xóa Sản Phẩm ---");

        Console.Write($@"Nhập Mã Sản Phâm Muốn Xóa: ");
        string maSpXoa = Console.ReadLine();

        var spCanXoa = this.lstSanPham.SingleOrDefault(sp => sp.MaSanPham == maSpXoa);
        if(spCanXoa == null)
        {
            Console.WriteLine($@"Không tìm thấy sản phẩm");
        }
        else
        {
            lstSanPham.Remove(spCanXoa);
        }

    }
}