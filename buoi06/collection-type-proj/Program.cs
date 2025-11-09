using System.Data.Common;
using System.Reflection;
using System.Runtime.InteropServices;

List<int> nums = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };

// Console.WriteLine($@"{string.Join(",", nums)}");

// add all number in nums that greater than 50 

Func<int> sumOfNumGreaterThan50 = () =>
{
    int tong = 0;

    foreach (int num in nums)
    {
        if (num > 50)
        {
            tong += num;
        }
    }

    return tong;
};

// Console.WriteLine($@"tong cac so lon hon 50: {sumOfNumGreaterThan50()}");

//Tìm số n người dùng nhập vào có trong list hay không nếu không có thì in ra không tìm thấy, nếu tìm thấy thì in ra vị trí của số đó

Func<string> findNumIndex = () =>
{

    string kq = "";

    Console.Write($@"Nhap so: ");
    int soCanTim = Convert.ToInt32(Console.ReadLine());

    int indexU = nums.FindIndex(hItem => hItem == soCanTim);


    if (indexU == -1)
    {
        Console.WriteLine($@"ko tim thay");
    }
    else
    {
        Console.WriteLine($@"so can tim o vi tri {indexU}");
    }
    return kq;
};

// Console.WriteLine($@"{findNumIndex()}");



// Bài tập --------------------------------- List chuỗi -----------------------------------------
List<string> lstStrings = ["apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon"];

// apple | AppLE 

Action TimTraiCay = () =>
{
    Console.WriteLine($@"nhap: ");
    string tenCanTim = Console.ReadLine().ToLower();

    string kq = "";


    int indexTim = lstStrings.FindIndex(item => item.ToLower().Contains(tenCanTim));

    if (indexTim != -1)
    {
        Console.WriteLine($@"{lstStrings[indexTim]}");
    } else
    {
        Console.WriteLine($@"ko tim that");
    }


    // foreach(string item in lstStrings)
    // {
    //     if(item.ToLower() == tenCanTim)
    //     {
    //         kq = @$"co {item} trong list";
    //     }
    // }


};