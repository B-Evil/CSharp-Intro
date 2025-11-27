/*
    # Customer
        Attributes
             * First Name
             * Last Name
             * Phone Number
             * Email
             * Username
             * Password
        Attributes
    # Customer
*/

using System;

public class Customer {
    private string firstName; 
    private string lastName;

    public Customer(string firstName, string lastName){
        SetName(firstName);
        SetLastName(lastName);
    }
    public void SetName(string firstName) {
        if (string.IsNullOrEmpty(firstName)) {
            throw new Exception("Erro.. First is required");
        }
        this.firstName = firstName;
    }

    public string GetFirstName() {
        return firstName;
    }

    public void SetLastName(string lastName) {
        if(string.IsNullOrEmpty(lastName)){
            throw new Exception("Erro.. Last i required");
        }
        this.lastName = lastName; 
    }

    public string GetLastName(){
        return lastName;
    }

    public string GetFullName (){
        return $"{GetFirstName()} {GetLastName()}";
    }
}

public class _04_OO_Class_App {
    public static void Main (string[] args) {
        Customer customerA =  new Customer("Bruno", "Santiago"); 
        Console.WriteLine($"Fullname: {customerA.GetFullName()}");
    }
}