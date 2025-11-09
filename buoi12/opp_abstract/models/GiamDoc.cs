using System;

namespace vanPhong
{
    public class GiamDoc : NhanVien
    {
        private int heSoLuong = 23;

        public override void dangNhap()
        {
            Console.WriteLine($"Hello Giam Doc {hoTen} da dang nhap");
        }

        public override double tinhLuong()
        {
            return heSoLuong * 10000;
        }
    }
}
