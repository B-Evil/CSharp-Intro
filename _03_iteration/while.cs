/*
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
 */
 using System;
class ForWhile
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number to add.");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (number != 0)
        {
            Console.WriteLine($"Number = {number}");
            sum += number;
            Console.Write("Enter a number to add.");
            number = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Sum = {sum}");
    }
}