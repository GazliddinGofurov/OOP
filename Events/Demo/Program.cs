using System;

namespace _Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db =  new DataBase();
            IdCardGenerator id = new IdCardGenerator();
            EmailGenerator ig =  new EmailGenerator();

            // Subscribe these classes to our userProcessor Event

            UserProcessor.userProcessorEvent+=db.SaveToDB;
            UserProcessor.userProcessorEvent +=id.GenerateIdCard;
            UserProcessor.userProcessorEvent += ig.SendEmailToUser;

            Console.WriteLine("Commands Accepted:");
            Console.WriteLine("1. new : Add new User");
            Console.WriteLine("2.  exit : Close the Application");

            while (true)
            {
                Console.Write("Enter Command:");
                var cmdInputs =  Console.ReadLine();

                if(cmdInputs.Equals("exit"))
                    break;
                else if (cmdInputs.Equals("new"))
                {
                    Console.WriteLine("\nEnter User Name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("\nEnter User Age: ");
                    var age = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEmail sending is required? (y/n)");
                    var emailNeeded = Console.ReadLine();

                    if (emailNeeded.Equals("n"))
                    {
                        UserProcessor.userProcessorEvent-= ig.SendEmailToUser;
                    }

                    UserProcessor.ProcessUser(name, age);
                    
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }

            }


        }
    }
}