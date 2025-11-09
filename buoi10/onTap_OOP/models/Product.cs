
// private: only able to use in this file
// public: allow to use in other files

// namespace: Cấu trúc lưu trữ --> similar to folder 
// tạo ra cấu trúc folder (trên lý thuyết) --> nghĩa là tất cả các file dưới cùng 1 namespace 
// sẽ đc csharp cho là cùng 1 folder
// Csharp sẽ mặc định là các file dưới cùng 1 folder khi nó cùng 1 folder và ko có để namespace


namespace ProductManagement;


// getter và setter
// hàm để giúp cho phép / ko cho phép ng dùng gán giá trị
public partial class Product
{
    public int id { get; set; }

    public string name { get; set; }

    public decimal price { get; set; }


}

// 1 File có thể tạo đc nhiều class -> quy tắc: khi tạo đối tượng - 1 file chỉ đc class 
// Tùy nhưng mà thường là 1 file 1 class


public class Phone
{
        public int id { get; set; }

    public string name { get; set; }

    public string series { get; set; }

}