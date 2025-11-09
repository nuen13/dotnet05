using BaiTapSoNguyenTo.Method;

internal class Progam
{
    private static void Main(string[] args)
    {

        Console.Write($@"Nhập số n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool soNguyen = true;
        string nhieuSo = "";

        for (int soN = 1; soN <= n; soN++)
        {
            soNguyen = AuraMethod.kiemTraSoNguyenTo(soN);

            if (soNguyen)
            {
                nhieuSo += Convert.ToString(soN) + " ";
            }
        }

        Console.WriteLine($@"cac so {nhieuSo}");

    }

}