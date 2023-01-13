// See https://aka.ms/new-console-template for more information

// For loop (counter controlled loop)

for (int counter = 0; counter < 10; counter++)
{
    Console.WriteLine($"counter number: {counter}, I am in a loop");

}
Console.WriteLine("For loop is finished! ");


// While loop (condition controlled loop - pre check)
int n = 0;
while(n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}: ");


}

// Do...while loop (condition controlled loop - post check)

int x = 0;
do
{
    //this conditions happens at least once

    Console.WriteLine("Input a number: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {x}: ");
} while(x < 5);

// forEach loop

// used for lists or collections

int[] collection = new int[] { 1,2,3,4,5 };

foreach (var item in collection)
{ Console.WriteLine(item); }

