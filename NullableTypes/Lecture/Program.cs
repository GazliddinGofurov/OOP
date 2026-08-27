using System;
namespace _NullableLecture
{
    class Program
    {
        static void Main (string[] args)
        {
            // there are two ways to Define a nullable int value type 
            // int? optionalValue =  null;
            Nullable<int> optionalValue;

            // Code here sets the optionalValue
            optionalValue =5;
  
            if (optionalValue.HasValue)
            {
                Console.WriteLine(optionalValue.Value);
            }
            else
            {
                Console.WriteLine("no value");
            }

            Console.WriteLine("\n");
            //------------------------------------------------------
            //Arithmetic operators with nullable types

            int? a = 10;
            int? b = null;
            int?sum = a + b ; // sum =  null
           
           // int (a value type) must be declared with "?" to accept a null value
           int? son = null;

           // straing (a reference type) inherently accept a null value

           string str =  null;

        


            
        }

    }
   
}