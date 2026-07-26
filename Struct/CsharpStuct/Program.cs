using System;

namespace CSharpStruct
{
    struct Employee
    {
        public int id;
        public void getId (int id)
        {
            System.Console.WriteLine("Employee Id: "+ id);
        }
    }

    struct Animal
    {
        public string name;
        public int legCount;

    // parameterized constructor
        public Animal(string Name, int LegCount)
        {
            name =  Name;
            legCount = LegCount; 
        }
    }

    struct Point
    {
        public int X {get; set;}
        public int Y {get; set;}

        public Point (int x, int y)
        {
            X =  x;
            Y = y; 
        }

        public void Display ()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }
    class Program
    {
        static void Main (string [] args)
        {
            Employee emp;
            emp.id = 1232;
            emp.getId(emp.id);


            // calls cosntructor of struct
            Animal cat =  new Animal("mushukcha",4);
            Console.WriteLine("Laqabi:"+cat.name);
            Console.WriteLine($"Oyoqlari {cat.legCount} ta");


            // Calls constructor of struct
            Point point1 =  new Point(10,20);
            Point point2 = point1;

            point2.X = 50;

            point1.Display();
            point2.Display();


            
        }
    }
}