using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing{
    class Program {
        static bool won = false;

        static int randomNumber = new Random().Next(1, 3);

        static int guess;
        static int numberOfGuesses = 1;

        static void Main(string[] args) {

            for (int i = 0; i < 30; i++) {
                Console.Write("*");
            };

            Console.WriteLine("\nWelcome to the number guessing game!");
            Console.WriteLine("You have 7 tries to guess the correct number between 1 and 100.");

            for (int i = 0; i < 30; i++) {
                Console.Write("*");
            };


            Console.WriteLine(randomNumber);

            while (numberOfGuesses != 7 && won != true) {
                Console.WriteLine($"Guess #{numberOfGuesses} Enter a number");
                numberOfGuesses++;

                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out guess))
                {
                    Console.WriteLine(EvalAnswer());
                }
                else
                {

                    Console.WriteLine($"Invalid Number, Attempts = {numberOfGuesses}");

                }

                restart();
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        static String EvalAnswer() {

            if (guess == randomNumber){
                won = true;
                return $"YOU WIN. The number is {randomNumber} and your inputGuess is {guess} :) \n";
           
            }
            else if (numberOfGuesses == 7){
                return $"\nYou Lost! You have tried {numberOfGuesses} times with no luck :( Random Number is {randomNumber} \n";
            }
            else{
                if (guess < randomNumber){
                    return $"Guess is too low! You have attempted {numberOfGuesses} times. \n";
                }
                else{
                    return $"Guess is too high! You have attempted {numberOfGuesses} times. \n";
                }
            }
        } 

        static Boolean restart()
        {
            Console.WriteLine("Do you want to play again (Y, N)");
            won = false;
            numberOfGuesses = 0;


            var answeredInput = Console.ReadKey().Key;
            if (answeredInput == ConsoleKey.Y){
                return true;
            } else{
                Environment.Exit(0);
                return false;
            }

        }

    }
}
