using System ;
using System.Diagnostics.Contracts;

namespace _task3
{
    abstract class Person
    {
        public string  Name { get; set; }
        public string  Address { get; set; }
        public string  hairColor { get; set; }
        public string  eyeColor { get; set; }

        public void setName (string name) => Name = name;  
        public void setAddress (string address) => Address = address;

        public void printPersonInfo()
        {
           Console.WriteLine($"Name {Name}");
           Console.WriteLine($"Address {Address}");
           Console.WriteLine($"Hair Color {hairColor}");
           Console.WriteLine($"Eye Color {eyeColor}");
        }
             
    }
    public interface IEmployee
    {
        void Hire();
        void Fire();
    }
    public interface IOfficeOccupant
    {
        void SetNumber(int number);
        int GetNumber();
        void SetOccupant(string name);
        string GetOccupant();
        
    }

    class HourlyEmployee : Person, IEmployee
    {
        public int hourlyRate {get; set;}
        public string  JobID { get; set; }
        public void setRate(int rate)=>hourlyRate=rate;

        public void Hire()=>Console.WriteLine($"HourlyEmployee named {Name} is Hired");
        public void Fire()=>Console.WriteLine($"HourlyEmployee named {Name} is Fried");
        public void printHourlyEmployeeInfo()
        {
            printPersonInfo();
            Console.WriteLine($"Hourly Rate {hourlyRate}");
            Console.WriteLine($"Job ID {JobID}");
        }
        
       
    }

    class SalariedEmployee : Person , IOfficeOccupant, IEmployee
    {
        private int officeNumber;
        private string occupantName;
        public double  WeeklyPay { get; set; }
        public void setWage(double wage) => WeeklyPay = wage;
        public void MoveOffice(int number)
        {
            SetNumber(number);
            Console.WriteLine($"Xodim yangi ofisga #{number}ga ko'chirildi.");
        }
        public void SetNumber(int number)
        {
            officeNumber = number;
        }
        public int GetNumber()
        {
            return officeNumber;
        }
        public void SetOccupant(string name)
        {
            occupantName =  name;
        }
        public string GetOccupant()
        {
            return occupantName;
        }
        public void Hire()=>Console.WriteLine($"SalariedEmployee named {Name} is Hired");
        public void Fire()=>Console.WriteLine($"SalariedEmployee named {Name} is Fried");

        public void PrintSalariedEmployeeInfo()
        {
            printPersonInfo();
            Console.WriteLine($"Haftalik Maosh: {WeeklyPay}");
            Console.WriteLine($"Office number: {GetNumber()}");
            Console.WriteLine($"Ofise Band qilgan shahs: {GetOccupant()}");

        }



    }
    class Program
    {
        static void Main (string [] args)
        {

            HourlyEmployee hourlyEmp =  new HourlyEmployee();
            hourlyEmp.Name = "Fazliddin";
            hourlyEmp.hairColor = "Black";
            hourlyEmp.JobID = "12DF41";
            hourlyEmp.Address = "Tashkent Yunusobod";
            hourlyEmp.setRate(100000);
            hourlyEmp.printHourlyEmployeeInfo();
            hourlyEmp.Fire();
            hourlyEmp.setAddress("Uchtepa");
            System.Console.WriteLine("\n=======HourlyEmployee=========");
            hourlyEmp.printHourlyEmployeeInfo();


            SalariedEmployee salariedEmp =  new SalariedEmployee();
            salariedEmp.Name = "Muroddila";
            salariedEmp.hairColor = "brown";
            salariedEmp.eyeColor = "blue";
            salariedEmp.Address = "Andijon";
            salariedEmp.WeeklyPay = 300000;
            salariedEmp.SetNumber(5);
            salariedEmp.SetOccupant("Muroddila");
            
            System.Console.WriteLine("\n=======SalariedEmployee=========");
            salariedEmp.PrintSalariedEmployeeInfo();
            salariedEmp.MoveOffice(1);
            System.Console.WriteLine(salariedEmp.GetNumber());


            
        }
    }
}
