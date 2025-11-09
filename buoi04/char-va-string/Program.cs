

string content = "hom nay la mot ngay that dep, em nhi!";

Console.WriteLine($@"Do dai cua chuoi la: {content.Count()}");

Console.WriteLine($@"First Letter: {content[0]}");

bool check = content.Contains("hom");
Console.WriteLine($@"Kiem tra ket qua: {check}");

string alert = check ? "co tu hom trong hom" : "ko co tu hom trong chuoi";

int vitriO = content.IndexOf("nay");
Console.WriteLine($@"Vi tri cua nay: {vitriO}");


string newContent = content.Replace("nay", "qua");
Console.WriteLine($@"{newContent}");


string content2 = "em oi, em dep lam hihi";
string newContent2 = content2.Substring(0, 5);

Console.WriteLine($@"substring cat {newContent2}");

