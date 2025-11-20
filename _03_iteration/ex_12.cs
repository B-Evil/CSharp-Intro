using System;
/*
 *  12. Create a guessing game following the specification below: 
 *      - Generate a random integer number from 1 to 100 (inclusive)
 *      - Let the user try to guess the number unitl it get new interval 
 *      - e.g. Generated number = 35 (The player can't see  this number)
 *      - If only one number left in the interval the player lose the game 
 *      - Try to guess a number from: 
 *          01 to 100 => 20
 *          21 to 100 => 65
 *          21 to 64 => 30
 *          31 to 64 => 41
 *          31 to 40 => 36
 *          31 to 35 => 35
 *     Congratulations you guessed the right number with 6 attempts !
 */
class Ex_12_for
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("----- Guessing Game ------");
        Console.WriteLine("--------------------------");

        Random rnd = new Random();
        int left = 1;
        int right = 100;
        int number = rnd.Next(left, ( right + 1));
        int tentativas = 0;
        int guess;

        while(true){
            Console.WriteLine($"{left} to {right}");
            Console.Write("Adivinhe um número: ");
            guess = Convert.ToInt32(Console.ReadLine());
            if(guess <= left && guess >= right) {
                Console.WriteLine("Números invalidos, Tente novemente.");
                continue;
            }
            
            if (right == left) {
                Console.WriteLine($"Você PERDEU. O número era : {number}");
                Console.WriteLine($"Tentativas: {tentativas}");
            } else if (guess == number){
                Console.Write($"Você GANHOU = {number}. Tentativas {tentativas}");
                ++tentativas;
                break;
            } else if (guess > number) {
                right = guess - 1;
                tentativas++;
            } else {
                left = guess + 1;
                tentativas++;
            }
        }
    }
}