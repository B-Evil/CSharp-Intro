using System;
using CompanyArray;
using OurCompany;
/* 
 *  24. implement a routine to return the longest sequence
 *      of duplicated elements of an array of integers
 *      containing inly 0s and 1s.
 */
class QuestArray_24
{
    public static void Main(string[] args)
    {
        int[] sequence = [0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1];

        int longest = FoundSequence(sequence);
        Console.WriteLine(longest);
        
    }

    private static int FoundSequence(int[] array)
    {
        int longest = 1;
        int maxLong = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1]) {
                maxLong++;
            } else {
                maxLong = 1;
            }

            if (longest < maxLong) {
                longest = maxLong;
            }
        }

        return longest;
    }
}