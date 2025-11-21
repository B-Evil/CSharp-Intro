using System;
using CompanyArray;
/*
 *  00. Array is a reference type
 *  
 */
class ARRAY_02
{
    public static void Main(string[] args)
    {
        int number = 10;
        int numberCopy = number;
        Console.WriteLine($"Number: {number}, NumberCopy: {numberCopy}");

        numberCopy = 20;
        Console.WriteLine($"nUMBER: {number} NumberCopy: {numberCopy}");

        Console.WriteLine("Printing 'both' arrays");
        int[] numbers = { 1, 2, 3 };
        int[] numbersCopy = numbers;
        LibraryArray.PrintIntArray(numbers, "numbers", true);
        LibraryArray.PrintIntArray(numbersCopy, "numbersCopy", true);

        numbers[0] = 3;
		numbers[2] = 1;
		Console.WriteLine("Printing 'both' arrays, after changing the numbers array");
		LibraryArray.PrintIntArray(numbers, "numbers", true);
		LibraryArray.PrintIntArray(numbersCopy, "numbersCopy", true);

        Console.WriteLine("Cloning the array and changing the cloned one");
        numbersCopy = (int[])numbers.Clone(); // Using the Clone method from the array
		numbersCopy[0] = 1;
		numbersCopy[2] = 3;
		LibraryArray.PrintIntArray(numbers, "numbers", true);
		LibraryArray.PrintIntArray(numbersCopy, "numbersCopy", true);
    }
}