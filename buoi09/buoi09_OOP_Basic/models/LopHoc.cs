// Tạo ra 1 kiểu dữ liệu lớp học 

public class LopHoc
{
    public List<SinhVien> dssv = new List<SinhVien>();


    public static int maTuTang;
    public string tenLop;

    public int maLop;

    public int chucNang = -1; 

    public LopHoc()
    {
        // Console.Write($@"Nhập vào mã lớp: ");
        // this.maLop = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($@"-- Thông Tin Lớp Học Mã {LopHoc.maTuTang} -- ");
        this.maLop = LopHoc.maTuTang;

        Console.Write($@"Nhập vào tên lớp: ");
        this.tenLop = Console.ReadLine();

        maTuTang++;

    }

        public void LoadChucNangLopHoc()
    {
        Console.WriteLine($@"--------------- Chương trình quản lý lớp học -----------------");
        Console.WriteLine($@"
        
        1. Load Danh Sách
        2. Thêm Sinh Viên
        3. Xóa Sinh Viên
        4. Cập Nhật Sinh Viên
        5. Tìm Kiếm Sinh VIên
        6. Sắp Xếp Sinh Viên
        7. Thoát");
    }


    public void ThemSinhVien()
    {
        var svNew = new SinhVien();

        dssv.Add(svNew);


    }

    public void XuatDSSV()
    {

        Console.WriteLine("Mã SV     | Tên sinh viên       | Toán  | Lý   | Hóa  | TB   | Xếp loại");

        foreach (SinhVien sv in this.dssv)
        {
            sv.xuatThongTinSinhVien();

        }

    }
    
    public void XoaSinhVien()
    {
        // mã -> tìm thấy mã | ko tìm thấy mã 

        Console.Write($@"Nhập vào mã sinh viên cần xóa: ");
        int maSVXoa = Convert.ToInt32(Console.ReadLine());

        // Tìm trong this.dssv có sv nào có maSinhVien = maSVXoa ko 

        int indexSVXoa = this.dssv.FindIndex(sv => sv.maSinhVien == maSVXoa);


        // Xóa objetc Sinh Vien tại vị trí index tương ứng
        if (indexSVXoa != -1)
        {
            this.dssv.RemoveAt(indexSVXoa);
            Console.WriteLine($@"Danh sách sinh viên sau khi xóa");
            this.XuatDSSV();
        }
        else
        {
            Console.WriteLine($@"Không tìm thấy ");

        }

        
        



    }








}