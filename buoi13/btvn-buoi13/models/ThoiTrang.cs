public class ThoiTrang : SanPham
{   
    public double GiamGia {get; set;}

    public override double TinhGiaBan()
    {

        double giaBan = 0;

        giaBan = GiaGoc - (GiaGoc * GiamGia/100);
        return giaBan;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($@"Giảm giá (%): {GiamGia}%");
    }
}