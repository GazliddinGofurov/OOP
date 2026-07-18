using System;
namespace _task2
{
    class Program
    {
        static void Main (string[] args)
        {
            // Foydalanuvchiga qaysi son qaysi rangni anglatishini ko'rsatamiz
            Console.WriteLine("Mavjud ranglar:");
            foreach (var val in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine($"{(int)val} - {val}");
            }
            
            Console.Write("\nRang indeksini kiriting: ");
            
            if (int.TryParse(Console.ReadLine(), out int line))
            {
                if (Enum.IsDefined(typeof(Color), line))
                {
                    Color color = (Color)line;
                    
                    // Har bir holat uchun alohida switch yozib o'tirmasdan, 
                    // to'g'ridan-to'g'ri o'zgaruvchining o'zini chiqarib qo'yamiz
                    Console.WriteLine($"{color} rangining indeksi: {(int)color}");
                }
                else
                {
                    Console.WriteLine("Kiritilgan indeks ro'yxatda mavjud emas!");
                }
            }
            else
            {
                Console.WriteLine("Iltimos, faqat son kiriting!");
            }
        }
            
        }

        enum Color{
            Red,
            Green,
            Blue,
            Pink,
            Orange,
            Yellow
        }
    }
