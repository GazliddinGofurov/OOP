using System;
using System.ComponentModel;
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
            /*
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
            */

            //task3
            
           // int[]myArray = {};
           /*
            int[]myArray = {12,23,54,21,44,3,9};
            var myTuple =  Task3(myArray);
            if(myTuple is (0, 0, 0, 0))
            {
                Console.WriteLine("Array Bo'sh");
            }
            else
            {
                Console.WriteLine($"Min: {myTuple.Min}");
                Console.WriteLine($"Max: {myTuple.Max}");
                Console.WriteLine($"Avg: {myTuple.Avg}");
                Console.WriteLine($"Sum: {myTuple.Sum}"); 
            }
            */

            /*
            // task4
            //Referance Tuple
            Tuple<int, string> tuple1 =  new Tuple<int, string>(19,"Alex");
            Tuple<int, string> tuple2 =  new Tuple<int, string>(19,"Alex");

            // Value tuples
            ValueTuple<int, string> valueTuple1 =  (21,"frank");
            ValueTuple<int, string> valueTuple2 = (21,"frank");

            Console.WriteLine(tuple1 == tuple2); // fasle
            Console.WriteLine(tuple1.Equals(tuple2)); // true

            Console.WriteLine(valueTuple1 == valueTuple2);
            Console.WriteLine(valueTuple1.Equals(valueTuple2));

            // Demak, savolning javobi: ValueTuple == operatorini qo‘llab-quvvatlaydi.
            // Kichik nuance: Tuple uchun == operatori kompilyatsiyadan o'tadi, 
            // lekin u reference equality qiladi; ValueTuple esa == ni elementlar bo‘yicha equality sifatida taqdim etadi.
            

            // tuple1.Item1 = 21;  // Property or indexer 'Tuple<int, string>.Item1' cannot be assigned to -- it is read only
            Console.WriteLine(valueTuple1.Item1);
            valueTuple1.Item1 = 19;
            Console.WriteLine(valueTuple1.Item1);
            */

            
            // task5
            /*
            (int x, int y) t1 ;
            Console.WriteLine("x ni kriting");
            t1.x = int.Parse(Console.ReadLine());
            Console.WriteLine("y ni kriting");
            t1.y = int.Parse(Console.ReadLine());

            string res =  Task5(t1);
            Console.WriteLine(res);
            */


            // task6
            Console.WriteLine("satir kriting - ");
            string str =  Console.ReadLine();
            var res = task6(str);
            Console.WriteLine($"Vowels {res.Vowels}\n Consonants {res.Consonants}\n total Length {res.totalLength}");




           
            

           

          


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

        static (int Min, int Max, double Avg, int Sum) Task3(int[] array)
        {
            var Min = int.MaxValue;
            var Max =  int.MinValue;
            var  Sum = 0;
            double Avg = 0;

            if(array.Length == 0)
            {
                return (0,0,0,0);
            }

            foreach(int item in array)
            {
                if(item< Min)
                        {
                            Min =  item;
                        }

                        if(item> Max)
                        {
                            Max = item;
                        }

                        Sum+=item;
                        
            }
            Avg = (double)Sum/ array.Length;
            return(Min, Max, Avg, Sum);   
            
               
        }

        static string Task5 ((int x, int y) input)
        {
            
            Dictionary<(int x,int y), string> dictionary = new Dictionary<(int x, int y), string>()
            {
                {(1,3),"hilton"},
                {(2,4),"NestOne"},
                {(3,0),"Gardens"},
                {(1,1),"U tower"}
            };

           
                if (dictionary.TryGetValue((input), out string place))
                {
                    return place;
                }
                else
                {
                    return "bunday joy topilmadi";
                }
        }

        static (int Vowels, int Consonants, int totalLength) task6 (string str)
        {
            int Vowels = 0;
            int Consonants =0;
            str = str.ToLower();
            
            
            
            foreach(char item in str)
            {
                if((item == 'a'||item == 'i'||item == 'o'||item == 'e'||item == 'u') && item != ' ')
                {
                    Vowels++;
                }
                else if(char.IsLetter(item))
                {
                    Consonants++;
                }
                else
                {
                    
                }
            }

           int  totalLength = str.Length;

            return (Vowels, Consonants, totalLength);
        }
    }
} 