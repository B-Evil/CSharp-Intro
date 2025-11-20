using System;
/*
 *    The class Random Represents a pseudo-number generator,
 *        which is an algorithm that produces a sequence of numbers that
 *        meet certain statistical requirements for randomness
 */
class Ex_radom_for
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int number1 = rnd.Next(); //Greater or equals to 0 and smaller than int32.Maxvalue
        int number2 = rnd.Next(10);//Greater or equals to 0 and smaller than 10
        int number3 = rnd.Next(10, 15);//Greater or equals to 10 and smaller than 15

        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);

    }
    
}