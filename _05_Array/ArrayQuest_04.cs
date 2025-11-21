using System;
using System.ComponentModel.DataAnnotations;
/*
 *  04. Implementa routine to receive an integer array and return
 *      the min and max values as output  parameters.
 *      FindMinAndMax(array, out min, ou max)
 */
class QuestArray_04
{
    public static void Main(string[] args)
    {
        int[] array = [6, 56, 23, 2, 6, 38, 50, 54, 67, 75, 54, 6, 77];
        int minimum;
        int maximum;
        FindMinAndMax(array, out minimum, out maximum);
        Console.WriteLine($"Min: {minimum} - Max: {maximum}");

        //Test-Unit case Min 
        Console.WriteLine($"Test result: {minimum == 2}");
        //Test- case Max
        Console.WriteLine($"Test result: {maximum == 77}");
    }


    public static void FindMinAndMax(int[] array, out int min, out int max)
    {
        min = array[0];
        max = array[0]; 

        for (int i = 0; i < array.Length; i++)
        {
            min = Math.Min(min, array[i]);
            max = Math.Max(max, array[i]);
        }
    } 
}