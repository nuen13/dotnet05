
using System.Text.Json.Nodes;

class Program
{
    static void Main()
    {
        HocVien hv = new HocVien();
        GiangVien gv = new GiangVien();
        NguoiDung nd = new NguoiDung();

        List<NguoiDung> lstNguoiDung = new List<NguoiDung>();
        
        lstNguoiDung.Add(gv);
        lstNguoiDung.Add(hv);
        lstNguoiDung.Add(nd);

        foreach(NguoiDung ndItem in lstNguoiDung)
        {
            if (ndItem is GiangVien)
            {
                GiangVien giangvien = ndItem as GiangVien; // => force type 
                giangvien.dangNhap();
            }
            else if (ndItem is HocVien)
            {
                HocVien hocvien = ndItem as HocVien;
                hocvien.dangNhap();
            }
            else if (ndItem is NguoiDung)
            {
                NguoiDung nguoiDung = ndItem as NguoiDung;
                nguoiDung.dangNhap();
            }

        }

        
        // hv.dangNhap();
        // hv.dangXuat();

        // gv.dangNhap();
        // gv.dangXuat();



    }
}

