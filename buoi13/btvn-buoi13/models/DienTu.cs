public class DienTu : SanPham
{

    public double ThueBaoHanh {get; set;}

    public override double TinhGiaBan()
    {
        double giaBan = 0;

        giaBan = GiaGoc + (GiaGoc * ThueBaoHanh/100);
        return giaBan;
    }



    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($@"Thuế Bảo Hành: {ThueBaoHanh}%");
    }
}