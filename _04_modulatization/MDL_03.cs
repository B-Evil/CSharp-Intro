using System;
using OurCompany;
/*
 *  18. Raad an integer number H and print a Christmas tree with height H.
 *  e.g.
 *  Height = 7
 */
class Intro_Modulo3
{
    public static void Main(string[] args)
    {
        const char CLEAR = ' ';
        const char LEAFS = '.';
        const char STAR = '*';
        const char TRUCK = '|'; 

        int height = Library.ReadInteger("Height: ");
        int space = height - 1;
        int folhas = 1;

        for (int level = 1; level <= height; level++) {
            Library.RepeatPrime(CLEAR, space);

            if (folhas == 1) {
                Console.Write(STAR);
            } else {
                Library.RepeatPrime(LEAFS, folhas);
            }
            Console.WriteLine();
            space--;
            folhas += 2;
        }

        for (int i = 1; i <= height / 2; i++) {
            Library.RepeatPrime(CLEAR, height - 1);
            Console.WriteLine(TRUCK);
        }
    }
    
}
