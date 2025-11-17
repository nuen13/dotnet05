public class IGiamDocDemo : INhanVien, IChamCong
{
    public bool CheckIn()
    {
        Console.WriteLine($@"Giam Doc checkin");
        return true;

    }

    public void DangNhap()
    {
        Console.WriteLine($@"GIam Doc Dang Nhap");
    }


    public double TinhLuong()
    {
        
       Console.WriteLine($@"Giam Doc Siue Giau");
       return 0; 
    }
}

