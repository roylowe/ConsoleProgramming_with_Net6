// See https://aka.ms/new-console-template for more information

// There are 2 types of functions: Void and value retruning

/* void Functions - completes a task than exists
    3 parts of functions:  Prototype - defines the function(type, namd, and parameters)
    definition - has teh code.It contains the code block

 Function call - makes the function
 Dry priniciple - don't repeat yourself
 YAGNI - You aren't going to neet it

Console.Writeline(); this is a void function

*/

void PrintName()
{
    Console.WriteLine("This is a void function: ");
    Console.WriteLine("Roy Lowe");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}

// Call the void function anywhere in the code



/* Value REturning Functions - completes a task and returns a result

    console.Readline(); this is  a value function
    value retunring starts with data type

*/

int LargestNumber(int num1, int num2, int num3)
{
    Console.WriteLine("This is a value returning function");
        int largest = num1;
    if(largest < num2)
    {
        largest = num2;
    }
    if(largest < num3)
    {
        largest = num3;
    }

    return largest;
}

PrintName();

Console.WriteLine("Eenter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Eenter number 2: ");

int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);
Console.WriteLine("End of Void Function");


Console.WriteLine("Eenter number 3: ");

int number3 = Convert.ToInt32(Console.ReadLine());

//with value returning functions put the return in a variable to be used
int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is: {result}");