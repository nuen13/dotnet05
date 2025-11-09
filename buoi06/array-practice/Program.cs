// ---- ARRAY LIST ---- // 


using System.Collections;
using System.Globalization;
using System.Text.Json;


// Khi Khai Bao array -> automatically lost a spot like spot depend on define
// 
int[] numbers = new int[5];
numbers[0] = 1;
numbers[2] = 2;

foreach (int num in numbers)
{
    Console.WriteLine($@"{num}");
}

ArrayList listnumber1 = new ArrayList(5);  // similar to the one above 
Console.WriteLine($@"{JsonSerializer.Serialize(listnumber1)}");