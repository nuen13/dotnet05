namespace ThuVienHam;

public class Method
{
    // n = 5 => tong = 1 + 2 + 3 + 4 + 5 

    public static int TinhTong(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n + TinhTong(n - 1);

    }

    public static string InDaySo(int n)
    {
        if (n == 1)
        {
            return "1";
        }


        return $@"{InDaySo(n - 1)} {n}";
    }



    public static void ThucHanhNhiemVu(Func<int, int, int> callbackFunction) 
    {
        Console.Write($@"
            {callbackFunction(1, 2)}
        ");
    }

}