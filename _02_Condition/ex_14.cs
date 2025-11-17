/*
 *   14. read an year print if is Leap year or Not 
 */

using System;
class If_LeapYear
{
    public static void Main(string[] args)
    {
        Console.Write("Year: ");
        double year = Convert.ToDouble(Console.ReadLine());
        //logic leapYear
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
            Console.WriteLine($"{year} is a leap year.");    
        }else{
            Console.Write($"{year} is not leap year");
        }
    }
}