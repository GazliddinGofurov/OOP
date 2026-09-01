using System;
using System.Reflection.Metadata.Ecma335;
namespace _Task2Events
{
    class Program
    {
        static void Main(string[] args)
        {

           Thermostat thermostat =  new Thermostat();
           thermostat.TemperatureChanged+=DisplayMessage;
           thermostat.CurrentTemperature = 20;
           thermostat.CurrentTemperature = 25;


            
        }

        static void DisplayMessage(object sender, TempChangedEventArgs e )
        {
            Console.WriteLine($"Harorat {e.OldTemperature} dan {e.NewTemperature} ga o'zgardi");

        }

    
     
    }
}