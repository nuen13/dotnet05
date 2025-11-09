


#region 
// Bài tập 1: Tính số ngày trong tuần và số ngày lẻ
// ------- 
// Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao 
// nhiêu ngày lẻ còn lại. Ví dụ, nếu người dùng nhập vào 10 ngày, kết 
// quả sẽ là 1 tuần và 3 ngày

// --- code --- // 
Console.WriteLine("Sô ngày: ");


//input: soNgay (int)
int soNgay = Convert.Int32(Console.ReadLine());


// process
int soTuan = soNgay / 7;
int soNgayLe = soNgay % 7;

Console.WriteLine($"Sô Tuần: {soTuan} \nSố ngày Lẻ: {soNgayLe}")

#endregion

;


//-- 2


// Console.WriteLine("gia tri don hang: ");
// string totalStr = Console.ReadLine();
// float totalInt = float.Parse(totalStr);

// Console.WriteLine("phan tram giam gia");
// string saleStr = Console.ReadLine();
// float saleInt = float.Parse(saleStr);

// double price = totalInt * (1 - (saleInt/100));

// Console.WriteLine(price);

// -- 3 

// Console.WriteLine("phut: ");
// string inputPhut = Console.ReadLine();

// int inputInt = Int32.Parse(inputPhut);

// int hour = inputInt / 60;
// int min = inputInt % 60;

// Console.WriteLine($"hour: {hour}, phut: {min}");

// -- 4

// Console.WriteLine("tien goc: ");
// string totalStr = Console.ReadLine();
// float totalInt = float.Parse(totalStr);

// Console.WriteLine("vat");
// string saleStr = Console.ReadLine();
// float saleInt = float.Parse(saleStr);

// double price = totalInt + totalInt* (saleInt/100);

// Console.WriteLine(price);

// -- 5
// Console.WriteLine("usd: ");
// string inputStr = Console.ReadLine();
// float inputInt = float.Parse(inputStr);

// float rate = 26417.43f;

// double vnd = inputInt * rate;
// Console.WriteLine(vnd);


// -- 6

// Console.WriteLine("so du: ");
// string totalStr = Console.ReadLine();
// float totalInt = float.Parse(totalStr);

// Console.WriteLine("tien rut");
// string saleStr = Console.ReadLine();
// float saleInt = float.Parse(saleStr);

// float tiencon = totalInt - saleInt;

// Console.WriteLine(tiencon);

// -- 7 
// Console.WriteLine("so du: ");
// string totalStr = Console.ReadLine();
// float totalInt = float.Parse(totalStr);

// Console.WriteLine("tien rut");
// string saleStr = Console.ReadLine();
// float saleInt = float.Parse(saleStr);

// float tiencon = totalInt / saleInt;

// Console.WriteLine(tiencon);



// -- 8
// Console.WriteLine("so du: ");
// string totalStr = Console.ReadLine();
// float totalInt = float.Parse(totalStr);

// Console.WriteLine("tien rut");
// string saleStr = Console.ReadLine();
// float saleInt = float.Parse(saleStr);

// float tiencon = totalInt / saleInt;

// Console.WriteLine(tiencon);


// -- 9 
// Console.WriteLine("km/h: ");
// string inputStr = Console.ReadLine();
// float inputInt = float.Parse(inputStr);

// float rate = 3.6f;

// double vnd = inputInt / rate;
// Console.WriteLine(vnd);


// -- 10
