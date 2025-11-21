using System;
using CompanyArray;
/*
    27. Implement a game of decoding a sequence of integer digits
        The game rules are:
        - Generate an array of random integer digits without duplication
        - Allow the player to provide 5 digits each turn
        - Show * for each digit that is in a correct position
        - Show + for each digit that is out position
        - Show - for each digit that is not part of the list
        - Keep the game until the player get all five
        Example:
        Secret: 02815
        Turn 1
        Input:  69234
        Output: --+--   
        Turn 2
        Input:  02784
        Ouput:  **-+-
        Turn 3
        Input:  02681
        Output: **-++
        Turn 4
        Input:  02851
        Output: ***++
        Turn 5
        Input:  02815
        Output: *****
        Congrats, You won!
 */
class QuestArray_27
{
    public static void Main(string[] args)
    {
        int[] sequence = GetRandomIntegers();
        int turn = 1;
        while(true){
            Console.WriteLine($"Turns {turn}");
            Console.Write("Input:  ");
            string guess = Console.ReadLine();
            if (guess.Length != sequence.Length) {
                Console.WriteLine($"Please provide {sequence.Length} digits");
                continue;
            }

            int correct = 0;
            Console.Write("Output: ");
            for (int i = 0; i < sequence.Length; i++)
            {
                int againDigit = Convert.ToInt32(guess[i].ToString());
                if (Array.IndexOf(sequence, againDigit) == -1) {
                    Console.Write("-");
                } else if (sequence[i] == againDigit) {
                    Console.Write("*");
                    correct++;
                } else {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
            if (correct == sequence.Length) {
                Console.WriteLine($"Congrats, You won! With {turn} turns.");
                break;
            }
            turn++;
        }
        
    }

    private static int[] GetRandomIntegers()
    {
        int[] array = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int[] sequence = new int[5];
        Random random = new Random();
        for (int i = 0; i < sequence.Length; i++)
        {
            int randomIndex = random.Next(i, array.Length);
            LibraryArray.SwapArray(array, i, randomIndex);
        }
        Array.Copy(array, 0, sequence, 0, sequence.Length);
        return sequence;
    }
}