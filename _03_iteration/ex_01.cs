/*
 *  01. Print the numbers from 1 to 100 without
 *      using lines after each number.
 */
 using System;
class Ex_01_for
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Type a number: ");
        int MIN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type other number: ");
        int MAX = Convert.ToInt32(Console.ReadLine());

        for (int i = MIN; i <= MAX; i++) {
            Console.Write($"{i}, ");
        } 
    }
}