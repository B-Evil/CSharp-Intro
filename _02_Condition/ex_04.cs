/*
 *  03. Read five integer numbers and print the biggest one.
 */

  using System;
class FiveInts
{
    public static void Main(string[] args)
    {
        Console.Write("Type the first N: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the second N: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the third N: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the fourth N: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the fiveth N: ");
        int num5 = Convert.ToInt32(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3) && (num1 > num4)) {
            Console.WriteLine($"biggest: {Math.Max(num1, num5)}");
        } else if ((num2 > num3) && (num2 > num4)) {
            Console.Write($"biggest: {Math.Max(num2, num5)}");
        } else if (num3 > num4) {
            Console.WriteLine($"biggest: {Math.Max(num3, num5)}");
        }else {
            Console.WriteLine($"biggest: {Math.Max(num4, num5)}");
        }
    }
}