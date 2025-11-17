
public class GiamDoc : NhanVien
{

    private int heSoLuong = 10;

    public override void dangNhap()
    {
        Console.WriteLine($@"Hello Giam Doc ");

    }
    
    public override double tinhLuong()
    {
        return heSoLuong * 1000;

    }

}