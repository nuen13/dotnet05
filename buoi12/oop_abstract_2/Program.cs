

class Program
{
    static void Main()
    {
        List<NhanVien> lstNhanVien = new List<NhanVien>();

        GiamDoc giamDoc = new GiamDoc();

        giamDoc.taiKhoan = "giamdoc";
        giamDoc.matKhau = "123";
        giamDoc.email = "giamdoc@gmail.com";
        giamDoc.hoTen = "Tran Giam Doc";

        NhanVienVanPhong nhanVien = new NhanVienVanPhong();

        nhanVien.taiKhoan = "nahnvien";
        nhanVien.matKhau = "234";
        nhanVien.email = "nahnvien@gmail.com";
        nhanVien.hoTen = "Nguyen Nhan Vien";

        lstNhanVien.Add(giamDoc);
        lstNhanVien.Add(nhanVien);

        foreach(var nv in lstNhanVien)
        {
            nv.dangNhap();
            double luong = nv.tinhLuong();
            Console.WriteLine($@"Pay: {luong}");
        }
    }
}