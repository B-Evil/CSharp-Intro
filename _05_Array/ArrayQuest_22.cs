using System;
using CompanyArray;
/*
 *  22. implement a routine to rotate an array n positions to the left: 
 *      RotateLeft(array, offset).
 */
class QuestArray_22
{
    public static void Main(string[] args)
    {
        int[] array = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int[] array1 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        RotatedArray(array, 4);
        LibraryArray.PrintIntArray(array, "Array Rotated");

        ReverseLeft(array1, 4);
        LibraryArray.PrintIntArray(array1, "Array Reverse");
    }

    private static void RotatedArray(int[] array, int offset)
    {
        int[] arrayReverse = new int[array.Length];
        Array.Copy(array, offset, arrayReverse, 0, array.Length - offset);
        Array.Copy(array, 0, arrayReverse, array.Length - offset, offset);
        Array.Copy(arrayReverse, 0, array, 0, array.Length);
    }

    private static void ReverseLeft(int[] array, int offset)
    {
        Reverse(array, 0, array.Length - 1);
        Reverse(array, 0, array.Length - offset - 1);
        Reverse(array, array.Length - offset + 1, array.Length - offset);
    }
    private static void Reverse( int[] array, int left, int right)
    {
        while (left < right)
        {
            int aux = array[left];
            array[left] = array[right];
            array[right] = aux;
            left++;
            right--;
        }
    }
}