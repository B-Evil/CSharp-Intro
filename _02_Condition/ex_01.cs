/*
 * - The if statement is a conditioning (selection) statement that allow the execution of parts of the program (CODE BLOCK)
 *   depending on Logical Expressions values
 * - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
 * - CODE BLOCK
 * - A CODE BLOCK is a group of coding statements (commands)
 *   - A CODE BLOCK is delimited by the '{' and '}' characters
 *     - There is an exception if there is only one command. (Bad practices)
 *  
 * Syntax:
 *    if (LOGICAL_EXPRESSION) {
 *       LOGICAL_EXPRESSION is TRUE
 *   }
 *
 *    if (LOGICAL_EXPRESSION) {
 *        LOGICAL_EXPRESSION is TRUE
 *    }
 *    else {
 *        LOGICAL_EXPRESSION is FALSE
 *    }
 * 
 *   if (LOGICAL_EXPRESSION_1) {
 *        LOGICAL_EXPRESSION_1 is TRUE
 *    }
 *    else if (LOGICAL_EXPRESSION_2) {
 *        LOGICAL_EXPRESSION_2 is TRUE
 *    }
 *    else if (LOGICAL_EXPRESSION_3) {
 *        LOGICAL_EXPRESSION_3 is TRUE
 *    }
 * 
 *    if (LOGICAL_EXPRESSION_1) {
 *        LOGICAL_EXPRESSION_1 is TRUE
 *    }
 *    else if (LOGICAL_EXPRESSION_2) {
 *        LOGICAL_EXPRESSION_2 is TRUE
 *    }
 *    else if (LOGICAL_EXPRESSION_3) {
 *        LOGICAL_EXPRESSION_3 is TRUE
 *    } else {
 *        All LOGICAL_EXPRESSIONS are false
 *    }
 * 
 *  01. Read two integers numbers and print the onw with highest value.
 *      Assume the values are not the same.
 */
using System;
class Ifelse
{
    public static void Main(string[] args)
    {
        Console.Write("Number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        //    if (num1 > num2) {
        //       Console.WriteLine($"Highest: {num1}");
        //    } else {
        //        Console.WriteLine($"Highest: {num2}");
        //    }
        Console.WriteLine($"Highest: {Math.Max(num1, num2)}");
    }
}
