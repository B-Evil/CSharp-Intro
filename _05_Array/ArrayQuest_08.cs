using System;
using System.ComponentModel;
using CompanyArray;
/*
 *  08. implement a routine to generate an integer array with randon numbers from
 *      a provided interval: int[] GenerateRandomArry(length, minValue, maxValue)
 */
class QuestArray_08
{
    public static void Main(string[] args)
    {
        Console.WriteLine("System of random array ");
        int[] randomArray1 = GenerateRandomArray(10, 0, 9);
        LibraryArray.PrintIntArray(randomArray1, "Array 1: ");

        int[] randomArray2 = GenerateRandomArray(10, 20, 60);
        LibraryArray.PrintIntArray(randomArray2, "Array 2 :");
    }

    public static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] array = new int[length];
        if (minValue > maxValue) {
            int aux = minValue;
            minValue = maxValue;
            maxValue = aux; 
        }
        Random aleatorio = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = aleatorio.Next(minValue, maxValue + 1);
        }
        return array; 
    }
}