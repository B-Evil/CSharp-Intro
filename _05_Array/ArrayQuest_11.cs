using System;
using CompanyArray;
/*
 *  11. Implement a routine to reverse an integer array. 
 *      Try it in-place
 */
class QuestArray_11
{
    public static void Main(string[] args)
    {
        int[] array = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        LibraryArray.PrintIntArray(array, "Array");
        ReverseArray(ref array); // reference for change array origin.
        LibraryArray.PrintIntArray(array, "Reverse Array");
    }

    public static void ReverseArray(ref int[] array)
    {
        int[] reverse = new int[array.Length];
        int j = array.Length - 1;
        for (int i = 0; i < array.Length; i++)
        {
            reverse[j] = array[i];
            j--;
        }
        array = reverse;
    }
}