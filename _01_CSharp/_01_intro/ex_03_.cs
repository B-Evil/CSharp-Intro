using System;
class IO
{
    public static void Main(string[] args)
    {
        //write code here ->
        Console.Write("Name: ");
        string userName = Console.ReadLine();

        Console.Write("Age: ");
        string ageAsString = Console.ReadLine();

        int age = Convert.ToInt16(ageAsString);
        
        string menssage = $"Hello, {userName}! Your age is {age}";
        Console.WriteLine(menssage);
    }
}