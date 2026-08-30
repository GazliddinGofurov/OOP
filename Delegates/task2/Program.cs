using System;
using System.Collections.Generic;  
namespace _DelegateTask2
{
    // Delegate va bu delegate yordamida list to'plami ichidan eng katta va kichik elementlarini tuple orqali qaytaruvchi metod hosil qiling. 
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(){12,23,43,1,3,82,10};

            MaxMinDelegate del1 =  MaxMin;
            var tuple = del1(nums);

            Console.WriteLine("Max:{0}, Min:{1}",tuple.Max, tuple.Min);


            

            myDelegate del2 = new myDelegate(Math1.sum); 
            del2+=Math1.substract;
            del2+= Math1.multiply;
            del2+= Math1.divide;
            del2(12,45);

            
            

        }

        public  delegate (int Max, int Min) MaxMinDelegate(List<int> list);
        public delegate void myDelegate (int a, int b);

        static (int max, int min) MaxMin (List<int> list)
        {
            int Max =  int.MinValue;
            int Min =  int.MaxValue;

            foreach(var item in list)
            {
                if(item< Min)
                {
                    Min = item;
                }
                if (item > Max)
                {
                    Max =  item;
                }
            }

            return (Max , Min);
        }
    }
}