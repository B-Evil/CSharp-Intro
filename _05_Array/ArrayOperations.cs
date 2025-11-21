using System;
using System.Linq;
using CompanyArray;
/* 
 *  Array: https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-7.0
 */
class ArrayOperations
{
    public static void Main(string[] args)
    {
        int[] myArray = [9, 2, 1, 8, 6, 5, 4, 3, 0, 7];
        LibraryArray.PrintIntArray(myArray, "myArray");

        //length
        Console.WriteLine($"Length = {myArray.Length}");

        //First Element of Array [0]
        int first = myArray.First();
        Console.WriteLine($"First: {first}");

        //Last Element: [array.Length -1]
        int last = myArray.Last();
        Console.Write($"Last: {last}");

        //Min 
        int min = myArray.Min();
        Console.WriteLine($"Min: {min}");

        //Max
        int max = myArray.Max();
        Console.WriteLine($"Max: {max}");

        //Avarege
        double average = myArray.Average();
        Console.WriteLine($"Avarege: {average}");

        //Clone 
        int[] myArrayClone = (int[])myArray.Clone();
        int[] clone = (int[])myArray.Clone();
        // Sort
        Array.Sort(myArray);
        LibraryArray.PrintIntArray(myArray, "My Array Sorted");

        // Clear
        LibraryArray.PrintIntArray(myArrayClone, "My Array Cloned");
        Array.Clear(myArrayClone);
        LibraryArray.PrintIntArray(myArrayClone, "My Array Cloned Cleared");

        // Copy
        int[] myArrayCopy = new int[myArray.Length];
        LibraryArray.PrintIntArray(myArrayCopy, "Before copy");
        Array.Copy(myArray, myArrayCopy, myArray.Length);
        LibraryArray.PrintIntArray(myArrayCopy, "After copy");

        // Copy range
        Array.Clear(myArrayCopy);
        LibraryArray.PrintIntArray(myArrayCopy, "Before copy");
        Array.Copy(myArray, 2, myArrayCopy, 3, 5);
        LibraryArray.PrintIntArray(myArrayCopy, "After copy");

        // Contains
        bool contains7 = myArray.Contains(7);
        Console.WriteLine($"Contains(7): {contains7}");
        Console.WriteLine($"Contains(13): {myArray.Contains(13)}"); ;

        // IndexOf
        int indexOf4 = Array.IndexOf(myArrayCopy, 4);
        Console.WriteLine($"IndexOf 4: {indexOf4}");

        // LastIndexOf
        int lastIndexOf0 = Array.LastIndexOf(myArrayCopy, 0);
        Console.WriteLine($"IndexOf 0: {lastIndexOf0}");

        // Reverse
        LibraryArray.PrintIntArray(myArray);
        Array.Reverse(myArray);
        LibraryArray.PrintIntArray(myArray, "myArray Reversed");

        // Fill
        Array.Fill(myArray, 5);
        LibraryArray.PrintIntArray(myArray);
        Array.Fill(myArray, 3, 5, 4);
        LibraryArray.PrintIntArray(myArray);

        // Distinct
        int[] myNewArray = { 0, 1, 2, 0, 1, 2, 3, 3, 3, 2, 2, 2, 1, 1, 1, 0, 0, 0 };
        int[] myNewArrayDistinct = myNewArray.Distinct().ToArray();
        LibraryArray.PrintIntArray(myNewArray);
        LibraryArray.PrintIntArray(myNewArrayDistinct);


        int[] myArray2 = { 9, 2, 1, 8, 6, 5, 4, 3, 0, 7 };

        // Count
        int evenCount = myArray2.Count(e => e % 2 == 0);
        Console.WriteLine($"Even count: {evenCount}");

        // Generating new array based on condition
        int[] greaterThan5 = myArray2.Where(e => e > 5).ToArray();
        LibraryArray.PrintIntArray(greaterThan5, "Greater than 5");
        LibraryArray.PrintIntArray(myArray2, "myArray2");
    }    
    
}