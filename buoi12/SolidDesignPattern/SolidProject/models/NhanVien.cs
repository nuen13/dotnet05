public class NhanVien
{
    public string Id {get; set;}
    public string hoTen {get; set;}
    public string email {get; set;} 
    public  chucVu chucVu {get; set;} = chucVu.NhanVien;
    public double luongCoBan {get; set;}
}