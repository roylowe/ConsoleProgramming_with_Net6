// See https://aka.ms/new-console-template for more information
string firstName = "Roy";
string lastName = "Lowe";

// Print to screen
Console.WriteLine(firstName);
Console.WriteLine(lastName);

// Concatenation

Console.WriteLine(firstName+ " " + lastName);
Console.WriteLine($"My full name is {firstName} {lastName}");  //concat using interpolation  

// String length
int length = firstName.Length;
Console.WriteLine(length);


// Replace string parts
string newName = firstName.Replace('R', 'T');
Console.WriteLine($"Your new name is {newName}");


// Append to other string variable

string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

// Split string

string[] splitName = fullName.Split('l');
for (int i=0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// Compare Strings
string testVariable = string.Empty;

if (string.IsNullOrEmpty(testVariable));
{
    Console.WriteLine($"The testVariable value is null");
}

// Convert to string

string convertedString = string.Empty;
int number = 12345;

convertedString = number.ToString();