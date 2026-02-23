// Nested Loop
/*
This is a loop that is inside another loop.
There uses vary - Used in sorting algorithms.
In this example we use a nested loop to create a rectangle.
The outer loop will be incharge of counting the rows and
the inner loop incharge of counting the columns.
The user will choose a symbol that they would to create a rectangle of.
What happens is that, in order to complete one iteration of the outer for loop,
we must complete all iterations of inner for loop. For next iteration,
we will have to do it all over again.
If we leave it there it will just write them all in a straight line.
To have then create a rectangle we will close the outer loop with an empty WriteLine.
*/

Console.Write("How many rows? ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("How many columns? ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("What Symbol? ");
String symbol = Console.ReadLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}