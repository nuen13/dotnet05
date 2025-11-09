// int count = 1;
// while (count <= 5)
// {
//     Console.WriteLine($@"hello {count}");
//     count++;

// }


/*
    Viết chương trình cho phép người dùng nhập vào số n (số năm làm việc): 
    Yêu cầu:
        Tính tổng từ 1 đến n.
        Lấy ví dụ : n = 5
        tong = 1 + 2 + 3 + 4 + 5;

        Lưu ý: Không dùng công thức không sử dụng vòng lặp
        tong = (n x (n+1) ) / 2; 
*/


// Console.Write($@"nhap n: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int count = 1;
// int total = 0;

// while (count <= n)
// {
//     total = total + count;
//     count++;

// }

// Console.WriteLine($@"{total}");

//-----------------------------// 




Console.Write($@"nhap n: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;
int total = 1;

if (n == 0)
{
    total = 1;

}
else
{
    while (count <= n)
    {
        total *= count;
        count++;

    }
}

Console.WriteLine($@"{total}");