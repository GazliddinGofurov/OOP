abstract class Employee : Person
        {
            public double Salary { get; set; }
            public abstract void Work();
            public Employee(string firstName, string lastName, string citizenship ,double salary
            ):base(firstName,lastName,citizenship) => Salary =  salary;     
           
        }