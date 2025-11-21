using System;
using CompanyArray;
/*
 *  26. Implement a routine to randomize an array of integers
 *  
 */
class QuestArray_26
{
    public static void Main(string[] args)
    {
        int[] array = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        LibraryArray.PrintIntArray(array, "Array origin");
        RondamizeArray(array);
        LibraryArray.PrintIntArray(array, "Array Randomize");
    }

    private static void RondamizeArray(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            int randomIndex = random.Next(i, array.Length);
            LibraryArray.SwapArray(array, i, randomIndex);
        }
    }
}