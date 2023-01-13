// See https://aka.ms/new-console-template for more information

// an array is a collection of values

// Declare Fixed sized Array the array elements are known
using System.Transactions;

int[] grades = new int[5];   // 5 spaces in memory are reserved counted from 0 to 4


// Add values to fixed size array
/*
grades[0] = 1;
grades[1] = 25;
grades[2] = 38;
grades[3] = 45;
grades[4] = 54;
*/

//one line to assign values
//grades = new int[] {1, 25, 38, 45,54};

// allow user to enter the grades
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Enter grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in fixed size array

Console.WriteLine("The grades you have entered are:");

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

// Declare variables sized array

string[] studentNames = new string[] {"Test", "Student1", "etc..." };  //{} the size is determined by elements in brackets

// Add values to variable sized array

//use same loop as above
Console.WriteLine("Enter all names:");

for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine("Enter name: ");
    studentNames[i] = Console.ReadLine();
}

// Print values in variable sized array
//see above 

Console.WriteLine("The names you have entered are:");

for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}
