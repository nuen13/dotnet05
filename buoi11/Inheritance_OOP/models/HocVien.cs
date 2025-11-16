

public class HocVien : NguoiDung
{
    public override void dangNhap()
    {
        Console.Write($@"Hoc Vien -- ");
        base.dangNhap();
    }
}