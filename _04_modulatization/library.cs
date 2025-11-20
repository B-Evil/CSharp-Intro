using System;
/*
 *  Sub-rotinas... 
 *  
 */
namespace OurCompany;

public class Library
{
    //Function with parameters Default
    public static int ReadInteger(string prompt = "Type a Number", string signal = " : ")
    {
        Console.Write($"{prompt} {signal}");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void RepeatPrime(char content, int times)
    {
        for (int i = 1; i <= times; i++)
        {
            Console.Write(content);
        }
    }

    // parameters Value -> 
    public static void SwapByValue(int a, int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }

    // parameters Reference
    public static void SwapByRef(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }

    //Parameters Output 
    public static void IntDivisor(int dividend, int divisor, out int quocient, out int remainder)
    {
        quocient = dividend / divisor;
        remainder = dividend % divisor;
    }

}