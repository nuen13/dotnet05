public class NhanVienVanPhong : NhanVien
{

    private int heSoLuong = 5;
    public override void dangNhap()
    {
        Console.WriteLine($@"Hello Nhan Vien Quen {hoTen} ");

    }
    
    public override double tinhLuong()
    {
        return heSoLuong * 1000;
    }


}