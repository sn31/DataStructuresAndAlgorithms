using System;

public class Palindrome {
    public string input;
    public bool PalindromeChecker (string input) {
        char [] inputBackward = input.ToCharArray ();
        Array.Reverse (inputBackward);
        int i = 0; 
        while (i < input.Length) {
            if (input[i] != inputBackward[i])
            {
                return false;
            }
            i++;
        }
        return true;
    }
}

class Program {
    public static void Main () {
        Console.WriteLine ("Please enter a word to see if it is a palindrome: ");
        string input = Console.ReadLine ().ToLower();
        Palindrome myString = new Palindrome ();
        Console.WriteLine (myString.PalindromeChecker (input));
    }
}