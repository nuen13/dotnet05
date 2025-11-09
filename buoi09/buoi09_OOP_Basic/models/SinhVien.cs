

using System.Net;

public class SinhVien //OOP 
{

    public static int maTuTang = 1; 
    public int maSinhVien;
    private string tenSinhVien;
    private double diemToan;
    private double diemLy;
    private double diemHoa;




    public SinhVien()
    {
        // Hàm khởi tạo 
        // Console.Write($@"Nhập mã sinh viên: ");
        // this.maSinhVien = Convert.ToInt32(Console.ReadLine());
        this.maSinhVien = SinhVien.maTuTang;

        Console.Write($@"Nhập tên sinh viên: ");
        this.tenSinhVien = Console.ReadLine();

        Console.Write($@"Nhập điểm toán: ");
        this.diemToan = Convert.ToInt32(Console.ReadLine());

        Console.Write($@"Nhập điểm lý: ");
        this.diemLy = Convert.ToInt32(Console.ReadLine());

        Console.Write($@"Nhập điểm hóa: ");
        this.diemHoa = Convert.ToInt32(Console.ReadLine());

        maTuTang++;
    }

    public void xuatThongTinSinhVien()
    {
         Console.WriteLine(@$"{this.maSinhVien,-9} | {this.tenSinhVien,-20} | {this.diemToan,3:F1} | {this.diemLy,3:F1} | {this.diemHoa,5:F1} | {this.TinhDiemTrungBinh(),5:F2} | {this.XepLoaiHocSinh(),-10}"
    );
    }




    public double TinhDiemTrungBinh()
    {
        return (this.diemToan + this.diemLy + diemHoa) / 3;
    }


    public string XepLoaiHocSinh()
    {
        double diemTrungBinh = this.TinhDiemTrungBinh();

        string xepLoai = diemTrungBinh switch
        {
            >= 8.0 => "giỏi",
            >= 6.5 and < 8.0 => "khá",
            >= 5.0 and < 6.5 => "trung bình",
            < 5.0 => "yếu",
            _ => "không hợp lệ"
        };
        return xepLoai;
    }
}