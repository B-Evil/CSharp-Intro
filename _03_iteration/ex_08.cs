using System;
using System.Diagnostics.Contracts;
/*
 *  08. Print the Fibonacci sequence while the term is smaller than 5000.
 *      Fibonacci =  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
 */
class Ex_08_for
{
    public static void Main(string[] args)
    {
        int aux = 0;
        int before = 0;
        int after = 1;
        string message = "Sequece Fibonacci: ";
        while (aux < 5000) {
            message += $"{aux}, ";
            aux = before + after;
            before = after;
            after = aux;
        }
        Console.WriteLine(message);
    }
    
}