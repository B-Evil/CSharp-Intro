using System;
/*
 *  
 *  
 */
class Intro_Modulo2
{
    public static void Main(string[] args)
    {
        int n1 = ReadInteger("Number 1: ");
        int n2 = ReadInteger("Number 2: ");
        int n3 = ReadInteger("Number 3: ");

        double avrg = Avarege(n1, n2, n3);
        Console.WriteLine($"The avarege of {n1} + {n2} + {n3} = {Math.Round(avrg, 2)}");
    }

    public static int ReadInteger(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static double Avarege(int num1, int num2, int num3)
    {
        int soma = num1 + num2 + num3;
        double avrg = soma / (double) 3;
        return avrg;
    }
    
}