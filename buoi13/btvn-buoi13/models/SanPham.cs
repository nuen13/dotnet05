public abstract class SanPham
{   
    public string MaSanPham {get; set;}
    public string TenSanPham {get; set;}
    public double GiaGoc {get; set;}


    public abstract double TinhGiaBan();

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($@"
Mã Sản Phẩm:    {MaSanPham}
Tên Sản Phẩm:   {TenSanPham}
Giá Gốc:        {GiaGoc}
Giá Bán:        {TinhGiaBan()}");
    }
}