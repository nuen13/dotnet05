namespace vanPhong
{
    public abstract class NhanVien
    {
        public string hoTen { get; set; }
        public string email { get; set; }
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }

        public abstract void dangNhap();
        public abstract double tinhLuong();
    }
}
