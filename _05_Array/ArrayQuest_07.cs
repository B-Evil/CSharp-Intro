using System;
using System.ComponentModel;
using CompanyArray;
/*
 *  07. Implement a routine to fill an integer array with an specific value:
 *      Fill(array, start, end, value)
 */
class QuestArray_07
{
    public static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
        LibraryArray.PrintIntArray(array);
        Fill(array, 3, 9, 7);
        LibraryArray.PrintIntArray(array);
    }

    public static void Fill(int[] array, int start, int end, int value)
    {
        if (start >= 0 && end >= 0 && start <= end &&
            start < array.Length && end < array.Length){
            for (int i = start; i < end; i++)
            {
                array[i] = value;
            }
        }
    }
}