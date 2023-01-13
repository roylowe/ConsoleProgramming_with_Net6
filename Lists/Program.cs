// See https://aka.ms/new-console-template for more information

//Lists of elements that is not fixed to a size
//Declare list
List<string> names = new List<string>();  //data type goes in <>
string name = string.Empty;


//Add values to list
names[0] = "TestName";  //can use array indexes  lists are an extension of arrays
names.Add("Roy");  // use the add method

Console.WriteLine("Enter names: ");

//while (name != "-1)
//while (name.Equals("-1) == false)
while (!name.Equals("-1"))

{
    Console.WriteLine("Enter Name: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
        { 
            names.Add(name);
        }
}

// Print values in list
Console.WriteLine("Printing names via for loop");
for (int i = 0; i< names.Count; i++)
{
    Console.WriteLine(names[i]);
}

//for each loop goes through each element in a collection
Console.WriteLine("Printing names via forEach loop");

foreach (string item in names)
{
    Console.WriteLine(item);
}