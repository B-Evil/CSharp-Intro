using System;
using System.Runtime.InteropServices.Marshalling;
using CompanyArray;
/*
 *      14. Implement a routine to return a new array 
 *          with only unique values from an array of integers
 */
class QuestArray_14
{
    public static void Main(string[] args)
    {
        int[] arr = { 3, 5, 8, 9, 3, 5, 1, 2, 5, 5, 5, 6, 8, 0, 4 };
        int[] unique = GetUnique(arr);
        LibraryArray.PrintIntArray(arr, "array");
        LibraryArray.PrintIntArray(unique,"unique");
    }

    public static int[] GetUnique(int[] array) {
        int[] unique = new int[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++) {
            bool found = false; 
            for (int j = 0; j < count; j++) {
                if (array[i] == unique[j]) {
                    found = true;
                    break;
                }
            }
            if(!found){
                unique[count] = array[i];
                count++;
            }
        }

        int[] result = new int[count];
        Array.Copy(unique, 0, result, 0, count );
        return result;
    }
    
}