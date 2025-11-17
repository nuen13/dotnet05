
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
