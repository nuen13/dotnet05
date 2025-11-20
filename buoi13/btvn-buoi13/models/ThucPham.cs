public class ThucPham : SanPham
{


    public double PhiVanChuyen {get; set;}

    public override double TinhGiaBan()
    {

        double giaBan = 0;

        giaBan = GiaGoc + PhiVanChuyen;
        return giaBan;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($@"Phí vận chuyển: {PhiVanChuyen}");
    }
}