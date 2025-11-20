using System;
using System.Runtime.CompilerServices;
using OurCompany;
/*
 *  - Modularização
 *     - Recursão
 *     - Recursividade
 */
class RecursionIntro
{
    public static void Main(string[] args)
    {
        int value = Library.ReadInteger("Number");
        CountingReverse(value);
        Console.WriteLine();
        Counting(value);

    }

    //Recursão
    public static void CountingReverse(int number)
    {
        if (number == 0)
        {
            return;
        }
        Console.Write($"{number}, ");
        CountingReverse(number - 1);
    }

    public static void Counting(int number)
    {
        if (number == 0){
            return;
        }
        CountingReverse(number - 1);
        Console.Write($"{number}, ");
    }
    
}