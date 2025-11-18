
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

NhanVienService nvService = new NhanVienService();

NhanVien nv = new NhanVien();

nvService.NhapThongTin(ref nv);
nvService.TinhLuong(nv);

Console.WriteLine($@"

Thông tin nhân viên: {JsonSerializer.Serialize(nv)}
Lương nhân viên: {nvService.TinhLuong(nv)}

");


// Activator tạo đối tượng
// Type typeNV  = typeof(NhanVien);
// NhanVien nvMoi = Activator.CreateInstance(typeNV);

// Console.WriteLine($@"
// Nhân viên đc tạo từ dynamic type: {nvMoi}
// ");


// Traditional ways
// Person ps = new Person();
// ps.HomeAddress = new Address(){City = "hcm", }


Address address = new Address("118 Balsa", "Inala");
Job job = new Job("IT", 2000);

Person ps = new Person(address, job);

Console.WriteLine($@"Person: {JsonSerializer.Serialize(ps)}");