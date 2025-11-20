using System;
using OurCompany;
/*
 *  Parameters Output
 *  
 */
class ModulaTization_Output
{
    public static void Main(string[] args)
    {
        int dividend = Library.ReadInteger("Dividend");
        int divisor = Library.ReadInteger("Divisor");
        int quocient;
        int remainder;
        // poderiamos declarar as variáveis na própria chamada ->  out int variável
        Library.IntDivisor(dividend, divisor, out quocient, out remainder);
        Console.Write($"{dividend} / {divisor} -> ");
        Console.WriteLine($"Quocient: {quocient} - Remainder: {remainder}");
    }
    
}