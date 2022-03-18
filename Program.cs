using System;

namespace Hangman
{
    class Program
    {
        static string correctWord = "hangman";
        static string name;
        static int numberOfGuesses;

        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            Console.WriteLine("Starting game...");
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            Console.WriteLine("Please enter your name...");
            string input = Console.ReadLine();

            if(input.Length >= 2)
            {
                name = input;
            }
            else
            {
                AskForUsersName();
            }
        }

        private static void PlayGame()
        {
            
            DisplayMaskedWord();
            AskForLetter();
        }

        static void AskForLetter()
        {
            string input;

            do
            {
            Console.WriteLine("Enter a letter:");
            input = Console.ReadLine();

            } while (input.Length != 1);

            numberOfGuesses++;
        }

        static void DisplayMaskedWord()
        {

            foreach (char c in correctWord)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }

        private static void EndGame()
        {
            Console.WriteLine($"Thank you for playing {name}");
            Console.WriteLine($"Guesses: {numberOfGuesses}");
        }

    }
}
