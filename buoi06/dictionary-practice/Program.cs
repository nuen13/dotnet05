



// --------------- DICTIONARY --------------- // 


// Define Dictionary
Dictionary<string, string> dictStudent = new Dictionary<string, string>();




// -- -- -- --  CRUD -- -- -- --  // 

// -- --  C -> CREATE -- -- // 
// // Add
dictStudent.Add("id", "121212");
dictStudent.Add("name", "MAO");
dictStudent.Add("dob", "12/12/2323");


// -- -- R -> READ -- -- //
// Note: in dict, key has to be unique
Console.WriteLine($@"student id: {dictStudent["id"]}");
Console.WriteLine($@"name: {dictStudent["name"]}");
Console.WriteLine($@"dob: {dictStudent["dob"]}");

Console.WriteLine($@"================ ");


// print key and value
foreach (string key in dictStudent.Keys)
{
    Console.WriteLine($@"{key} : {dictStudent[key]}");
}

Console.WriteLine($@"================ ");

// Print value only 
foreach (string value in dictStudent.Values)
{
    Console.WriteLine($@"{value}");
}

Console.WriteLine($@"================ ");

// Access the big dictionary 
foreach (var key_value in dictStudent)
{
    Console.WriteLine($@"{key_value.Key} - {key_value.Value}");
}

// -- -- U -> UPDATE -- -- //


// Vừa thêm vừa update -> key chưa có thì add -> key chưa có thì update
dictStudent["id"] = "2323"; // update
dictStudent["job"] = "blow"; // add

Console.WriteLine($@"================ ");

foreach (string key in dictStudent.Keys)
{
    Console.WriteLine($@"{key} : {dictStudent[key]}");
}

// -- -- D -> DELETE -- -- //
dictStudent.Remove("id");
Console.WriteLine($@"================ ");
foreach (var key_value in dictStudent)
{
    Console.WriteLine($@"{key_value.Key} - {key_value.Value}");
}


// ----- //
// Diff way of adding 

// ppl dont normally use this way 
Dictionary<int, string> dictPhone = new Dictionary<int, string>()
{
    {0, "1212"},
    {1, "1212"},
    {2, "1212"},
};

for (int i = 0; i < dictPhone.Count(); i++)
{
    Console.WriteLine($@"{i} - {dictPhone[i]}");
}

if (!dictStudent.ContainsKey("id"))
{
    Console.WriteLine($@"ko tim thay id trong dicit");
}


