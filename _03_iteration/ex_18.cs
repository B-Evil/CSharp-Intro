using System;
/*
 *  18. Raad an integer number H and print a Christmas tree with height H.
 *  e.g.
 *  Height = 7
 */
class Ex_18_for
{
    public static void Main(string[] args)
    {
        const char STAR = '*';
        const char SPACE = ' ';
        const char LEAFS = '.';
        const char TRUCK = '|';

        Console.Write("Height: ");
        int height = Convert.ToInt32(Console.ReadLine());
        int space = height - 1;
        int leafs = 1;

        for (int row = 1;  row <= height; row++) {
            for(int i = 1; i <= space; i++) {
                Console.Write(SPACE);
            }
            if (leafs == 1) {
                Console.Write(STAR);
            } else {
                for (int i = 1; i <= leafs; i++) {
                    Console.Write(LEAFS);
                }
            }
            Console.WriteLine();
            space--;
            leafs += 2;
        }
        for (int truck = 1; truck <= height / 2; truck++) {
            for (int i = 1; i <= height - 1; i++) {
                Console.Write(SPACE);
            }
            Console.WriteLine(TRUCK);
        }    
    }
    
}
