// See https://aka.ms/new-console-template for more information

// Empty DateTime - is a data type
using System.Globalization;

DateTime date = new DateTime();  // this is a datetime object



// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1980,12,30);
Console.WriteLine($"My DOB is: {dateOfBirth} ");


// Create a DateTime from current timestamp.

DateTime now = DateTime.Now;
Console.WriteLine($"The time now is: {now}");

// Create a DateTime from a String

DateTime dateFromString = DateTime.Parse("1/31/2021",CultureInfo.InvariantCulture);
Console.WriteLine($"The date from string is: {dateFromString}");

// Add Additional Time

Console.WriteLine($"One hour from now is: {now.AddHours(1)}");

// DateTime from Ticks
Console.WriteLine("Time as a numberal: " + now.Ticks);

// Date only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine($"DateOnly date of birth: {dateOnlyOfBirth}");

// Time only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine($"TimeOnly now: {timeOnly}");