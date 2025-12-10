using System;
/*
# An abstract class is a class that cannot be instantiated.
  It can only be used as a base class for other classes.
# An abstract class can contain abstract methods (methods without a body)
  and non-abstract methods (methods with a body).
# When a non-abstract class inherits an abstract class, it should 
  provide an implementation of the abstract methods.
# An abstract method can only be present inside an abstract class.
# The abstract keyword is used to create an abstract class or method.
# An abstract class:
  # Can have access modifiers like public, private, protected, etc.
  # Can have fields, properties, constructors, events, indexers,
    operators, finalizers, and static constructors.
  # Can inherit from another abstract class or a non-abstract class.
  # Can implement an interface.
  # Can NOT be sealed.

# Class Content
  # Use example Inheritance2
    # Instatianed the Shap class
    # Make the Shap class abstract
    # Try to instantiated the Shap class
    # Define a new abstract method

# Homework:
  Implement the GetArea methods for Circle and Square
 */
namespace OurCompany.LearnCoding.OOP.Abstract;

public class AbstractApp{
    public static void Main(string[] args){
        Square square = new Square("Red", "black", 5, new Point(1, 5), new Point(3, 4));
        
    }
}

public class Point{
  public int X { get; set; }
  public int Y { get; set; }

  public Point (int x, int y){
    X = x; 
    Y = y;
  }
}

public abstract class Shape {
  public string BorderColor {set; get;} 
  public int BorderWidth {set; get;} 
  public string BackgroundColor {set; get;}

  public Shape (string borderColor, string backgroundColor, int borderWidth) {
    BorderColor = borderColor; 
    BorderWidth = borderWidth; 
    BackgroundColor = backgroundColor;
  }

  public abstract double GetArea();
}

public class Triangle : Shape{
  public Point Point1 {set; get;}
  public Point Point2 {set; get;}
  public Point Point3 {set; get;}
  public Triangle (string borderColor, string backgroundColor, int borderWidth,
                   Point point1, Point point2, Point point3) : base(borderColor, backgroundColor, borderWidth){
    Point1 = point1;
    Point2 = point2;
    Point3 = point3;
  }

    public override double GetArea(){
        Console.WriteLine("Area of Trinagle");
        return 15;
    }
}

public class Square : Shape{
  public Point Point1 {set; get;}
  public Point Point2 {set; get;}
  public Square (string borderColor, string backgroundColor, int borderWidth,
                  Point point1, Point point2) :  base(borderColor, backgroundColor, borderWidth){
    Point1 = point1;
    Point2 = point2;
  }
    public override double GetArea(){
        Console.WriteLine("Area of square");
        return 4;
    }
}

public class Circle : Shape {
  public Point Center {set; get;}
  public int Radius {set; get;}
  public Circle (string borderColor, string backgroundColor, int borderWidth, 
                 Point center, int radius) : base(borderColor, backgroundColor, borderWidth){
    Center = center; 
    Radius = radius;
  }

    public override double GetArea(){
        Console.WriteLine("Area of Circle");
        return 35;
    }
}

public class Rectangle : Shape {
  public Point Point1 {set; get;}
  public Point Point2 {set; get;}
  public Point Point3 {set; get;}
  public Point Point4 {set; get;}
  public Rectangle (string borderColor, string backgroundColor, int borderWidth,
                     Point point1, Point point2, Point point3, Point point4)
                     : base(borderColor, backgroundColor , borderWidth){
    Point1 = point1;
    Point2 = point2;
    Point3 = point3;
    Point4 = point4;
  }

    public override double GetArea(){
        Console.WriteLine("Area of Rectangle");
        return 54;
    }
}