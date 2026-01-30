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
// Console.ReadKey();  prevents from program from ending unti we type a key in the console

// Variables
/*
Creating a variable takes two steps;
1. Declaration which is technically declaring the type of the value you will be storing and
2. Initialization which is basically giving it a value. Example below shows it better
*/
int x; // declaration
x = 123; // initialization
// You can combine the two steps in just one line of code.
int y = 321; // the part before the equal sign is declaration and the one after it is initialization
int z = x + y; // You can even do math with them
/*
So those variable behave like the values they represent. 
Think of them as the represantation of those specific values to the outside.

More meaningful examples below with different data types.
*/

int age = 26; // An int stores a whole integer
double height = 5.7; // A double stores a decimal point
bool alive = true; // A boolean is used in stances where only have two options, using either true or false values
char symbol = '$'; // This stores a single character, make sure it is within single quotes
String name = "Jared"; // This stores multiple characters and they must be in double quotes
String userName = symbol + name; // A variable again can combin two different variables

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine("Hello " + name);
Console.WriteLine("Your age is " + age);
Console.WriteLine("Your height is " + height + " feet");
Console.WriteLine("Are you alive? " + alive);
Console.WriteLine("Your symbol is: " + symbol);
Console.WriteLine("Your username is: " + userName);

// Next is Constants
/*
These are imutable values which are know at complie time and do not 
change for the lifetime of the program. This prevents people from changing it
if you don't want it to be changed.

To do that we use const before the declaration of a variable as shown below.
*/

const double pi = 3.14159;

// Next is Typecasting
/*
This is the ability to change a variable's data type.
To convert to integer for example we use a method called Convert.ToInt32().
Let's see in the examples below how we can do it for other data types.
*/

double a = 3.14;
int b = Convert.ToInt32(a);
Console.WriteLine(b);

/*
What we did above is take the value of a, make a copy of it and assign it to a new
variable b, if we print a we will still get it's original value of 3.14. What happened
with b is that it truncated all the values after the decimal point and gave us an integer.
We can also get the specific data type of a value as shown below.
*/
Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());

/*
Now let's go a head and convert an int to a double. 
Just as in integer, we will use a method Convert.ToDouble()
*/
int c = 123;
double d = Convert.ToDouble(c); // This will not put a decimal point at the end of the value but it will still be a double.
Console.WriteLine(d);
Console.WriteLine(c.GetType());
Console.WriteLine(d.GetType());

/*
Let's Convert an int to a string.
We will use a method Convert.ToString() as shown in the example below.
*/

int e = 321;
String f = Convert.ToString(e);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(e.GetType());
Console.WriteLine(f.GetType());

/*
Now we convert a string into a char.
We will use a method Convert.ToChar() as shown in the example below.
*/

String g = "$";
Char h = Convert.ToChar(g);
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(g.GetType());
Console.WriteLine(h.GetType());

/*
Let's convert a string into a boolean next.
We will use a method Convert.ToBoolean() as show in the example below.
*/

string i = "true";
bool j = Convert.ToBoolean(i);
Console.WriteLine(i);
Console.WriteLine(j);
Console.WriteLine(i.GetType());
Console.WriteLine(j.GetType());

// How to Accept User Input in C#
/*
When the user inputs a value is of the string type.
We use the method Console.ReadLine() as show below.
*/

Console.WriteLine("What is your name?");
String nme = Console.ReadLine();
Console.WriteLine("Hello " + nme);