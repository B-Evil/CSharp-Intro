using System;
/*
 *  13. implement a routine to return many times a 
 *      value occurs in an array of integers
 */
class QuestArray_13
{
    public static void Main(string[] args)
    {
        int[] arr = { 5, 8, 5, 3, 9, 5, 0, 3, 3, 5, 6 };

        Console.WriteLine($"Test with 5 passed: {CounterValue(arr, 5) == 4}");
        Console.WriteLine($"Test with 5 passed: {CounterValue(arr, 7) == 0}");
        Console.WriteLine($"Test with 5 passed: {CounterValue(arr, 8) == 1}");
        Console.WriteLine($"Test with 5 passed: {CounterValue(arr, 3) == 3}");
    }

    private static int CounterValue(int[] array, int value)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] == value) {
                count++;
            }
        }
        return count;
    }
}