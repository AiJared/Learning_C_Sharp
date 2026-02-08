// If statements are the most basic form of decision making
/*
This is a condition that must be made for a specific block of code to be executed.
If not it will either be ignored or something else will be executed.
*/

Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are qualified to sign up!");
}
else
{
    Console.WriteLine("You must be 18+ years old to sign up!");
}