// A Switch is an efficient alternative to writing many else if statements.
/*
So a switch works by creating cases and comparing them to one another,
where each case executes a specific block of code if true. 
Each case is closed break
Like in if statements where we have else to end it, in switch we use default.
The default is what we execute in case what we are working with isn't true.
*/

Console.WriteLine("What day is today? ");

String day = Console.ReadLine();

switch (day)
{
    case "Monday":
        Console.WriteLine("It's Monday");
        break;

    case "Tuesday":
        Console.WriteLine("It's Tuesday");
        break;

    case "Wednesday":
        Console.WriteLine("It's Wednesday");
        break;

    case "Thursday":
        Console.WriteLine("It's Thursday");
        break;

    case "Friday":
        Console.WriteLine("It's Friday");
        break;

    case "Saturday":
        Console.WriteLine("It's Saturday");
        break;

    case "Sunday":
        Console.WriteLine("It's Sunday");
        break;

    default:
        Console.WriteLine(day + " is not a day");
        break;
}