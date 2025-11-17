/*
 *  11. Read the current hour (military time: 0 to 23) and print the
 *      appropriate salutationn: Good morning
 *                               Good Afternoon 
 *                               Good evening 
 *                               Good night
 */

using System;
class If_Hour
{
    public static void Main(string[] args)
    {
        Console.Write("Typer the current hour (military): ");
        int hour = Convert.ToInt32(Console.ReadLine());
        
        if (hour >= 5 && hour <= 12) {
            Console.Write("Good morning");
        } else if (hour >= 13 && hour <= 17) {
            Console.Write("Good afternoon");
        }else if (hour >= 18 && hour <= 20){
            Console.Write("Good evening");
        }else{
            Console.Write("Good night");
        }
    }
}