/*  -> Class Mat: 
 *       Ceiling, Floor,Round, Truncate
 *       Abs, Max, Min, Pow, Sqrt
 *       PI 
 *  -> Most Common 
 */
using System;
class MathOperations
{
    public static void Main(string[] args)
    {
        //Calcula o número de PI
        Console.WriteLine($"PI ={Math.PI}");
        // Returns the absolute value
        Console.WriteLine($"Math.Abs(10)  = {Math.Abs(10)}"); // 10
        Console.WriteLine($"Math.Abs(-10) = {Math.Abs(-10)} "); // 10
        //Seleciona o número maior
        Console.WriteLine($"Math.Max(10, 7) = {Math.Max(10, 7)}");//10
        //Seleciona o número menor
        Console.WriteLine($"Math.Min(10, 7) = {Math.Min(10, 7)}");// 7
        //potenciação 
        Console.WriteLine($" 2^4 = {Math.Pow(2, 4)}");// 16
        //square root 
        Console.WriteLine($"Square Root -> Math.Sqrt(4) = {Math.Sqrt(16)} ");// 4

        double value = 7.321375;
        Console.WriteLine($"Ceiling:    {Math.Ceiling(value)} "); // 8
        Console.WriteLine($"Floor:      {Math.Floor(value)}"); // 7
        Console.WriteLine($"Round:      {Math.Round(value, 2)}");// 7.32
        Console.WriteLine($"Truncate:   {Math.Truncate(value)}");// 7
    }
}
