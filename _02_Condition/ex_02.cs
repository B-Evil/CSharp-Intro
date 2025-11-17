/*
 *  02. Read two integers numbers and print the one with highest value.
 *      If the values are equal, print "EQUALS".
 */

 using System;
class Equals
{
    public static void Main(string[] args)
    {
        Console.Write("Type a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type other number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 == num2) {
            Console.WriteLine($"EQUALS");
        } else {
            Console.WriteLine($"Highest: {Math.Max(num1, num2)}");
        }
    }
}