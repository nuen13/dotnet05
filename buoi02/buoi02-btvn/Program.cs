#region Bai01

// Bài 1:
// Tình huống: Bạn đang xây dựng một ứng dụng ghi lại nhiệt độ trong ngày để hỗ trợ cảnh báo thời tiết. Khi
// người dùng nhập vào một con số biểu thị nhiệt độ (°C), hệ thống cần phải phản hồi:

// Nếu nhiệt độ lớn hơn 0 → hiển thị “🌤 Trời ấm”
// Nếu nhiệt độ nhỏ hơn 0 → hiển thị “❄️ Trời lạnh, có thể có băng giá!”
// Nếu nhiệt độ bằng 0 → hiển thị “🌫 Trời rất lạnh, đúng 0°C!”


// input: int nhietDo 
Console.Write($@"Nhiệt độ: ");
int nhietDo = Convert.ToInt32(Console.ReadLine());

// output: string loiNhan 
string loiNhan = "";

// process 
loiNhan = nhietDo switch
{
    > 0 => "🌤 Trời ấm",
    < 0 => "❄️ Trời lạnh, có thể có băng giá!",
    0 => "🌫 Trời rất lạnh, đúng 0°C!"
};

Console.WriteLine($@"{loiNhan}");
#endregion

#region Bai02 

// Bài 2:  Tình huống thực tế – "Tính thuế thu nhập cho người đi làm":
// Bạn được giao xây dựng một phần mềm nhỏ để hỗ trợ kế toán công ty tính toán nhanh thuế thu nhập cá nhân
// cho nhân viên mỗi tháng.
// Kế toán chỉ cần nhập vào số tiền thu nhập hàng tháng, hệ thống sẽ tự động tính toán số thuế phải nộp theo
// quy định sau:

// Nếu thu nhập ≤ 5 triệu đồng → ✅ Miễn thuế
// Nếu thu nhập > 5 triệu và ≤ 10 triệu đồng → 💰 Thuế 10%
// Nếu thu nhập > 10 triệu đồng → 💸 Thuế 20%


// input: int soTien
Console.Write($@"Số tiền thu nhập (triệu đồng): ");
int soTien = Convert.ToInt32(Console.ReadLine());

// output: string loiNhan
string loiNhan = "";

// process
loiNhan = soTien switch
{
    <= 5 => "✅ Miễn thuế",
    > 5 and <= 10 => "💰 Thuế 10%", 
    > 10 => "💸 Thuế 20%"
};

Console.WriteLine($@"Thu nhập: {soTien} triệu -> {loiNhan}");
#endregion

#region Bai03 
// Bài 3: 🧭 Tình huống – “Xác định mùa trong năm từ số tháng”
// Hãy xây dựng một chức năng cho ứng dụng lịch Việt Nam. Khi người dùng nhập vào số tháng (từ 1 đến 12),
// chương trình cần xác định xem tháng đó thuộc mùa nào trong năm:
// Xuân: Tháng 1, 2, 3
// Hạ: Tháng 4, 5, 6
// Thu: Tháng 7, 8, 9
// Đông: Tháng 10, 11, 12


// input: int thang
Console.Write($@"Nhập số tháng (từ 1 đến 12): ");
int thang = Convert.ToInt32(Console.ReadLine());

// output: string mua
string mua = "";

// process: 
mua = thang switch
{
    1 or 2 or 3 => "Xuân",
    4 or 5 or 6 => "Hạ",
    7 or 8 or 9 => "Thu", 
    10 or 11 or 12 => "Đông"
};

Console.WriteLine($@"Tháng {thang} là mùa {mua}. ");
#endregion

#region Bai04
// Bài 4: 🪖 Tình huống – “Kiểm tra độ tuổi tham gia nghĩa vụ quân sự”
// Bạn được giao xây dựng một chương trình hỗ trợ cho cán bộ xã trong việc rà soát danh sách thanh niên đủ điều
// kiện tham gia nghĩa vụ quân sự.
// Cán bộ sẽ nhập tuổi của công dân, và hệ thống sẽ phân loại kết quả như sau:
// Nếu dưới 18 tuổi → ❌ Chưa đủ tuổi tham gia NVQS
// Nếu từ 18 đến 27 tuổi → ✅ Đủ tuổi tham gia NVQS
// Nếu trên 27 tuổi → ⛔ Quá tuổi tham gia NVQS


// input: int tuoi
Console.Write($@"Tuổi của công dân: ");
int tuoi = Convert.ToInt32(Console.ReadLine());


// output: string loiNhan
string loiNhan = "";

// process: 
loiNhan = tuoi switch
{
    < 18 => "❌ Chưa đủ tuổi tham gia NVQS ",
    >= 18 and <= 27 => "✅ Đủ tuổi tham gia NVQS ",
    > 27 => "⛔ Quá tuổi tham gia NVQS ",

};

Console.WriteLine($@"{tuoi} tuối -> {loiNhan}");
#endregion

#region Bai05
// Bài 5: 🔍 Tình huống – “Lọc số đặc biệt cho hệ thống bảo mật”
// Bạn đang phát triển một hệ thống tạo mật khẩu bảo mật, trong đó chỉ chấp nhận những con số “đặc biệt”
// – tức là số nguyên tố.
// Để đảm bảo tính chính xác, bạn cần viết một chương trình giúp kiểm tra xem một số nguyên người dùng nhập
// vào có phải là số nguyên tố hay không.

// input: int soDacBiet
Console.Write($@"Nhập số: ");
int soDacBiet = Convert.ToInt32(Console.ReadLine());

// output: string loiNhan
string loiNhan = "Là số đặc biệt";


// process: 
if (soDacBiet < 2)
{
    loiNhan = "Không phải số đặc biệt";
}
else
{
    for (int count = 2; count <= Math.Sqrt(soDacBiet); count++)
    {
        if (soDacBiet % count == 0)
        {
            loiNhan = "Không phải số đặc biệt";
            break;
        }
    }
}

Console.WriteLine($@"Số {soDacBiet} -> {loiNhan}");


#endregion

#region Bai06
// Bài 6:💡 Tình huống – “Tính tiền điện cho hộ gia đình”
// Bạn đang xây dựng một chương trình hỗ trợ tính tiền điện hàng tháng cho các hộ gia đình. Khi người dùng
// nhập vào số điện tiêu thụ trong tháng (tính bằng kWh), chương trình sẽ tính tiền điện phải trả theo biểu giá đơn
// giản hóa sau:


// input: int dienTieuThu
Console.Write($@"Nhập số điện tiêu thu: ");
int dienTieuThu = Convert.ToInt32(Console.ReadLine());


// output int tienDien
int tienDien = 0;

// process: 
// < 100 kwh => 1500
// >= 100 and <= 200 => 2000
// > 200 => 2500


if (dienTieuThu < 100)
{
    tienDien = dienTieuThu * 1500;
}
else if (dienTieuThu >= 100 && dienTieuThu <= 200)
{
    tienDien = 99 * 1500 + (dienTieuThu - 99) * 2000; 
}
else 
{
    tienDien = 99 * 1500 + 101 * 2000 + (dienTieuThu - 200) * 2500; 
}

Console.WriteLine($@"Tiền điện phải đóng là {tienDien:N0}");



#endregion

#region Bai07

// Bài 7: 🎬 Tình huống – “Hệ thống đặt vé rạp chiếu phim”
// Bạn đang phát triển một ứng dụng đặt vé xem phim online. Khi người dùng chọn hạng vé (Standard, Premium,
// VIP), hệ thống sẽ hiển thị thông tin về tiện ích mà họ nhận được kèm theo vé


// input: int loaiVe

Console.WriteLine($@"Loại Vé");
Console.WriteLine($@"1. Standard");
Console.WriteLine($@"2. Premium");
Console.WriteLine($@"3. VIP");
Console.Write($@"Chọn loại vé (1, 2, 3): ");
int loaiVe = Convert.ToInt32(Console.ReadLine());

//output: string tienIch 
string tienIch = "";


// process: 
// standard => "Ghế ngồi thường, không có đồ uống" 
// premium => "Ghế ngồi thoải mái, có đồ uống miễn phí" 
// VIP => "Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí" 

tienIch = loaiVe switch
{
    1 => "Ghế ngồi thường, không có đồ uống ",
    2 => "Ghế ngồi thoải mái, có đồ uống miễn phí ",
    3 => "Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí ", 
    _ => "Lựa chọn không hợp lệ"
};

Console.WriteLine($@"Bạn đã chọn {tienIch}");

#endregion

#region Bai08 
// Bạn đang viết một ứng dụng cho hãng taxi giúp tự động tính tiền cước dựa vào số km mà khách đã đi. Biểu giá
// tính như sau:
// 1km => 10000 vnd 
// >= 2km and <= 5km => 8000 km 

// input: int soKM
Console.Write($@"Nhập số km : ");
int soKM = Convert.ToInt32(Console.ReadLine());


//output: int donGia
int donGia = 0;
// process
if (soKM <= 0)
{
    Console.WriteLine($@"số km không hợp lệ");
}

if (soKM == 1)
{
    donGia = 10000;
}
else if (soKM >= 2 && soKM <= 5)
{
    donGia = 10000 + (soKM - 1) * 8000;
}
else 
{
    donGia = 10000 + 4 * 8000 + (soKM - 5) * 6000;
}

Console.WriteLine($@"Sô km: {soKM}, đơn giá {donGia}");



#endregion


#region Bai09 
// Bài 9: 🔤 Tình huống – “Phân loại chữ cái: nguyên âm hay phụ âm”
// Bạn đang phát triển một trò chơi học chữ cái tiếng Anh cho trẻ em. Khi người dùng nhập vào một ký tự, chương
// trình sẽ tự động phân loại:
// Nếu ký tự là nguyên âm (a, e, i, o, u – không phân biệt hoa/thường) → in ra “✅ Là nguyên âm”
// Ngược lại → in “🔠 Là phụ âm”


// input: char chuCai

Console.Write($@"Nhập chữ cái: ");
char chuCai = Convert.ToChar(Console.ReadLine());

// output: string ketLuan
string ketLuan = "";

// process: 
ketLuan = chuCai switch
{
    'a' or 'e' or 'i' or 'o' or 'u' => "✅ Là nguyên âm",
    _ => "🔠 Là phụ âm"
};

Console.WriteLine($@"{chuCai} {ketLuan}");

#endregion

#region Bai10
// Bài 10: ✈️ Tình huống – “Xác định tiện ích theo loại vé máy bay”
// Bạn đang xây dựng một hệ thống đặt vé máy bay online. Khi hành khách chọn loại vé (Economy, Business hoặc
// First Class), hệ thống cần hiển thị tiện ích tương ứng như sau:

// Economy => Ghế thường
// Business => Ghế rộng
// First Class => Ghế sang trọng

// input: int luaChon


Console.WriteLine($@"Loại vé máy bay");
Console.WriteLine($@"1. Economy");
Console.WriteLine($@"2. Business");
Console.WriteLine($@"First Class");
Console.Write($@"Nhập loại vé (1, 2, 3): ");
int luaChon = Convert.ToInt32(Console.ReadLine());

// output: string tienIch 
string tienIch = "";

// process: 
tienIch = luaChon switch
{
    1 => "Ghế thường",
    2 => "Ghế rộng",
    3 => "Ghế sang trọng", 
    _ => "Lựa chọn không hợp lệ"
};


Console.WriteLine($@"{tienIch}");


#endregion