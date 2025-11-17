/*
 * 07. Read trhe buying price (cost), the sired
 *     profit percentege and the thse sales tax % 
 *     and calculate the final sales price of a product.  
 */

using System;
class SalesTax
{
    public static void Main(string[] args)
    {
        Console.Write("Buying Price: ");
        double buyingPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Profit percentege: ");
        double profitPercentege = Convert.ToDouble(Console.ReadLine());
        Console.Write("Sales tax percentege: ");
        double salesTaxPercentege = Convert.ToDouble(Console.ReadLine());

        double profit = (buyingPrice * profitPercentege) / 100;
        double salePrice = buyingPrice + profit;
        double saletax = (salePrice * salesTaxPercentege) / 100;
        double finalProduct = salePrice + saletax;

        Console.Write($"Profit: {profit}");
        Console.WriteLine($"Sales tax: {saletax}");
        Console.WriteLine($"Final Sale: {finalProduct}");
    }
}