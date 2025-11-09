using System;

namespace vanPhong
{
    public class NhanVienVanPhong : NhanVien
    {
        private int heSoLuong = 2;

        public override void dangNhap()
        {
            Console.WriteLine($"Hello Nhan Vien {hoTen} da dang nhap");
        }

        public override double tinhLuong()
        {
            return heSoLuong * 1000;
        }
    }
}
