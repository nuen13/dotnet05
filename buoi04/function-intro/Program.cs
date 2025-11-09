

// Function (Hàm) trong C# chia code thành các khối nhỏ để dễ quản lý , để sử dụng và dùng khi cần thiết



// Declare Function 
void firstFunc()
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"hello");
    Console.ResetColor();

}

// gom code vô hàm -> cần gọi hàm thì code mời chạy
firstFunc(); // --> function call


// Phân loại function 
// Void -> Hàm ko có giá trị 
// void function()
// int, string, bool -> hàm có giá trị trả về 
// int function()

// Hàm tính tổng
int tinhTong()
{
    int a = 1;
    int b = 3;
    return a + b; // -> bat buoc có return ko thì sẽ báo lỗi (đối với hàm có giá trị)
}

int b = tinhTong();
Console.WriteLine($@"{b}");

// hàm có tham số - parameter 
// Tính tích 
int tinhTich(int a = 10, int b = 9) // -> default value, only activate whenever values pass are invalid
{
    return a * b;
}

int c = tinhTich(3, 4);
Console.WriteLine($@"{c}");


function tinhDiem()
{
    
}s