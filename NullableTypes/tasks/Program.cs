using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace _task {
    class Program {
        static void Main (string[] args){
            // task1
            /*
            Console.Write("Yoshingizni Kriting:");
            string? input = Console.ReadLine();
           
            if (int.TryParse(input, out int age))
            {
                Console.WriteLine($"Sizning yoshingiz:{age}");
            }
            else
            {
                Console.WriteLine("Yosh Kiritilmagan");
            }
            */

            // task2
            string? name =  null;
            var res = name?? "Unknown";
            Console.WriteLine(res);

            // task3
            double? score = null;
            string natija = score?.ToString() ?? "Ball mavjud emas";
            Console.WriteLine(natija); 

            //task4
            string? city = null;
            Console.WriteLine(city ?? "taskent");  // tashkent

            // task5
            decimal? price = 20;
            Console.WriteLine($"Final price:{price ?? 100}");

            // task7
            Console.WriteLine(GetNumber(122)); // 122
            Console.WriteLine(GetNumber(null)); // 0 

            // task8
            Console.WriteLine(GetName(null)); // unknown
            Console.WriteLine(GetName("Frank")); // Frank


            // task9
            Console.WriteLine(CalculatePrice(100,null));


            // task10
            Student student  = new Student();
            student.Name = "Fazliddin";
            student.Age = 21;
            student.Score = 4.1;

            student.PrintInfo();

            Student student1  = new Student();
            student1.Name = null;
            student1.Age = null;
            student1.Score = null;

            student1.PrintInfo();





        }

        static int GetNumber(int? number)
        {
            return number ?? 0;
        }

        static string GetName(string? name)
        {
            return name ?? "unknown";
        }

        static decimal CalculatePrice (decimal price, double? discount)
        {
           decimal res = price - price * (decimal)(discount ?? 0)/100;

           return res;
        }


        
    }
}
