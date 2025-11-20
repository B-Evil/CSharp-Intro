/*
 *  02. Read two integer numbers representing an interval
 *      and print all numbers insede the interval.     
 */
 using System;
class Ex_02_for
{
    public static void Main(string[] args)
    {
        Console.Write("Type a number: ");
        int MIN = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type other number: ");
        int MAX = Convert.ToInt32(Console.ReadLine());

        if (MIN >= MAX) {
            int aux = MAX;
            MAX = MIN;
            MIN = aux;
            for (int i = MAX; i >= MIN; i--) {
                Console.Write($"{i}, ");
            }
        }else{
            for (int i = MIN; i <= MAX; i++) {
                Console.Write($"{i}, ");
            }
        }

    }
}