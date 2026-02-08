// In this small program we will find the hypotenuse of a right triangle.
Console.WriteLine("Enter side A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(a * a + b * b);

Console.WriteLine(c);