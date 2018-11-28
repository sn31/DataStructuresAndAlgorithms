using System;
using System.Collections.Generic;
using System.Linq;
using Anagram.Models;

namespace Anagram.Models
{
    public class AnagramChecker
    {
        private string _mainWord;
        private List<string> _wordList = new List<string> { };
        
        public string GetMainWord()
        {
            return _mainWord;
        }
        public void SetMainWord(string mainWord)
        {
            _mainWord = mainWord;
        }
        public List <string> GetWordList()
        {
            return _wordList;
        }
        public void SetWordList(string wordListStringOriginal)
        {
            string[] wordListString = wordListStringOriginal.Split(',');
            List<string> wordList = new List<string> { };
            for (int i = 0; i < wordListString.Length; i++)
            {
                wordList.Add(wordListString[i].ToString());
            }
            _wordList = wordList;
        }
        public string AnagramFinder()
        {
            if (!_wordList.Any() || _mainWord == "")
            {
                return "Please provide both a word and a list of words.";
            }
            else
            {
                List<string> resultList = new List<string> { };
                int k = 0;
                while (k < _wordList.Count)
                {
                    if (_wordList[k].Length != _mainWord.Length)
                    {
                        k++;
                        continue;
                    }
                    int j = 0;
                    for (int i = 0; i < _mainWord.Length; i++)
                    {
                        if (!_mainWord.Contains(_wordList[k][i]))
                        {
                            j++;
                        }
                    }
                    if (j == 0)
                    {
                        resultList.Add(_wordList[k]);
                    }
                    k++;
                }
                string result = (resultList.Count == 0) ? "There is no anagram in the provided list!" : "Anagram found: " + string.Join(" ", resultList);
                return result;
            }
        }
    }
}

// public class Program
// {
//     public static void Main()
//     {
//         Console.Write("Please provide a word: ");
//         string mainWord = Console.ReadLine();
//         Console.Write("Please provide a list of possible anagrams, seperated by commas: ");
//         string[] wordListString = Console.ReadLine().Split(',');
//         AnagramChecker newAnagram = new AnagramChecker();
//         newAnagram.SetMainWord(mainWord);
//         newAnagram.SetWordList(wordListString);
//         Console.WriteLine(newAnagram.AnagramFinder());
//     }
// }