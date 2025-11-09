
// ------------ Bài Tập 01 ------------ // 

// IstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]

// Bài tập: Tính tổng của các số trong một mảng 

// Mô tả: 
// Bạn đc cung cấp 1 mảng số nguyên lstNumber. Nhiệm vụ là tỉnh tổng 
// tất cả các số trong mảng này 

// Input:
// lstNumber: 1 danh sách (mảng) chứa các số nguyên. Đây là mảng bạn cần tính tổng

// Output:
// Trả về tổng của tất cả các số trong mảng lstNumber 



List<int> lstNumber = new List<int>() { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };


Func<int> TongCacSoTrongMang = () =>
{
    int tong = 0;

    foreach (int num in lstNumber)
    {
        tong += num;
    }

    return tong;
};

Console.WriteLine($@"Tổng của các số trong mảng là: {TongCacSoTrongMang()}");