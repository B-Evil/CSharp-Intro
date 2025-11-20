using System;
/*
 *   11. Read a integer number and calculate it's Factorial.
 *      f(n) = n(n - 1)(n - 2)(n - 3)...1
 */
class Ex_11_for
{
    public static void Main(string[] args)
    {
        Console.Write("Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = num; i >= 2; i--)
        {
            factorial *= i; //  num = num * i;
        }
        Console.WriteLine($"Factorial: {factorial}");
    }
    
}