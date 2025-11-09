#region 6.tim tu dai nhat 

// Đề bài: Viết một hàm nhận vào một chuỗi s, trả về từ dài nhất trong chuỗi đó. Nếu có nhiều từ có độ dài bằng
// nhau, trả về từ đầu tiên tìm thấy.
// Ví dụ:
// Input: "I love programming"
// Output: "programming


// process
string TimTuDaiNhat(string s)
{
    string tuHienTai = "";
    string tuMoi = "";

    for (int count = 0; count < s.Length; count++)
    {


        if (s[count] != ' ')
        {
            tuHienTai += s[count];
        }
        else
        {
            if (tuHienTai.Length > tuMoi.Length)
            {
                tuMoi = tuHienTai;
            }
            tuHienTai = "";
        }
        if (tuHienTai.Length > tuMoi.Length)
        {
            tuMoi = tuHienTai;
        }

    }
    return tuHienTai;
};



// input: string s 
Console.Write($@"Nhập chuỗi: ");
string s = Console.ReadLine();

// string s = "I love programming";

// output: string output 
string output = TimTuDaiNhat(s);
Console.WriteLine($@"{output}");

#endregion


#region 7. Loại bỏ ký tự đặc biệt

// 7. Loại bỏ ký tự đặc biệt
// Đề bài: Cho một chuỗi s chứa các từ và ký tự đặc biệt, hãy loại bỏ tất cả các ký tự đặc biệt và trả về chuỗi chỉ
// chứa các từ và khoảng trắng.
// Ví dụ:
// Input: "he@llo! worl#d"
// Output: "hello world"


string LoaiBoKyTu(string s)
{

    string tuMoi = "";
    for (int count = 0; count < s.Length; count++)
    {
        if (char.IsLetterOrDigit(s[count]) || char.IsWhiteSpace(s[count]))
        {
            tuMoi += s[count];
        }
    }


    return tuMoi;
}


// input: string s 
Console.Write($@"Nhập chuỗi: ");
string s = Console.ReadLine();

// output string output 
string output = LoaiBoKyTu(s);
Console.WriteLine($@"{output}");

#endregion


#region 8. Tách từ và trả về từ dài nhất có chứa số
// Đề bài: Cho một chuỗi s chứa các từ cách nhau bởi khoảng trắng, trong đó có các từ chứa cả chữ cái và chữ
// số. Viết hàm trả về từ dài nhất có chứa ít nhất một số. Nếu không có từ nào chứa số, trả về chuỗi rỗng.
// Ví dụ:
// Input: "abc123 def45 ghi6789"
// Output: "ghi6789"

// input: string s
// Console.Write($@"Nhập chuỗi: ");
// string s = Console.ReadLine();

string s = "abc123 def45 ghi6789";




string TimTuDaiNhatCoSo(string s)
{
    string tuHienTai = "";
    string tuMoi= "";

    bool coSo = false;

    for (int count = 0; count < s.Length; count++)
    {
        if (s[count] != ' ')
        {
            tuHienTai += s[count];
            if (char.IsDigit(s[count]))
            {
                coSo = true;
            }
        }
        else
        {
            if (coSo && tuHienTai.Length > tuMoi.Length)
            {
                tuMoi = tuHienTai;
            }
            coSo = false;
            tuHienTai = "";
        }

        if (coSo && tuHienTai.Length > tuMoi.Length)
        {
            tuMoi = tuHienTai;
        }
    }
    return tuMoi;
};




// output: string output 
string output = TimTuDaiNhatCoSo(s);


Console.WriteLine($@"{output}");

#endregion
