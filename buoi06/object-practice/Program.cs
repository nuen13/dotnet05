

List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string strResult = "1, 2, 3, 4";

object kq = nums;

List<int> results = (List<int>)kq;

foreach(int value in results)
{
    Console.WriteLine($@"{value}");
}