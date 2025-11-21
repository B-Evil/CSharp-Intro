using System;
/*
 *  09. Implement a routine to indicate two arrays of integer are equals
 *      (Have the same values on same indexes)
 */
class QuestArray_09
{
    public static void Main(string[] args)
    {
        int[] array1 = [1, 2, 3, 4, 5];
        int[] array2 = [1, 2, 3, 4, 5];
        Console.WriteLine($"Test Passed: {ArrayEquals(array1, array2)}");

        int[] array3 = [1, 2, 3, 4, 5, 7, 6, 8];
        int[] array4 = [1, 2, 3, 4, 5, 6, 7, 8];
        Console.WriteLine($"Test Passed: {ArrayEquals(array3, array4)}");

        int[] array5 = [1, 2, 3, 4, 5, 7, 6, 8];
        int[] array6 = [1, 2, 3, 4, 5, 8];
        Console.WriteLine($"Test Passed: {ArrayEquals(array5, array6)}");
        
    }

    private static object ArrayEquals(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length) {
            return false;
        }
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }
}