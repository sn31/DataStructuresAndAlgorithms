using System;
namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public static bool ValidityCheck(string inputWord)
        {
            if (inputWord.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < inputWord.Length; i++)
            {
                if (!Char.IsLetter(inputWord[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static int Counter(string inputWord, string inputString)
        {
            int result = 0;
            string processedStr = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                processedStr += (!Char.IsPunctuation(inputString[i])) ? inputString[i].ToString() : "";
            }
            string[] inputStringArr = processedStr.Split(' ');
            for (int i = 0; i < inputStringArr.Length; i++)
            {
                if (inputWord.ToLower() == inputStringArr[i].ToLower())
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}