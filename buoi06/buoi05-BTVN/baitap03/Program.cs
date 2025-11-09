// ------------ Bài Tập 03 ------------ // 

// lstNumber = [1, 1, 2, 2, 2, 3, 4, 4, 5]

// Remove Duplicated From Sorted Array (Easy)

// Mô tả: 
// Loại bỏ các phần tử trùng lặp trong 1 mảng đã 
// sắp xếp và trả về chiều dài của mảng mới

// Ví dụ
// Input: nums = [1, 1, 2, 2, 2, 3, 4, 4, 5]
// Output: 5 (mảng mới = [1, 2, 3, 4, 5])

// ------------ ------------ ------------ //


// INPUT
List<int> lstNumber = new List<int> { 1, 1, 2, 2, 2, 3, 4, 4, 5};


// OUTPUT

int countMoi = 0;

// PROCESS

// List<int> listMoi = new List<int> { };
// int indexSo;


// Func<int> loaiBoSo = () =>
// {
//     foreach (int num in lstNumber)
//     {
//         indexSo = listMoi.FindIndex(item => item == num);
//         if (indexSo == -1)
//         {
//             listMoi.Add(num);
//         }
//     }

//     countMoi = listMoi.Count();
//     return countMoi;
// };


// Console.WriteLine($@"Chiểu dài của mảng mới là {loaiBoSo()}");


HashSet<int> setNumber = new HashSet<int>(lstNumber);
countMoi = setNumber.Count();

Console.WriteLine($@"Chiểu dài của mảng mới là {countMoi}");











