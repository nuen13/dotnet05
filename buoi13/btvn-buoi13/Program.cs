class Program
{
    static void Main()
    {   

        // --- // 
        List<SanPham> lstSapham  = new List<SanPham>(); 
        SanPhamService spService = new SanPhamService();
        // --- //



        bool running = true;

        while (running)
        {
            Console.WriteLine($@"          
--- Hệ thống quản lý bán hàng ---
1. Thêm sản phẩm
2. Hiển thị danh sách sản phẩm
3. Tính tổng doanh thu 
4. Xóa sản phẩm
5. Thoát
            ");
            Console.Write($@"Vui lòng chọn chức năng: ");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch(choice)
            {
                case 1:
                    spService.ThemSanPham();
                    break;
                case 2:
                    spService.HienThiDanhSach();
                    break;
                case 3:
                    double tong = spService.TinhTongDoanhThu();
                    Console.WriteLine($@"Tông Doanh Thu là {tong}");
                    break;
                case 4: 
                    spService.XoaSanPham();

                    break;
                
                default:
                    Console.WriteLine($@"Lựa chọn không hợp lệ, vui lòng chọn lại");
                    break;
            }
            if(choice == 5)
            {
                running = false;
            }
        }

    }
}
