using System;
class Miles
{
    public static void Main(string[] args)
    {
        Console.Write("Type your value in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.60934;
        Console.WriteLine($"{miles} miles = {kilometers} Kilometers");
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
}