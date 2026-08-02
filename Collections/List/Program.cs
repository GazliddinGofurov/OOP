using System ;
using System.Collections.Generic;
namespace _List
{
    class Program
    {
        static void  Main (string[] args)
        {
            //task1 - eng katta just sonni topish
            /*
            List<int> numbers =  new List<int>(){12,23,1,3,5,9,10};
            int son = EngKattaJuftSon(numbers);
            Console.WriteLine("Eng Katta Juft son:"+son);
           */

            // task2  [1,2,2,4]  xato 2 , [1,2,2,3,4,5,5,7] xato 2 va 5
            /*
            List<int> numbers =  new List<int>(){1, 2, 2, 4, 6, 6, 7, 8};
            List<int> test1 = BarchaXatoRaqamlarniTop(numbers);
            Console.WriteLine("Xatolar:");
            foreach (int a in test1)
            {
                Console.WriteLine(a);
            }
            */

            // task3
            /*
            Dictionary<int, int> diction1 = new Dictionary<int, int>()
            {
                {1,101},
                {2,202},
                {3,303},
                {4,401}
            };

            PrintDictionary(diction1);

            Dictionary<string, string> diction2 = new Dictionary<string, string>()
            {
                {"name","Alex"},
                {"age","25"},
                {"isMarried","false"},
                {"Weight","85kg"}
            };
            PrintDictionary(diction2);
            */

            // task4 
            List<string>names = new List<string>()
            {
                "Alex",
                "henry",
                "Ron",
                "Antony",
                "Frank",
                "Ali",
                "Jack",
                "Daniel",
                "Rocky",
                "Arthur"
            };
            
            foreach(string ele in names)
            {
                Console.WriteLine(ele);
            }
            names.Sort();
            Console.WriteLine("\nSorted per Alphbet");
            foreach(string ele in names)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("\nRemove names starting with 'A'");
            DeleteNames(names);
            foreach(string ele in names)
            {
                Console.WriteLine(ele);
            }
          
        }

        public static int EngKattaJuftSon(List<int> mylist)
        {
            int max = 0;
            foreach(int x in mylist)
            {
                if(x%2==0 && x > max)
                {
                    max = x;
                }
            }

            return max;
        }

        public static List<int> BarchaXatoRaqamlarniTop (List<int> mylist)
        {
           List<int> korilgan = new List<int>();
           List<int> xatolar =  new List<int>();

           foreach(int num in mylist)
            {
                if (korilgan.Contains(num) && !xatolar.Contains(num))
                {
                    xatolar.Add(num);
                }
                else
                {
                    korilgan.Add(num);
                }
            }

            return xatolar;
        }

        public static void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary1)
        {
            foreach(KeyValuePair<TKey,TValue> ele in dictionary1)
            {
                Console.WriteLine("Key: {0}, Value: {1}", ele.Key, ele.Value);
            }
        }

        public static void DeleteNames(List<string> names)
        {
            for(int i = 0; i < names.Count; i++)
            {
                if(names[i][0]=='a' || names[i][0] == 'A')
                {
                    names.RemoveAt(i);
                    i--;
                }
            }
        }

      
    }
}