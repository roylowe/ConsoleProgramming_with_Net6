// See https://aka.ms/new-console-template for more information
// conditional operators Section 3 Udemy course

Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

// if statements ( use these operators; ==, <, >, >=, <=, != )

if(numberOfApples > numberOfOranges)
{
    Console.WriteLine("you have more apples");
}
else if(numberOfApples < numberOfOranges )
{
    Console.WriteLine("you have more oranges");
}
else if(numberOfApples == numberOfOranges)
{
    Console.WriteLine("you have the same number of apples and oranges");
}
else
{
    Console.WriteLine("Invalid input!  Enter a valid whole counting number");
}

// Switch statements

Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch(grade)
{
    //if you want to do a range from like 0 to 60
    //case int n when n<=60:
    case 0:
        Console.WriteLine("You Failed!");
        break;
    case 10:
        Console.WriteLine("you got 10 marks");
        break;
    default: 
        Console.WriteLine("Invalid Grade");
        break;
}

// Ternary operators

//evaluates one condition provides two possible answerws

var message = numberOfApples > numberOfOranges ? "You have more apples" : "you have more oranges";
