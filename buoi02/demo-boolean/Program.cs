// int a = 5;
// int b = 3;
// int c = 5;


// Console.WriteLine($@"a = b {a == b}"); // check if a = b --> a = b False
// Console.WriteLine($@"a = c {a == c}"); // check if a = c --> a = b True
// Console.WriteLine($@"a >= b: Greater than or equal: {a >= b}"); // check if a >= b --> a >= b True 
// Console.WriteLine($@"a >= c: Greater than or equal: {a >= c}"); // check if a >= c --> a >= b True 
// Console.WriteLine($@"a > c: a greater than c: {a > c}"); // check if a greater than c --> a > c True 
// Console.WriteLine($@"a > c: a smaller than c: {a < c}");// check if a smaller than c --> a < c False 
// Console.WriteLine($@"a != c: a NOT equal c: {a != c }");// check if a smaller than c --> a != c True 

// -------------------------------------------------------------------------------------------------------------------

// Example 1: Let user type 1 number if positive then show, if not ignore 

// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0)
// {
//     Console.WriteLine($@"OK");
// }
// Console.WriteLine($@"END");

// -------------------------------------------------------------------------------------------------------------------
// Cấu trúc nhánh: if else - số chẵn lẻ
Console.Write("Type ur number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
 Console.WriteLine($@"even");
} else {
	Console.WriteLine($@"odd");
}
