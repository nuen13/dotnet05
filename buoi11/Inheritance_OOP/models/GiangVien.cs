public class GiangVien : NguoiDung
{
    public double TinhLuong()
    {
        return this.luongCoBan * 2;
    }

    public override void dangNhap()
    {
        Console.WriteLine($@"Chao Mung Giang Vien -- dang Nhap");
        // base.Login();
    }

}