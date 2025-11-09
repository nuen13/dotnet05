

// INPUT -- lstStrings = ["apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon"]
using System.Globalization;

List<string> lstStrings = new List<string> { "apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon" };


// ----- ----- ----- ----- ---- // 
// Cau hoi 01: Tính độ dài của mảng
// Yêu cầu: Viết chương trình để đếm số phần tử trong mảng lstStrings.
int cauhoi01_ketqua = lstStrings.Count();


// Cau hoi 02: In ra các chuỗi dài hơn 5 ký tự
// Yêu cầu: Viết chương trình để in ra các chuỗi trong lstStrings có độ dài lớn hơn 5 ký tự.

List<string> cauhoi02_ketqua = lstStrings.Where(chuHon5KyTu => chuHon5KyTu.Count() > 5).ToList();


// Cau hoi 03: Tìm chuỗi dài nhất trong mảng
// Yêu cầu: Viết chương trình để tìm chuỗi có độ dài lớn nhất trong mảng lstStrings.

string cauhoi03_ketqua = "";
int doDaiCuaChuoi = 0; //AYO ???

Func<string> TimChuoiDaiNhat = () =>
{

    foreach (string chuoi in lstStrings)
    {
        if (chuoi.Count() > doDaiCuaChuoi)
        {
            doDaiCuaChuoi = chuoi.Count();
            cauhoi03_ketqua = chuoi;
        }

    }
    
    return cauhoi03_ketqua;
};



// Cai hoi 04: In ra các chuỗi có chứa chữ 'a'
// Yêu cầu: Viết chương trình để in ra tất cả các chuỗi trong lstStrings có chứa chữ cái 'a'.
List<string> cauhoi04_ketqua = lstStrings.Where(chuoiCoChuA => chuoiCoChuA.Contains("a")).ToList();


// Cau hoi 05: Tìm chuỗi bắt đầu bằng chữ 'm'
// Yêu cầu: Viết chương trình để tìm tất cả các chuỗi trong lstStrings bắt đầu bằng chữ 'm'.
List<string> cauhoi05_ketqua = new List<string>();

Action TimChuoiBatDauBangChuM = () =>
{
    foreach(string chuoi in lstStrings)
    {
        if(chuoi[0] == 'm')
        {
            cauhoi05_ketqua.Add(chuoi);
        }

    };
};


// Cau hoi 06: Đếm số chuỗi có độ dài nhỏ hơn 6 ký tự
// Yêu cầu: Viết chương trình để đếm số chuỗi có độ dài nhỏ hơn 6 ký tự trong lstStrings.
int cauhoi06_ketqua = 0;

List<string> ChuoiDaiHon6 = lstStrings.Where(chuoi => chuoi.Count() < 6).ToList();

cauhoi06_ketqua = ChuoiDaiHon6.Count();


// Cau hoi 07: In ra chuỗi dài thứ hai trong mảng
// Yêu cầu: Viết chương trình để tìm và in ra chuỗi dài thứ hai trong mảng lstStrings.

string cauhoi07_ketqua = "";


List<string> lstStringsTamThoi = new List<string>(lstStrings);

Func<string> TimChuoiDaiNhatTrongArray = () =>
{

    string chuoiDaiNhat = "";
    int chieuDaiChuoi = 0;

    foreach (string chuoi in lstStringsTamThoi)
    {

        if (chuoi.Count() > chieuDaiChuoi)
        {
            chieuDaiChuoi = chuoi.Count();
            chuoiDaiNhat = chuoi;
        }

    }
    return chuoiDaiNhat;
};

string chuoiDaiNhat = TimChuoiDaiNhatTrongArray();


lstStringsTamThoi.Remove(chuoiDaiNhat);
cauhoi07_ketqua = TimChuoiDaiNhatTrongArray();



// Cau hoi 08: Sắp xếp mảng theo thứ tự bảng chữ cái
// Yêu cầu: Viết chương trình để sắp xếp mảng lstStrings theo thứ tự bảng chữ cái (A-Z).

List<string> listChuoiSapXep = new List<string>(lstStrings);
// Dùng sort --------
listChuoiSapXep.Sort();


// Cau hoi 09: Chuyển tất cả các chuỗi thành chữ hoa
// Yêu cầu: Viết chương trình để chuyển tất cả các chuỗi trong lstStrings thành chữ in hoa.
List<string> ListVoiStringGhiHoa = new List<string>();

foreach(string string1 in lstStrings)
{
    ListVoiStringGhiHoa.Add(string1.ToUpper());
}


// Cau hoi 10: Thay thế chuỗi "banana" bằng "pear"
// Yêu cầu: Viết chương trình để thay thế chuỗi "banana" bằng "pear" trong lstStrings.

List<string> ListVoiPear = new List<string>(lstStrings);


for(int count = 0; count <= ListVoiPear.Count() - 1; count ++)
{
    if(ListVoiPear[count] == "banana")
    {
        ListVoiPear[count] = "pear";
    }

}

// ----- ----- ----- ----- ---- // 

// Cau hoi 1
Console.WriteLine($@"Câu hỏi 1: Độ dài của list là: {cauhoi01_ketqua}");

// Cau hoi 2
Console.WriteLine($@"Câu hỏi 2: Các chuỗi trong list dài hơn 5 ký tự là: {string.Join(", ", cauhoi02_ketqua)}");

// Cau hoi 3
Console.WriteLine($@"Câu hỏi 3: Chuỗi dài nhất trong list là: {TimChuoiDaiNhat()}");

// Cau hoi 4
Console.WriteLine($@"Câu hỏi 4: Các chuỗi trong list có chứa chữ 'a': {string.Join(", ", cauhoi04_ketqua)}");

// Cau hoi 5
TimChuoiBatDauBangChuM();
Console.WriteLine($@"Câu hỏi 5: Các chuỗi trong list bắt đầu bằng chữ'm': {string.Join(", ", cauhoi05_ketqua)}");

// Cau hoi 6
Console.WriteLine($@"Câu hỏi 6: Số lượng chuỗi trong list có ít hơn 6 chữ cái là: {cauhoi06_ketqua}");

// Cau hoi 7
Console.WriteLine($@"Câu hỏi 7: Chuỗi dài thứ 2 ở trong list là: {cauhoi07_ketqua}");

// Cau hoi 8
Console.WriteLine($@"Câu hỏi 8: List sau khi được sắp xếp theo thứ tự từ A - Z: {string.Join(", ", listChuoiSapXep)}");

// Cau hoi 9
Console.WriteLine($@"Câu hỏi 9: List với chữ ghi hoa: {string.Join(", ", ListVoiStringGhiHoa)}");


// Cau hoi 10
Console.WriteLine($@"Câu hỏi 10: List với 'pear' thay cho 'banana': {string.Join(", ", ListVoiPear)}");



