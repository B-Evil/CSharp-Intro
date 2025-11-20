using System;
using System.Runtime.CompilerServices;
/*
 *  04. Read integer numbers (flag = empty) and print the avarege.
 */
class Ex_04_for
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int count = 0; 
        while(true){
            Console.Write("Type a number: ");
            string numAsString = Console.ReadLine();
            if (numAsString == "") {
                break;
            }
            int num = Convert.ToInt32(numAsString);
            sum += num;
            count++;
        }

        if(count == 0) {
            Console.WriteLine("No numbers Entered!");
        }else {
            double avarege = sum / (double) count;
            Console.WriteLine($"Avarege: {avarege}");
        }

    }
}
