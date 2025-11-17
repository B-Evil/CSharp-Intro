/*
 *  03. Read three integers and print the highest value.
 */

  using System;
class ThreeInts
{
    public static void Main(string[] args)
    {
        Console.Write("Type the first N: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the second N: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the third N: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if ((num1 == num2) && (num2 == num3)){
            Console.Write("Equals");
        }
        else if (num1 > num2){
            Console.WriteLine($"Highest: {Math.Max(num1, num3)}");
        }
        else{
            Console.WriteLine($"Highest: {Math.Max(num2, num3)}");
        }

        // otimizando -> 
        Console.WriteLine(Math.Max(num1, Math.Max(num2, num3)));
    }
}