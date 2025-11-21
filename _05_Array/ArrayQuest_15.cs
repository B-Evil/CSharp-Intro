using System;
using System.Linq;
using System.Runtime.InteropServices;
using CompanyArray;
/*
 *  15. implement a routine to receive two arrays of 
 *      integers and return an array with the intersection
 *  
 */
class QuestArray_15
{
    public static void Main(string[] args)
    {
        int[] dadosA = { 4, 5, 6, 7, 0, 1, 3 };
        int[] dadosB = { 9, 8, 5, 10, 9, 7, 7, 3 };
        int[] intersection = GetIntersection(dadosA, dadosB);
        LibraryArray.PrintIntArray(intersection);
    }

    private static int[] GetIntersection(int[] dadosA, int[] dadosB)
    {
        int[] section = new int[dadosA.Length];
        int count = 0;
        for (int i = 0; i < dadosA.Length; i++)
        {
            for (int j = 0; j < dadosB.Length; j++) {
                if (dadosA[i] == dadosB[j])
                {
                    section[count] = dadosA[i];
                    count++;
                    break;
                }
            }
        }
        if (count == 0) {
            return null;
        }
        //clear informations
        int[] result = new int[count];
        Array.Copy(section, 0, result, 0, count );
        return result; 
    }
}