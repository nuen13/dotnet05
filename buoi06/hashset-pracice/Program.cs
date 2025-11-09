// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// --------------- HASH SET --------------- // 


// DEFINE 
HashSet<int> setSo = new HashSet<int> { 3, 1, 2, 1, 1, 1, 1, 1, 1 };

foreach (int value in setSo)
{
    Console.WriteLine($@"{value}");
}

setSo.Add(12);
setSo.Add(12);
setSo.Add(12);
setSo.Add(12);
setSo.Add(12);

foreach (int value in setSo)
{
    Console.WriteLine($@"{value}");
}

if (setSo.Contains(12))
{
    Console.WriteLine($@"12 o day");
} // set tim kiem le -> O(1)


setSo.Remove(12);

if (!setSo.Contains(12))
{
    Console.WriteLine($@"12 ko day");
} // set tim kiem le -> O(1)


int[,] matrix =
{
    {1, 2, 3 },
    {4, 5, 6},
    {7, 8, 9}
};


List<List<int>> matrix1 = new List<List<int>>()
{
    new List<int> {1, 2, 3},
    new List<int> {4, 5, 6},
    new List<int> {7, 8, 9},
};
Console.WriteLine(string.Join(", ", matrix1[0])); // -> {1, 2, 3}
Console.WriteLine($@"{matrix1[0][2]}"); // -> 3
Console.WriteLine($@"{matrix1[1][2]}"); // -> 6

