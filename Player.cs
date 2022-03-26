using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class Player
    {
        public string name;
        public int score;
        public List<char> guessedLetters = new List<char>();    
        public Player(string name)
        {
            this.name = name;
        }
    }
}