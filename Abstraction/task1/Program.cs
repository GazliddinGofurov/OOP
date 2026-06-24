using System;
namespace _task1
{

    abstract class Shape
    {
        public string Color { get; set; }
        public abstract double Area();
        public string getColor()
        {
            return Color;
        }
    }

    class Circle : Shape
    {
        public double  Radius  { get; set; }
        public override double Area()
        {
           return Math.PI*Radius*Radius; 
        }   
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Length*Width;
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
           Circle circle = new Circle();
           circle.Color = "Blue";
           circle.Radius = 10;
           System.Console.WriteLine("Circle");
           System.Console.WriteLine("Color: "+circle.getColor());
           System.Console.WriteLine("Area: "+circle.Area());


           Rectangle rectangle = new Rectangle();
           rectangle.Color = "Green";
           rectangle.Width = 10;
           rectangle.Length = 5;
           System.Console.WriteLine("\nRectangle");
           System.Console.WriteLine("Color: "+rectangle.getColor());
           System.Console.WriteLine("Area: "+rectangle.Area());
            
        }
    }
}
