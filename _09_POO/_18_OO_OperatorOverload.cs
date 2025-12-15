using System;
using System.Linq;
/*
# Operator overloading allows a user-defined type to define the behavior
   of an operator when applied to its instances.
# A user-defined type can overload a predefined C# operator. That is, a 
  type can provide the custom implementation of an operation in case one
  or both of the operands are of that type.
# The operator keyword is used to declare an operator.
# An operator declaration must include both a public and a static modifier.
# A unary operator has one input parameter, while a binary operator has two
  input parameters.
# Sintaxe:
  # public static [RETURN_TYPE] operator [OPERATOR] ([TYPE] object1, [TYPE] object2)
# The following table shows the operators that can be overloaded:
Operators	                                 Notes
+x, -x, !x, ~x	                           Unary operators
++, --                                     Increment and decrement operators
+, -, *, /, %, &, |, ^, <<, >>             Arithmetic and bitwise operators
==, !=, <, >, <=, >=	                     Comparison operators
+=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=   Compound assignment operators

# Class Content
  # Example 1:
    # Create a class Point: X, Y and ToString
    # Overload the + operator
      # Add X and Y
  # Example 2:
    # Create a class Person: FirstName, LastName, ToString
    # Overload the == operator
  # Homework:
    # Overload the unary operators ++ and -- in the Point class
    # ++ = Add 1 to X and Y
    # -- = Substract 1 from X and Y
*/
namespace OurCompany.LearnCoding.OOP.OpOverload;
public class OverloadApp{
    public static void Main(string[] args){
      Point pointA = new Point{
          X = 10,
          Y = 20
      };
      Console.WriteLine(pointA);
      Point pointB = new Point{
          X = 30,
          Y = 40
      };
      Console.WriteLine(pointB);
      Point newPoint = pointA + pointB;
      Console.WriteLine(newPoint);
      Console.WriteLine("");

      //exemplo 02
      Person personA = new("Bruno", "Santiago");
      Console.WriteLine(personA);

      Person personB = new("Bruno","Santiago");
      Console.WriteLine(personB);

      Person personC = new("Bruno","Rodrigues");
      Console.WriteLine(personC);

      Person personA2 = personA;
      Console.WriteLine(personA2);

      Console.WriteLine($"personA == personB = {personA == personB}");
      Console.WriteLine($"personA == personC = {personA == personC}");
      Console.WriteLine($"personA == personA2 = {personA == personA2}");

      Point soma = pointA++;
      Console.WriteLine($"soma: {soma}"); 
      Point subtracao = pointA--;
      Console.WriteLine($"subtração: {subtracao}"); 
    }
}

public class Point{
  public int X { get; set; }
  public int Y { get; set; }

  public override string ToString()
  {
      return $"[X: {X} - Y: {Y}]";
  }

  public static Point operator + (Point left, Point right){
    Point newPoint = new Point{
      X = left.X + right.X,
      Y = left.Y + right.Y
    };
    return newPoint;
  }

  public static Point operator ++ (Point soma){
    Point newSum = new Point{
      X = soma.X += 10, 
      Y = soma.Y += 5
    };
    return newSum;
  }

  public static Point operator -- (Point decremento){
    Point subtracao= new Point{
      X = decremento.X -= 10,
      Y = decremento.Y -= 5
    };
    return subtracao; 
  }
}

public class Person{
  public string FirstName { get; set; }
  public string LastName { get; set; }

  public Person(string first, string last){
    FirstName = first;
    LastName = last;
  }

  public override string ToString(){
    return$"[Person: {FirstName} {LastName}]";
  }

  public static bool operator == (Person left, Person right){
    return left.FirstName == right.FirstName &&
           left.LastName == right.LastName;
  }

  public static bool operator != (Person left, Person right){
    return !(left == right);
  }

  public override bool Equals(object obj){
    if(obj is Person){
      return this == (Person) obj;
    } else {
      return false;
    }
  }
  public override int GetHashCode(){
    return FirstName.GetHashCode()+LastName.GetHashCode();
  }
}