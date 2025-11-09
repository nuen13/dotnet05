namespace QuanLyThongTinNhanVien;

public class NhanVien
{

    // --  + maNhanVien: int
    // --  + tenNhanVien: string
    // --  + luong: double
    // --  + soGioLam: double

    public static int maTuTang = 1;

    public int maNhanVien { get; set; }
    public string tenNhanVien { get; set; }
    public double luong { get; set; }
    public double soGioLam { get; set; }


    // Lấy 1 nhân viên

    public NhanVien()
    {

        this.maNhanVien = NhanVien.maTuTang;

        Console.Write($@"Nhập tên nhân viên: ");
        this.tenNhanVien = Console.ReadLine();

        Console.Write($@"Nhập lương nhân viên: ");
        this.luong = Convert.ToDouble(Console.ReadLine());

        Console.Write($@"Nhập số giờ nhân viên làm: ");
        this.soGioLam = Convert.ToDouble(Console.ReadLine());

        maTuTang++;

    }
    
    public void xuatThongTinNhanVien()
    {

        Console.WriteLine(@$"{this.maNhanVien,-9} | {this.tenNhanVien,-20} | {this.luong,3:F1} | {this.soGioLam,3:F1} |"); 

    }
}