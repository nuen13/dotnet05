namespace BaiTapSoNguyenTo.Method;

public class AuraMethod
{
    public static Boolean kiemTraSoNguyenTo(int soN)
    {
        bool nguyenTo = true;

        if (soN < 2)
        {
            nguyenTo = false;
        }
        else
        {
            for (int count = 2; count <= Math.Sqrt(soN); count++)
            {
                if (soN % count == 0)
                {
                    nguyenTo = false;
                    break;
                }
            }
        }

        return nguyenTo;

    }

}