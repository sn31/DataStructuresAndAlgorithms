using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using Translator;
namespace Translator
{
    public class LeetspeakTranslator
    {
        public string Translate(string input)
        {
            Regex rx = new Regex(@"^[a-zA-Z]+$");
            List<char> inputList = new List<char> { };
            List<char> outputList = new List<char> { };
            Dictionary<char, char> charDictionary = new Dictionary<char, char>() { };
            charDictionary['e'] = '3';
            charDictionary['o'] = '0';
            charDictionary['t'] = '7';
            charDictionary['I'] = '1';
            charDictionary['E'] = '3';
            charDictionary['O'] = '0';
            charDictionary['T'] = '7';
            
            for (int i = 0; i < input.Length; i++)
            {
                inputList.Add(input[i]); //Adding each char to inputList
                if (i > 1 && rx.IsMatch(inputList[i - 1].ToString()) && (inputList[i] == 's' || inputList[i] == 'S'))
                {
                     outputList.Add('z');
                }
                else if (charDictionary.ContainsKey(inputList[i]))
                {   
                    outputList.Add(charDictionary[inputList[i]]);
                }
                else
                {
                    outputList.Add(inputList[i]);
                }
            }
            string translatedOutput = string.Join("", outputList.ToArray());
            return translatedOutput;
        }
    }
}

class Progam {
    public static void Main()
    {   
        LeetspeakTranslator myTranslation = new LeetspeakTranslator();
        Console.WriteLine("Enter anything to translate: ");
        string input = Console.ReadLine();
        Console.WriteLine(myTranslation.Translate(input));
    }
}