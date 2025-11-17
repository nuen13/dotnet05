
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;   // vì bạn dùng ToList(), FirstOrDefault(), v.v.

class Program
{
    static void Main()
    {
        // DanhMuc<int> lstSo = new DanhMuc<int>();

        // lstSo.danhSach.Add(1);
        // lstSo.danhSach.Add(2);
        // lstSo.danhSach.Add(3);

        // DanhMuc<string> lstString = new DanhMuc<string>();
        // lstString.danhSach.Add("A");
        // lstString.danhSach.Add("B");
        // lstString.danhSach.Add("C");

        DanhMuc<Product> products = new DanhMuc<Product>();

        Product prd1 = new Product();
        prd1.ID = 1;
        prd1.Name = "Dildo";
        prd1.Price = "122";

        products.Add(prd1);




        Console.WriteLine($@"List San Pham: {JsonSerializer.Serialize(products.GetAll())}");


        DanhMuc<User> users = new DanhMuc<User>();

        User us = new User();

        us.ID = 1;
        us.UserName = "kienkien";
        us.fullName = "Kien";
        us.email = "kien@gmail.com";
        us.password = "123";

        users.Add(us);

        Console.WriteLine($@"List User: {JsonSerializer.Serialize(users.GetAll())}");
    }
}