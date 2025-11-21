using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using CompanyArray;
/*
 *    12. Implement a routine to return an array with all elements
 *        that are duplicated from an array of integers
 */
class QuestArray_12
{
    public static void Main(string[] args)
    {
        int[] array = { 9, 3, 5, 7, 3, 9, 9, 7, 5, 8 };
        LibraryArray.PrintIntArray(array, "Origin array");

        int[] duplicated = GetDuplicated(array);
        LibraryArray.PrintIntArray(duplicated, "Duplicated");
    }

    public static int[] GetDuplicated(int[] array)
    {
        int[] duplicated = new int[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    duplicated[count] = array[j];
                    count++;
                    break;
                }
            }
        }

        int[] dupFinal = new int[count - 1];
        Array.Copy(duplicated, 0, dupFinal, 0, count - 1);
        return dupFinal.Distinct().ToArray();
    }
}