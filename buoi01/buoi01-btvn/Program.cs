#region Bai0
// Viết chương trình nhập vào cân nặng (kg) và chiều cao (m) của một người. 
// Tính và in ra chỉ số BMI (Body Mass Index) của người đó.

//input: canNang (double), chieuCao(double)
Console.Write($@"Nhập số cân nặng (kg): ");
double canNang = Convert.ToDouble(Console.ReadLine());

// output: BMI (double)
double BMI; 

Console.Write($@"Nhập chiều cao (m): ");
double chieuCao = Convert.ToDouble(Console.ReadLine());

BMI = canNang / (chieuCao * chieuCao);

Console.WriteLine($@"Chỉ số BMI của bạn là: {BMI}");

#endregion

#region Bai01
// Bài tập 1: Tính số ngày trong tuần và số ngày lẻ
// ------- 
// Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao 
// nhiêu ngày lẻ còn lại. Ví dụ, nếu người dùng nhập vào 10 ngày, kết 
// quả sẽ là 1 tuần và 3 ngày

// --- code --- // 
Console.Write("Sô ngày: ");


//input: soNgay (int)
int soNgay = Convert.ToInt32(Console.ReadLine());


// process
int soTuan = soNgay / 7;
int soNgayLe = soNgay % 7;

Console.WriteLine($"Sô Tuần: {soTuan} \nSố ngày Lẻ: {soNgayLe}");

#endregion

#region Bai02
// Bài tập 2 : Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// ------- 
// Yêu cầu người dùng nhập vào giá trị của một đơn hàng và phần trăm giảm giá. 
// Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng 
// giảm giá

// input: tongGiaTri (double), giamGia (double)

Console.Write($@"Nhập tổng hóa đơn: ");
double tongGiaTri = Convert.ToDouble(Console.ReadLine());

Console.Write($@"Nhập phần trăm giảm giá: ");
double giamGia = Convert.ToDouble(Console.ReadLine());

// output: giaTriSauSale (double)
double soTienGiam = 0;
double giaTriSauGiam = 0 ;

// process: 
// soTienGiam = tongGiaTri *  giamGia/100
// giaTriSauGiam = tongGiaTri - soTienGiam

soTienGiam = tongGiaTri * giamGia / 100;
giaTriSauGiam = tongGiaTri - soTienGiam;


Console.WriteLine($@"Số tiền giảm: {soTienGiam}");
Console.WriteLine($@" Số tiền sau khi giảm: {giaTriSauGiam}");

#endregion

#region Bai03
// Bài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút
// ------ 
// Yêu cầu người dùng nhập vào một số phút và chuyển đổi số phút này thành giờ 
// và phút. Ví dụ, nếu người dùng nhập vào 130 phút, kết quả sẽ là 2 giờ và 10 
// phút.

// input: int soPhut

Console.Write($@"Nhập sô Phút: ");
int soPhut = Convert.ToInt32(Console.ReadLine());

// output: int Gio, int Phut
int Gio = 0;
int Phut = 0;

// process: Gio = soPhut / 60, Phut = soPhut % 60
Gio = soPhut / 60;
Phut = soPhut % 60;

Console.WriteLine($@"{soPhut} phút --> {Gio} giờ, {Phut} phút");

#endregion

#region Bai04
// Bài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
// Yêu cầu người dùng nhập vào số tiền gốc và tỷ lệ thuế VAT (ví dụ: 10%). 
// Tính và in ra tổng số tiền sau khi đã cộng thêm thuế.

// input: double tienGoc, double VAT
Console.Write($@"Nhập tiền gốc: ");
double tienGoc = Convert.ToDouble(Console.ReadLine());


Console.Write($@"Nhập VAT: ");
double VAT = Convert.ToDouble(Console.ReadLine());

// output: double tongTien

double tienSauThue = 0;
// process: tongTien = tienGoc + tienGoc* (VAT/100)
tienSauThue = tienGoc + tienGoc * (VAT / 100);
Console.Write($@"Tiền sau Thuế: {tienSauThue}");

#endregion

#region Bai05 

// Bài tập 5: Chuyển đổi đơn vị tiền tệ
// Yêu cầu người dùng nhập vào một số tiền bằng USD và tỷ giá chuyển 
// đổi từ USD sang VND. Tính và in ra số tiền tương ứng bằng VND.



// input: double usd
Console.Write($@"USD: ");
double usd = Convert.ToDouble(Console.ReadLine());

// output: double vnd 
double vnd = 0; 


double tiSo = 26417.43;
// process: vnd = usd * tiSo
vnd = usd * tiSo;

Console.WriteLine($@"{usd}$ = {vnd} vnd");

#endregion

#region Bai06
//Bài tập 6: Tính số dư sau khi rút tiền từ tài khoản
//Yêu cầu người dùng nhập vào số dư tài khoản hiện tại và số tiền muốn rút. 
// Tính và in ra số dư còn lại sau khi rút tiền (lưu ý không kiểm tra số dư âm ở bài này).

// input: double soDuTK, double tienRut 
Console.Write($@"Sô dư tài khoản: ");
double soDuTK = Convert.ToDouble(Console.ReadLine());


Console.Write($@"Tiền rút: ");
double tienRut = Convert.ToDouble(Console.ReadLine());

// output: double soDuConLai
double soDuConLai;

// process: soDuConLai = soDuTK - tienRut
soDuConLai = soDuTK - tienRut;

Console.WriteLine($@"Tiền trong tài khoản: {soDuConLai}");

#endregion

#region Bai07
// Bài tập 7: Tính tốc độ trung bình
// Yêu cầu người dùng nhập vào quãng đường đã đi (km) và thời gian 
// đã đi (giờ). Tính và in ra tốc độ trung bình (km/h)


// input: double S, int T

Console.Write($@"Nhập quãng đường: ");
double S = Convert.ToDouble(Console.ReadLine());


Console.Write($@"Nhập thời gian: ");
int T = Convert.ToInt32(Console.ReadLine());

// output: double V
double V;

// process V = S / T 
V = S / T;

Console.WriteLine($@"Tốc độ trung bình: {V}");

#endregion

#region Bai08
//Bài tập 8: Tính tỷ lệ phần trăm
//Yêu cầu người dùng nhập vào một số và một tổng số, sau đó tính 
// và in ra tỷ lệ phần trăm của số đó trong tổng số

// input: double so, int tongSo

Console.Write($@"Nhập số: ");
double so = Convert.ToDouble(Console.ReadLine());


Console.Write($@"Nhập tổng số: ");
double tongSo = Convert.ToDouble(Console.ReadLine());


// output: int phanTram 
double phanTram = 0;

// process phanTram = so / tongSo;
phanTram =  so / tongSo * 100;


Console.WriteLine($@"{so} chiếm {phanTram}% của {tongSo}");



#endregion

#region Bai09
// Bài tập 9: Chuyển đổi từ km/h sang m/s
// Yêu cầu người dùng nhập vào vận tốc bằng km/h và chuyển đổi nó sang m/s 
// theo công thức: m/s = km/h ÷ 3.6. In ra kết quả sau khi chuyển đổi


// input: double V

Console.Write($@"Vận tốc (km / h): ");
double V = Convert.ToDouble(Console.ReadLine());

// output: double Vkhac 
double Vkhac = 0;

double tiSo = 3.6;
//process: Vkhac = V / tiSo
Vkhac = V / tiSo;

Console.WriteLine($@"{V} km/h = {Vkhac} m/s");


#endregion


#region bai10
//Bài tập 10: Tính lượng calo tiêu thụ
// Yêu cầu người dùng nhập vào số phút đã tập thể dục và loại hình 
// tập thể dục (chọn từ các giá trị đã định trước như chạy, đạp xe, 
// bơi lội). Tính và in ra lượng calo tiêu thụ dựa trên số phút và 
// loại hình tập thể dục (sử dụng hệ số calo tiêu thụ giả định cho 
// mỗi loại hình)

// intput: double soPhut, int luaChon
Console.Write($@"Nhập số Phút: ");
double soPhut = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($@"");

Console.WriteLine("Chọn loại hình tập thể dục:");
Console.WriteLine("1. Chạy");
Console.WriteLine("2. Đạp xe");
Console.WriteLine("3. Bơi lội");
Console.Write("Lựa chọn của bạn (1-3): ");
int luaChon = Convert.ToInt32(Console.ReadLine());

// output: double calo
double caloDaDot = 0; 

int calo = 0;
//process caloDaDot = calo * soPhut


calo = luaChon switch
{

    1 => 10,
    2 => 8,
    3 => 11
};


caloDaDot = calo * soPhut;

Console.WriteLine($@"Số calo đã đốt là: {calo}");




#endregion