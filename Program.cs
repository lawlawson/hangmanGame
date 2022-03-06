using System;

namespace Hangman
{
    class Program
    {
        static string name;

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
            name = Console.ReadLine();
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
        }

        static void DisplayMaskedWord()
        {
            
            Console.WriteLine("Displaying masked word...");
        }

        private static void EndGame()
        {
            Console.WriteLine($"Thank you for playing {name}");
        }

    }
}
