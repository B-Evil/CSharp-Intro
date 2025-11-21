using System;
using CompanyArray;
/*
 *  23. implement a routine to move all zeros of an integer
 *      array to the left side.
 */
class QuestArray_23
{
    public static void Main(string[] args)
    {
        int[] array1 = [0, 1, 2, 0, 0, 3, 0, 0, 4, 5, 0, 0, 0, 7, 0, 0];
        int[] array2 = [1, 2, 3, 0, 0, 0, 0, 4, 5, 0, 0, 0, 7, 0, 8, 0, 0, 0, 0];
        int[] array3 = [1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6];

        LibraryArray.PrintIntArray(array1, "Array1");
        MoveZerosLeft(array1);
        LibraryArray.PrintIntArray(array1, "Array1.0");

        LibraryArray.PrintIntArray(array2, "Array2");
        MoveZerosLeft(array2);
        LibraryArray.PrintIntArray(array2, "Array2.0");

        LibraryArray.PrintIntArray(array3, "Array3");
        MoveZerosLeft(array3);
        LibraryArray.PrintIntArray(array3, "Array3.0");
    }

    private static void MoveZerosLeft(int[] array)
    {
        int[] aux = new int[array.Length];
        int iAux = array.Length - 1;
        for(int i = array.Length - 1; i >= 0; i--) {
            if (array[i] != 0) {
                aux[iAux] = array[i];
                iAux--; 
            }
        }
        Array.Copy(aux, 0, array, 0, array.Length);
    }
}