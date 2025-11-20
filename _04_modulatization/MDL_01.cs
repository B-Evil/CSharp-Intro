using System; 
/*
 *  Module, sub-rotine: 
 *  - Function
 *  - Procedures
 */

public class ModularizationIntro
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world of sub-routines");
        Procedimentos1();
        int soma = AddTowIntegers(1,2);
        Console.WriteLine(soma);
    }

    // - Procedures
    public static void Procedimentos1()
    {
        Console.WriteLine("I am The Procedures 1.");
        Procedimentos2();
    }

    public static void Procedimentos2()
    {
        Console.WriteLine("I am The Procedures 2");
        Procedimentos3();
    }

    public static void Procedimentos3()
    {
        Console.WriteLine("I am Procedures 3");
    }

    // - Functions
    public static int AddTowIntegers(int number1, int number2)
    {
        return number1 + number2;
    }
} 

