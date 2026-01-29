// Why Learn C#?
/* 
1. It is flexible for building different kinds of applications from console
apps, web services, desktop apps and games.
2. It is the best in the gaming industry, if you want to be a game developer,
"which in my case I do" then C# and C++ are the right languages for it.
 */

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("This is amazing!");
Console.Beep(); //Making your console Beep after executing code.

// A couple of things you need to know regarding C# code
/*
- A C# program has several layers to it and unlike Python, here it entails a lot
of typing just like C and Java.
- Variable names are defined explicitly.
- All program lines MUST end with a semicolon.
- There is this Main method that is the entry point of a C# program and immediately
after defining it, there are curly braces that contain the body of the main method.
- Everything that is created ontop of the Main methon will be executed when you run
the code and work down executing any code that follows.
- In order for any program to run, the Main method MUST be called.
- There is a Console.WriteLine method that displays whatever text you put into it
on a console display. As seen from the two examples above, when we run the program,
it will display Hello, World! and This is amazing! respectfully on the console. 
- The text being displayed on the console MUST be written in double quotes.
And we call it a string literal because we are literally calling a string.
*/

// Now let's look at Output Formatting
/*
- As we saw up there, Console.WriteLine displays a string literal on console.
However, we can also use Console.Write and there is a difference on how the two work.
*/
Console.Write("Hey!");
Console.WriteLine("I am just testing this out.");
/*
- As you have seen in the console display, Write doesn't create a new line for the
next output while WriteLine does.
- The difference between the two is that when you use Write it displays everything 
in one line while WriteLine creates a new line for the next output.
- There is a shotcut to writing a WriteLine though, you just c, hit tab twice and it
will autogenerate WriteLine for you.
- Another formating method is a comment and as you can see this is already a comment,
but more like a multi line comment. To write a single line comment just start with
two foward slashes.
- Finally it's the escape sequences, an escape sequence can format an output in many
ways from adding tab to new line to form feed you name it. Take a look at the example
in the code below.
*/
Console.WriteLine("\tAiJared"); // Adds tab before AiJared
Console.WriteLine("Jared\nMaina"); // Displays Maina on a new line
// There is a long list of escape sequences for a lot of actions.
// There is also a way to prevent a program from ending until we type a key.
Console.ReadKey(); // prevents from program from ending unti we type a key in the console
