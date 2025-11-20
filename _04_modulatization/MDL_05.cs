using System;
using OurCompany;
/*
 *  parameters Default 
 *  
 */
class Default_05
{
    public static void Main(string[] args)
    {
        int num1 = Library.ReadInteger("Number");
        int num2 = Library.ReadInteger("Number", "->");
        int num3 = Library.ReadInteger("Number");
        int num4 = Library.ReadInteger();
    }
    
}