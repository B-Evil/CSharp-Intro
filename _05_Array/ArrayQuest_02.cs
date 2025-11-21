using System;
using CompanyArray;
using OurCompany;
/*
 *  02.Implement a routine to read an array of integers
 *     from the Console: int[] ReadIntArray(string: label
 *     ,int: length) Use 'Label[index] = ' for each Element
 */
class QuestArray_02
{
    public static void Main(string[] args)
    {
        int tamanho = Library.ReadInteger("Number", ": ");
        int[] myArray1 = LibraryArray.ReadIntArray("My Array", tamanho);
        LibraryArray.PrintIntArray(myArray1, "Array ");
    }
    
}