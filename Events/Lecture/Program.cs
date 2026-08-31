using System;
namespace _Events
{
    public delegate string myDel(string str);
    class Program
    {
        static void Main(string[] args)
        {
            EventProgram obj =  new EventProgram();

            //Subscribe a subscriber method to the event
            obj.MyEvent+=UserWelcomeHandler;

            // Trigger the process
            obj.RaiseWelcomeEvent("Fazliddin");


        }

        static string UserWelcomeHandler(string name)
        {
            string message  = "Welcome"+name;
            Console.WriteLine(message);
            return message;
        }
    }

    class EventProgram
    {   
        // Declare Event
        public event myDel MyEvent;

        public void RaiseWelcomeEvent(string name)
        {
            // Safely invoke all subscribed delegates
            MyEvent?.Invoke(name);
        }

      
    }
}