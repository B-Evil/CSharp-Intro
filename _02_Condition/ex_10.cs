/*
 *  10. Read two numbers, desired operation (+ , - , * , /) andprint an string
 *      representing the operation with the result.
 */

using System;
class If_Operations
{
    public static void Main(string[] args)
    {
        Console.Write("Type a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type other number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type your operation. ex: (+ , -, *, /) ");
        string operation = Console.ReadLine();

        int soma = 0;
        if (operation == "+"){
            soma = num1 + num2;
        }else if (operation == "-"){
            soma = num1 - num2;
        }else if (operation == "*"){
            soma = num1 * num2;
        }else{
            soma = num1 / num2;
        }

        string result = $"{num1} {operation} {num2} = {soma}";
        Console.WriteLine(result);
    }
}