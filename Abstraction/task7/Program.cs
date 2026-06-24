using System;
namespace _task7
{
    class Program
    {   
        static void Main (string [] args)
        {
            Student student =  new Student("Fazliddin","Gofurov","Uzbek","TATU",1000000);
            student.PrintStudentInfo();
            student.Eat();
            student.Walk();
            student.Sleep();

            Dasturchi dasturchi = new Dasturchi("Pavel","Durov","Russian",99000000,"Backend");
            dasturchi.dasturchiPrintInfo();
            dasturchi.Eat();
            dasturchi.Sleep();
            dasturchi.Work();
            dasturchi.Walk();

            
        }
    }
}
