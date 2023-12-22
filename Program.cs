using System;

class Program
{

    static void Main(string[] args)
    {
    
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);

            Console.WriteLine("Guess the random number 1 - 10");
            int userGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("The random number was {0}", randomNumber);

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Your guess was too low");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Your guess was too high");
            }
            else
            {
                Console.WriteLine("You are correct");
            }
        }
    }