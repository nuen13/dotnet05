// tính chu vi và diện tích, người dùng nhập bán kính


// input: banKinh(double)
// process: 
// output: double dienTich, double chuVi


Console.Write($@"Nhập bán kính: ");

double r = Convert.ToDouble(Console.ReadLine());
double pi = Math.PI;

double A = 0;
double P = 0;

A = pi * r * r;
P = pi * 2 * r;

Console.WriteLine($@"
    Bán kính: {r}
    Chu vi: {P}
    Diện Tích: {A}

");



