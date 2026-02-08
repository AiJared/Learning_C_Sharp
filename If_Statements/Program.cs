// If statements are the most basic form of decision making
/*
This is a condition that must be made for a specific block of code to be executed.
If not it will either be ignored or something else will be executed using an
else if block and if not we execute the else block.
*/

Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 100)
{
    Console.WriteLine("You are too old to sign up!");
}


else if (age >= 18)
{
    Console.WriteLine("You are qualified to sign up!");
}

else if (age <0 )
{
    Console.WriteLine("You haven't been boran yet!");
}

else
{
    Console.WriteLine("You must be 18+ to sign up!");
}