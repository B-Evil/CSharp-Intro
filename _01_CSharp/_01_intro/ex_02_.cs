using System;

class HomeWork
{
    public static void Main(string[] args)
    {
        Console.Write("Type temperature in Celsius:  ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double f = (celsius * 1.8) + 32;
        string menssage = $"The temperature in fahrenheit is: {f}";
        Console.WriteLine(menssage);
    }
}