using System;
/*
 *  03. Read two integer numbers representing an interval
 *      and print all even numbers inside interval.
 */
class Ex_03_for
{
    public static void Main(string[] args)
    {
        Console.Write("Type a number: ");
        int MIN = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type other number: ");
        int MAX = Convert.ToInt32(Console.ReadLine());

        if (MIN >= MAX){
            if (MAX % 2 != 0){
                MAX++;
            }
            int aux = MAX;
            MAX = MIN;
            MIN = aux;
            for (int i = MAX; i >= MIN; i -= 2){
                Console.Write($"{i}, ");
            }
        }else {
            if(MIN % 2 != 0) {
                MIN++;
            }
            for (int i = MIN; i <= MAX; i += 2 ) { 
                Console.Write($"{i}, ");
            }
        }
    }
}