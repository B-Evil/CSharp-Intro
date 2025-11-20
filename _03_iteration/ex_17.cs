using System;
/*
 *  17. Same as the previous question but starting from the right 
 *   e.g.
 *   Height = 7
 */
class Ex_17_for
{
    public static void Main(string[] args)
    {
        Console.Write("Height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        int spaces = height - 1;
        int stars = 1;
        for (int row = 1; row <= height; row++) {
            for (int i = 1; i <= spaces; i++) {
                Console.Write(" ");
            }
            for (int j = 1; j <= stars; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
            stars++;
            spaces--;
        }
    }   
    
}
