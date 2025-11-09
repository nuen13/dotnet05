// input: n (int)


// output: tam giac vuong can 

using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

Console.Write($@"Nhap vao  ☆: ");
int a = Convert.ToInt32(Console.ReadLine());


string star = "☆";



for (int count = 1; count <= a; count++)
{
    for (int count2 = 1; count2 <= count; count2++)
    {

        Console.Write($@"{star} ");

    }
    
    Console.WriteLine($@"");

}


