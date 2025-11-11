
public class NhanVien
{
    public static int maTuTang = 1;

    public int maNhanVien { get; set; }

    public string? tenNhanVien { get; set; }

    public double hourRate { get; set; }

    public int hours { get; set; }

    public NhanVien()
    {

    }

    public NhanVien(bool create = true)
    {
        this.maNhanVien = maTuTang;

        Console.Write($@"Name: ");
        this.tenNhanVien = Console.ReadLine();

        Console.Write($@"Hour Rate: ");
        this.hourRate = Convert.ToDouble(Console.ReadLine());

        Console.Write($@"Hours: ");
        this.hours = Convert.ToInt32(Console.ReadLine());

        maTuTang++;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($@"MSNV: {this.maNhanVien} - Name: {this.tenNhanVien} - Luong:{this.hourRate * this.hours} ");

    }

}