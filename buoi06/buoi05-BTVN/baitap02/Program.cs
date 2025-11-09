// ------------ Bài Tập 02 ------------ // 

// lst_number = [2, 7, 11, 15]

// Mô tả: Tìm 2 số trong 1 danh sách số nguyên sao cho tổng của chúng bằng 1 giá trị target cho trước

// Ví dụ:
// Input: nums = [2, 7, 11, 15], target 9 
// Output: [0, 1] (vì nums[0] + nums[1] = 2 + 7 = 9) ngược lại nếu ko có


// input
List<int> lst_number = new List<int> { 2, 7, 11, 15 };


Console.Write($@"Nhập Target: ");
int target = Convert.ToInt32(Console.ReadLine());

// int target = 9;



//output 
List<int> viTri = new List<int> { };
string kq = " ";


Func<int, string> TimViTri = (target) =>
{

    int soDau;
    int indexSo;
    foreach (int num in lst_number)
    {
        soDau = target - num;
        indexSo = lst_number.FindIndex(item => item == soDau);
        if (indexSo != -1)
        {
            int index1 = lst_number.IndexOf(num);
            int index2 = lst_number.IndexOf(soDau);

            viTri.AddRange(index1, index2);

            kq = $@"Vị trí của 2 số có tổng bằng {target} trong lst_numbers là [{string.Join(", ", viTri)}]";
            return kq;
        }
    }
    kq = $@"Không có số nào trong lst_number có tổng bằng {target}";
    return kq;
};

Console.WriteLine($@"{TimViTri(target)}");












