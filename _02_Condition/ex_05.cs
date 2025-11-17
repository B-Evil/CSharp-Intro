/*
 *  05. Read Three inteegrs and print them in ascending order.
 *      (non descending).
 */

using System;
class If_Order
{
    public static void Main(string[] args)
    {
        Console.Write("Type the first N: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the second N: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the third N: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        string message;
        if ((num1 > num2) && (num1 > num3)) {
            message = $"{Math.Min(num2, num3)}, {Math.Max(num2, num3)}, {num1}";
        }else if (num2 > num3) {
            message = $"{Math.Min(num1, num3)}, {Math.Max(num1, num3)}, {num2}";
        }else {
            message = $"{Math.Min(num1, num2)}, {Math.Max(num1, num2)}, {num3}";
        }
        Console.WriteLine(message);
    }
}