


Console.Write($@"co so: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($@"luy thua: ");
int x = Convert.ToInt32(Console.ReadLine());

int b = 1;

while (x > 0)
{
    b *= n;
    x--;

}

Console.WriteLine($@"{b}");