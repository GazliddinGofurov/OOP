using System;
using System.Security.Cryptography.X509Certificates;
namespace _task1
{
    public enum WeekDay
        {
            Monday = 1,
            Tuesday =2,
            Wednesday = 3,
            Thursday  = 4,
            Friday  = 5,
            Saturday  = 6,
            Sunday = 7
            
        }

    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hafta Kunini Kiriting:");

    
            if(int.TryParse(Console.ReadLine(), out int inputNumber))
            {
                WeekDay day  =  (WeekDay)inputNumber;

                if (IsWeekend(day))
                {
                    Console.WriteLine("Dam Olish kuni!");
                }
                else
                {
                    Console.WriteLine("ish kuni.");
                }  
            }
            else
            {
                Console.WriteLine("Iltimos, Faqat Son Kriting!");
            }

            


        }

         static bool IsWeekend(WeekDay day)
        {
            return day == WeekDay.Saturday || day == WeekDay.Sunday;
           
        }
    } 

  
}

