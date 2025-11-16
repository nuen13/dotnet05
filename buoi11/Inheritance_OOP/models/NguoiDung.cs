


public class NguoiDung
{
    public string taiKhoan { get; set; }

    public string matKhau { get; set; }

    public string email { get; set; }

    public string hoTen { get; set; }

    private int heSoLuong { get; set; }

    protected double luongCoBan{ get; set; }

    public virtual void dangNhap()
    {
        Console.WriteLine($@"Login ");
    }

    public void dangXuat()
    {
        Console.WriteLine($@"Logout ");
    }



}