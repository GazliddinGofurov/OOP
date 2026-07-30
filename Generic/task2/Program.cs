using System;

namespace _task3
{
    class Program
    {
        static void  Main (string [] args)
        {
            double[] buses = {12.34,23.001,93.12,45.01};
            string[]restrauns = {"Alo", "Bahor", "Tanovar","Versal"};
            int[]numbers = {1,3,5,9,2};


            System.Console.WriteLine(lastElement<double>.getLastItem(buses));
            Console.WriteLine(lastElement<string>.getLastItem(restrauns));
            Console.WriteLine(lastElement<int>.getLastItem(numbers));
            
        }
    }
}