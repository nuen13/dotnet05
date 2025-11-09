// input 1 -> 4 - 1. nang, 2. mua, 3. lanh, 4. tuyet


// INPUT: 1, 2, 3, 4 (int)
// OUTPUT


// Console.Write($@"What's the weather like td (1. nang, 2 mua, 3. lanh, 4. tuyet): ");
// int weather = Convert.ToInt32(Console.ReadLine());


// string ketQua = "";

// if (weather == 1)
// {
//     ketQua = "nang cuc";
// }
// else if (weather == 2)
// {
//     ketQua = "mua";
// }
// else if (weather == 3)
// {
//     ketQua = "lanh";
// }
// else if (weather == 4)
// {
//     ketQua = "tuyet";
// }
// else
// {
//     ketQua = "input unknown";
// }
// ;

// Console.WriteLine($@"{ketQua}");

// -------------------------------------------------------------------------------------------------------------------
// Shorter ver 

Console.WriteLine($@"Chon so tu 1 -> 4");

int no = Convert.ToInt32(Console.ReadLine());
string ketQua = "";

ketQua = no switch
{

    1 => "nang",
    2 => "mua",
    3 => "lanh",
    4 => "tuyet",
    _ => "ko xac dinh"
};

Console.WriteLine($@"{ketQua}");