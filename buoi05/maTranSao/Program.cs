internal class Progam
{
    private static void Main(string[] args)
    {

        #region inMaTranSao
        // Console.Write($@"row: ");
        // int row = Convert.ToInt32(Console.ReadLine());


        // Console.Write($@"col: ");
        // int col = Convert.ToInt32(Console.ReadLine());

        // string kq = "";

        // kq = Method.maTranSao(row, col);
        // Console.WriteLine($@"{kq}");

        #endregion


        #region 
        double toan = 0, ly = 0, hoa = 0;

        MethodMan.tinhDiem(ref toan, ref ly, ref hoa);

        double diemTrungBinh;
        string xepLoai;

        MethodMan.TinhDiemTBvaXepLoai(toan, ly, hoa, out diemTrungBinh,
            out xepLoai);

        Console.WriteLine($@"
            dtb: {diemTrungBinh}
            xeploai: {xepLoai}
        "); 

        


        #endregion

    }

}