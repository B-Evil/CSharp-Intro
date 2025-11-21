using System;
using OurCompany;
/*
 *  00. Creat a program toread 10 integer numbers and print all numbers
 *      after the last number is read.
 */
class Array_00
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = Library.ReadInteger($"Number{i + 1}");
        }
        for (int i = 0; i < numbers.Length; i++) {
            Console.Write(numbers[i]+" - ");
        }
    }
    
}

