

using System.Data;
using System.Runtime.Intrinsics.Arm;

public class MethodMan
{

    /// <summary>
    /// take row and col -> print out number
    /// </summary>
    /// <param name="row">int row</param>
    /// <param name="col">int col</param>
    public static string maTranSao(int row, int col) //input: maTranSao: int = 5
    {
        string kq = "";
        for (int count = 0; count < col; count++)
        {
            for (int count2 = 0; count2 < row; count2++)
            {
                kq += "* ";
            }
            Console.WriteLine($@"");
            kq += "\n";
        }


        return kq;
    }



    // ref: là từ khóa tham chiếu (sau khi gọi hàm thì những biến tham chiếu bên ngoài sẽ đc cập nhập giá trí) 
    // kiểu dùng method hay function để update nhiều tham số (var) -> dùng khi 
    // cái kiểu của function là void mà mình cần return cái khác
    public static void tinhDiem(ref double toan, ref double ly, ref double hoa)
    {
        Console.Write($@"toan: ");
        toan = Convert.ToDouble(Console.ReadLine());

        Console.Write($@"ly: ");
        ly = Convert.ToDouble(Console.ReadLine());

        Console.Write("$@hoa: ");
        hoa = Convert.ToDouble(Console.ReadLine());


    }

    public static void TinhDiemTBvaXepLoai(double diemToan,
        double diemLy, double diemHoa, out double dtb, out 
        string xepLoai)
    {
        //output: dtb , xepLoai

        dtb = (diemToan + diemHoa + diemLy) / 3;

        xepLoai = dtb switch
        {
            < 5 => "yeu",
            >= 5 and < 6.5 => "trung binh",
            >= 6.5 and < 8 => "kha",
            >= 8 and < 10 => "gioi",
            _ => "ko the tinh",
        };
    }
}