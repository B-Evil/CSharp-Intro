using System;
using System.Runtime.CompilerServices;
using OurCompany;
/*
 *  - By value
 *  - By reference (ref) 
 */
class Parameters_Value_Ref
{
    public static void Main(string[] args)
    {
        int number1 = Library.ReadInteger("Num1: ");
        int number2 = Library.ReadInteger("Num2: ");
        //Call routine Value 
        Library.SwapByValue(number1, number2);
        Console.WriteLine($"Number_1: {number1} - Number_2: {number2}");

        //Call routine Referenc (Ref)
        Library.SwapByRef(ref number1, ref number2);
        Console.WriteLine($"Number_1: {number1} - Number_: {number2}");
    }
    
}