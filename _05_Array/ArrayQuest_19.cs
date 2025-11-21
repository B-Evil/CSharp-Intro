using System;
/*
 *      19. implement A routine to indicate if an array is in ascendent order
 *  
 */
class QuestArray_19
{
    public static void Main(string[] args)
    {
        int[] a1 = { 1, 2, 3, 7, 9 }; //True
        int[] a2 = { 1, 2, 3, 7, 9, 4 }; //False
        int[] a3 = { 1, 2, 3, 7, 7, 9 }; //False
        int[] a4 = { 1, 2, 3, 7, 9, 9 }; //False

        Console.WriteLine($"{IsAncendingOrder(a1)}");
        Console.WriteLine($"{IsAncendingOrder(a2) == false}");
        Console.WriteLine($"{IsAncendingOrder(a3) == false}");
        Console.WriteLine($"{IsAncendingOrder(a4) == false}");
    }

    private static bool IsAncendingOrder(int[] array)
    {
        //temos que diminuir o tamnho do array para o loop não quebrar 
        for(int i = 0; i < array.Length - 1; i++) {
            if (array[i] >= array[i + 1])
            {
                return false;
            } 
        }

        return true;
    }
}