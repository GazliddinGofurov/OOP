using System;
namespace _Bankomat
{
    class Program
    {
        static void Main (string [] args)
        {
            ATMState currentState =  ATMState.Idle;
            int atmCash =  100000;
            bool isRunning =  true;
            int parol = 2232;

            Console.WriteLine("Bankomat Tizimiga Xush Kelipsiz!");
            while (isRunning)
            {
                // if(atmCash<=0 && currentState != ATMState.OutOfCash)
                // {
                //     currentState = ATMState.OutOfCash;
                // }
                Console.WriteLine($"\n[Joriy Holat: {currentState}] | [Bankomatda qolgan pul: {atmCash} so'm]");

                switch (currentState)
                {
                    case ATMState.Idle:
                        Console.WriteLine("Buyruqlar: 1 - Karta solish, 0 - Dasturni yopish");
                        Console.Write("Tanlang: ");
                        string choice  = Console.ReadLine();
                        if(choice == "1")
                        {
                            currentState =  ATMState.CardInserted;
                            Console.WriteLine("Karta muvaffaqiyatli solindi.");   
                        }
                        else if(choice == "0")
                        {
                            isRunning = false;
                        }
                        else
                        {
                            Console.WriteLine("Notogri Buyruq!");
                        }
                        break;

                    case ATMState.CardInserted:
                        Console.WriteLine("PIN kodni kriting (Chiqish uchun - 'exit'):");
                        string inputPin  =  Console.ReadLine();

                        if(inputPin.ToLower() == "exit")
                        {
                            currentState =  ATMState.Idle;
                            System.Console.WriteLine("Karta Qaytarilib berildi");
                            break;
                        }

                        if(int.TryParse(inputPin, out int pin) && pin == parol)
                        {
                            currentState = ATMState.Idle;
                            System.Console.WriteLine("PIN togri ,Tizimga kirdingiz");
                        }
                        else
                        {
                            Console.WriteLine("Parol Xato , Qayta Urinib ko'ring");
                        }
                        break;
        
                }
            }

            
        }

         enum ATMState{
            Idle, //Karta Solinmagan
            CardInserted, // Karta solingan , PIN kutilmoqda
            Authenticated, // Pul yechiga tayyor
            OutOfCash    // Bankomatta pul tugagan
        }
    }
}