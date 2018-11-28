using System;
using System.Collections.Generic;
namespace Hangman.Models
{
    public class Game
    {
        private static string _keyWord = "animals";
        public static bool gameStatus = true;
        public static string[] answer = new string[7] { "-", "-", "-", "-", "-", "-", "-" };
        private static List<string> _guesses = new List<String> { };
        public static Dictionary<int, string> pictureLibrary = new Dictionary<int, string>()
        { { 0, "Noose.png" }, { 1, "Hangman-1.png" }, { 2, "Hangman-2.png" }, { 3, "Hangman-3.png" }, { 4, "Hangman-4.png" }, { 5, "Hangman-5.png" }, { 6, "Hangman-6.png" }
        };
        public int guessCount = _guesses.Count;
        public string FindChar(string newGuess)
        {
            if (_guesses.Contains(newGuess))
            {
                return "I have made this guess before, please guess again!";
            }
            if (!_keyWord.Contains(newGuess))
            {
                _guesses.Add(newGuess);
            }
            else
            {
                for (int i = 0; i < _keyWord.Length; i++)
                {

                    if (_keyWord[i].ToString() == newGuess)
                    {
                        answer[i] = newGuess;
                        guessCount = _guesses.Count;
                    }
                }
            }
            if (guessCount > 5)
            {
                gameStatus = false;
                _guesses.Clear();
                return "Game Over!";
            }
            return String.Join(" ", answer);
        }
        public static void ClearAll()
        {
            _guesses.Clear();
        }
        public List<string> GetGuesses()
        {
            return _guesses;
        }
        public string GetPicture(int guessCount)
        {
            return pictureLibrary[guessCount];
        }
    }
}