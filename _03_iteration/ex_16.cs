using System;
/*
 *  16. Read an integer number H and print H lines composed of (*)
 *      characters start with ine and adding one * for each new line.
 *      e.g.
 *      Height = 7 
 */
class Ex_16_for
{
    public static void Main(string[] args)
    {
        Console.Write("Height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int row = 1; row <= height; row++) {
            for (int i = 1; i <= row; i++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}