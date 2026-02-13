// Logical Operators
/*
They are used to check if more than one conditions are true.

In this case we will use AND (&&), and OR (||).
*/

Console.WriteLine("What is the temperatur outside: (c)");

Double temp = Convert.ToDouble(Console.ReadLine());

// Let's start with logical AND
/*
For this operator to work, both conditions MUST be true. 
*/

if (temp > 10 && temp <= 25)
{
    Console.WriteLine("It's warm outside");
}

// Now the OR operator
/*
For OR operator to work, one of the conditions have to be true. 
*/

else if (temp <= -50 || temp > 50)
{
    Console.WriteLine("DO NOT GO OUTSIDE!");
}