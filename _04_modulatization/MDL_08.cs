using System;
/*
 * - Modularização
 *     - Recursão
 *     - Recursividade  part 02
 */
class MDL_08
{
    public static void Main(string[] args)
    {
        for (int i = 0; i <= 5; i++) {
            Console.WriteLine($"{i}! - {RecursionFactoiral(i)}");
        }
    }

    public static long RecursionFactoiral(int value)
    {
        if (value == 0 || value == 1) {
            return 1; 
        } else return value * RecursionFactoiral(value - 1);
    }
    
}