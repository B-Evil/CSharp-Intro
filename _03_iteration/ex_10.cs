using System;
/*
 *      10. Create a multipication table game following the specification below: 
 *          - The game must ask muyiplication question using random numbers from 0 yo 9.  
 *          e.g  3 x 9 = ? 
 *               7 x 8 = ?
 *               0 x 2 = ? 
 * 
 *          The game ends when hte user type an empty value or if the user get 5 
 *          incorrect answer;
 *          - At the end of the game print the score showing the number  of correct and
 *            incorrect answer.
 */
class Ex_10_for
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int correct = 0;
        int incorrect = 0;
        int result = 0;
        int num1 = 0;
        int num2 = 0;
        string guessStr;
        int guess = 0;

        while (true){
            num1 = rnd.Next(11);
            num2 = rnd.Next(11);
            result = num1 * num2;
            Console.Write($"{num1} x {num2} = ");
            guessStr = Console.ReadLine();

            if (guessStr == string.Empty) { break; }
            guess = Convert.ToInt32(guessStr);
            if (guess == result){
                correct++;
                Console.WriteLine("Correct");
            }
            else{
                incorrect++;
                Console.WriteLine("Incorrect");
            }

            if (incorrect == 5){
                break;
            }
        }
        ;

        Console.WriteLine($"Correct answers : {correct}");
        Console.WriteLine($"Incorrect answers : {incorrect}");
    }
    
}
