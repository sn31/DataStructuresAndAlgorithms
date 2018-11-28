using System;

class NumberGame
{
    public int initialNumber = 50;
    public int upperBound = 100;
    public int lowerBound = 0;
    public void UserNumberFinder()
    {
        Console.WriteLine("Is this your number higher or lower than " + initialNumber + "? (Higher/Lower/Correct)");
        string direction = Console.ReadLine().ToLower();

        while (direction != "correct")
        {
            int newNumber = initialNumber;
            if (direction == "lower")
            {
                upperBound = initialNumber;
                newNumber -= ((initialNumber - lowerBound) / 2);
                initialNumber = newNumber;
            }
            else
            {
                lowerBound = initialNumber;
                newNumber += ((upperBound - initialNumber) / 2);
                initialNumber = newNumber;
            }
            Console.WriteLine("Is this your number higher or lower than {0}? (Higher/Lower/Correct)", newNumber);
            direction = Console.ReadLine().ToLower();
        }
        if (direction == "correct")
        {
            Console.WriteLine("You got it right!");
        }
    }

    public void ComputerNumberFinder()
    {
        Random rnd = new Random();
        int rndNumber = rnd.Next(1, 101);
        Console.WriteLine(rndNumber); //Just for testing
        Console.WriteLine("The computer has picked a random number, please enter your guess: ");
        int guess = int.Parse(Console.ReadLine());
        while (guess != rndNumber)
        {
            if (guess < rndNumber)
            {
                Console.WriteLine("Go higher please!");
            }
            else
            {
                Console.WriteLine("Go lower please!");
            }
            guess = int.Parse(Console.ReadLine());
        }
        if (guess == rndNumber)
        {
            Console.WriteLine("You got it right!");
        }
    }
}

class Program
{
    public static void Main()
    {
        NumberGame myNumber = new NumberGame();
        Console.WriteLine("Would you like to play the higher/lower game? (Y/N)");
        if (Console.ReadLine() == "y")
        {
            Console.WriteLine("Would you like the computer to guess your number (Mode A) or would you like to guess it's number (Mode B)? (A/B)");
            if (Console.ReadLine() == "a")
            {
                myNumber.UserNumberFinder(); //Mode A - Computer predicts the user's number.
            }
            else
            {
                myNumber.ComputerNumberFinder(); //Mode B - User predict the computer's number.
            }
        }
        else
        {
            Console.WriteLine("Goodbye!");
            System.Environment.Exit(0);
        }
    }
}