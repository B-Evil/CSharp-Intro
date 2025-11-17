/*
 *  12. Read a single digit number and print the description (name).
 */

using System;
using System.Data.Common;
class If_Single
{
    public static void Main(string[] args)
    {
        Console.Write("Single Digit: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string digit; 

        if(num < 0 || num > 9){
            digit = "digit invalit";
        }else{
            if (num == 0) {
                digit = "zero";
            } else if (num == 2) {
                digit = "two";
            } else if (num == 3) {
                digit = "three";
            } else if (num == 4) {
                digit = "four";
            } else if (num == 5) {
                digit = "five";
            } else if (num == 6) {
                digit = "six";
            } else if (num == 7) {
                digit = "seven ";
            } else if (num == 8) {
                digit = "eight";
            } else {
                digit = "nine";
            }
            Console.WriteLine(digit);
        }
    }
}