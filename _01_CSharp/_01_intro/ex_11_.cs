/*
 * 11. Read an integer number with 6 digits and separete it
 *     into two integer with 3 digits each.
 */
 using System;
 class Ex11
{
    public static void Main(string[] args)
    {
        Console.Write("Type number with 6 Digits: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int first = num / 1000;
        int second = num % 1000; 
        Console.WriteLine($" {first} - {second}");
    }
}