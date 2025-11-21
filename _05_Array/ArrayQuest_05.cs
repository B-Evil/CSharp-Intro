using System;
/*
 *  05. implement a routine to calculate the avarege of an array 
 *      of integers: double ArrayAvarege(array).
 */
class QuestArray_05
{
    public static void Main(string[] args)
    {
        int[] array = [17, 33, 40, 85, 6, 8];
        double avarege = ArrayAvarege(array);

        //Unit-test -> case 01
        Console.WriteLine($"Test Avarege. Result: {avarege == (double)31.5}");
    }

    private static double ArrayAvarege(int[] array)
    {
        long sum = 0; 
        for (int i = 0; i < array.Length; i++) {
            sum += array[i];
        }

        return sum / (double) array.Length;
    }
    

    /*  
     *   -   O professor deu dois exemplos. utilizamos o primeiro exemplo   
     *        que usa apenas uma sub-rotina para calcular a média do array.
     * 
     *   -   Porém em alguns casos é melhor quebrar a rotina em duas ou mais 
     *        sub-rotinas.
     */ 
} 



