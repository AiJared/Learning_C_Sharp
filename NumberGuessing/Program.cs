// Number Guessing Game
/*
In this game we will use the Random class to set a number with a range
of minimum and maximum.
The user will have to guess a number and we will let them know if the
number is too low or too high until they get it.
*/

Random random = new Random();
int min = 1;
int max = 100;
bool playAgain = true;
int number;
int guess;
int guesses;
String response = "";

while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";

    number = random.Next(min, max + 1);

    while (guess != number)
    {
        Console.WriteLine("Guess a number between " + min + " - " + max + ": ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);

        if (guess > number)
        {
            Console.WriteLine(guess + " is too high!");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is too low!");
        }
        guesses++;
    }

    Console.WriteLine("Number: " + number);
    Console.WriteLine("YOU WIN!");
    Console.WriteLine("Guesses: " + guesses);

    Console.WriteLine("Would you like to play again (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();

}