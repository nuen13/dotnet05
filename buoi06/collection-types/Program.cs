


// Collection List 


/* 

    Use to same many values of the same type 

    List<type> ten-bien = new List<type> {// Danh Sach Gia Tri}

*/


using System.Text.Json;
using System.Text.Json.Nodes;

List<string> dsHoTenasd = new List<string>(); // --> Define 

List<string> dsHoTen= new List<string>() { "buoi", "chum", "asd" };

// CRUD: Create (Insert), Read, Delete 
// -> things u can do with list in C#

/*

Read: 
    - index
    - count -> len of list / count element
    - value -> value of that elemnt 

*/


// both of these below have the same use -> get the value at that position 
string hoTen = dsHoTen[1]; // chum
string _hoTen = dsHoTen.ElementAt(1);

Console.Write($@"{_hoTen}");


// Duyệt List 
for (int index = 0; index < dsHoTen.Count; index++)
{
    string HoTenElement = dsHoTen[index];
    Console.WriteLine($@"{HoTenElement}");
}


foreach (string item in dsHoTen)
{
    Console.WriteLine($@"{item}");
}



// Converting List to String
Console.WriteLine($@"{JsonSerializer.Serialize(dsHoTen)}");
Console.WriteLine($@"{string.Join(", ", dsHoTen)}");

// Note: When call an unexist index in the list -> code will show error 

// ------------------- Create ------------------ // 

/* 
    - When adding an element in the list, list's count will INCREASE
    - depend on where value is add, index will be change
*/

dsHoTen.Add("ayo"); // add 1 to Last 

dsHoTen.AddRange("asd", "Asd", "qw"); // add muls to last 

dsHoTen.Insert(2, "Suoi"); // insert in a wanted position 

dsHoTen.InsertRange(2, "Suoi", "asd");

Console.WriteLine($@"{string.Join(", ", dsHoTen)}");
Console.WriteLine($@"{JsonSerializer.Serialize(dsHoTen)}");




// ------------------- UPDATE ------------------ // 
dsHoTen[0] = "bruh";
//Note: để udpate thì phải duyệt list và tìm kiếm (kĩ thuật đặt cờ)
// Nghiệp vụ tìm "Suoi" => đổi thành Song

// int indexUpdate = -1;

// for (int index = 0; index < dsHoTen.Count; index++)
// {
//     if (dsHoTen[index] == "Suoi")
//     {
//         indexUpdate = index;
//     }
// }
// if(indexUpdate != -1)
// {
//     dsHoTen[indexUpdate] = "Song";
// }


// Using findIndex 

int indexU = dsHoTen.FindIndex(hItem => hItem == "Suoi"); // if cant find -> -1 
if(indexU != -1)
{
    dsHoTen[indexU] = "Song";
}



Console.WriteLine($@"{string.Join(" -- ", dsHoTen)}");


// ------------------- DELETE ------------------ // 

// Delete -> Gắn liền với tìm kiếm -> tìm thấy mới xóa

List<int> listNumber = new List<int>() { 10, 20, 30, 50, 40, 50, 50, 20 };
Console.WriteLine($@"chua xoa: {string.Join(",", listNumber)}");


listNumber.Remove(50); // Remove Value
listNumber.RemoveAt(0); // Remove at Index -> change the index of all value behind 






