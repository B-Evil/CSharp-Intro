using System;
using CompanyArray;
using OurCompany;
/*
 *  01. Implement a routine to clone an array of integers:
 *      int Clone(int[]).
 */
class QuestArray_01
{
    public static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int[] myArray = LibraryArray.Clone(array);

        LibraryArray.PrintIntArray(array, "Origin");
        LibraryArray.PrintIntArray(myArray, "Clone");

        //unit test -> 
        array[0] = 100; 
        
        LibraryArray.PrintIntArray(array, "Origin");
        LibraryArray.PrintIntArray(myArray, "Clone");
    }
    
}