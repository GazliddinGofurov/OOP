using System;
using System.Reflection.Metadata.Ecma335;

namespace ProjectsForTuple
{
    class Program
    {
        static void Main (string[] args)
        {
            // task1
            // str  = "10"  tup kopaytuvchilarga ajratib bitta ozgaruchiga  yigib chiqarsin
            // [(2,1),(5,1)
            /*
            string str =  "360";
            List<(int,int)> list = TupKopaytuchi(str);

            foreach(var item in list)
            {
                Console.Write($"({item.Item1}, {item.Item2}), ");
            }
            */

            // task2 
            var students = new List<(string Name, int Score)>
            {
                ("Ali", 85),
                ("Vali", 92),
                ("Sardor", 78),
                ("Madina", 95),
                ("Jasur", 64),
                ("Malika", 88),
                ("Nodir", 71),
                ("Aziza", 99)
            };

            var (bestStudent, worstStudent) = Task2(students);

            Console.WriteLine($"Eng Alochi: {bestStudent.Name} ({bestStudent.Score}) ball");
            Console.WriteLine($"Eng Past Ball: {worstStudent.Name} ({worstStudent.Score}) ball");

          


        }

        static List<(int, int)> TupKopaytuchi (string str)
        {
            int num =  int.Parse(str);
            List<(int,int)> list = new List<(int, int)>();

            if (num % 2 == 0)
            {
                int counter  = 0;
                while (num % 2 == 0)
                {
                    counter++;
                    num/=2;
                }

                list.Add((2,counter));
            }
            
            for(int i = 3; i*i<num; i += 2)
            {
                if (num % i == 0)
                {
                    int counter  = 0;
                    while (num % i == 0)
                    {
                        counter++;
                        num/=i;
                    }

                    list.Add((i,counter));
                }
            }

            if (num > 1)
            {
                list.Add((num,1));
            }

            return list;
        }

        static ((string Name, int Score)Best, (string Name, int Score)Worst) Task2(List<(string name, int score)> list)
        {
           // Boshlangich Qiymat beramiz
           var best = (Name: "", Score: int.MinValue);
            var worst = (Name: "", Score: int.MaxValue);


            foreach(var item in list)
            {
                if(item.score < worst.Score)
                {
                    worst =  (item.name, item.score);
                    
                }

                if (item.score > best.Score)
                {
                    best  =  (item.name, item.score);
                }
                   
            }

            return (best, worst);
            
        }
    }
}