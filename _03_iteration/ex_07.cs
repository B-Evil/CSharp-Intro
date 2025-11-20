using System;
/*
 *  07. Read integer numbers (flag = empty) and print smallets
 *      value and it's frenquency.
 */
class Ex_07_for
{
    public static void Main(string[] args)
    {
        string enterNum;
        int? number = null;
        int? lowest = null;
        int frequency = 0;
        do {
            Console.Write("Enter number: ");
            enterNum = Console.ReadLine();
            if (enterNum != string.Empty) {
                number = Convert.ToInt32(enterNum);
                if ( (!lowest.HasValue) || (number < lowest)) {
                    frequency = 1;
                    lowest = number;
                } else if (number == lowest) {
                    frequency++;    
                }
            }
        } while (enterNum != string.Empty);
        if(lowest.HasValue) {
            Console.WriteLine($"Lowest: {lowest}, frequency: {frequency} ");
        }else{
            Console.WriteLine("Nenhum valor foi informado...");
        }
    }
    
}