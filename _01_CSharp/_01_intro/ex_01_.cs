using System;
class Operations
{
    public static void Main(string[] args)
    {
        Console.WriteLine("System of avarege");
        Console.Write("Type your first number: ");
        int firstPoint = Convert.ToInt16(Console.ReadLine());
        Console.Write("Type your second number: ");
        int secondPoint = Convert.ToInt16(Console.ReadLine());
        Console.Write("Type your third number: ");
        int thirdPoint = Convert.ToInt16(Console.ReadLine());

        double avarege = (firstPoint + secondPoint + (double) thirdPoint) / 3;
        string menssage = $"Your avarege is: {avarege}";

        Console.WriteLine(menssage);
    }
}