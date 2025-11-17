/*
 *      Switch -> Get the day of the week description from the number
 *         -Saturday and Sunday
 *         - Monday and tuesday 
 *         - Wednesday and Thursday 
 *         - Friday 
 */
using System;
class SWITCH
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--------- Weekdays ----------");
        Console.Write("Type a day.");
        int days = Convert.ToInt32(Console.ReadLine());
        string weekday;
        switch (days) {
            case 1:
                weekday = "Sunday";
                break;
            case 2:
                weekday = "Monday";
                break;
            case 3:
                weekday = "Tuesday";
                break;
            case 4:
                weekday = "Wednesday";
                break;
            case 5:
                weekday = "Thursday";
                break;
            case 6:
                weekday = "Friday";
                break;
            case 7:
                weekday = "Saturday";
                break;
            default:
                weekday = $"Your day #{days} is invalid";
            break;
        }
    } 
}