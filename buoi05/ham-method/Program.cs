using System.Data;

internal class Progam
{
    private static void Main(string[] args)
    {
        Console.WriteLine($@"Hello, World!");

        int soA = 67;
        int soB = 69;

        int soC = 1;
        int soD = 2;


        int tongAB = Method.TinhTong(a: soA, b: soB);
        int tongCD = Method.TinhTong(a: soC, b: soD);



        Console.WriteLine($@"tong1 = {tongAB}");
        Console.WriteLine($@"tong2 = {tongCD}");
    


    }

    // Khai báo hàm

    // private -> only able to use in this file
    // public -> able to use in other file

    

}

