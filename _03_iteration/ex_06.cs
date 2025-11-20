using System;
/*
 *  06. Read integer numbers (flag = empty) and print the two highest
 */
class Ex_06_for
{
    public static void Main(string[] args)
    {
        string enterNum;
        int number;
        int? highest1 = null;
        int? highest2 = null;
        do {
            Console.Write("Number: ");
            enterNum = Console.ReadLine();
            if(enterNum != string.Empty){
                number = Convert.ToInt32(enterNum);
                if (!highest1.HasValue){
                    highest1 = number;
                }else if (number > highest1) {
                    highest2 = highest1;
                    highest1 = number;
                }else if (number != highest1 &&((!highest2.HasValue) || (number > highest2))){
                    highest2 = number; 
                }             
            }
        } while (enterNum != string.Empty);
        if(highest1.HasValue){
            Console.WriteLine($"Highest 1: {highest1}");
            if (highest2.HasValue) {
                Console.WriteLine($"Highest 2: {highest2}");
            }
        }else{
            Console.Write("Nnenhum valor foi informado...");
        }
    }
    
}