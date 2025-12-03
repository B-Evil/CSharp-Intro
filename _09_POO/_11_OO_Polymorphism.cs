using System;
using System.Runtime.InteropServices;
/*
# Polymorphism is a concept that allows objects of different classes
  to be treated as if they were objects of the same class.
# It is achieved through inheritance, where a subclass can inherit 
  properties and methods from its superclass and override them.
# Polymorphism allows you to write code that can work with objects
  of different classes in a uniform way, making your code more
  simple, flexible and reusable.

# Class Content
  # Recreate the example of Hospital Classes (Copy from _08_OO_Inheritance3.cs)
  # Use the method PrintBadge as vitual/override
  # Store objects in a Array of Person
  # Loop and call the method PrintBadge
  # Show how to check and cast to a specific object type using the operator: is
*/

namespace OurCompany.LearnCoding.OOP.Polymorphism;
public class Polymorphism {
    public static void Main(string[] args){
        Person[] personDB = new Person[10]; 
        personDB[0] = new Patient{
            FirstName = "Maisla",
            LastName = "Rodrigues",
            Email = "rmaisl@noemail.com",
            Phone = "(00) 3333-333",
            PatientID = "P=1001",
            Symptoms = "Fever"
        };

        personDB[1] = new Nurse{
            FirstName = "Silvia",
            LastName = "Santiago",
            NurseID = "NU-004",
            Email = "ssantiago@noemail.com",
            Phone = "(00) 5555-333",
            Shift = "Night",
            EmployeeID = "Em-029", 
            StartDate = "20 / 04 / 2015",
            BankAccountInfo = "Bank: nu - Account: 777"
        };

        personDB[2] = new Doctor{
            FirstName = "Osmar",
            LastName = "Almeida",
            Email = "aosmar@noemail.com",
            Phone = "(22) 4444-444",
            EmployeeID = "Em-023",
            StartDate = "04 / 03 / 2020",
            BankAccountInfo = "Back: In - Accnt: 000",
            DoctorID = "Doc-023",
            Specialization = "cardiac"
        };

        personDB[3] = new Doctor{
            FirstName = "Bruno",
            LastName = "Santiago",
            Email = "sbruno@noemail.com",
            Phone = "(00) 7777-6666",
            EmployeeID = "Em-0203",
            StartDate = "06 / 07 / 2010",
            BankAccountInfo = "Back: Bit - Accnt: 777",
            DoctorID = "Doc-077",
            Specialization = "images"
        };

        for(int i = 0; i < 4; i++){
            if(personDB[i] is Nurse){
                Nurse nurse = (Nurse) personDB[i]; 
                Console.WriteLine($"Nurse: {nurse.FullName} - Shift: {nurse.Shift}");
            }
        }

        for(int i = 0; i < 4; i++) {
            if(personDB[i] is Doctor){
                Doctor doctor = (Doctor) personDB[i]; 
                Console.WriteLine($"Doctor: {doctor.FullName} - Spetialization: {doctor.Specialization} ");
            }
        }

    }
}


public class Person{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string FullName {
        get{
            return $"{FirstName} {LastName}";
        }
    }
    public string Email {get; set;}
    public string Phone {get; set;}

    public virtual void PrintBadge(){
        Console.WriteLine($"Person");
        Console.WriteLine($"Full Name Name: {FullName}");
        Console.WriteLine($"E-mail: {Email}");
        Console.WriteLine($"Phone: {Phone}");
    }
}

public class Patient : Person{
    public string PatientID {get; set;}
    public string Symptoms {get; set;}

    public override void PrintBadge(){
        Console.WriteLine("Patient");
        base.PrintBadge(); 
        Console.WriteLine($"Patient ID: {PatientID}");
        Console.WriteLine($"Symptoms: {Symptoms}");
        Console.WriteLine();
    }
}

public class Employee : Person{
    public string EmployeeID {get; set;}
    public string BankAccountInfo {get; set;}
    public string StartDate {get; set;}

    public override void PrintBadge(){
        Console.WriteLine("Employee");
        base.PrintBadge();
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Bank Account: {BankAccountInfo}");
        Console.WriteLine($"Start Date: {StartDate}");
    }
}

public class Nurse : Employee{
    public string NurseID {get; set;}
    public string Shift {get; set;}
    public override void PrintBadge(){
        Console.WriteLine("Nurse");
        base.PrintBadge();
        Console.WriteLine($"Nurse ID: {NurseID}");
        Console.WriteLine($"Shift: {Shift}");
        Console.WriteLine();
    }
}


public class Doctor : Employee{
    public string DoctorID {get; set;}
    public string Specialization {get; set;}
    public override void PrintBadge() {
        Console.WriteLine($"Doctor");
        base.PrintBadge(); 
        Console.WriteLine($"Doctor Id : {DoctorID}");
        Console.WriteLine($"Specialization: {Specialization}");
    }
}