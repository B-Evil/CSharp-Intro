/*
 *  15.  Read The Name, Heigth and Gender (M = Male; F = Female) of a person
 *       and calculete the ideal weight using rules below; 
 *       - Male : (Ideal weight = 72.7 x height) - 58
 *       - Female : (Ideal weight = 62.1 x height) - 44.7
 *       The height is in meters and the wight in kilograms
 */

using System;
using System.Security.Cryptography.X509Certificates;
class If_Ideal
{
    public static void Main(string[] args)
    {
        Console.Write("Type your Name: ");
        string nameUser = Console.ReadLine();
        Console.Write("Type your gender (Female = F; Male = M): ");
        string gender = Console.ReadLine().ToUpper();
        Console.Write("Type your height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double idealWeight = 0; 
        if (gender != "F" && gender != "M") {
            Console.WriteLine("I'dont have gender in world.");
        }else{
            if (gender == "M") {
                idealWeight = Math.Round(((72.7 * height) - 58), 2);
            }else{
                idealWeight = Math.Round(((62.1 * height) - 44.1), 2);
            }
            Console.WriteLine($"Hi, {nameUser}! Your weight ideal is {idealWeight}");
        }
    }
}