/* Viết chương trình cho phép người dùng nhập vào điểm toán, lý, hoá. Yêu cầu tính điểm trung bình và xếp loại theo rank hạng như sau
    Điểm trung bình >= 8.0: Xếp loại Giỏi
    Điểm trung bình >= 6.5 và < 8.0: Xếp loại Khá
    Điểm trung bình >= 5.0 và < 6.5: Xếp loại Trung bình
    Điểm trung bình < 5.0: Xếp loại Yếu
*/


// Console.Write($@"toan: ");
// double toan = Convert.ToDouble(Console.ReadLine());

// Console.Write($@"ly: ");
// double ly = Convert.ToDouble(Console.ReadLine());

// Console.Write($@"hoa: ");
// double hoa = Convert.ToDouble(Console.ReadLine());

// double trungBinh = (toan + ly + hoa) / 3;

// string xepHang = "";

// xepHang = trungBinh switch
// {
//         >= 8.0            => "giỏi",
//         >= 6.5 and < 8.0  => "khá",
//         >= 5.0 and < 6.5  => "trung bình",
//         < 5.0             => "yếu",
//         _                 => "không hợp lệ"
// };


// Console.WriteLine($@"ban la hoc sinh {xepHang}");


Console.Write($@"luong: ");

double luong = Convert.ToDouble(Console.ReadLine());
//double luong = double.Parse(Console.ReadLine());

string thue = " ";
double thuePhaiTra = 0;


(thue, thuePhaiTra) = luong switch
{
    <= 5.0                => ("miễn thuế", 0),
    > 5 and <= 10         => ("10%", luong - (luong * 10 / 100)),
    > 10                  => ("20%", luong - (luong * 20 / 100)),
    _                     => ("no money brok shit", 0)
};

Console.WriteLine($@"{luong}, {thue}, {thuePhaiTra}");

