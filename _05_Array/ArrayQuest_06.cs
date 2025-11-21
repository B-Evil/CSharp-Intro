using System;
using System.Linq;
using System.Runtime.ExceptionServices;
/*
 *  06. Implement a routine to return the first and last elements of an array 
 *      of integers as output parameters: 
 *      GetFirstAndlast(array , out first, out last)
 * 
 */
class QuestArray_06
{
    public static void Main(string[] args)
    {
        int[] array = [1, 2, 4, 5, 6, 7, 8, 9];
        int first;
        int last;
        getFirstAndLast(array, out first, out last);
        
        Console.WriteLine($"Test unit First: {first == 1}");
        Console.WriteLine($"Test unit Last: {last == 9}");
    }

    public static void getFirstAndLast(int[] array, out int elementFirst, out int elementLast)
    {
        elementFirst = array.First();
        elementLast = array.Last();
    }
}