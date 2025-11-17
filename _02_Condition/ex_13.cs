/*
 *  13. Read an latter and print if it`s a consonant or vowel.
 */

using System;
class If_Latter
{
    public static void Main(string[] args)
    {
        Console.Write("Letter: ");
        string word = Console.ReadLine();
        string letter = "aeiou";

        if (letter.IndexOf(word) != -1) {
            Console.WriteLine($"letter {word} is a vowel");
        } else {
            Console.WriteLine($"letter {word} is a consonant");    
        }

    }
}