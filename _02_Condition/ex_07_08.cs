/*
 *      07. Read an age and print "Minor" if the age is smaller than 18.
 *      08. Read an age and print "Minor" if the age is smaller than 18 and
 *          "ADULT" otherwise
 */

using System;
class If_Age
{
    public static void Main(string[] args)
    {
        Console.Write("Type your age: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 18 ) {
            Console.WriteLine($"Minor");
        }else {
            Console.WriteLine($"ADULT");
        }
    }
}