using System;
using System.Linq.Expressions;
/*
 *  25.implement a routine to given an array of N non-negative
 *     integers representing an elevation map where the width of each 
 8     bar is 1, compute how much water is able trap after raining.
 */
class QuestArray_25
{
    public static void Main(string[] args)
    {
        int[] elevation = [2, 1, 3, 0, 1, 3, 2, 0, 1, 2, 0, 1, 4, 1, 5, 0, 2, 1, 0, 3, 0, 0, 2];
        int water = GetTrapedWater(elevation);
        Console.WriteLine($"total of traped Water: {water}");
    }

    private static int GetTrapedWater(int[] elevation)
    {
        int[] trapedWaterRight = GetTrapedWaterRight(elevation);
        int[] trapedWaterLeft = GetTrapedWaterLeft(elevation);
        int unit = 0;
        int totalGlobalWater = 0;
        int unitWater = 0;
        for (int i = 0; i < elevation.Length; i++)
        {
            unit = Math.Min(trapedWaterLeft[i], trapedWaterRight[i]);
            totalGlobalWater = unit - elevation[i];
            if (totalGlobalWater > 0)
            {
                unitWater += totalGlobalWater;
            }
        }

        return unitWater;
    }

    private static int[] GetTrapedWaterRight(int[] elevation)
    {
        int[] sideRight = new int[elevation.Length];
        int maxRight = 0;
        sideRight[elevation.Length - 1] = maxRight;
        for (int i = elevation.Length - 1; i > 0; i--)
        {
            if (elevation[i] > maxRight)
            {
                maxRight = elevation[i];
            }
            sideRight[i - 1] = maxRight;
        }
        return sideRight;
    }

    private static int[] GetTrapedWaterLeft(int[] elevation)
    {
        int[] sideLeft = new int[elevation.Length];
        int maxLeft = 0;
        for (int i = 1; i < elevation.Length; i++)
        {
            if (elevation[i - 1] > maxLeft)
            {
                maxLeft = elevation[i - 1];
            }
            sideLeft[i] = maxLeft;
        }

        return sideLeft;
    }
    

}