using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
/*
 *  05. Read integer numbers (flag = empty) and print the highest value.
 */
class Ex_05_for
{
    public static void Main(string[] args)
    {
        string numberStr;
        int num;
        int highest = int.MinValue; // -> recebe menor número inteiro
        bool numEnter = false;
        do {
            Console.Write("Number: ");
            numberStr = Console.ReadLine();
            if (numberStr != string.Empty) { // -> diferente de string vazia
                numEnter = true;
                num = Convert.ToInt32(numberStr);
                highest = Math.Max(highest, num);
                //if (num > highest){
                //    highest = num;
                //}
            }
        } while (numberStr != string.Empty);
        if (numEnter) {
            Console.Write($"highest: {highest}");
        }else{
            Console.WriteLine("No numbers Entered.");
        }
    }
}