using System;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

public class CarApp {
    public static void Main(string[] args) {
        Car car1 = new Car("EO20T3S", "Mitsubishi","Eclips", "sedan"); 
        car1.SetYear(2023);
        car1.SetColor("Black");
        car1.Print();

        Car car2 = new Car("AAA1", "Honda", "Civic", "Sedan", 2020, "Black"); 
        car2.Print();

        Car car3 = new Car("BBB2", "Chevrolet", "Prisma", "Sedan", 2015);
        car3.Print();

        Car car4 = new Car("BBB2", "Fiat", "Fastback", "SUV", "Silver");
        car4.Print();
    }
}


public class Car {
    private string vim;
    private string maker;
    private string cartype; 
    private string model; 
    private int year; 
    private string color; 


    //Constructors
    public Car(string vim, string maker, string model, string cartype) {
        SetVim(vim);
        SetMaker(maker);
        SetModel(model);
        SetCarType(cartype);
    }

    public Car(string vim, string maker, string model, string cartype,
               int year, string color):this(vim, maker, model, cartype){
        SetYear(year);
        SetColor(color);
    }

    public Car(string vim, string maker, string model, string cartype,
               int year):this(vim, maker, model, cartype){
        SetYear(year);
    }

    public Car(string vim, string maker, string model, string cartype,
               string color):this(vim, maker, model, cartype){
        SetColor(color);
    }

    //Vim
    public void SetVim(string value){
        vim = value;
    }

    public string GetVim() {
        return vim;
    }

        //maker
    public void SetMaker(string value){ 
        maker = value;
    }

    public string GetMaker(){
        return maker;
    }

    //type
    public void SetCarType(string value){
        cartype = value;
    }

    public string GetCarType(){
        return cartype;
    }

    //model
    public void SetModel(string value){
        model = value;
    }

    public string GetModel(){
        return model;
    }

    //year
    public void SetYear(int value){
        year = value;
    }

    public int GetYear(){
        return year;
    }

    //color
    public void SetColor(string value){
        color = value;
    }

    public string GetColor(){
        return color;
    }

    public void Print(){
        Console.Write($"Vim: {GetVim()} - Maker: {GetMaker()} - Type: {GetCarType()} ");
        Console.Write($"Model: {GetModel()} - Year: {GetYear()} - Color: {GetColor()}");
        Console.WriteLine();
    }
}