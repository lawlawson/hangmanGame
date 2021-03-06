using System;
using System.Collections.Generic;
using System.IO;

namespace Hangman
{
    class Program
    {
        static string correctWord;
        static char[] letters;
        static Player player;
        

        static void Main(string[] args)
        {
            try
            {
                StartGame();
                PlayGame();
                EndGame();
            }
            catch
            {
                Console.WriteLine("Oops, something went wrong!");
            }

        }

        private static void StartGame()
        {
            string[] words;
            try
            {
                words = File.ReadAllLines(@"/Users/lawrencenarh-lawson/Documents/Words.rtf");
            }
            catch
            {
               words = new string[] { "tree", "dog", "cat"};
            }
            

            Random random = new Random();
            correctWord = words[random.Next(0, words.Length)];
            
            letters = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
            
                letters[i] = '_';
            
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            Console.WriteLine("Please enter your name...");
            string input = Console.ReadLine();

            if(input.Length >= 2)
            {
                player = new Player(input);     
            }
            else
            {
                AskForUsersName();
            }
        }

        private static void PlayGame()
        {

            do
            {
                Console.Clear();
                DisplayMaskedWord();
                char guessedLetter = AskForLetter();
                CheckLetter(AskForLetter());
            }
            while (correctWord != new string(letters));

            Console.Clear();
        }

        private static void CheckLetter(char guessedLetter)
        {   
            for (int i = 0; i < correctWord.Length; i++)
            {
                if (guessedLetter == correctWord[i])
                {
                    letters[i] = guessedLetter;
                    player.Score++;
                }
                    
            }
        }

        static char AskForLetter()
        {
            string input;

            do
            {
                Console.WriteLine("Enter a letter:");
                input = Console.ReadLine();

            } while (input.Length != 1);

            var letter = input[0];

            if (!player.GuessedLetters.Contains(letter))
                player.GuessedLetters.Add(letter);

            return letter;
        }

        static void DisplayMaskedWord()
        {

            foreach (char c in letters)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        private static void EndGame()
        {
            Console.WriteLine($"Congrats!");
            Console.WriteLine($"Thank you for playing {player.Name}!");
            Console.WriteLine($"Guesses: {player.GuessedLetters.Count} Score: {player.Score}");
        }   

    }
}
