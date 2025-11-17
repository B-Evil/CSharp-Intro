/*
 * 10. Read the duration od an experoment in seconds and calculate
       duration in hours, Minutues and Seconds.
 */
 using System;
 class Ex10
{
    public static void Main(string[] args)
    {
        Console.Write("Time in Seconds: ");
        int timeInSeconds = Convert.ToInt32(Console.ReadLine());
        int hours = timeInSeconds / 3600;
        int timeAux = timeInSeconds % 3600;
        int minutes = timeAux / 60;
        int seconds = timeAux % 60;
        Console.WriteLine($"{hours}H - {minutes}m - {seconds}sg");
    }
}