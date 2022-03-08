using System;

namespace Hangman
{
    class Program
    {
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
            Console.WriteLine("Playing the game...");
            DisplayMaskedWord();
            AskForLetter();
        }

        static void AskForLetter()
        {
            Console.WriteLine("Asking for letter...");
            numberOfGuesses++;
        }

        static void DisplayMaskedWord()
        {
            
            Console.WriteLine("Displaying masked word...");
        }

        private static void EndGame()
        {
            Console.WriteLine($"Thank you for playing {name}");
            Console.WriteLine($"Guesses: {numberOfGuesses}");
        }

    }
}
