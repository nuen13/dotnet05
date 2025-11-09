// Write an algo -> take user input degree in celcius and convert it into fahrenheit 


// Console.Write($@"Nhap Nhiet Do Vo: ");
// string nhietdoString = Console.ReadLine();

// int nhietdo = Convert.ToInt32(nhietdoString);


// double nhietdomoi = nhietdo * 9/5 + 32;

// Console.Write($@"
//     celcius: {nhietdo},
//     fahrenheit: {nhietdomoi}
// ");



//input: doC (double)

Console.Write($@"Nhập nhiệt độ C zô: ");
double doC = Convert.ToDouble(Console.ReadLine());

//output: doF (double)
double doF = default(double); //double doF = 0l;

doF = doC * 9 / 5 + 32;

//process
Console.WriteLine($@"Nhiệt độ F: {doF}");
