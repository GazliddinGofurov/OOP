using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Reflection.Metadata;
namespace _DelegateTask4
{
    class Program
    {
        static  Predicate<Student> filterDelegate = startWithALetter;
        static Action<Student> action = actionA;
        

        static void Main(string[] args)
        {
            List<Student> students  = new List<Student>()
            {
                    new Student { Name = "Alex", Age = 20, GPA = 3.8 },
                    new Student { Name = "Bob", Age = 18, GPA = 2.7 },
                    new Student { Name = "John", Age = 22, GPA = 3.2 },
                    new Student { Name = "Tom", Age = 19, GPA = 4.0 },
                    new Student { Name = "Mike", Age = 21, GPA = 2.4 }
            };

            
            
            var res = FilterStudent(students, filterDelegate);
            foreach(var item in res)
            {
                Console.WriteLine(item.Name);
            }

            ProcessStudent(students,actionA);

            action+=actionB;
            ProcessStudent(students,actionB);

            Console.WriteLine("Adding 0.2 points for each students GPA\n");
            ProcessStudent(students,action);

             Console.WriteLine("Action C\n");
             ProcessStudent(students,actionC);

        }

        static List<Student> FilterStudent(List<Student> students, Predicate<Student> condition)
        {
            List<Student> sorted = new List<Student>();
            foreach(var item in students)
            {
                if (condition(item))
                {
                    sorted.Add(item);
                }
            }

            return sorted;
        }

        static void ProcessStudent (List<Student> students, Action<Student> action)
        {
            foreach(var item in students)
            {
                action(item);
            }
        }

        static bool isGpaOver3(Student student)=> student.GPA>=3;
        static bool isOlderthan20(Student student)=>student.Age>=20;
        static bool startWithALetter (Student student)=> (student.Name[0]=='a' ||student.Name[0]=='A');

        static void actionA(Student student)
        {
            Console.WriteLine($"{student.Name}-{student.Age}-{student.GPA}");
        }

        static void actionB(Student student)
        {
            student.GPA+=0.2;
        }
        
        static void actionC(Student student)
        {
            if(isGpaOver3(student)&& startWithALetter(student))
            {
                actionA(student);
            }
        }
        
        
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
    }

    
}