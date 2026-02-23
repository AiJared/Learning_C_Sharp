// While Loop
/*
While loop repeats a specific code if some condition remains to be true.
In the example below we will ask a user to enter their name.
While loop will help us check whether or not they've entered a name.
If they don't enter anything, it will prompt them to enter it again.
*/
Console.WriteLine("Please enter your name: ");
String name = Console.ReadLine();

while (name == "")
{
    Console.WriteLine("Please enter your name: ");
    name = Console.ReadLine();
}

Console.WriteLine("Hello " + name);