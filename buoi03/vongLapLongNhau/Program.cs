// -- Vòng Lặp Lồng Nhau -- // 

/*
    Viết chương trình cho phép người dùng nhập vào ma trận (hàng, cột). Yêu cầu
    in ra các ngôi sao tương ứng
*/



Console.Write($@"sô cột: ");
int soCot = Convert.ToInt32(Console.ReadLine());

Console.Write($@"số hàng: ");
int soHang = Convert.ToInt32(Console.ReadLine());

string ketQua = "";

for (int count = 0; count < soCot; count++)
{
    for (int count2 = 0; count2 < soHang; count2++)
    {
        ketQua += " * ";
    }
    ketQua += "\n";
}

Console.WriteLine($@"{ketQua}");

