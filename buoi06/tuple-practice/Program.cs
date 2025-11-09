//----------------------- Tuple -----------------------------
//Tương tự set tuy nhiên lưu các giá trị có thể khác nhau 
//Thường dùng để lưu 1 row dữ liệu : 
//Ví dụ lưu thông tin 1 sản phẩm: id, name, price
Tuple<int, string, double> tupProd = new Tuple<int, string, double>(1, "Iphone", 10000);
Console.Write($@"{tupProd.Item1}");
Console.Write($@"{tupProd.Item2}");
Console.Write($@"{tupProd.Item3}");

//tuple literal
var tupProdLiteral = (id: 1, name: "Iphone", price: 1000);
Console.WriteLine($@"{tupProdLiteral.id}");
Console.WriteLine($@"{tupProdLiteral.name}");
Console.WriteLine($@"{tupProdLiteral.price}");

