/*
 *      16.Read the values of the side of a triangle and print
 *         the type of the triangle.
 *         - isosceles: Only two sides are equals 
 *         - Scalene: All sides are different 
 *         - Equilateral: All sides are equal
 */
using System;
class If_Triangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- The type of the triangle ---");
        Console.Write("Type side A: ");
        int sideA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type side B: ");
        int sideB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type side C: ");
        int sideC = Convert.ToInt32(Console.ReadLine());

        string triangle;
        if ((sideA + sideB > sideC) || (sideA + sideC > sideB) || (sideC + sideB > sideA)) {
            if (sideA != sideB && sideB != sideC ) {
                triangle = "The triangle is Scalene.";
            } else if (sideA == sideB && sideB == sideC) {
                triangle = "The triangle is Equilateral.";
            } else {
                triangle = "The triangle is Isosceles.";
            }
        } else { 
            triangle = "Cannot form a triangle";
        }
        Console.WriteLine(triangle);
    } 
}