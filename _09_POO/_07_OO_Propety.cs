using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
/*
    # Properties are used to encapsulate fields and provide a way to access them.
    # They are similar to methods, but they are accessed like fields.
    # There are two types of properties: auto-implemented properties and custom properties.
    # Auto-implemented properties have a get and a set accessor, but no implementation. 
        The compiler will automatically generate a backing field for the property.
    # Custom properties have a get and a set accessor, and a custom implementation. 
        This allows you to perform additional logic when the property is accessed or modified.

    # Class Content:
      # 1. Attribute with Set and Get
      # 2. Custom Property
      # 3. Auto-implemented Property
      # 4. Auto-implemented Property with "expression-bodied syntax"
*/

namespace OurCompany.LearnCoding.OOP.Property;
public class Car_Pr {
    public static void Main(string[] args){
        Car car1 = new Car(); 
        car1.SetVin("OES20T3");
        string vin = car1.GetVin();
        Console.WriteLine($"Vin: {vin}");

        car1.Maker = "Honda";
        string maker = car1.Maker;
        Console.WriteLine($"Maker: {maker}");

        car1.Model = "Civic";
        string model = car1.Model;
        Console.WriteLine($"Model: {model}");

        car1.Year = 2025; 
        int year = car1.Year;
        Console.WriteLine($"Year: {year}");
    }
}

public class Car {
    private string vin; 
    public void SetVin(string value){
        vin = value;
    }
    public string GetVin(){
        return vin;
    }

    private string maker; 
    public string Maker{
        set{
            maker = value;
        }
        get
        {
            return maker;   
        }
    }

    public string Model {set; get;}

    private int year; 
    public int Year {get => year; set => year = value;}
}