// ------------ Bài Tập 03 ------------ // 

// lstNumber = [1, 1, 1, 2, 2, 3]

// Mô tả:
// Cho 1 int list, tìm k phần tử xuất hiện nhiều lần nhất trong list và return dưới dạng
// list. Nếu có nhiều phần tử có cùng tần số xuất hiện, trả về bất kỳ trong số chúng

// Ví dụ:
// Input: nums = [1, 1, 1, 2, 2, 3], k = 2
// Output: [1, 2]

// Giải thích: 
// Trong list, số 1 xuất hiện 3 lần, số 2 xuất hiện 2 lần, và số 3 xuất hiện 1 lần. Ta cần
//  trả về 2 phần tử xuất hiện nhiều lần nhất, và chúng có thể là 1 và 2 hoặc 2 và 1 

// Lưu Ý:
// kq có thể đc trả về dưới bất kỳ thứ tự nào
// Số lần xuất hiện của các phần tử ko cần phải theo thứ tự tăng dần



// INPUT 
using System.Runtime.InteropServices;

List<int> nums = new List<int> { 1, 2, 2, 3, 3, 3 };
// int k = 2;

// Console.Write($@"k: ");
// int k = Convert.ToInt32(Console.ReadLine());

// OUTPUT 
// string kq = "";


// PROCESS
Dictionary<int, int> numsDict = new Dictionary<int, int>();

foreach (int num in nums)
{
    int numCount = nums.Count(n => n == num);

    if(!numsDict.ContainsKey(num))
    {
        numsDict.Add(num, numCount);
    }


}

List<KeyValuePair<int, int>> numsList = numsDict.ToList();


List<int> kqList = new List<int>();

// for(int count = 0; count < k; count++)
// {
//     kqList.Add(numsList[count][0]);
// }

Console.WriteLine($@"{string.Join(", ", numsList)}");

