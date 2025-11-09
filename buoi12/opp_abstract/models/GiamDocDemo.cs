public class GiamDocDemo : INhanVien
{
    public bool checkIn(){
        Console.WriteLine($@"Giam Doc Check in");
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