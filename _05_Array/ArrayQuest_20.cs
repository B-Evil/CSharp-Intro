using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
/*
 *  20. Implement a routine to indicate if an array of integers has
 *      two values that sum to a provided value: bool HasSum(array, Sum)
 */
class QuestArray_20
{
    public static void Main(string[] args)
    {
        int[] array = [5, 3, 0, 2, 8, -7, 6, 4, 5, 10];
        Console.WriteLine(HasSum(array, 8)); // true
        Console.WriteLine(HasSum(array, 5));
        Console.WriteLine(HasSum(array, 1));
        Console.WriteLine(HasSum(array, 18));
        Console.WriteLine(HasSum(array, 6));
        Console.WriteLine(HasSum(array, 0) == false);
        Console.WriteLine(HasSum(array, 10));
        Console.WriteLine(HasSum(array, -6) == false);
        Console.WriteLine(HasSum(array, 20) == false);
    }

    public static bool HasSum(int[] array, int sum)
    {
        for(int i = 0; i < array.Length - 1; i++) 
        {
            for (int j = i + 1; j < array.Length; j++ ) {
                if (array[i] + array[j] == sum) {
                    return true;
                }
            }
        }
        return false;
    }
}