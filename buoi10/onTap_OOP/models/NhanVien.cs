using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace QuanLyNhanVien;


public class NhanVien
{
    public int maNhanVien { get; set; }
    public string tenNhanVien { get; set; }
    public double luong { get; set; }

    public int hesoLuong { get; set; } = 1;

    // private int heSoLuong{get; set;} = 1; // --> user cant change 
    // public int heSoLuong {get; } = 1 // --> get means user can access -> can chaneg
    public string chucVu { get; set; }



    // Have this by default -> does not need to declare 
    public NhanVien()
    {
        // Contructor: Hàm khởi tạo 
        // Chạy khi object đc tạo ra 
        // Đây là 1 dạng overload function 

    }

    public NhanVien(int ma, string ten, double luong)
    {
        this.maNhanVien = ma;
        this.tenNhanVien = ten;
        this.luong = luong;
    }

    // Cách Clone object qua location memory mới
    // Phương thức khởi tạo sao chép

    public NhanVien CloneNhanVien()
    {

        return (NhanVien)this.MemberwiseClone();

    }


    /// <summary>
    /// Hàm tính lương 1 
    /// </summary>
    /// <returns></returns>
    public double TinhLuong()
    {
        return this.luong * this.hesoLuong;


    }


    /// <summary>
    /// Hàm tính lương 2 + có tiền thưởng (int)
    /// </summary>
    /// <param name="tienThuong"></param>
    /// <returns></returns>
    public double TinhLuong(int tienThuong)
    {
        return this.luong * this.hesoLuong + tienThuong;
    }


    /// <summary>
    /// Hàm tính lương 3 + có tiền thưởng (double)
    /// </summary>
    /// <param name="tienThuong"></param>
    /// <returns></returns>
    public double TinhLuong(double tienThuong)
    {
        return this.luong * this.hesoLuong + tienThuong;
    }



    // Static: 


    // Tuy nó ở trong object -> nhưng nó ko thuộc về object 
    // CAN'T 
    // Nhanvien nv3 = new NhanVien();
    // nv3.DisplayClassName(); --> ko làm như này đc

    // CAN 
    // Nhanvien.DisplayClassName()
    public static string DisplayClassName()
    {
        return nameof(NhanVien);
    }
}


