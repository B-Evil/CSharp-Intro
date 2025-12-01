/*
# Inheritance is a feature that allows the definition of a base class
  that provides specific functionality and to define derived classes
  that either inherit or override that functionality.
# The class whose members are inherited is called the base/super class, and
  the class that inherits those members is called the derived/sub class.
# A derived class can have only one direct base class. However,
  inheritance is transitive, which allows you to define an inheritance
  hierarchy for a set of types.
# Constructos are not inherited by derived classes.
# To inherit from a class, use the : symbol
  e.g: public class Triagle : Shape {...}
# It is possible to reuse a Construtor from a base class by adding : base(params)
  on a sub-class constructor
# Class Content:
  # Overview using a diagram for Sharp:
    Triangle
    Square
    Rectangle
    Circle
  # Attributes:
    Common: BackgroundColor, BorderColor, BorderWidth
    Triangle: Points (3)
    Square: Points (2)
    Rectangle: Points(4)
    Circle: Point + Radius
 */

using System;
namespace OurCompany.LearnCoding.OOP.Inheritance;
public class ShapeApp{
  public static void Main(string[] args){
    Triangle t1 = new Triangle("Pink", "Gold", 5, new Point(1, 10),
                                                  new Point(4, 9),
                                                  new Point(15, 17) ); 
    Console.WriteLine($"tringle: {t1.BorderColor} - {t1.BorderWidth} - {t1.BackgroundColor}");
      
    Square s1 = new Square("Black", "White", 10, new Point(4, 9),
                                                 new Point(2, 13));
    Console.WriteLine($"Saquare: {s1.BorderColor} - {s1.BorderWidth} - {s1.BackgroundColor}");

    Circle c1 = new Circle("White", "Black", 5 , new Point(50, 50), 25);
    Console.WriteLine($"circle: {c1.BorderColor} - {c1.BorderWidth} - {c1.BackgroundColor}");

    Rectangle r1 = new Rectangle("blue", "Red",  5, new Point(4,10),
                                                   new Point(15, 20),
                                                   new Point(23, 30),
                                                   new Point(7, 14));
    Console.WriteLine($"Rectangle: {r1.BorderColor} - {r1.BorderWidth} - {r1.BackgroundColor}");
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

public class Shape {
  public string BorderColor {set; get;} 
  public int BorderWidth {set; get;} 
  public string BackgroundColor {set; get;}

  public Shape (string borderColor, string backgroundColor, int borderWidth) {
    BorderColor = borderColor; 
    BorderWidth = borderWidth; 
    BackgroundColor = backgroundColor;
  }
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
}

public class Square : Shape{
  public Point Point1 {set; get;}
  public Point Point2 {set; get;}
  public Square (string borderColor, string backgroundColor, int borderWidth,
                  Point point1, Point point2) :  base(borderColor, backgroundColor, borderWidth){
    Point1 = point1;
    Point2 = point2;
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
}