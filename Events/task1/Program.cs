using System;
namespace _task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // OnEvenNumberFound nomli event hosil qiling va bu event'ni to'plam ichida juft sonlar topilgan paytda ishlashligini ta'minlang 
            List<int> sonlar =  new List<int>{12,21,87,19,0,2,8,10};
            
            //Eventni metodga ulash
            EvenNumber.OnevenNumberFound+=EvenNumberHandler;

            EvenNumber.CheckNumber(sonlar);


            
        }

        // Event ishlagandi shu method bajariladi
        static void EvenNumberHandler(object sender, UserArgs e)
        {
            Console.WriteLine($"Juft son topildi {e.Number}");
            
        }

       

    }
    class EvenNumber
    {
        // Event
        public static EventHandler<UserArgs>? OnevenNumberFound;

        // List ichidagi sonlarni tekshiradi
        public static void CheckNumber(List<int> nums)
        {
            foreach (int num in nums)
            {
                if(num % 2 == 0)
                {
                    // Eventga yuboriladigan ma'lumot
                    UserArgs args =  new UserArgs();
                    args.Number = num;

                    //Eventni ishga tushiramiz
                    OnevenNumberFound?.Invoke(null, args);
                }
            }
            
        }
    }

    class UserArgs : EventArgs
    {
        public int Number { get; set; }
    }
}