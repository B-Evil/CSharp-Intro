/*
 *  06 - Read the buying price (cost), the desired profit percentage and calculete the sales price of product.
 */

using System;
class SalePrice
{
    public static void Main(string[] args)
    {
        Console.Write("Type the buying price: ");
        double buyPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Type the desired profit: ");
        double profit = Convert.ToDouble(Console.ReadLine());
        double salesPrice = (buyPrice * profit) / 100;
        double productFinal = buyPrice + salesPrice;
        string message = $"The Sales price is $: {productFinal}";
        Console.WriteLine(message);
    }
}