using System;
using System.Reflection.Metadata;
/*
 *  10. Implement a routine to check if an array of integer
 *      is palindrome.
 */
class QuestArray_10
{
    public static void Main(string[] args)
    {
        //palindrome
        int[] arr1 = { 4, 7, 9, 0, 9, 7, 4 };
        Console.WriteLine($"Test 01 Palindrome = {isPalindrome(arr1)}");

        int[] arr2 = { 1, 2, 3, 4, 4, 3, 2, 1 };
        Console.WriteLine($"Test 02 Palindrome = {isPalindrome(arr2)}");
        
        int[] arr3 = { 3, 4, 8, 6, 0, 8, 4, 3};
        Console.WriteLine($"Test 03 Palindrome = {isPalindrome(arr3)}");
    }

    public static bool isPalindrome(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            if (array[left] != array[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}