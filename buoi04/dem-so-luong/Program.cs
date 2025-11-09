// input: chuỗi nhập từ bàn phím

// xử lý: loại bỏ khoảng trắng trong chuỗi
// Dùng vòng lặp duyệt từng ký tự trong chuỗi

// nếu ký tự đó != ' ' => nối ký tự đó vào chuỗi mới

// output: chuỗi sau khi loại bỏ khoảng trắng


Console.Write($@"Nhap: ");
string content = Console.ReadLine();

string output = "";

for (int count = 0; count < content.Length; count++)
{
    if (content[count] != ' ')
    {
        output += content[count];
    }
}

Console.WriteLine($@"{output}");