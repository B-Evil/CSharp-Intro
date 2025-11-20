/*
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
 */
 using System;
class ForIteration
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 8; i++) {
            Console.Write($"{i}, ");
        }

    }
}