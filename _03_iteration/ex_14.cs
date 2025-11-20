using System;
/*
 *  14.Read an integer number and determine if it is a prim
 *     number or not.
 */
class Ex_14_for
{
    public static void Main(string[] args)
    {
        Console.Write("Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool IsPrime = true;
        for (int i = 2; i < number / 2; i++) {
            if (number % i == 0) {
                IsPrime = false;
                break;
            }
        }
        if (IsPrime && number != 1) {
            Console.WriteLine($"{number} is Prime");
        } else {
            Console.WriteLine($"{number} is NOT Prime");
        }
    }
    
}


/*
 *  ->  Um número primo só é divisivel apenas por 1 ou por ele mesmo
 *      Nosso loop começa no numero 2 e continua enquanto i for menor que num
 *      Se num for primo ele nunca entra na condição if (num % i == 0). 
 */