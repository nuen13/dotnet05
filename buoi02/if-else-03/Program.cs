




Console.Write($@"Nhập lương cơ bản: ");
double luong = Convert.ToDouble(Console.ReadLine());

Console.Write($@"Nhập số giờ làm việc trong tuần: ");
double thoiGian = Convert.ToDouble(Console.ReadLine());

double luongTuan;

if (thoiGian > 40)
{
    luongTuan = luong * (40 + (thoiGian - 40) * 1.5);
}
else
{
    luongTuan = luong * thoiGian;
}

Console.WriteLine($@"Luong cua ban la: {luongTuan}");