/*
 *  09. Read an integer number and print if the number is Even or Odd.
 */

using System;
class If_EvenOrOdd
{
    public static void Main(string[] args)
    {
        Console.Write("Type a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0) {
            Console.WriteLine($"The number {num} it`s Even");
        }else { 
            Console.WriteLine($"The number {num} it`s Odd");
        }
    }
}