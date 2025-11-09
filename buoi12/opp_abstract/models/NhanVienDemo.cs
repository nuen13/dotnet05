public class NhanVienDemo: INhanVien
{
    public bool checkIn()
    {
        return true;
    }

    public void dangNhap()
    {
        Console.WriteLine($@"Nhan Vien dang nhap vao interface");

    }

    public double tinhLuong()
    {
        return 1000;
        
    }


}