/**

    Khái niệm trong hướng đối tượng 

    Class: lớp đối tượng (kiểu dữ liệu do mình tạo ra có thể chứa đc nhiều giá trị cũng như hàm phương thức)
        + Thuộc tính: là biến trong đối tượng
        + Phương thức: hàm trong đối tượng
    
    Object (object instance là object được tạo ra từ class -lớp đối tượng) chứa các thuộc tính 
    và phương thức được đối tượng định nghĩa sẵn


**/

// SinhVien svA = new SinhVien();
// svA.xuatThongTinSinhVien();

// SinhVien svB = new SinhVien();
// svB.xuatThongTinSinhVien();

// sv.maSinhVien = 1;
// sv.tenSinhVien = "Le Van Luyen";
// sv.diemToan = 10;
// sv.diemLy = 10;
// sv.diemHoa = 10;

LopHoc lophoc = new LopHoc();

// lophoc.ThemSinhVien();
// lophoc.ThemSinhVien();

// lophoc.XuatDSSV();


while(lophoc.chucNang != 7)
{
    lophoc.LoadChucNangLopHoc();
    lophoc.chucNang = Convert.ToInt32(Console.ReadLine());


    switch (lophoc.chucNang)
    {
        case 1:
            lophoc.XuatDSSV();
            break;
        case 2:
            lophoc.ThemSinhVien();
            break;
        case 3:
            lophoc.XoaSinhVien();
            break;
        case 4:

            break;
        case 5:

            break;
        case 6:

            break;


        default:
            break;

    }

}
