using System;
using System.Reflection.Metadata;

namespace GenericClass
{
    class Program
    {
        static void Main (string [] args)
        {
            GenericClass<int> obj1 =  new GenericClass<int>(100);
            obj1.Display();

            GenericClass<string> obj2 = new GenericClass<string>("Hello World!");
            obj2.Display();

            GenericClass<bool> obj3 =  new GenericClass<bool>(true);
            obj3.Display();

            // Creating Pair with Int va string
            Pair<int, string> pair1 = new Pair<int, string>(100,"Avtobus");
            pair1.Display();

            Pair<double, Char> pair2 =  new Pair<double, char>(10.2342,'$');
            pair2.Display();




            int a=4, b=7;

            Console.WriteLine($"\n{a} , {b}");
            Swapper<int>.Swap(ref a, ref b);
            Console.WriteLine($"\n{a} , {b}");
  


        }
    }
}