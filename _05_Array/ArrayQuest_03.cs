using System;
using CompanyArray;
/*
 *  03. Implement a routine to print an integer array allowinf the options 
 *      to provide a label and print the array inliner or multi-line.
 * 
 *  - INLINE: all elements of the array in a single line, separated 
 *    by commna "," and inside open/close brackets: e.g [1,2,3,4,5]       
 * 
 *  - Multi: each element in a new line after the index, the index 
 *    hould be sinside brackets.
 */
class QuestArray_03
{
    public static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8];

        LibraryArray.WriteArray(array, "Inline", true);
        //LibraryArray.WriteArray(array, "Multi", false);
    }
    
}