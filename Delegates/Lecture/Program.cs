using System;

namespace _Delegates
{
    class Program
    {
        // Delegate declaration
        public delegate void PrintDelegate(int a, int b);
        public delegate void Notify();
        public delegate int Operation(int x, int y);
        

       
        static void Main(string[] args)
        {
            // Instantiating delegate
            PrintDelegate delegate1 =  new PrintDelegate(PrintWithFormat);
            delegate1+=PrintWithInterpolation;
            
            // Invoking delegate
            delegate1(12,34);


            Notify notify = MethodA;
            notify+=MethodB;

            notify();  // Invokes both MethodA and MethodB


            Operation op = Add;
            Console.WriteLine("Addition: "+ op(11,5));
            Console.WriteLine("Addition: "+ op(10,8));
            op+=Multiply;
            Console.WriteLine("Multiplication: "+ op(10,8));
            Console.WriteLine("Multiplication: "+ op(1,8));
            
        }
         // Method matching delegate signuture
        static  void PrintWithFormat(int a, int b)
        {
            Console.WriteLine("Format:{0}, {1}",a,b);
        }
        static  void PrintWithInterpolation(int a, int b)
        {
            Console.WriteLine($"Interpolation:{a},{b}");
        }

        public static void MethodA()=>Console.WriteLine("Method A executed");
        public static void MethodB()=>Console.WriteLine("Method B executed");


        public static int Add(int a, int b)=> a+b;
        public static int Multiply(int a, int b)=> a*b;
    }
    
}