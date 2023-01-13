// See https://aka.ms/new-console-template for more information

//Inheritance is sharing with something else


//ABSTRACT MEANS CANNOT INSTANTIATE OBJECT


using Inheritance;

// the colon means inherit from class


//instantiate cube


// cube.Length= 1; // can now access cube properties

// var datatype is quick way to define a variable



Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height: ");
int height = Convert.ToInt32(Console.ReadLine());

// constructors are default methods created in a class that enforce that an object meets specifications before being instantiated

Cube cube = new Cube(width, height, length); //{ Width = width, Length = length, Height = height};
var triangle = new Triangle() { Length = length, Height = height};
var rectangle = new Rectangle() { Length = length, Width = width};

//below replaced by line 32
//cube.Length = length;
//cube.Width = width;
//cube.Height = height;

//triangle.Length= length;
//triangle.Height= height;

//rectangle.Length= length;
//rectangle.Width= width;

Console.WriteLine($"Cube area is: {cube.getArea}");
Console.WriteLine($"triangle area is: {triangle.getArea}");
Console.WriteLine($"rectangle area is: {rectangle.getArea}");