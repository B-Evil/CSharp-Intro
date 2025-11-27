/*
    #-> Encapsulation is the wrappping up of data and information inside
         a class, and offer methods/properties to a access them.
    #-> It is achieved by declariing attributes (and some methods) as private
        and using methods/properities to access them.
    #-> there are four access modifiers that can be used to crontol the
        visibility:
            public: Anywhere
            private: Only inside the class
            protected: Only inside the Class and sub-classes
            internal: Only inside the same A internal: Only inside the same    
            Assembly (EXE, DLL or Project)
    # Class Content:
         # 1. Review Namespace
        # 2. Create a new class Car
*/

using System;
using System.Runtime.CompilerServices;

namespace OurCompany.LearnCoding.OOP.Encapsulation; 
public class Car_App {
    public static void Main(string[] args){ 
       Car car1 = new Car("OES203T", "Porsche", "911");
       Console.WriteLine($"Vim: {car1.GetVim()} - Maker: {car1.GetMaker()} - Model: {car1.GetModel()}");
       //car1.SetVim() private
    }
}

public class Car{
    private string vin; 
    private string model; 
    private string maker;

    //Constructor
    public Car(string vin, string maker, string model){
        SetVim(vin);
        SetMaker(maker);
        SetModel(model);
    }

    //vim
    private void SetVim(string value){
        if(String.IsNullOrEmpty(vin)){
            throw new Exception("Erro.. Vim is required");
        }
        this.vin = value;
    }
    public string GetVim(){
        return vin;
    }

    //maker
    public void SetMaker(string value){
        if(String.IsNullOrEmpty(maker)){
            throw new Exception("Erro.. maker is required");
        }
        this.maker = value;
    }
    public string GetMaker(){
        return maker;
    }

    //model
    public void SetModel(string value){
        if(String.IsNullOrEmpty(model)){
            throw new Exception("Erro... Model is required");
        }
        this.model = value;
    }
    public string GetModel(){
        return model;
    }

}