
#region Cach01
// input: content (string)
Console.Write($@"Nhap content: ");
string content = Console.ReadLine();


// output: reverse of content (string)
string reverseContent = "";


// process
int lenContent = content.Length;

for (int count = 0; count <= lenContent - 1; count++)
{
    reverseContent += content[lenContent - 1 - count];

}

Console.WriteLine($@"{reverseContent}");

#endregion


#region Cach02: ReIndex 

for (int count = 1; count <= lenContent ; count++)
{
    output += input[^count];

}


#endregion