using System;
/*
 *  13. Read an integer number with any length and reverse it's digits.
 *      Input = 12345
 *      Output = 54321
 */
class Ex_13_for
{
    public static void Main(string[] args)
    {
        Console.Write("Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int numberAux = number;
        int inverted = 0;

        while (numberAux != 0) {
            int lastNum = numberAux % 10;
            inverted = inverted * 10 + lastNum;
            numberAux /= 10;
        }

        Console.WriteLine($"O inverso de {number} é {inverted}");
    }

}
