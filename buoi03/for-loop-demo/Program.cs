Console.Write($@"co so: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.Write($@"so mu: ");
int x = Convert.ToInt32(Console.ReadLine());


int final = 1;

for (int count = 1; count <= x; count++)
{
    final *= n ;

}
Console.WriteLine($@"{final}");