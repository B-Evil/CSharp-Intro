using System;
/*
 *      15.Read two integer numbers and calculate the "integer" division 
 *         without use the division operator.  
 */
class Ex_15_for
{
    public static void Main(string[] args)
    {
        Console.Write("Dividendo: ");
        int dividendo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());
        if (divisor == 0) {
            Console.WriteLine("Nenhum número é divisível por zero");
            return;
        }

        int originDividendo = dividendo;
        int originDivisor = divisor;
        divisor = Math.Abs(divisor);
        dividendo = Math.Abs(dividendo);

        int quociente = 0;
        int resto = dividendo;
        while (resto >= divisor) {
            quociente++;
            resto -= divisor; 
        }

        if ((originDividendo >= 0 && originDivisor < 0) ||
            (originDividendo < 0 && originDivisor >= 0) ) {
            quociente = -quociente;
        }
        Console.WriteLine($"{originDividendo} / {originDivisor} = {quociente}");
    }
    
}
