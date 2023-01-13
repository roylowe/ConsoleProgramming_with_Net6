// See https://aka.ms/new-console-template for more information

/*console is a class; List is another class
 * 
 * primitive data types (int, string, char, bool, etc), 
 * 
 * objective oriented programing has to do with creating your own data types done through a class
 * 
 * class is blue print of an object
 * 
 * property is a noun  (name, age, etc)
 * 
 * everything in a class should be in it's own file
 * 
 * Single responsibility priniciple
 * 
 * 
 */

//define class   see Person.cs

// To use class (Person.cs)
//Call data type Person give it a name assign it a new instance of the class

using ClassesAndObjects;

Person  person = new Person();

// can have multiple instance of same class

Person person2 = new Person();
string middleName = string.Empty;

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();


Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();


Console.WriteLine("Enter age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

// to set a salary for each person define a local variable

Console.WriteLine("Enter the salary: ");
int salary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Middle Name: ");
middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Full Name is: {person.getFullName()}");
}
else
{
    Console.WriteLine($"Full Name is: {person.getFullName(middleName)}");
}


// pass the salary as a variable 
person.setSalary(salary);

//Console.WriteLine($"First Name is: {person.FirstName} ");
//Console.WriteLine($"Last Name is: {person.LastName} ");
Console.WriteLine($"Your name is: {person.getFullName()} ");
Console.WriteLine($"Age is: {person.Age} ");
Console.WriteLine($"Salary is: {person.getSalary()} ");

Console.WriteLine($"Year of Birth is: {DateUtil.YearofBirth(person.Age)}");

