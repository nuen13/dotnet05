
// INPUT --- lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]

using System.Globalization;

List<int> lstNumber = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };

// Cau hoi 01: Tính tổng các số lớn hơn 50 trong danh sách
// Yêu cầu: Viết chương trình tính tổng các số trong lstNumber mà lớn hơn 50

int cauhoi01_ketqua = 0;

Func<int> tinhTongTren50 = () =>

{
    foreach (int num in lstNumber)
    {
        if (num > 50)
        {
            cauhoi01_ketqua += num;
        }
    }

    return cauhoi01_ketqua;
};


// Cau hoi 02: Đếm số phần tử lớn hơn 30
// Yêu cầu: Viết chương trình đếm số phần tử trong danh sách lstNumber mà lớn hơn 30

int cauhoi02_ketqua = 0;


Func<int> tinhTongTren30 = () =>

{
    foreach (int num in lstNumber)
    {
        if (num > 30)
        {
            cauhoi02_ketqua += num;
        }
    }

    return cauhoi02_ketqua;
};



// Cau hoi 03: Tìm số lớn nhất trong danh sách
// Yêu cầu: Viết chương trình để tìm số lớn nhất trong lstNumber.

int cauhoi03_ketqua = 0;

Func<int> TimSoLonNhat = () =>
{

    foreach(int num in lstNumber)
    {
        if(num > cauhoi03_ketqua)
        {
            cauhoi03_ketqua = num;
        }
    }


    return cauhoi03_ketqua;
};


// Cai hoi 04: Tính trung bình cộng của các số lẻ
// Yêu cầu: Viết chương trình để tính trung bình cộng của các số lẻ trong danh sách lstNumber

double cauhoi04_ketqua = 0;

Func<double> TrungBinhSoLe = () =>
{

    double tong = 0;
    double soLuongSoLe = 0;
    foreach (int num in lstNumber)
    {
        if (num % 2 != 0)
        {
            tong += num;
            soLuongSoLe += 1;
        }
    }

    cauhoi04_ketqua = tong / soLuongSoLe;
    return cauhoi04_ketqua;
};


// Cau hoi 05: In ra các số chẵn trong danh sách
// Yêu cầu: Viết chương trình để in ra tất cả các số chẵn trong lstNumber.

// string cauhoi05_ketqua = "";

// Func<string> InSoChan = () =>
// {
//     foreach (int num in lstNumber)
//     {
//         if (num % 2 == 0)
//         {
//             cauhoi05_ketqua += @$"{num} ";
//         }
//     }

//     return cauhoi05_ketqua;
// };


List<int> listSoChan = lstNumber.Where(soChan => soChan % 2 == 0).ToList();

// Cau hoi 06: Tìm vị trí đầu tiên của số 20 trong danh sách
// Yêu cầu: Viết chương trình để tìm vị trí đầu tiên của số 20 trong danh sách lstNumber.


int cauhoi06_ketqua = lstNumber.FindIndex(so => so == 20);

// Cau hoi 07: Tìm số lượng phần tử bằng 15 trong danh sách
// Yêu cầu: Viết chương trình để đếm số lượng phần tử bằng 15 trong lstNumber


List<int> demSo15 = lstNumber.Where(so15 => so15 == 15).ToList();
int cauhoi07_ketqua = demSo15.Count();

// Cau hoi 08: Tính tổng các số nhỏ hơn 40
// Yêu cầu: Viết chương trình tính tổng các số trong danh sách lstNumber nhỏ hơn 40.
int cauhoi08_ketqua = 0;


Func<int> tinhTongNhoHon40 = () =>

{
    foreach (int num in lstNumber)
    {
        if (num < 30)
        {
            cauhoi08_ketqua += num;
        }
    }

    return cauhoi08_ketqua;
};

// Cau hoi 09: Đếm số lượng các số chia hết cho 5
// Yêu cầu: Viết chương trình để đếm bao nhiêu số trong danh sách chia hết cho 5


List<int> SoChiaHetCho5 = lstNumber.Where(chiaHetCho5 => chiaHetCho5 % 5 == 0).ToList();
int cauhoi09_ketqua = SoChiaHetCho5.Count();

// Cau hoi 10: Tạo danh sách mới chỉ chứa các số nhỏ hơn 50
// Yêu cầu: Viết chương trình để tạo một danh sách mới chỉ chứa các số nhỏ hơn 50 từ danh sách lstNumber

List<int> cacSoNhoHon50 = lstNumber.Where(soNhoHon50 => soNhoHon50 < 50).ToList();




// -------------------------------------------------------------------------------------- // 


// Cau hoi 01
Console.WriteLine($@"Câu hỏi 1: Tổng các số lớn hơn 50 trong list là: {tinhTongTren50()}");

// Cau hoi 02
Console.WriteLine($@"Câu hỏi 2: Tổng các số lớn hơn 30 trong list là: {tinhTongTren30()}");

// Cau hoi 03
Console.WriteLine($@"Câu hỏi 3: Số lớn nhất trong list là: {TimSoLonNhat()}");

// Cau hoi 04
Console.WriteLine($@"Câu hỏi 4: Trung bình cộng của các số lẻ trong list là: {TrungBinhSoLe()}");

// Cau hoi 05

// Console.WriteLine($@"Câu hỏi 5: Các số chẵn trong list là: {InSoChan()}");
Console.WriteLine($@"Câu hỏi 5: Các số chẵn trong list là: {string.Join(", ", listSoChan)}");


// Cau hoi 06
Console.WriteLine($@"Câu hỏi 6: Vị trí đầu tiên của số 20 trong list là: {cauhoi06_ketqua}");

// Cau hoi 07
Console.WriteLine($@"Câu hỏi 7: Số lượng phần tử bằng 15 trong list là: {cauhoi07_ketqua}");

// Cau hoi 08
Console.WriteLine($@"Câu hỏi 8: Tổng các số nhỏ hơn 40 trong list là: {tinhTongNhoHon40()}");

// Cau hoi 09
Console.WriteLine($@"Câu hỏi 9: Số lượng các số chia hết cho 5 trong list là: {cauhoi09_ketqua}");

// Cau hoi 10
Console.WriteLine($@"Câu hỏi 5: Các số nhỏ hơn 50 trong list là: {string.Join(", ", cacSoNhoHon50)}");
