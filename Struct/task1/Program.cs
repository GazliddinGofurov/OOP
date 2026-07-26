using System ;
using System.Drawing;
namespace _task1
{
    
    readonly struct Point2D
    {
        public double X { get; }
        public double Y { get; }

        public  Point2D(double x, double y)
        {
            X = x;
            Y =  y;
        }

        public static double DistanceTo(Point2D p1, Point2D p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X,2) +
                         Math.Pow(p2.Y - p1.Y,2));
        }
    }

    

    class Program
    {
        
   
        static void Main (string [] args)
        {
            Point2D point1 =  new Point2D(-2, -3);
            Point2D point2 =  new Point2D(1,1);

            double res = Point2D.DistanceTo(point1,point2);

            Console.WriteLine($"D = {res}");
            
        }  
    }

    
}