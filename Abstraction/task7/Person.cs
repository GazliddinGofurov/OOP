abstract class Person : Jonzot
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Citizenship { get; set; }

            public Person(string firstName, string lastName, string citizenship)
            {
                FirstName = firstName;
                LastName = lastName;
                Citizenship = citizenship;
                
            }
            public override void Eat() => Console.WriteLine($"{FirstName} is eating....");
            public override void Walk() => Console.WriteLine($"{FirstName} is walking.....");
            public override void Sleep() =>Console.WriteLine($"{FirstName} is sleeping......");
            public virtual void PrintInfo()
            {
            Console.WriteLine($"Ism: {FirstName}");
            Console.WriteLine($"Familya: {LastName}");
            Console.WriteLine($"Fuqorolik: {Citizenship}");
            }  
           
        }