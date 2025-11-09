using System;
using System.Collections.Generic;
using vanPhong;

class Program
{
    static void Main()
    {
        List<NhanVien> lsNhanVien = new List<NhanVien>();

        GiamDoc giamDoc = new GiamDoc
        {
            taiKhoan = "giamdoc123",
            matKhau = "123",
            email = "giamdoc@email",
            hoTen = "Nguyen Giam Doc"
        };

        NhanVienVanPhong nv = new NhanVienVanPhong
        {
            taiKhoan = "nv123",
            matKhau = "123",
            email = "nv@email",
            hoTen = "Nguyen Van Phong"
        };

        lsNhanVien.Add(giamDoc);
        lsNhanVien.Add(nv);

        foreach (NhanVien nhanVien in lsNhanVien)
        {
            nhanVien.dangNhap();
            double luong = nhanVien.tinhLuong();
            Console.WriteLine($"Luong: {luong}\n");
        }


        GiamDocDemo gdDemo = new GiamDocDemo();
        NhanVienDemo nvDemo = new NhanVienDemo();

        List<INhanVien> lstINhanVien = new List<INhanVien>();

        lstINhanVien.Add(gdDemo);
        lstINhanVien.Add(nvDemo);

        foreach (INhanVien nvItem in lstINhanVien)
        {
            nvItem.dangNhap();
            double luong = nvItem.tinhLuong();
            Console.WriteLine($@"class - {nvItem.GetType().Name} - Luong {nvItem.tinhLuong}");

        }

        DanhMuc<Product> products = new DanhMuc<Product>();
        Product prd1 = new Product();
        prd1.Id = 1;
        prd1.Name = "Iphone";
        prd1.Price = "1000";
        products.Add(prd1);
        products.GetAll();

    }


    
}
