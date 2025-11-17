/*
 *   06. Read a integer number and print if is postive or negative.
 */

using System;
class If_PositiveorNegative
{
    public static void Main(string[] args)
    {
        Console.Write("Type a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0 ) {
            Console.WriteLine($"It`s Positive");
        }else {
            Console.WriteLine($"It`s Negative");
        }
    }
}