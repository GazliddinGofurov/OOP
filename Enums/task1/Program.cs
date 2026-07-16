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

        enum TrafficLight
        {
            red,
            yellow,
            green
        }
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main (string[] args)
        {

            Console.WriteLine("1-12 gacha bolgan oy raqamini kiriting");
            if(int.TryParse(Console.ReadLine(), out int month))
            {
                if(month < 1 || month > 12)
                {
                    Console.WriteLine("Xato! Oy raqami faqat 1 dan 12 gacha bo'lishi mumkin.");
                    return;
                }

                Season joriyFasl;

                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        joriyFasl =  Season.Winter;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        joriyFasl = Season.Spring;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        joriyFasl = Season.Summer;
                        break;
                    default: // 9, 10, 11 oylar uchun
                        joriyFasl = Season.Autumn;
                        break;
                }
                Console.WriteLine($"Hozirgi fasl: {joriyFasl}");
            }
            else
            {
                Console.WriteLine("Iltimos, faqat Son kiriting!");
            }
           

            /*
            Console.WriteLine("Enter a color:");
            string color =  Console.ReadLine();

            if(Enum.TryParse<TrafficLight>(color, out TrafficLight light))
            {
                switch (light)
                {
                    case TrafficLight.red:
                        Console.WriteLine("Toxta");
                        break;
                    case TrafficLight.yellow:
                        Console.WriteLine("Tayyorlan");
                        break;
                    case TrafficLight.green:
                        Console.WriteLine("Yugur");
                        break;
                    default:
                    Console.WriteLine("Bunday svetofor rangi yo'q");
                    break;
                }
                
            }
            else
            {
                Console.WriteLine("Soz xato kirtildi");
            }
            */

            
            /*
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
            */

        }

         static bool IsWeekend(WeekDay day)
        {
            return day == WeekDay.Saturday || day == WeekDay.Sunday;
        }
    } 

  
}

