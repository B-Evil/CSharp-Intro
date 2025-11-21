using System;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
// Routine
namespace CompanyArray;

public class LibraryArray
{
    public static void PrintIntArray(int[] array, string label = null, bool inline = true)
    {

        if (array == null) {
            Console.WriteLine("Nothin to print: Array is null");
            return;
        }

        if (inline)
        {
            if (label != null)
            {
                Console.Write($"{label}: ");
            }
            // Open Bracket
            Console.Write("[");
            // All elements but the last one
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            // Last element and the close bracket
            Console.WriteLine($"{array[array.Length - 1]}]");
        }
        else
        {
            if (label != null)
            {
                Console.WriteLine($"{label}:");
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}]: {array[i]}");
            }
        }
    }

    // exercicio 01 -> 
    public static int[] Clone(int[] InputArray)
    {
        int[] cloneArray = new int[InputArray.Length];
        for (int i = 0; i < cloneArray.Length; i++)
        {
            cloneArray[i] = InputArray[i];
        }
        return cloneArray;
    }

    //exercicio 02 -> 
    public static int[] ReadIntArray(string label, int length)
    {
        int[] array = new int[length];
        //reading 
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{label}[{i}] = ");
            array[i] = Convert.ToInt32(Console.ReadLine()); 
        }
        //returning the array
        return array;
    }

    // exercício 03 ->
    public static void WriteArray(int[] array, string label, bool inline)
    {
        if (inline)
        {
            Console.Write($"{label}: [");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"{array.Last()}]");
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{label} [{i}] : [{array[i]}]");
            }
        }
    }
    
    public static void SwapArray(int[] array, int left, int right)
    {
        int aux = array[left];
        array[left] = array[right];
        array[right] = aux;
    }
}