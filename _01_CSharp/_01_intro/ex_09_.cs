/*
 *  09. Read two integer numbers and swap the 
        variables content.
 *
 */
using System;
class Ex09
{
    public static void Main(string[] args)
    {
        Console.Write("1st Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2sd Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"1 Number => {num1} and  2Number => {num2} ");
        int aux = num1;
        num1 = num2;
        num2 = aux;
        Console.WriteLine($"1 Number => {num1} and 2 Number => {num2}");
    }
}