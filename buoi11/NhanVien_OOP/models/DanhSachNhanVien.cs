
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json;

public class DanhSachNhanVien
{
    public List<NhanVien> danhSachNhanVien { get; set; } = new List<NhanVien>();

    public void themNhanVien()
    {

        // Bắt Nhập Nhân Viên Mới 
        Console.WriteLine($@"Type in info for employee {NhanVien.maTuTang}");
        NhanVien newNV = new NhanVien(true);

        danhSachNhanVien.Add(newNV);
    }


    public void HienThiThongTinNhanVien()
    {

        Console.WriteLine($@"Employee List");
        foreach (NhanVien nhanVien in this.danhSachNhanVien)
        {

            nhanVien.HienThiThongTin();
        }
    }

    // 3 - change name, search with MSNV
    public void DoiTenNhanVien()
    {
        Console.Write($@"Employee No: ");
        int maTimKiem = Convert.ToInt32(Console.ReadLine());
        bool found = false;


        foreach (NhanVien nvItem in this.danhSachNhanVien)
        {
            if (nvItem.maNhanVien == maTimKiem)
            {
                Console.Write($@"New name: ");
                string newName = Console.ReadLine();
                string odlName = nvItem.tenNhanVien;
                nvItem.tenNhanVien = newName;
                found = true;
                Console.WriteLine($@" Employee with {maTimKiem} is change from {odlName} to {newName} ");
            }
        }
        if (!found)
        {
            Console.WriteLine($@"Can find employee with {maTimKiem}");
        }
    }

    public void TieuDietNhanVien()
    {
        Console.Write($@"employee no: ");
        int maNVXoa = Convert.ToInt32(Console.ReadLine());

        NhanVien? nv = this.danhSachNhanVien.SingleOrDefault(nv => nv.maNhanVien == maNVXoa);

        if(nv == null)
        {
            this.danhSachNhanVien.Remove(nv);
        }
        else
        {
            Console.WriteLine($@"ko tim thay {maNVXoa}");
        }


    }


    public void timKiemNhanVien()
    {
        List<NhanVien> listNhanVienTimKiem = new List<NhanVien>();

        Console.Write($@"Name: ");
        string tuKhoa = StringHelper.ToSlug(Console.ReadLine() ?? "");

        // foreach (NhanVien nvItem in this.danhSachNhanVien)
        // {
        //     string tenSlug = StringHelper.ToSlug(nvItem.tenNhanVien ?? "");
        //     if (tenSlug.Contains(tuKhoa))
        //     {
        //         listNhanVienTimKiem.Add(nvItem);
        //     }
        // }

        listNhanVienTimKiem = this.danhSachNhanVien.Where(nv => StringHelper.ToSlug(nv.tenNhanVien ?? "").Contains(tuKhoa)).ToList();

        // display founded employee
        Console.WriteLine($@" ----- List of Employee that contains {tuKhoa} ----- ");

        if (listNhanVienTimKiem.Count > 0)
        {
            foreach (NhanVien nvItem in listNhanVienTimKiem)
            {
                nvItem.HienThiThongTin();
            }
        }
        else
        {
            Console.WriteLine($@"Nothing match with {tuKhoa}");
        }
    }
    public void saveJSON()
    {
        string jsonList = JsonSerializer.Serialize(this.danhSachNhanVien);

        File.WriteAllText("dsnv.json", jsonList);
    }

    public void loadJSON()
    {

        // load in string
        string jsonData = File.ReadAllText("dsnv.json");

        // chuyen doi ve object 
        this.danhSachNhanVien = JsonSerializer.Deserialize<List<NhanVien>>(jsonData);
    }
}


