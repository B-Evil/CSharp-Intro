using System;
/*
 *  - Array is a data structure to store a collection of variable of the same type
 *  - Usually (C#, Java, C, C++) an Array has a fixed (static) type and length, 
 *    define at declaration time
 * 
 *  - The elements of an array are accessed by an index, from 0 (first) to array
 *    length - 1 (last)
 *
 */
class Array_01
{
    public static void Main(string[] args)
    {
        int[] numbers = [1, 2, 3, 4, 5, 6];
        Console.WriteLine(numbers[5]);

        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }

        string[] names = new string[5];
        names[0] = "josé";
        names[1] = "Bruno";
        names[2] = "Artur";
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        Console.WriteLine(names[3] == null);
    }
    
}