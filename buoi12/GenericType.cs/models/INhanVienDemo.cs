public class INhanVienDemo : INhanVien, IChamCong // implement, đa kế thừa
{
    public bool CheckIn()
    {
        return true;
    }
    public void DangNhap()
    {
        Console.WriteLine($@"Nhan Vien Dang Nhap Vao Interface");
    }

    public double TinhLuong()
    {
        return 1001020;
    }

}