using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Nodes;
using ProductManagement;
using QuanLyNhanVien;
using Force.DeepCloner;


/*
    Lưu Ý: 4 tính chất của hướng đối tượng OOP 

    + Tính trừu tượng (abstraction): 
        Tập trung vào các thành phần lưu trữ của đối tượng 
        (thuộc tính và phương thức)

    + Tính đóng gói (encapsulation): 
        getter, setter
        Tính đóng gói cho phép che giấu đi thông tin và 
        những tính chất xử lý bên trong của đối tương. Các
        đối tượng khác đều ko thể tác đông trực tiếp đến 
        dữ liệu bên trong và thay đổi trạng tháy của các 
        đối tượng mà bắt buộc phải thông qua các phương 
        thức công khai do đối tượng đó cung cấp (phương
        thức get và set )


    + Tính kế thừa (Inheritance); 
        - Cho phép 1 lớp con kế thừa thuộc tính và tính chất của lớp cha
        - Promote code re-use, and enables the creation of hierarchial 
        relationships between clasess
    + Tính đa hình (Polymorphism):
        - Means 'many forms"
        - Allow the same method name to behave diff depending on the 
        object that calls its
        - 2 main types:
            - Compile-time (method - overloading)
            - Runtime (method - overriding )




*/


Product prod = new Product();
prod.id = 0;
prod.name = "Iphone 12";
prod.price = 10000;

Console.WriteLine($@"{JsonSerializer.Serialize(prod)}");


Phone phone = new Phone();

NhanVien nv = new NhanVien();
nv.luong = 1000;

Console.WriteLine($@"{nv.TinhLuong()}");

// Constructor - Overload function (only exist it code type - c#, etc.. )


nv.TinhLuong(1000.50);

Console.WriteLine($@"
Kết quả tính lương 1: {nv.TinhLuong()}
Kết quả tính lương 2: {nv.TinhLuong(200)}
Kết quả tính lương 3: {nv.TinhLuong(200.3)}
");

// ----- // 

NhanVien nv2 = new NhanVien();
nv2.maNhanVien = 2;
nv2.tenNhanVien = "Victor Wembiyanma";
nv2.luong = 1092;


Console.WriteLine($@"
Thông tin nhân viên 2: 
{JsonSerializer.Serialize(nv2)}");

// ---- // 
NhanVien nv3 = new NhanVien(ma:69, ten:"Giannis Antetotakumpo", luong:12);


Console.WriteLine($@"
Thông tin nhân viên 3: 
{JsonSerializer.Serialize(nv3)}");


/* 
    Đối với tất cả programming language 

    primative langage - computer can recognize -> giá trị nguyên thủy 
        int, string, bool, double, ... 
    
    reference value (giá trị tham chiếu)
        collections(tuple , list, set, hashset, ... ) và object

*/



// Đối tượng động -> tạo đối tượng ko thông qua class
// var ob1 = new {id = 5};

NhanVien nv4 = new NhanVien();
nv4.maNhanVien = 12;

NhanVien nv5 = nv4;
nv5.maNhanVien = 10;

NhanVien nv6 = nv4.CloneNhanVien(); // Shallow clone
nv6.maNhanVien = 90;

NhanVien nv7 = nv4.DeepClone();
nv7.maNhanVien = 123;
// shallow clone: 
// khi clone sử dụng phương thức này -> các giá trị primative khi thay 
// đổi sẽ đc clone ra các ô nhớ mới. Tuy nhiên các giá trị ref value sẽ
// vẫn đc tham chiếu khi gán 

// Kiểu nó chỉ clone 1 cấp -> cấp sau hơn nó vẫn lưu vị trí của thằng cũ 




Console.WriteLine($@"

id nhân viên 4: {nv4.maNhanVien}
id nhân viên 5: {nv5.maNhanVien}
id nhân viên 6: {nv6.maNhanVien}

");

// id nhân viên 4: 10
// id nhân viên 5: 10 

// Nhân viên 4 bị đổi thành 10 

Console.WriteLine($@"{NhanVien.DisplayClassName}");