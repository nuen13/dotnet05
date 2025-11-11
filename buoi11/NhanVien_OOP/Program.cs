




DanhSachNhanVien congTy = new DanhSachNhanVien();
bool running = true;

while(running)
{

    Console.WriteLine($@"
------- Employee Management -------
1/ Add Employee
2/ Display List
3/ Change Employee Name 
4/ Remove Employee
5/ Find Employee
6/ Save File
7/ Load File
8/ Exit
-----------------------------------
");

    Console.Write($@"Pick an option: ");
    int select = Convert.ToInt32(Console.ReadLine());

    switch (select)
    {
        
        // Add 
        case 1:
            congTy.themNhanVien();
            break;

        // Display
        case 2:
            congTy.HienThiThongTinNhanVien();
            break;

        //Find
        case 3:
            congTy.DoiTenNhanVien();
            break;

        case 4:
            congTy.TieuDietNhanVien();
            break;

        case 5:
            congTy.timKiemNhanVien();
            break;
        case 6:
            congTy.saveJSON();
            break;
        case 7:
            congTy.loadJSON();
            break;
            


        default:
            break;
    }

    

    if(select == 8){

        running = false;
    }


}