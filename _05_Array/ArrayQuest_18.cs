using System;
using System.IO.Pipelines;
using CompanyArray;
/*
 *  18. implementa a routine to receive two arrays of integers 
 *      (ascending order) and return a new with the union
 */
class QuestArray_18
{
    public static void Main(string[] args)
    {
        int[] a = {1, 4, 5, 9, 40, 50};
        int[] b = {1, 2, 4, 5, 7, 9, 10, 45};
        int[] union = ArrayUnion(a, b);
        LibraryArray.PrintIntArray(a, "Array a");
        LibraryArray.PrintIntArray(b, "Array b");
        LibraryArray.PrintIntArray(union, "Array Union");
    }

    private static int[] ArrayUnion(int[] a, int[] b)
    {
        int[] union = new int[a.Length + b.Length];
        int ia = 0;
        int ib = 0;
        int iu = 0;
        while ((ia < a.Length) && (ib < b.Length)) {
            if (a[ia] == b[ib]) {
                union[iu] = a[ia];
                ia++;
                ib++;
            } else if (a[ia] < b[ib]) {
                union[iu] = a[ia];
                ia++;
            } else {
                union[iu] = b[ib];
                ib++;
            }
            iu++;
        }

        while (ia < a.Length)
        {
            union[iu] = a[ia];
            ia++;
            iu++;
        }
        
        while (ia < a.Length) {
            union[iu] = b[ib];
            ib++;
            iu++;
        }
        //return array ->
        int[] result = new int[iu];
        Array.Copy(union, 0, result, 0, iu);
        return result;
    }
}