using System;
using System.Collections.Generic;
using CompanyArray;
/*
 *  21. Implement a routine to receive two sorted arrays and
 *      return a new array with all elements and sorted as well
 */
class QuestArray_21
{
    public static void Main(string[] args)
    {
        int[] a = {1, 4, 7, 8, 11, 15};
        int[] b = {2, 3, 4, 7, 9, 18, 21, 40};
        int[] array = SortedArray(a, b);
        LibraryArray.PrintIntArray(array, "New Array");
    }

    private static int[] SortedArray(int[] a, int[] b)
    {
        int[] sorted = new int[a.Length + b.Length];
        int ia = 0;
        int ib = 0;
        int iu = 0;
        while (ia < a.Length && ib < b.Length)
        {
            if (a[ia] < b[ib])
            {
                sorted[iu] = a[ia];
                ia++;
            }
            else
            {
                sorted[iu] = b[ib];
                ib++;
            }
            iu++;
        }

        while (ia < a.Length) {
            sorted[iu] = a[ia];
            ia++;
        }
        while (ib < b.Length) {
            sorted[iu] = b[ib];
            ib++;
        }
        
        return sorted;
    }
} 