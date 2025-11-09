// Kỹ thuật đệ quy: Hàm gọi lại chính nó

using ThuVienHam;



#region hàm đệ quy -> tính tổng
/* 

    Viết chương trình cho phép người dùng nhập vào số n
    => tính tổng từ 0 -> n 
 
*/

// Console.Write($@"Nhập Số N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// // Gọi hàm tính tổng
// int Tong = Method.TinhTong(n);
// Console.WriteLine($@"{Tong}");


#endregion

/* 
    In dãy số từ 1 -> n ==> 1, 2, 3, 4, 5, n

*/

Console.Write($@"Nhập N: ");
int n = Convert.ToInt32(Console.ReadLine());



string daySo = Method.InDaySo(n);
Console.WriteLine($@"{daySo}");



/* 

    Lambda Expresion

    Func<input, input, ......, output> tinhTongAB 

*/

Func<int, int, int> tinhTongAB = (a, b) => a + b;



/* 

    Callback function -> đóng vai trò là tham số truyền vào hàm khác

*/

Method.ThucHanhNhiemVu(tinhTongAB);

Method.ThucHanhNhiemVu((a, b) => a * b);  //anonymous callback function 