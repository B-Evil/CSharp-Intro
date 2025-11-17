/*
 *  08. Read the name, salary and salary percentage and print the name
 *      new salary.
 */

using System;
class Ex08
{
    public static void Main(string[] args)
    {
        Console.Write("Type the name: ");
        string userName = Console.ReadLine();
        Console.Write("Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Type increse the salary percentege: ");
        double increseSalary = Convert.ToDouble(Console.ReadLine());

        double percentege = (salary * increseSalary) / 100;
        double newSalary = salary + percentege;
        Console.WriteLine($"Nome: {userName}");
        Console.WriteLine("Cargo: Desenvolvedor Back-End");
        Console.WriteLine($"New Salary R$: {newSalary}");  
    }
}