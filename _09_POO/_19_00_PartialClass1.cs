using System;
/*
# Partial classes allow you to split the definition of a class or
  interface over multiple files.
# Each file contains a section of the type definition, and all 
  parts are combined when the application is compiled.
# It is also useful when working with automatically generated source
  code, as code can be added to the class without having to recreate
  the source file.
# To split a class definition, use the partial keyword modifier.
# All the parts must use the partial keyword, and all the parts must
  be available at compile time to form the final type.

# Class Content:
  # Create a class using partial in two files
*/

namespace OurCompany.LearnCoding.OOP.PartialClass;
public class PartialApp{
    public static void Main(string[] args){
        Customer cliente = new Customer("Evil", 203);
        Console.WriteLine(cliente);
    }
}

public partial class Customer{
    public int ID { get; set; } 
    public Customer(string Name, int ID){
        this.Name = Name;
        this.ID = ID;
    }
}