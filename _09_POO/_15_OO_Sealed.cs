using System; 

/*
# The sealed keyword is used to prevent a class from being inherited
  by other classes or a method/property to be overriden.
# That means a sealed class cannot have a sub/derived class.
# You can also use the sealed modifier on a method or property that 
  overrides a virtual method or property from a base class. 
# When you define new methods or properties in a class, you can prevent
  deriving classes from overriding them by not declaring them as virtual.
# It is an error to use the abstract modifier with a sealed class, because
  an abstract class must be inherited by a class that provides an 
  implementation of the abstract methods or properties.

# Class Content
  # Create an example to show it:
    - MyBaseClass
    - MySubClass
    - MySubSubClass
    - Defines a method to PrintID
    - Show the SubClass as sealed
    - Show without virtual/override
    - Show with virtual/override
    - Show the PrintID as sealed
  # 

 */

namespace OurCompany.LearnCoding.OOP.Sealed;
public class SealedApp{
    public static void Main(string[] args){
        BaseClass baseObject = new BaseClass{
            ID = "B-ID 001",
            Name = "Name 1"
        };
        baseObject.PrintID();

        SubClass subObject = new SubClass{
            ID = "S-ID 001",
            Name = "Sub Name",
            specialization  = " Sub Spec 1"
        };
        subObject.PrintID();

        BaseClass SubObjectCopy = subObject;
        SubObjectCopy.PrintID();

        SsubClass ssubObject = new SsubClass{
          ID = "ss -ID 001",
          Name = "Name ss class", 
          Location = "Brasil", 
          specialization = "ss spec 01"
        };
        ssubObject.PrintID();
    }
}

public class BaseClass{
    public string ID { get; set; }
    public string Name { get; set; }

    public virtual void PrintID(){
        Console.WriteLine($"ID: {ID.ToUpper()}");
    }
}

public class SubClass : BaseClass{
    public string specialization { get; set; }

    public override sealed void PrintID(){
        Console.WriteLine($"ID: {ID.ToLower()}");
    }
}

public class SsubClass : SubClass{
    public string Location {get; set;}
   // public override void PrintID(){
   //     Console.WriteLine($"ID: {ID}");
   // }
}