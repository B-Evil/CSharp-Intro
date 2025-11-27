using System;
using System.Reflection.Metadata;
namespace OurCompany.LearnCoding.OOP.PropertyDemo;
public class Car_App {
    public static void Main(string[] args) {
        Car car1 = new Car(); 
        car1.Vin = "OES203T";
        car1.Maker = "porsche"; 
        car1.Model = "Carrera";
        car1.Year = 2024; 
        Console.WriteLine($"Vin: {car1.Vin} - Maker: {car1.Maker} - Model: {car1.Model} - Year: {car1.Year}");       

        var car2 = new Car
        {
            Vin = "WES204T", 
            Maker = "Ferrai",
            Model = "488",
            Year = 2025    
        };
        Console.WriteLine($"Vin: {car2.Vin} - Maker: {car2.Maker} - Model: {car2.Model} - Year: {car2.Year}");

    }
}

public class Car {
    public string Vin {get; set;}
    public string Maker {get; set;}
    public string Model {get; set;}
    public int Year {get; set;}
}