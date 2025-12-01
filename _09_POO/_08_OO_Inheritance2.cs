using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace OurCompany.LearnCoding.OOP.Inheritance3;
public class HospitalApp{
    public static void Main(string[] args){ // PERSON
        Person person1 = new Person {
            FirstName = "Bruno",
            LastName = "Santiago",
            Email = "brunosantiago@email.com",
            Phone = "(77) 9999-9999"
        };
        person1.Print();

        Patient patient1 = new Patient {  //PATIENT
            FirstName = "Osmar",
            LastName = "Rodrigues",
            Email = "osmarR@email.com",
            PatientID = "001",
            Symptoms = "Fever"
        };
        patient1.Print();

        Nurse nurse1 = new Nurse{ //Nurse
          FirstName = "Thiago",
          LastName = "Rodrigues",
          Email = "thiagoR@gmail.com",
          Phone = "(175) 0000-000",
          EmployeeID = "yee-002",
          BankAccountInfo = "Bank - Exo Acc - 203",
          StartDate = "2027 - 04",
          NurseID = "nu-203",
          Shift = "Morning"
        };
        nurse1.Print(); 
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

    public void Print(){
        Console.WriteLine($"Person");
        Console.WriteLine($"Full Name Name: {FullName}");
        Console.WriteLine($"E-mail: {Email}");
        Console.WriteLine($"Phone: {Phone}");
    }
}

public class Patient : Person{
    public string PatientID {get; set;}
    public string Symptoms {get; set;}

    public void Print(){
        base.Print(); 
        Console.WriteLine("Patient");
        Console.WriteLine($"Patient ID: {PatientID}");
        Console.WriteLine($"Symptoms: {Symptoms}");
        Console.WriteLine();
    }
}

public class Employee : Person{
    public string EmployeeID {get; set;}
    public string BankAccountInfo {get; set;}
    public string StartDate {get; set;}

    public void Print(){
        base.Print();
        Console.WriteLine("Employee");
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Bank Account: {BankAccountInfo}");
        Console.WriteLine($"Start Date: {StartDate}");
    }
}

public class Nurse : Employee{
    public string NurseID {get; set;}
    public string Shift {get; set;}
    public void Print(){
        base.Print();
        Console.WriteLine("Nurse");
        Console.WriteLine($"Nurse ID: {NurseID}");
        Console.WriteLine($"Shift: {Shift}");
        Console.WriteLine();
    }
}


//HomeWork creat new Class Doctor
public class Doctor : Employee{
    public string DoctorID {get; set;}
    public string Specialization {get; set;}
    public void Print() {
        base.Print(); 
        Console.WriteLine($"Doctor");
        Console.WriteLine($"Doctor Id : {DoctorID}");
        Console.WriteLine($"Specialization: {Specialization}");
    }
}