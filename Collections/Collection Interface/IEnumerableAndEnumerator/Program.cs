using System;
using System.Collections.Generic;

namespace _CollectionInterface
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
    }
    class Program
    {

        static List<int> JuftSonQaytar()
        {
            List<int> storage  =  new List<int>();
            for(int i = 0; i<10000000; i++)
            {
                if (i % 2 == 0)
                {
                    storage.Add(i); 
                }
                
            }

            return storage;
        }
        static void Main (string[] args)
        {

            List<int> A = JuftSonQaytar();

            Console.WriteLine(A[99]);


            /*
            ICollection<Student> students =  new List<Student>();

            students.Add(new Student{Name = "Alex",Age = 18, GPA = 4.2});
            students.Add(new Student{Name = "Bob",Age = 28, GPA = 3.2});
            students.Add(new Student{Name = "TOM",Age = 19, GPA = 3.1});

            Console.WriteLine($"Count of Students {students.Count}");

            foreach(Student items in students)
            {
                Console.WriteLine(items.Name);
            }

            List<string> name = new List<string>();

            */

        }


    }
}