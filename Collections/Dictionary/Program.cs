using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _Dictionary
{
    class Program
    {
        public static void Main (string[] args)
        {
            //Task1 Massiv ichida takrorlangan elementlar sonini toping.
            /*
            List<int> numbers = new List<int>(){1, 2 ,3 ,2 ,5 ,1, 4, 2};
            Dictionary<int, int> test1 = FindDucplicant(numbers);

            foreach(KeyValuePair<int, int> pair in test1)
            {
                Console.WriteLine("{0} -> {1} marta",pair.Key,pair.Value);
            }
            */


            // task2  ArrayList ichida faqat sonlarni yigindisini chiqarish
            /*
            ArrayList aList=  new ArrayList()
            {
                12,
                "hello",
                45,
                true,
                89,
                "abc"
            };

            Console.WriteLine("SUM OF ARRAY: "+SumOfArrayList(aList));
            */

            List<Student> students =  new List<Student>()
            {
                new Student {Name = "Alex",Age = 18, GPA = 2.6},
                new Student {Name = "Ron",Age = 19, GPA = 3.1},
                new Student {Name = "Henr",Age = 18, GPA = 1.2},
                new Student {Name = "Bob",Age = 22, GPA = 3.9},
                new Student {Name = "Rex",Age = 20, GPA = 2.3},
                new Student {Name = "Tom",Age = 25, GPA = 3.0},
                new Student {Name = "Mike",Age = 21, GPA = 2.4}
            };

            string maxGPAStdName = "";
            double max = 0;
            foreach(Student std in students)
            {
                if (max < std.GPA)
                {
                    max = (double)std.GPA;
                    maxGPAStdName = (string)std.Name;
                }
            }
            Console.WriteLine("\nGPA eng yuqori student {0} with {1} ball",maxGPAStdName,max);
            
            List<Student> smartStd =  new List<Student>();
            foreach(Student std in students)
            {
                if (std.GPA >= 3.0)
                {
                    smartStd.Add(std);
                }
            }
            Console.WriteLine("\nGPA 3.0 dan katta studentlar;");
            foreach(Student std in smartStd)
            {
                Console.WriteLine("name:{0}, GPA {1}",std.Name,std.GPA);
            }

            int younest = 120;
            string youngestStd = "";
            
            foreach(Student std in students)
            {
                if (younest > std.Age)
                {
                    younest = std.Age;
                    youngestStd = std.Name;
                }
            }
            Console.WriteLine("\nEng Yosh Student {0} {1} yosh ",youngestStd,younest);


            Console.WriteLine("\nstudentlarni GPA bo'yicha kamayish tartibida chiqaring (LINQsiz).");
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = 0; j < students.Count - 1 - i; j++)
                {
                    if (students[j].GPA < students[j + 1].GPA)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }

            foreach (Student std in students)
            {
                Console.WriteLine($"{std.Name} - {std.GPA}");

            }
            

           
            
        }

        public static Dictionary<int, int> FindDucplicant(List<int> list)
        {
            Dictionary<int,int>korilgan =  new Dictionary<int, int>();

            foreach(int ele in list)
            {
                if (korilgan.ContainsKey(ele))
                {
                    korilgan[ele]++;
                }
                else
                {
                    korilgan.Add(ele,1);
                }
            }

            return korilgan;
        }

        public static int SumOfArrayList (ArrayList aList)
        {
            int tempNum = 12;
            int sum = 0;
            foreach (var items in aList)
            {
                if (items is int)
                {
                    sum+=(int)items;
                }
            }

            return sum;
        }
    }
}